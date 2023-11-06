--SCRIPT PARA LAS BITÁCORAS Y TRIGGERS
--Creación de tablas de Errores y Triggers

use bdSGR;

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

select idUsuario, Nombre, Fecha,  CONVERT(VARCHAR(8), Hora, 108)
as HoraIngreso from tbBitacoraAcceso order by fecha desc;

--Tabla para almacenar errores
create table RegistroErrores(
    ErrorLogID INT IDENTITY(1, 1) PRIMARY KEY,
    ErrorTime DATETIME,
    ErrorMessage NVARCHAR(MAX)
);

select * from RegistroErrores

--REPORTES
--Bitacora creación de Reportes
create table tbBitacoraReporte(
Usuario int,
Fecha date,
Tabla varchar(50),
Accion varchar(50),
IdDato int,
);

select * from tbBitacoraReporte

--Trigger Insertar Reporte
create trigger TCrearReporte
on tbReporte
after insert
as
begin

	insert into tbBitacoraReporte(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','INSERT',idReporte
	from inserted)
	
end;

--Trigger Eliminar Reporte
create trigger TEliminarReporte
on tbReporte
after delete
as
begin

	insert into tbBitacoraReporte(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','DELETE',idReporte
	from deleted)
	
end;

--Trigger Editar Reporte
create trigger TEditarReporte
on tbReporte
after update
as
begin

	insert into tbBitacoraReporte(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','UPDATE',idReporte
	from inserted)
	
end;


--delete from tbBitacoraAcceso where idUsuario = 1;
select * from tbReporte
select * from tbBitacoraReporte order by Fecha desc


--USUARIOS
--------Bitacora creación de Usuarios-----------
----Tabla de la bitacora
create table tbBitacoraUsuarios(
Usuario varchar(50),
Fecha date,
Tabla varchar(50),
Accion varchar(50),
idDato int);

----TRIGER PARA CREAR
CREATE TRIGGER TCrearUsuario
ON tbUsuario
AFTER INSERT
AS
BEGIN
    INSERT INTO tbBitacoraUsuarios(Usuario, Fecha, Tabla, Accion, idDato)
    SELECT SYSTEM_USER, GETDATE(), 'tbUsuario', 'INSERT', idUsuario
    FROM inserted;
END;

select * from tbBitacoraUsuarios;

---TRIGGER PARA EDITAR
CREATE TRIGGER TEditarUsuario
ON tbUsuario
AFTER UPDATE
AS
BEGIN
    INSERT INTO tbBitacoraUsuarios(Usuario, Fecha, Tabla, Accion, idDato)
    SELECT SYSTEM_USER, GETDATE(), 'tbUsuario', 'UPDATE', idUsuario
    FROM inserted;
END;

--TRIGGER PARA ELIMINAR
CREATE TRIGGER TEliminarUsuario
ON tbUsuario
AFTER DELETE
AS
BEGIN
    INSERT INTO tbBitacoraUsuarios(Usuario, Fecha, Tabla, Accion, idDato)
    SELECT SYSTEM_USER, GETDATE(), 'tbUsuario', 'DELETE', idUsuario
    FROM deleted;
END;


--VEHÍCULOS
create table tbBitacoraAccionesVehiculo(
Usuario int,
Fecha date,
Tabla varchar(50),
Accion varchar(50),
IdDato int,
);

select * from tbBitacoraAccionesVehiculo

--Trigger Insertar Vehiculo
create trigger tCrearVehiculo
on tbVehiculo
after insert
as
begin

	insert into tbBitacoraAccionesVehiculo(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbVehiculo','INSERT',idVehiculo
	from inserted)
	
end;

select * from tbBitacoraAccionesVehiculo

--Trigger Eliminar Vehiculo
create trigger tEliminarVehiculo
on tbVehiculo
after delete
as
begin

	insert into tbBitacoraAccionesVehiculo(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbVehiculo','DELETE',idVehiculo
	from deleted)
	
end;

select * from tbBitacoraAccionesVehiculo


--Trigger Editar Vehiculo
create trigger tEditarVehiculo
on tbVehiculo
after update
as
begin

	insert into tbBitacoraAccionesVehiculo(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbVehiculo','UPDATE',idVehiculo
	from inserted)
	
end;

select * from tbBitacoraAccionesVehiculo
