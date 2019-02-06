CREATE DATABASE MyRestfullApp;

CREATE TABLE users (
	id INT IDENTITY PRIMARY KEY,
	nombre NVARCHAR(100) NOT NULL,
	apellido NVARCHAR(100) NOT NULL,
	email NVARCHAR(100) NOT NULL,
	pass NVARCHAR(20) NOT NULL
);

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

	
	--Update-Database