/*1)*/	
select * from dbo.Productos ordenby Order by pNombre 

/*2)*/
select * from dbo.Proveedores where Localidad = 'Capital'

/*3)*/
select * from dbo.Envios where Cantidad >= 200 and Cantidad <= 300

/*4)*/
select sum(Cantidad) as Cantidad from dbo.Envios

/*5)*/
select (SUM(Precio)/COUNT(Precio)) as PrecioPromedio from dbo.Productos 

/*6)*/
select (Precio*Cantidad) from dbo.Productos as t1 inner join dbo.Envios as t2 on t1.pNumero = t2.pNumero

/*7)*/
select sum(Cantidad) as CantidadTotal from dbo.Envios where Numero = 102 and pNumero = 1

/*8)*/ 
select Prod.pNombre from dbo.Productos as Prod inner join dbo.Envios as Env  on Env.pNumero=Prod.pNumero inner join dbo.Proveedores as Prov on Prov.Numero = Env.Numero where Prov.Localidad = 'Avellaneda'

/*9)*/
select Prov.Domicilio, Prov.Localidad from dbo.Proveedores as Prov where Prov.Localidad Like '%i%'

/*10)*/
