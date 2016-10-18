/*1)*/	
select * from dbo.Productos ordenby Order by pNombre 

/*2)*/
select * from dbo.Proveedores where Localidad = 'Capital'

/*3)*/
select * from dbo.Envios where Cantidad >= 200 and Cantidad <= 300

/*4)*/
select sum(Cantidad) as Cantidad from dbo.Envios

/*5)*/




  
