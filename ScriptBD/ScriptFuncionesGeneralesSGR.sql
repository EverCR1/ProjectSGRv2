--SCRIPT PARA LAS FUNCIONES GENERALES DEL SISTEMA

use bdSGR;

--Funci�n para el Login
create function Flogin(@Usuario varchar(50), @Pass varchar(50))
returns int
as begin
	Declare @idUsuario as int
	set @idUsuario = (select idUsuario from tbUsuario
					where username = @Usuario and
					DECRYPTBYPASSPHRASE('sgr', Pass) = @Pass)
	return @idUsuario
end

--Funci�n para administrar Permisos
create function FPermisos(@idUsuario int)
returns int
as begin
	declare @Cargo as int
	set @Cargo = (select idCargo from tbUsuario where 
	idUsuario = @idUsuario)
	return @Cargo
end

-----CAMBIAR CONTRASE�A
CREATE PROCEDURE CambiarContrasena
    @usuarioID INT, 
    @contrasenaActual VARCHAR(100),
    @nuevaContrasena VARCHAR(100),
    @confirmarContrasena VARCHAR(100)
AS
BEGIN
    DECLARE @contrasenaGuardada VARCHAR(100)
    
    -- Obtener la contrase�a actual del usuario
    SET @contrasenaGuardada = (select DECRYPTBYPASSPHRASE('sgr',pass) from tbUsuario where idUsuario = @usuarioID)


    -- Verificar si la contrase�a actual coincide con la contrase�a almacenada
    IF @contrasenaActual = @contrasenaGuardada
    BEGIN
        -- Verificar si la nueva contrase�a y la confirmaci�n coinciden
        IF @nuevaContrasena = @confirmarContrasena
        BEGIN
            -- Actualizar la contrase�a en la base de datos
            UPDATE tbUsuario
            SET pass = ENCRYPTBYPASSPHRASE('sgr', @nuevaContrasena)
            WHERE idUsuario = @usuarioID
        END
    END
END


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

--Script para la recuperaci�n de datos manual
RESTORE DATABASE bdSGR
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak'
WITH REPLACE;

RESTORE DATABASE CopiaPrueba
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak';

--Respaldo Autom�tico
use bdSGR
GO

declare @fecha varchar(max)
declare @ruta varchar(max)

set @fecha = CONVERT(varchar(10),GETDATE(),105)
set @ruta = 'C:\CopiasProyecto\Auto\COPIA-'+@fecha+'.bak'

BACKUP DATABASE [bdSGR] TO DISK = @ruta

GO

--SCRIPTS PARA LAS ESTAD�STICAS (GR�FICAS) DE LA APLICACI�N
use bdSGR;

--Determina el Veh�culo m�s Utilizado (es decir, el que tiene m�s reportes)
CREATE PROCEDURE pVehiculoMost
AS BEGIN
	SELECT
		Veh�culo,
		COUNT(idReporte) AS Reportes
	FROM
		vReporte
	GROUP BY
		Veh�culo
	ORDER BY
		Reportes DESC;
END

exec pVehiculoMost

select * from tbReporte

--Determina el Capital de un Veh�culo en los �ltimos 7 d�as
CREATE PROCEDURE gCapital(@idVehiculo int)
AS BEGIN
	SELECT
		Veh�culo,
		CONVERT(DATE, fecha) AS Fecha,
		SUM(Capital) AS CapitalDiario
	FROM vReporte
	WHERE idVehiculo = @idVehiculo
		AND fecha >= DATEADD(day, -7, GETDATE())
	GROUP BY Veh�culo, CONVERT(DATE, fecha)
	ORDER BY CONVERT(DATE, fecha) ASC;
END

