-- DDL
CREATE DATABASE Minerva;
USE [master]
GO
CREATE LOGIN [usrminerva] WITH PASSWORD=N'123456', 
   DEFAULT_DATABASE=[Minerva], 
   CHECK_EXPIRATION=OFF, 
   CHECK_POLICY=ON
GO
USE [Minerva]
GO
CREATE USER [usrminerva] FOR LOGIN [usrminerva]
GO
USE [Minerva]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrminerva]
GO

DROP TABLE CompraDetalle;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Producto;

CREATE TABLE Producto(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	codigo VARCHAR(10) NOT NULL,
	descripcion VARCHAR(250) NOT NULL,
	unidadMedida VARCHAR(20) NOT NULL,
	saldo DECIMAL NOT NULL DEFAULT 0,
	precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0)
);
CREATE TABLE Proveedor(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nit BIGINT NOT NULL,
	razonSocial VARCHAR(100) NOT NULL,
	direccion VARCHAR(250) NULL,
	telefono VARCHAR(30) NOT NULL,
	representante VARCHAR(100) NOT NULL
);
CREATE TABLE Empleado(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	cedulaIdentidad VARCHAR(15) NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	primerApellido VARCHAR(30) NOT NULL,
	segundoApellido VARCHAR(30) NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	celular BIGINT NOT NULL,
	cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	usuario VARCHAR(12) NOT NULL,
	clave VARCHAR(250) NOT NULL,
	CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idProveedor INT NOT NULL,
	transaccion INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idCompra INT NOT NULL,
	idProducto INT NOT NULL,
	cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
	precioUnitario DECIMAL NOT NULL,
	total DECIMAL NOT NULL,
	CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
	CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD registroActivo BIT NULL DEFAULT 1;

-- DML
INSERT INTO Producto(codigo,descripcion,unidadMedida,saldo,precioVenta)
VALUES ('HB100', 'Hojas Bond tamaño carta', 'Paquete',50,25.15);

UPDATE Producto SET precioVenta=25.35 WHERE id=1;

SELECT * FROM Producto;



CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT id, codigo, descripcion, unidadMedida, saldo, precioVenta,
		 usuarioRegistro, fechaRegistro
  FROM Producto
  WHERE registroActivo=1 AND 
		codigo+descripcion+unidadMedida LIKE '%'+REPLACE(@parametro,' ','%')+'%'

EXEC paProductoListar 'hoja carta'