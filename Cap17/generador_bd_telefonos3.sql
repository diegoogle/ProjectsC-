USE master

if exists (select * from sysdatabases where name='bd_telefonos3')
begin
  raiserror('La base de datos existe; elimin�ndola....',0,1)
  DROP database bd_telefonos3
end
GO

raiserror('Creando base de datos bd_telefonos3....',0,1)
go

CREATE DATABASE bd_telefonos3
GO

USE bd_telefonos3
GO

CREATE TABLE telefonos
(
  idpersona     INTEGER IDENTITY(1,1) PRIMARY KEY,
  nombre        VARCHAR(16) NOT NULL,
  apellido1     VARCHAR(12) NOT NULL,
  apellido2     VARCHAR(12),
  direccion     VARCHAR(30) NOT NULL,
  telefono      VARCHAR(12) NOT NULL,
  observaciones VARCHAR(240),
  foto          VARCHAR(30)
)
GO

INSERT INTO telefonos
       VALUES ('Leticia', 'Aguirre', 'Soriano', 'Triana, Sevilla', '954345678', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Pedro', 'Aguado', 'Rodr�guez', 'Alcal� de Henares, Madrid', '918888888', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Alfons', 'Gonz�lez', 'P�rez', 'Argentona, Barcelona', '933333333', 'Director de desarrollo', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Miguel', 'L�pez', 'Trujillo', 'Mataporquera, Cantabria', '942232323', 'Es propietario de la empresa PUBLICSA', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Sonia', 'Febril', 'Parra', 'Valdeolivas, Granada', '958565656', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Elena', 'Veiguela', 'Suarez', 'Mux�a, La Coru�a', '981425323', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Ana Mar�a', 'Cuesta', 'Su�er', 'Gij�n, Asturias', '984454545', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Isabella', 'Ceballos', 'Gonz�lez', 'Boston, U.S.A.', '123456789', 'La m�s grande', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Francisco', 'Ceballos', 'Fern�ndez', 'Boston, U.S.A.', '111555999', 'CEO Evermedia', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Manuel', 'Setien', 'Latorre', 'Santander, Cantabria', '942555333', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Ismael', 'Puertas', 'L�pez', 'Matar�, Barcelona', '934343567', 'Frabicante de calzado', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Carmen', 'Torres', 'Salda�a', 'Motril, Granada', '958737373', 'Ninguna', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Javier', 'Ceballos', 'Fern�ndez', 'Alcal� de Henares, Madrid', '911234567', 'Ingeniero de Inform�tica', 'fotos/foto.jpg')
INSERT INTO telefonos
       VALUES ('Roberto', 'Canales', 'Mora', 'Torrej�n, Madrid', '916753306', 'Director ejecutivo de Autentia', 'fotos/foto.jpg')
GO
quit
