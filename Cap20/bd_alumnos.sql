USE master

if exists (select * from sysdatabases where name='bd_alumnos')
begin
  raiserror('La base de datos existe; eliminándola....',0,1)
  DROP database bd_alumnos
end
GO

raiserror('Creando base de datos bd_telefonos....',0,1)
go

CREATE DATABASE bd_alumnos
GO

USE bd_alumnos
GO

CREATE TABLE alumnos
(
  id_alumno     INT PRIMARY KEY,
  nombre        VARCHAR(50) NOT NULL,
  apto          BIT NOT NULL
)
GO

INSERT INTO alumnos VALUES (1, 'Alumno 1', 'True')
INSERT INTO alumnos VALUES (2, 'Alumno 2', 'False')
INSERT INTO alumnos VALUES (3, 'Alumno 3', 'True')
INSERT INTO alumnos VALUES (4, 'Alumno 4', 'True')
INSERT INTO alumnos VALUES (5, 'Alumno 5', 'False')
INSERT INTO alumnos VALUES (6, 'Alumno 6', 'True')
INSERT INTO alumnos VALUES (7, 'Alumno 7', 'True')
INSERT INTO alumnos VALUES (8, 'Alumno 8', 'True')
INSERT INTO alumnos VALUES (9, 'Alumno 9', 'False')
INSERT INTO alumnos VALUES (10, 'Alumno 10', 'True')
INSERT INTO alumnos VALUES (11, 'Alumno 11', 'True')
INSERT INTO alumnos VALUES (12, 'Alumno 12', 'True')
INSERT INTO alumnos VALUES (13, 'Alumno 13', 'False')
INSERT INTO alumnos VALUES (14, 'Alumno 14', 'True')
INSERT INTO alumnos VALUES (15, 'Alumno 15', 'True')
INSERT INTO alumnos VALUES (16, 'Alumno 16', 'True')
INSERT INTO alumnos VALUES (17, 'Alumno 17', 'True')
INSERT INTO alumnos VALUES (18, 'Alumno 18', 'True')
INSERT INTO alumnos VALUES (19, 'Alumno 19', 'False')
GO

quit
