create database Ristorante;
use Ristorante;

create table Menu(
Id int identity(1,1) primary key not null,
Primo nvarchar(50),
Secondo nvarchar(50),
Contorno nvarchar(50),
Dolce nvarchar(50)
);

create table Giornata(
Id int identity(1,1) primary key not null,
Giorno nvarchar(50),
Orario nvarchar(50),
FkMenu int foreign key references Menu 
);
