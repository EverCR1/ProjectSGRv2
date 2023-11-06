--SCRIPT PARA EL MÓDULO VEHÍCULOS

use bdSGR;

-- Crea el procedimiento almacenado
CREATE PROCEDURE InsertVehi
    @nuevo_nombre VARCHAR(50),
    @nueva_capacidad INT,
    @nueva_marca VARCHAR(25),
    @nuevo_color VARCHAR(25),
    @nuevo_estado VARCHAR(25),
    @nuevo_idPiloto INT,
    @nuevo_idUsuario INT
AS
BEGIN
    INSERT INTO tbVehiculo (nombre, capacidad, marca, color, estado, idPiloto, idUsuario)
    VALUES (@nuevo_nombre, @nueva_capacidad, @nueva_marca, @nuevo_color, @nuevo_estado, @nuevo_idPiloto, @nuevo_idUsuario);
END

--Editar tabla vehiculos
CREATE PROCEDURE UpdateVehi
    @nuevo_nombre VARCHAR(50),
    @nueva_capacidad INT,
    @nueva_marca VARCHAR(25),
    @nuevo_color VARCHAR(25),
    @nuevo_estado VARCHAR(25),
    @nuevo_idPiloto INT,
    @nuevo_idUsuario INT,
	@Original_idVehiculo INT
AS
BEGIN
    UPDATE [dbo].[tbVehiculo] SET [nombre] = @nuevo_nombre, [capacidad] = @nueva_capacidad, [marca] = @nueva_marca, [color] = @nuevo_color, 
	[estado] = @nuevo_estado, [idPiloto] = @nuevo_idPiloto, [idUsuario] = @nuevo_idUsuario 
	WHERE ([idVehiculo] = @Original_idVehiculo) 
END

--Listar
CREATE PROCEDURE [dbo].SelectIdVehiculo
(
	@Original_idVehiculo int
)
AS
	SET NOCOUNT ON;
SELECT * FROM dbo.tbVehiculo
WHERE idVehiculo = @Original_idVehiculo
GO

--VISTA PARA DATAGRIDVIEW
CREATE VIEW VistaVehiculo AS
SELECT 
V.idVehiculo,
V.nombre [Nombre],
V.capacidad [Capacidad],
V.marca [Marca],
V.color [Color],
V.estado [Estado],
V.idPiloto,
U.nombres [Piloto],
V.idUsuario
FROM tbVehiculo V inner join tbPiloto P on V.idPiloto = P.idPiloto 
INNER JOIN tbUsuario U ON P.idUsuario = U.idUsuario

--Listar Pilotos Disponibles
CREATE PROC LPiloto
    @idVehiculo int
AS
BEGIN
    IF @idVehiculo IS NOT NULL
    BEGIN
        -- Lista al piloto asociado y a los demás pilotos disponibles
        SELECT V.idPiloto AS IdPiloto, U.nombres AS Nombres
        FROM tbPiloto V
        INNER JOIN tbUsuario U ON V.idUsuario = U.idUsuario
        WHERE V.idPiloto = (SELECT idPiloto FROM tbVehiculo WHERE idVehiculo = @idVehiculo)
        UNION
        SELECT V.idPiloto AS IdPiloto, U.nombres AS Nombres
        FROM tbPiloto V
        INNER JOIN tbUsuario U ON V.idUsuario = U.idUsuario
        WHERE V.idPiloto NOT IN (SELECT idPiloto FROM tbVehiculo)
    END
    ELSE
    BEGIN
        -- Lista únicamente a los pilotos disponibles (que no tienen vehículos asociados)
        SELECT V.idPiloto AS IdPiloto, U.nombres AS Nombres
        FROM tbPiloto V
        INNER JOIN tbUsuario U ON V.idUsuario = U.idUsuario
        WHERE V.idPiloto NOT IN (SELECT idPiloto FROM tbVehiculo)
    END
END

--Eliminar un Vehiculo
IF EXISTS (SELECT * FROM sysobjects 
WHERE name = 'DeleteVehiculo' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].DeleteVehiculo
GO
CREATE PROCEDURE [dbo].DeleteVehiculo
(	@Original_idVehiculo int )
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[tbVehiculo] WHERE ([idVehiculo] = @Original_idVehiculo) 
GO

-- Verifica si el nombre del vehículo ya está registrado
CREATE FUNCTION VerificarVehiculo(@nombre VARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @existeNombre INT;

    -- Verificar si el nombre del vehículo ya existe en la tabla tbVehiculo
    SELECT @existeNombre = CASE WHEN EXISTS (
        SELECT 1
        FROM tbVehiculo
        WHERE nombre = @nombre
    ) THEN 1 ELSE 0 END;

    RETURN @existeNombre;
END;


