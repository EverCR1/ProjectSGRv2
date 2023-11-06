--SCRIPT PARA EL MÓDULO DE USUARIOS

use bdSGR;

----CREAR USUARIO NORMAL
ALTER PROCEDURE pCrearUsuario( @DPI bigint, @nombres varchar(75), @apellidos varchar(75), 
@username varchar(50),@pass varchar(max),@fechaNac date, @idCargo int)
AS BEGIN
    INSERT INTO tbUsuario (DPI,nombres,apellidos,username,pass,fechaNac,idCargo)
    VALUES (@DPI,@nombres,@apellidos,@username, ENCRYPTBYPASSPHRASE('sgr', @pass), @fechaNac,@idCargo)
END

----- CREAR PILOTO
ALTER PROCEDURE pUsuarioLicencia
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

--EDITAR USUARIO
--drop procedure pEditarUsuario
CREATE PROCEDURE pEditarUsuario( @ide int, @DPI bigint, @nombres varchar(75), @apellidos varchar(75), 
@username varchar(50),@pass varchar(max),@fechaNac date, @idCargo int)
AS BEGIN
    Update tbUsuario set DPI=@DPI, nombres=@nombres,apellidos=@apellidos, username=@username,
	 pass=ENCRYPTBYPASSPHRASE('sgr', @pass),fechaNac=@fechaNac,idCargo=@idCargo where idUsuario=@ide;
END

---Editar Piloto
drop procedure pEditarPiloto
Create PROCEDURE pEditarPiloto(
    @ide INT,
    @DPI BIGINT,
    @nombres VARCHAR(75),
    @apellidos VARCHAR(75),
    @username VARCHAR(50),
    @pass VARCHAR(MAX),
    @fechaNac DATE,
    @idCargo INT,
	@tipoLicencia Varchar(5)
)
AS 
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Actualizar en la tabla tbUsuario
        UPDATE tbUsuario
        SET DPI = @DPI,
            nombres = @nombres,
            apellidos = @apellidos,
            username = @username,
            pass = ENCRYPTBYPASSPHRASE('sgr', @pass),
            fechaNac = @fechaNac,
            idCargo = @idCargo
        WHERE idUsuario = @ide;

        -- Verificar si el usuario es un piloto
        IF EXISTS (SELECT 1 FROM tbPiloto WHERE idUsuario = @ide)
        BEGIN
            -- Actualizar en la tabla piloto
            UPDATE tbPiloto
            SET tipoLicencia = @tipoLicencia 
            WHERE idUsuario = @ide;
        END

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        
    END CATCH
END




exec CambiarContrasena 3,'passcaal','123','123'

--DETALLES PILOTO
CREATE procedure detallesPiloto
 @idUsuario INT
As
BEGIN
	SELECT 
			U.idUsuario,U.DPI, U.nombres, U.apellidos, U.username, U.fechaNac, DATEDIFF(YEAR, U.fechaNac, GETDATE()) AS Edad, P.tipoLicencia, C.Cargo
        FROM tbUsuario U inner join tbPiloto P on U.idUsuario = P.idUsuario 
		inner join tbCargo C on U.idCargo = C.idCargo where U.idUsuario = @idUsuario
END;

--DETALLES USUARIO
CREATE PROCEDURE detallesUsuario
@idUsuario int
AS
BEGIN
 SELECT 
			U.idUsuario,U.DPI, U.nombres, U.apellidos, U.username, U.fechaNac, DATEDIFF(YEAR, U.fechaNac, GETDATE()) AS Edad, C.Cargo
        FROM tbUsuario U  inner join tbCargo C on U.idCargo = C.idCargo where U.idUsuario = @idUsuario

END;

--LISTAR PILOTOS
CREATE VIEW vListarPilotos AS
    SELECT 
        U.idUsuario, U.DPI, U.nombres, U.apellidos, U.username, DATEDIFF(YEAR, U.fechaNac, GETDATE()) AS Edad, P.tipoLicencia,U.idCargo,U.pass, C.Cargo
    FROM tbUsuario U 
    INNER JOIN tbPiloto P ON U.idUsuario = P.idUsuario
    INNER JOIN tbCargo C ON U.idCargo = C.idCargo


SELECT * FROM vListarPilotos;

--LISTAR USUARIOS
CREATE VIEW vListarUsuarios AS
    SELECT 
        U.idUsuario, U.DPI, U.nombres, U.apellidos, U.username, DATEDIFF(YEAR, U.fechaNac, GETDATE()) AS Edad,U.idCargo,U.pass, C.Cargo
    FROM tbUsuario U 
    INNER JOIN tbCargo C ON U.idCargo = C.idCargo 
    WHERE U.idCargo != 2;


----ELIMINAR USUARIO
CREATE PROCEDURE pEliminarUsuario
    @UsuarioID INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Elimina el usuario según el ID proporcionado
        DELETE FROM tbUsuario WHERE idUsuario = @UsuarioID;
        COMMIT;
    END TRY
    BEGIN CATCH
        -- Si se produce un error, revierte la transacción
        ROLLBACK;
        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage)
        VALUES (GETDATE(), ERROR_MESSAGE());
    END CATCH;
END;

---ELIMINAR PILOTO
CREATE PROCEDURE pEliminarPiloto
    @UsuarioID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM tbPiloto WHERE idUsuario = @UsuarioID;

        DELETE FROM tbUsuario WHERE idUsuario = @UsuarioID;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        -- Capturar el error
        PRINT 'Error al intentar eliminar los datos de Usuario y Piloto';
        INSERT INTO RegistroErrores (ErrorTime, ErrorMessage) VALUES (GETDATE(), ERROR_MESSAGE());
    END CATCH
END;

--Proc ListarCargos
CREATE PROCEDURE ListarCargos
AS BEGIN
	select idCargo as IdCargo, Cargo as Cargo
	from tbCargo order by Cargo asc
END

-- Verifica si el username ya está registrado
CREATE FUNCTION VerificarUsername(@username VARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @existeUsername INT;

    -- Verificar si el username ya existe en la tabla tbUsuario
    SELECT @existeUsername = CASE WHEN EXISTS (
        SELECT 1
        FROM tbUsuario
        WHERE username = @username
    ) THEN 1 ELSE 0 END;

    RETURN @existeUsername;
END;