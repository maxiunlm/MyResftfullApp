-- Paso 1: Crear la BD
CREATE DATABASE MyRestfullApp;

/* INNECESARIO, ES UN CODE FIRST
CREATE TABLE users (
	Id INT IDENTITY PRIMARY KEY, 
	Nombre NVARCHAR(100) NOT NULL,
	Apellido NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Pass NVARCHAR(20) NOT NULL
);
*/

-- Paso2: Editar connectionString en el web.config
-- <add name="DefaultConnection" connectionString="Data Source=(local);Initial Catalog=MyRestfulApp;Integrated Security=True" providerName="System.Data.SqlClient" />
-- Es importante mantener el atributo name="DefaultConnection"

-- Paso 3: Correr la Aplicacion

-- Paso 4: Correr el siguiente insert
INSERT INTO dbo.users
(
    nombre,
    apellido,
    email,
    pass
)
VALUES
(   N'Juan', -- nombre - nvarchar(100)
    N'Perez', -- apellido - nvarchar(100)
    N'juan@perez.com', -- email - nvarchar(100)
    N'123456'  -- pass - nvarchar(20)
),
(   N'Carlos', -- nombre - nvarchar(100)
    N'Garcia', -- apellido - nvarchar(100)
    N'carlos@garcia.com', -- email - nvarchar(100)
    N'67890'  -- pass - nvarchar(20)
),
(   N'Ana', -- nombre - nvarchar(100)
    N'Fernandez', -- apellido - nvarchar(100)
    N'ana@ferandez.com', -- email - nvarchar(100)
    N'45678'  -- pass - nvarchar(20)
);

	
-- Para refrescar el modelo  Update-Database