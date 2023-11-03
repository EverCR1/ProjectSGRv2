

use bdSGR;

--Función para el Login
create function Flogin(@Usuario varchar(50), @Pass varchar(50))
returns int
as begin
	Declare @idUsuario as int
	set @idUsuario = (select idUsuario from tbUsuario
					where username = @Usuario and
					DECRYPTBYPASSPHRASE('sgr', Pass) = @Pass)
	return @idUsuario
end

--Función para administrar Permisos
create function FPermisos(@idUsuario int)
returns int
as begin
	declare @Cargo as int
	set @Cargo = (select idCargo from tbUsuario where 
	idUsuario = @idUsuario)
	return @Cargo
end

select dbo.FPermisos(5);
select dbo.FLogin('ever8','passever');
select dbo.fTotalReportes();
--Función para obtener total Reportes
create function fTotalReportes()
returns int
as begin
	DECLARE @TotalReportes INT;
    
    SELECT @TotalReportes = COUNT(*) FROM tbReporte;
    
    RETURN @TotalReportes;
end

--- Procedimiento para el Registro (Ejemplo)
CREATE PROCEDURE FRegistro(@Usuario varchar(100), @Pass varchar(max), @idPer int)
AS BEGIN
    INSERT INTO tbUsuario (Usuario, Pass, idPersona)
    VALUES (@Usuario, ENCRYPTBYPASSPHRASE('sgr', @Pass), @idPer)
END

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

--Ejemplo Crear Reporte
-- Declaración de una tabla de tipo tabla para la entrada de IngresosViaje
DECLARE @Ingre IngresosViaje
INSERT INTO @Ingre (idVuelta, Ingreso)
VALUES
    (1, 100.00),
    (2, 150.00),
    (3, 120.00);

-- Ejemplo de llamada al procedimiento almacenado pCrearReporte
EXEC pCrearReporte
	@CantViajes = 3,
    @Vehiculo = 1,
    @Fecha = '2023-10-20',
    @turno = 1,
    @pPiloto = 101,
    @pAyudante = 102,
    @pCombustible = 50.00,
    @pViaticos = 30.00,
    @pExtras = 25.00,
    @tIngresos = 400.00,
    @tEgresos = 100.00,
    @Capital = 300.00,
    @Comentario = 'Reporte de ejemplo',
    @Usuario = 1,
    @Ingresos = @Ingre;

select * from tbReporte;
select * from tbReportexVuelta;

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

--Ejemplo Editar Reporte
-- Declaración de una tabla de tipo tabla para la entrada de IngresosViaje
DECLARE @Ingre IngresosViaje
INSERT INTO @Ingre (idVuelta, Ingreso)
VALUES
    (1, 100.00),
    (2, 150.00),
    (3, 120.00);

-- Ejemplo de llamada al procedimiento almacenado pCrearReporte
EXEC pEditarReporte
	@ide = 43,
	@CantViajes = 3,
    @Vehiculo = 1,
    @Fecha = '2023-10-15',
    @turno = 1,
    @pPiloto = 101,
    @pAyudante = 102,
    @pCombustible = 50.00,
    @pViaticos = 30.00,
    @pExtras = 25.00,
    @tIngresos = 400.00,
    @tEgresos = 100.00,
    @Capital = 300.00,
    @Comentario = 'Reporte de edicion',
    @Usuario = 1,
    @Ingresos = @Ingre;

select * from tbReporte

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

select * from tbReporte

--Procedimiento para Buscar Reportes de acuerdo a la fecha
CREATE PROCEDURE pBuscarReporte
    @FechaBuscada DATE
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Selecciona los reportes que coinciden con la fecha especificada
        SELECT *
        FROM tbReporte
        WHERE Fecha = @FechaBuscada;

        COMMIT;
    END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;
        
        -- Registra el error
        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
    END CATCH;
END;

exec pBuscarReporte '2023-10-17'
select * from tbReporte

--Procedimiento para Mostrar Reportes
CREATE PROCEDURE pListarReporte
AS
BEGIN
    BEGIN TRY
        
        BEGIN TRANSACTION;

        --Consulta SELECT con JOIN para obtener datos de más de 1 tabla
        SELECT 
            R.idReporte, R.idVehiculo, V.nombre, R.fecha, R.cantViajes, R.turno, 
            R.PagoPiloto, R.PagoAyudante, R.PagoCombustible, R.PagoViaticos, R.PagoExtras, 
            R.TotalIngresos, R.TotalEgresos, R.Capital, R.Comentario, R.idUsuario
        FROM tbReporte R inner join tbVehiculo V on R.idVehiculo = V.idVehiculo
        ORDER BY fecha DESC;

        
        COMMIT;
    END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;

        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
        
    END CATCH;
END;

exec pListarReporte

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

exec listarReporte

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



--Procedimiento para crear usuarios
CREATE PROCEDURE pCrearUsuario(@DPI bigint, @nombres varchar(75), @apellidos varchar(75), 
@username varchar(50),@pass varchar(max),@fechaNac date, @idCargo int)
AS BEGIN
    INSERT INTO tbUsuario (DPI,nombres,apellidos,username,pass,fechaNac,idCargo)
    VALUES (@DPI,@nombres,@apellidos,@username, ENCRYPTBYPASSPHRASE('sgr', @pass), @fechaNac,@idCargo)
END

exec pCrearUsuario 1234567891234,'Prueba','Pasas','pruebas','sd1','2020-10-12',1

select * from tbUsuario

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

exec pListarIngresos 1

select * from tbReporte
select * from tbReportexVuelta

--Procedimiento para Listar los nombres de los Vehiculos
CREATE PROC ListarVehiculos
AS BEGIN
	select idVehiculo as IdVehiculo, nombre as Nombre 
	from tbVehiculo order by nombre asc
END

exec ListarVehiculos


--Procedimiento para la creación de usuarios
CREATE PROCEDURE pCrearUsuario( @DPI bigint, @nombres varchar(75), @apellidos varchar(75), 
@username varchar(50),@pass varchar(max),@fechaNac date, @idCargo int)
AS BEGIN
    INSERT INTO tbUsuario (DPI,nombres,apellidos,username,pass,fechaNac,idCargo)
    VALUES (@DPI,@nombres,@apellidos,@username, ENCRYPTBYPASSPHRASE('sgr', @pass), @fechaNac,@idCargo)
END

--Procedimiento para la creación de Pilotos
CREATE PROCEDURE pUsuarioLicencia
    @DPI BIGINT,
    @nombres VARCHAR(75),
    @apellidos VARCHAR(75),
    @username VARCHAR(50),
    @pass VARCHAR(MAX),
    @fechaNac DATE,
    @idCargo INT,
    @tipoLicencia VARCHAR(5)
AS
BEGIN
    -- Declarar una variable para almacenar el ID generado
    DECLARE @NuevoID INT;

    -- Insertar en la tabla de usuarios
    INSERT INTO dbo.tbUsuario (DPI, nombres, apellidos, username, pass, fechaNac, idCargo)
    VALUES (@DPI, @nombres, @apellidos, @username, ENCRYPTBYPASSPHRASE('sgr', @pass), @fechaNac, @idCargo);

    -- Obtener el ID generado
    SET @NuevoID = SCOPE_IDENTITY();

    -- Insertar en la tabla de licencias
    INSERT INTO dbo.tbPiloto (idUsuario, tipoLicencia)
    VALUES (@NuevoID, @tipoLicencia);
END;

select * from tbUsuario
select * from tbPiloto
select * from tbReporte order by fecha desc

--Script para la copia de seguridad desde la App
create procedure pCopiaSeguridad
    @ruta varchar(200)
as 
begin
    declare @dest varchar(200)
    set @dest = @ruta
    backup database [bdSGR] to disk = @dest
end


--Script para la copia de seguridad manual
declare @destino varchar(200)
set @destino = 'C:\CopiasSQL\COPIA_'+CONCAT(DATEPART(SECOND,GETDATE()),'_',
DATEPART(MINUTE,GETDATE()))+'.bak'
backup database [bdSGR] to disk = @destino
go

select * from tbUsuario;


RESTORE DATABASE bdSGR
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak'
WITH REPLACE;

RESTORE DATABASE CopiaPrueba
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak';
