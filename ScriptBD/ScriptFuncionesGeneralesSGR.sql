--SCRIPT PARA LAS FUNCIONES GENERALES DEL SISTEMA

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

-----CAMBIAR CONTRASEÑA
CREATE PROCEDURE CambiarContrasena
    @usuarioID INT, 
    @contrasenaActual VARCHAR(100),
    @nuevaContrasena VARCHAR(100),
    @confirmarContrasena VARCHAR(100)
AS
BEGIN
    DECLARE @contrasenaGuardada VARCHAR(100)
    
    -- Obtener la contraseña actual del usuario
    SET @contrasenaGuardada = (select DECRYPTBYPASSPHRASE('sgr',pass) from tbUsuario where idUsuario = @usuarioID)


    -- Verificar si la contraseña actual coincide con la contraseña almacenada
    IF @contrasenaActual = @contrasenaGuardada
    BEGIN
        -- Verificar si la nueva contraseña y la confirmación coinciden
        IF @nuevaContrasena = @confirmarContrasena
        BEGIN
            -- Actualizar la contraseña en la base de datos
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

--Script para la recuperación de datos manual
RESTORE DATABASE bdSGR
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak'
WITH REPLACE;

RESTORE DATABASE CopiaPrueba
FROM DISK = 'C:\CopiasSQL\COPIA_43_15.bak';

--Respaldo Automático
use bdSGR
GO

declare @fecha varchar(max)
declare @ruta varchar(max)

set @fecha = CONVERT(varchar(10),GETDATE(),105)
set @ruta = 'C:\CopiasProyecto\Auto\COPIA-'+@fecha+'.bak'

BACKUP DATABASE [bdSGR] TO DISK = @ruta

GO

--SCRIPTS PARA LAS ESTADÍSTICAS (GRÁFICAS) DE LA APLICACIÓN
use bdSGR;

--Determina el Vehículo más Utilizado (es decir, el que tiene más reportes)
CREATE PROCEDURE pVehiculoMost
AS BEGIN
	SELECT
		Vehículo,
		COUNT(idReporte) AS Reportes
	FROM
		vReporte
	GROUP BY
		Vehículo
	ORDER BY
		Reportes DESC;
END

exec pVehiculoMost

select * from tbReporte

--Determina el Capital de un Vehículo en los últimos 7 días
CREATE PROCEDURE gCapital(@idVehiculo int)
AS BEGIN
	SELECT
		Vehículo,
		CONVERT(DATE, fecha) AS Fecha,
		SUM(Capital) AS CapitalDiario
	FROM vReporte
	WHERE idVehiculo = @idVehiculo
		AND fecha >= DATEADD(day, -7, GETDATE())
	GROUP BY Vehículo, CONVERT(DATE, fecha)
	ORDER BY CONVERT(DATE, fecha) ASC;
END

