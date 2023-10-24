
use bdSGR;

--Creación de tablas de Errores y Triggers

--Tabla para almacenar errores
create table RegistroErrores(
    ErrorLogID INT IDENTITY(1, 1) PRIMARY KEY,
    ErrorTime DATETIME,
    ErrorMessage NVARCHAR(MAX)
);

--Bitacora creación de Reportes
create table tbBitacoraNewReport(
Usuario int,
Fecha date,
Tabla varchar(50),
Accion varchar(50),
IdDato int,
);
drop trigger TCrearReporte
create trigger TCrearReporte
on tbReporte
after insert
as
begin

	insert into tbBitacoraNewReport(Usuario,Fecha,Tabla,Accion,IdDato)
	(select idUsuario,GETDATE(),'tbReporte','INSERT',idReporte
	from inserted)
	
end;

select * from tbBitacoraNewReport;
