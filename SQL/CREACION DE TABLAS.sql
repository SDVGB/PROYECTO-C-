CREATE DATABASE APLICACION

USE APLICACION 

CREATE TABLE EMPRESA(
ID_EMPRESA Int primary key ,
NOMBRE_E   Varchar(30) ,
TIPO       Varchar(20),
UBICACION  Varchar(30) )

CREATE TABLE USUARIO(
ID_USUARIO   Int primary key ,
NICK_U       Varchar(10),
CONTRASEÑA   Varchar(10) ,
NOMBRE_U     Varchar(20),
APELLIDO_U   Varchar (20),
DEPARTAMENTO Varchar (20),
CARGO        Varchar (30),
ID_EMPRESA   Int foreign key (ID_EMPRESA) references EMPRESA (ID_EMPRESA));

CREATE TABLE TIPO_DE_REQUERIMIENTO(
ID_TIPO  Int primary key,
NOMBRE_R Varchar(30))

CREATE TABLE TIPO_DE_PRIORIDAD(
ID_PRIORIDAD  Int primary key,
NOMBRE_P      Varchar(10),
PLAZO         Int)


CREATE TABLE REQUERIMIENTO(
ID_REQUERIMIENTO Int primary key,
DESCRIPCION      Varchar(30) ,
ID_USUARIO       Int foreign key (ID_USUARIO) references USUARIO (ID_USUARIO),
ID_TIPO          Int foreign key (ID_TIPO) references TIPO_DE_REQUERIMIENTO (ID_TIPO),
ID_PRIORIDAD     Int foreign key (ID_PRIORIDAD) references TIPO_DE_PRIORIDAD (ID_PRIORIDAD),
ESTADO           Char (1))




