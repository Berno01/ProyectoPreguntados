go
Create database Preguntados
go
use Preguntados
go
CREATE TABLE Categoria (
idCategoria int identity primary key not null,
NombreCategoria varchar (100) not null,
Imagen varchar(200) default null,
)


CREATE TABLE Pais(
idPais int identity primary key,
nombrePais varchar(30) not null
)

CREATE TABLE Genero(
idGenero int identity primary key,
nombreGenero varchar(30) not null
)

CREATE TABLE Rol(
idRol int identity primary key,
nombreRol varchar(15)
)

CREATE TABLE Usuarios (
ci varchar(15) primary key,
NombreCompleto varchar(70) not null,
idRol int not null,
idGenero int not null,
idPais int not null,
usuario varchar(15) not null,
contra varchar(15) not null,
foto varchar(200) default null,
CONSTRAINT fk_pais FOREIGN KEY (idPais) REFERENCES Pais(idPais),
CONSTRAINT fk_genero FOREIGN KEY (idGenero) REFERENCES Genero(idGenero)
)


CREATE TABLE Preguntas (
idPregunta int identity primary key,
idCategoria int not null,
Pregunta varchar (200) not null,
RespuestaCorrecta varchar (200) not null,
RespuestaIncorrecta1 varchar (200) not null,
RespuestaIncorrecta2 varchar (200) not null,
CONSTRAINT fk_categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
)

CREATE TABLE Juego (
idJuego int identity primary key,
idCategoria int not null,
ci varchar(15) not null,
puntaje float not null,
CONSTRAINT fk_categoriaJuego FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
)

--inserciones basicas
--USUARIO ADMIN


INSERT INTO Genero values ('Masculino')
INSERT INTO Genero values ('Femenino')

INSERT INTO Rol values ('Administrador')
INSERT INTO Rol values ('UsuarioNormal')

INSERT INTO Pais values ('Bolivia')
INSERT INTO Pais values ('Argentina')

select * from usuarios
INSERT INTO Usuarios values ('10650001tja', 'Bernardo Rueda', 2, 1, 1, 'berno', '1234', 'aqui va la ubicacion de la foto')


select imagen from Categoria
select idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, NombreCategoria  FROM Preguntas P, Categoria C where P.idCategoria=C.idCategoria
select * from Preguntas
update preguntas set RespuestaCorrecta='correcta'
select TOP 1 idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, C.NombreCategoria, C.Imagen from Preguntas P, Categoria C order BY NEWID()
---------------------------------------
/*
select * from Preguntas
select * from usuarios

insert into Preguntas values (1, '¿Quien eres?', 'Nadie sabe', 'Soy humano', 'Soy boliviano')

select * from Juego

select ci, nombreCompletto, genero, pais, foto
select * from usuarios


INSERT INTO Juego VALUES (1, '10651192tja', 4)

select TOP 1 * from Preguntas ORDER BY NEWID()

select * from usuarios where usuario = 'berno'

select * from rol

select * from Preguntas
delete from categoria where idCategoria=10


select Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, NombreCategoria FROM Preguntas P, Categoria C where P.idCategoria=C.idCategoria

select idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, NombreCategoria  FROM Preguntas P, Categoria C where P.idCategoria=C.idCategoria
select * from preguntas

Delete from Preguntas where id =2
select * from juego

insert into Juego values(1, '10651192tja', 5)

select * from juego

select TOP 1 idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, C.NombreCategoria from Preguntas P, Categoria C order BY NEWID()

select U.ci, NombreCompleto, nombreGenero, U.foto, J.puntaje from usuarios U, Juego J, Genero G where U.idGenero = G.idGenero
select * from usuarios
*/
select  U.ci, NombreCompleto, nombreGenero, U.foto, J.puntaje from usuarios U, Juego J, Genero G where U.idGenero = G.idGenero



