USE APLICACION
GO
--EMPRESA
Select * from EMPRESA

insert EMPRESA select 1,'AIEP S.A.','Educacional','Grajales 5000'
insert EMPRESA select 2,'Amazon Reteal','Retail','Seatle USA'
--USUARIO
Select * from USUARIO

insert USUARIO select 1,'blisbos','123456','bernando','lisboa','contabilidad','contador',1
insert USUARIO select 2,'pperez','987654','paola','perez','contabilidad','administrador',1
insert USUARIO select 3,'pedro','789456','pedro','marquez','contabilidad','administrador',1
--TIPO DE REQUERIMIENTO					
select *  from TIPO_DE_REQUERIMIENTO

insert TIPO_DE_REQUERIMIENTO select 1,'Instalar Software'
insert TIPO_DE_REQUERIMIENTO select 2,'Formatear computador'
insert TIPO_DE_REQUERIMIENTO select 3,'Desbloquear usuario '
--TIPO DE PRIORIDAD
select *  from TIPO_DE_PRIORIDAD

insert TIPO_DE_PRIORIDAD select 1,'Alta',3
insert TIPO_DE_PRIORIDAD select 2,'Media',4
insert TIPO_DE_PRIORIDAD select 3,'Baja',5
--REQUERIMIENTO
select *  from REQUERIMIENTO

insert REQUERIMIENTO select 1,'Instalar Office',1,1,3,'P'
insert REQUERIMIENTO select 2,'Instalar Chrome',1,1,1,'P'
insert REQUERIMIENTO select 3,'Instalar Excel',2,1,3,'P'
insert REQUERIMIENTO select 4,'Instalar Outllok',2,1,1,'P'

