--SCRIPT PARA LA CREACIÓN DE LA BASE DE DATOS, RELACIONES Y DATOS BÁSICOS

create database bdSGR;

use bdSGR;

--Tabla Tipo de Usuario (Cargo)
create table tbCargo(
idCargo int primary key identity(1,1) not null,
Cargo varchar(50) not null,
)

--Tabla Usuario (Administrador, Piloto y Ayudante)
create table tbUsuario(
idUsuario int primary key identity(1,1) not null,
DPI bigint not null,
nombres varchar(75) not null,
apellidos varchar(75) not null,
username varchar(50) unique not null,
pass varbinary(8000) not null,
fechaNac date not null,
idCargo int not null,

foreign key (idCargo) references tbCargo (idCargo),
)

--Tabla para Pilotos (se crea una nueva tabla ya que los Pilotos
--tienen un campo extra que no poseen los Administradores y Ayudantes
create table tbPiloto(
idPiloto int primary key identity(1,1) not null,
idUsuario int not null,
tipoLicencia varchar (25) not null,

foreign key (idUsuario) references tbUsuario (idUsuario) on delete cascade,
)

--Tabla Vehículo
create table tbVehiculo(
idVehiculo int primary key identity(1,1) not null,
nombre varchar(50) unique not null,
capacidad tinyint not null,
marca varchar(25) not null,
color varchar(25) not null,
estado varchar(25) not null,
idPiloto int not null,
idUsuario int,

foreign key (idPiloto) references tbPiloto (idPiloto),
foreign key (idUsuario) references tbUsuario (idUsuario),
)

--Tabla Reporte
create table tbReporte(
idReporte int primary key identity(1,1) not null,
cantViajes int not null,
idVehiculo int not null,
fecha date not null,
turno tinyint not null,
pagoPiloto int not null,
pagoAyudante int not null,
pagoCombustible int not null,
pagoViaticos int not null,
pagoExtras decimal(8,2) not null,
totalIngresos decimal(8,2) not null,
totalEgresos decimal(8,2) not null,
capital decimal(8,2) not null,
comentario text,
idUsuario int ,

foreign key (idVehiculo) references tbVehiculo (idVehiculo),
foreign key (idUsuario) references tbUsuario (idUsuario),
)

--Tabla Vuelta (Rabinal-Salama 1, etc)
create table tbVuelta(
idVuelta int primary key identity(1,1) not null,
nombre varchar(25) not null,
)

--Tabla ReportexVuelta (Ingresos por cada vuelta)
create table tbReportexVuelta(
idReportexVuelta int primary key identity(1,1) not null,
idReporte int not null,
idVuelta int not null,
Ingreso decimal(8,2) not null,

foreign key (idReporte) references tbReporte (idReporte) on delete cascade,
foreign key (idVuelta) references tbVuelta (idVuelta),
)

-- Crear un tipo de tabla para IngresosPorViaje
CREATE TYPE IngresosViaje AS TABLE
(
	idReporte int,
	idVuelta int,
	Ingreso decimal(8, 2)
)

--Función para encriptar contraseñas
create function protect(@valor varchar(max))
returns varbinary(8000)
as
Begin
	declare @clave varbinary(8000)
	set @clave = ENCRYPTBYPASSPHRASE('sgr',@valor)
	return @clave
end

--Función para desencriptar contraseñas
create function desprotect(@val varbinary(8000))
returns varchar(max)
as
Begin
	declare @dat varchar(max)
	set @dat = DECRYPTBYPASSPHRASE('sgr',@val)
	return @dat
end

--Insertar Datos a la tabla tbCargo
insert into tbCargo values ('Administrador');
insert into tbCargo values ('Piloto');
insert into tbCargo values ('Ayudante');

select * from tbCargo

--Insertar Datos a la tabla tbUsuario (las fechas utilizan el formato yy-mm-dd)
insert into tbUsuario values (1234567891234,'Ever','Corazon','ever8',
dbo.protect('passever'),'1990-05-13',1);
insert into tbUsuario values (9876543219876,'Olsend','Luna','olsend150',
dbo.protect('passluna'),'1990-08-10',1);
insert into tbUsuario values (1212121212121,'Monica','Caal','alejand',
dbo.protect('passcaal'),'1990-10-20',1);
insert into tbUsuario values (3434343434343,'Pail','Perez','pailp',
dbo.protect('passpail'),'1980-01-10',2);
insert into tbUsuario values (7878787878787,'Romero','de Paz','romer',
dbo.protect('passrome'),'1984-08-16',2);
insert into tbUsuario values (5656565656565,'Ayum','Guzman','guzm1',
dbo.protect('passguz'),'1991-04-04',3);

select * from tbUsuario;

--Insertar Datos a la tabla tbPiloto
insert into tbPiloto values (4,'A');
insert into tbPiloto values (5,'B');

select * from tbPiloto;

--Insertar Datos a la tabla tbVehiculo
insert into tbVehiculo values ('Rabinalerita',20,'Hiace','Azul','Activo',1,1);
insert into tbVehiculo values ('Salamateca',16,'KIA','Roja','Activo',4,1);
--insert into tbVehiculo values ('Azulita',16,'KIA','Roja','Activo',6,1);

select * from tbVehiculo;

--Insertar Datos a la tabla tbVuelta
insert into tbVuelta values ('Rabinal-Salamá 1');
insert into tbVuelta values ('Salamá-Rabinal 1');
insert into tbVuelta values ('Rabinal-Salamá 2');
insert into tbVuelta values ('Salamá-Rabinal 2');
insert into tbVuelta values ('Rabinal-Salamá 3');
insert into tbVuelta values ('Salamá-Rabinal 3');
insert into tbVuelta values ('Rabinal-Salamá 4');
insert into tbVuelta values ('Salamá-Rabinal 4');

select * from tbVuelta;

--Insertar Datos a la tabla tbReporte
insert into tbReporte values (4,1,'2023-10-13',6,80,50,250,30,0,600,410,190,'sc',1);
insert into tbReporte values (4,1,'2023-10-14',5,80,50,300,30,0,700,460,240,'sc',1);

select * from tbReporte;

--Insertar Datos a la tabla tbReportexVuelta
insert into tbReportexVuelta values (1,1,100);
insert into tbReportexVuelta values (1,2,150);
insert into tbReportexVuelta values (1,3,150);
insert into tbReportexVuelta values (1,4,200);

insert into tbReportexVuelta values (2,1,200);
insert into tbReportexVuelta values (2,2,200);
insert into tbReportexVuelta values (2,3,150);
insert into tbReportexVuelta values (2,4,150);

select * from tbReportexVuelta;

--delete from tbReporte where idReporte >= 7


