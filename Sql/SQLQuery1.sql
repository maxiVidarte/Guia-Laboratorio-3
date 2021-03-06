/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP 1000 [pNumero]
      ,[pNombre]
      ,[Precio]
      ,[Tamaño]
  FROM [TP3-2016].[dbo].[Productos]

/*1)*/	
select * 
from dbo.Productos ordenby 
Order by pNombre 

/*2)*/
select * 
from dbo.Proveedores 
where Localidad = 'Capital'

/*3)*/
select * 
from dbo.Envios 
where Cantidad >= 200 and Cantidad <= 300

/*4)*/
select sum(Cantidad) as Cantidad 
from dbo.Envios

/*5)*/
select (SUM(Precio)/COUNT(Precio)) as PrecioPromedio 
from dbo.Productos 

/*6)*/
select (Precio*Cantidad) 
from dbo.Productos as t1 
inner join dbo.Envios as t2 on t1.pNumero = t2.pNumero

/*7)*/
select sum(Cantidad) as CantidadTotal 
from dbo.Envios 
where Numero = 102 and pNumero = 1

/*8)*/ 
select Prod.pNombre from dbo.Productos as Prod 
inner join dbo.Envios as Env  on Env.pNumero=Prod.pNumero 
inner join dbo.Proveedores as Prov on Prov.Numero = Env.Numero 
where Prov.Localidad = 'Avellaneda'

/*9)*/
select Prov.Domicilio, Prov.Localidad from dbo.Proveedores as Prov where Prov.Localidad Like '%i%'

/*10)*/
use [TP3-2016];
insert into Productos 
(pNumero, pNombre, Precio, Tamaño) 
Values ('4','Chocolate', '0.35' , 'Chico')

/*11)*/
use [TP3-2016];
insert into Proveedores(Numero,Nombre, Domicilio,Localidad)
Values('103','Gomez','Centenario 1250','Lanus')

/*12)*/
use [TP3-2016];
insert into Proveedores (Numero, Nombre, Domicilio, Localidad)
values ('107','Rosales','','La Plata')

/*13)*/
use [TP3-2016];
update Productos 
set Precio = 7.50
where Tamaño = 'Grande'

/*14)*/
use [TP3-2016];
update Productos
set Tamaño = 'Mediano'
from Productos, Envios
where Productos.pNumero = Envios.pNumero and Productos.pNumero = 1 and Envios.Cantidad>= 300

/*15)*/
Delete from Productos
where pNumero = 1

/*16)*/
delete Proveedores from Proveedores 
where not exists(Select Envios.Numero from Envios where Envios.Numero = Proveedores.Numero)






