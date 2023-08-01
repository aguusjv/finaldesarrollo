create database LINQ

create table informacion
(
ID int primary key identity(1,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
legajo int not null,
categoriaID int not null,
foreign key (categoriaID) references categoria(ID))

create table categoria
(
ID int not null primary key,
Cat_Nombre varchar(50) not null)

INSERT INTO categoria (ID,Cat_Nombre)
VALUES
    (1,'Categoría 1'),
    (2,'Categoría 2'),
    (3,'Categoría 3')

