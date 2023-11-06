--SCRIPT PARA EL MÓDULO REPORTES
use bdSGR;

--Función para obtener total Reportes
create function fTotalReportes()
returns int
as begin
	DECLARE @TotalReportes INT;
    
    SELECT @TotalReportes = COUNT(*) FROM tbReporte;
    
    RETURN @TotalReportes;
end

--Procedimiento para la Creación de Reportes
CREATE PROCEDURE pCrearReporte (@CantViajes int, @Vehiculo int, @Fecha date, @turno tinyint, @pPiloto int,
@pAyudante int, @pCombustible int, @pViaticos int, @pExtras decimal(8,2), @tIngresos decimal(8,2),
@tEgresos decimal(8,2), @Capital decimal(8,2), @Comentario text, @Usuario int,
@Ingresos IngresosViaje readonly)
AS BEGIN

	DECLARE @NuevoReporteID INT;

	-- Inicia una transacción
	BEGIN TRANSACTION;

    BEGIN TRY
		INSERT INTO tbReporte values (@CantViajes, @Vehiculo, @Fecha, @turno, 
		@pPiloto, @pAyudante, @pCombustible, @pViaticos, @pExtras, @tIngresos,
		@tEgresos, @Capital, @Comentario, @Usuario);
		
		SET @NuevoReporteID = SCOPE_IDENTITY(); --Obtiene el valor del idReporte Actual

		INSERT INTO tbReportexVuelta (idReporte,idVuelta,Ingreso)
        SELECT @NuevoReporteID, idVuelta, Ingreso
        FROM @Ingresos;

	COMMIT; --Confirma los cambios

	END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;
        
		INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
		VALUES (GETDATE(), ERROR_MESSAGE());

    END CATCH;
END;

--Procedimiento para Actualizar Reportes
CREATE PROCEDURE pEditarReporte(@ide int,@CantViajes int, @Vehiculo int, @Fecha date, @turno tinyint, @pPiloto int,
@pAyudante int, @pCombustible int, @pViaticos int, @pExtras decimal(8,2), @tIngresos decimal(8,2),
@tEgresos decimal(8,2), @Capital decimal(8,2), @Comentario text, @Usuario int,
@Ingresos IngresosViaje readonly)
AS 
Begin
	BEGIN TRANSACTION;

    BEGIN TRY
		Update tbReporte set cantViajes = @CantViajes, idVehiculo = @Vehiculo, fecha = @Fecha,
		turno = @turno, pagoPiloto = @pPiloto, pagoAyudante = @pAyudante, pagoCombustible = @pCombustible,
		pagoViaticos = @pViaticos, pagoExtras = @pExtras, totalIngresos = @tIngresos,
		totalEgresos = @tEgresos, capital = @Capital,comentario = @Comentario, idUsuario = @Usuario
		where idReporte = @ide;

		-- Borra los ingresos anteriores asociados al Reporte
        DELETE FROM tbReportexVuelta WHERE idReporte = @ide;

        -- Inserta los nuevos ingresos
        INSERT INTO tbReportexVuelta (idReporte, idVuelta, Ingreso)
        SELECT @ide, idVuelta, Ingreso
        FROM @Ingresos;

		COMMIT;

	END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;

        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
    END CATCH;
END;

--Procedimiento para Eliminar un Reporte
CREATE PROCEDURE pEliminarReporte
    @ReporteID INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Elimina el reporte según el id proporcionado
        DELETE FROM tbReporte WHERE idReporte = @ReporteID;

        COMMIT;
    END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;

        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
    END CATCH;
END;

--Vista para los reportes
CREATE VIEW vReporte AS
SELECT
    R.idReporte,
    R.idVehiculo,
    V.nombre [Vehículo],
    R.fecha [Fecha],
    R.cantViajes [Viajes],
    R.turno [Turno],
    R.PagoPiloto [Pago Piloto],
    R.PagoAyudante [Pago Ayudante],
    R.PagoCombustible [Combustible],
    R.PagoViaticos [Viáticos],
    R.PagoExtras [Extras],
    R.TotalIngresos [Total Ingresos],
    R.TotalEgresos [Total Egresos],
    R.Capital [Capital],
    R.Comentario [Comentario],
    R.idUsuario
FROM
    tbReporte R
INNER JOIN
    tbVehiculo V ON R.idVehiculo = V.idVehiculo


--Añadirle order by a la Vista
CREATE PROCEDURE listarReporte
AS BEGIN
	select * from vReporte order by Fecha desc
END

--Buscar Reporte
CREATE PROCEDURE buscarReporte
@fechaInicio date, @fechaFinal date
AS BEGIN
	select * from vReporte where Fecha between @fechaInicio and @fechaFinal
	order by Fecha desc
END

--Vista Para Ingresos
CREATE VIEW vIngresos
AS
SELECT 
    V.nombre [Viaje], R.Ingreso AS [Ingreso], R.idReporte
FROM tbReportexVuelta AS R
INNER JOIN 
tbVuelta AS V ON R.idVuelta = V.idVuelta;

--Procedimiento para Obtener los Ingresos de un Reporte
CREATE PROCEDURE pListarIngresos(@ideRep int)
AS
BEGIN
    BEGIN TRY
        
        BEGIN TRANSACTION;

        --Consulta SELECT con JOIN para obtener datos de ambas tablas
        SELECT * from vIngresos
		where idReporte = @ideRep;

        COMMIT;
    END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;

        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
        
    END CATCH;
END;

--Procedimiento para Listar los nombres de los Vehiculos
CREATE PROC ListarVehiculos
AS 
BEGIN
    SELECT idVehiculo AS IdVehiculo, nombre AS Nombre
    FROM tbVehiculo
    WHERE estado <> 'Inactivo'
    ORDER BY nombre ASC
END


--Verificar que el un Vehículo solo pueda tener un reporte por día
CREATE FUNCTION VerificarReporte(@idVehiculo int, @fecha date)
RETURNS int
AS
BEGIN
    DECLARE @existeReporte int;

    -- Verificar si existe un reporte para el vehículo en la fecha especificada
    SELECT @existeReporte = CASE WHEN EXISTS (
        SELECT 1
        FROM tbReporte
        WHERE idVehiculo = @idVehiculo AND fecha = @fecha
    ) THEN 1 ELSE 0 END;

    RETURN @existeReporte;
END


