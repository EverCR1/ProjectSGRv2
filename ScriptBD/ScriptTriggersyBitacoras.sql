
use bdSGR;

--Creación de tablas de Errores y Triggers

--Tabla para almacenar errores
create table RegistroErrores(
    ErrorLogID INT IDENTITY(1, 1) PRIMARY KEY,
    ErrorTime DATETIME,
    ErrorMessage NVARCHAR(MAX)
);

select * from RegistroErrores

--Bitacora creación de Reportes
create table tbBitacoraNewReport(
Usuario int,
Fecha date,
Tabla varchar(50),
Accion varchar(50),
IdDato int,
);

select * from tbBitacoraNewReport

--Trigger Insertar Reporte
create trigger TCrearReporte
on tbReporte
after insert
as
begin

	insert into tbBitacoraNewReport(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','INSERT',idReporte
	from inserted)
	
end;

--Trigger Eliminar Reporte
create trigger TEliminarReporte
on tbReporte
after delete
as
begin

	insert into tbBitacoraNewReport(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','DELETE',idReporte
	from deleted)
	
end;

--Trigger Editar Reporte
create trigger TEditarReporte
on tbReporte
after update
as
begin

	insert into tbBitacoraNewReport(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','UPDATE',idReporte
	from inserted)
	
end;



select * from tbBitacoraNewReport;


--Tabla para almacenar los datos de la Bitácora de Acceso
create table tbBitacoraAcceso(
idUsuario int,
Nombre varchar(50),
Fecha Date,
Hora time,
)

--Procedimiento para la Bitácora de Acceso
CREATE PROCEDURE pBitacoraAcceso
@idUser int
AS BEGIN
    DECLARE @FechayHora DATETIME 
	DECLARE @Nombre varchar(50)

    SET @FechayHora = GETDATE()
	
	SET	@Nombre = (select username from tbUsuario where idUsuario = @idUser)
    
    -- Insertar los datos en la tabla de bitácora de acceso
    INSERT INTO tbBitacoraAcceso (idUsuario, Nombre, Fecha, Hora)
    VALUES (@idUser, @Nombre, CAST(@FechayHora AS DATE), 
	CAST(@FechayHora AS TIME));
    
END;

select * from tbBitacoraAcceso

select idUsuario, Nombre, Fecha,  CONVERT(VARCHAR(8), Hora, 108)
as HoraIngreso from tbBitacoraAcceso order by fecha desc;

delete from tbBitacoraAcceso where idUsuario = 1;

select * from tbReporte

select * from tbBitacoraNewReport order by Fecha desc

