# Stock-y-Surtidos-App

## Para no olvidarme:
- Falta modificar los metodos de los listados personalizados para que también acepten filtrar por categoria/fuente al mismo tiempo que filtran los datos con sus propias condiciones

## Ventanas

### Principal

Cuando abre el programa abre aca, esta ventana no tiene nada mas que botones para ir al listado de productos y el listado de fuentes.

- TO-DO: Boton para generar un Excel conteniendo: productos que tenemos bien en una columna, otra columna con productos que no tenemos o tenemos poco, una columna con los gastos de cada producto que nos recomienda comprar en los lugares donde sale mas barato, con una columna al lado que especifique de que lugar hay que comprarlo (agrupado por eso) y otra columna que haga lo mismo pero con los productos mas caros, entonces se consigue un presupuesto minimo y presupuesto maximo. Los productos caros obviamente se tienen que conseguir por la comparacion de productos de la misma categoria y no de distinta tienda, a parte de ser distintos productos obviamente

### Productos

Un producto representa a un bien físico del mundo real y proveniente de un supermercado, local, tienda X.
Se puede ver, agregar, modificar y eliminar Productos.

- TO-DO: Tambien se puede ver distintas listas de productos, desde listas ordenadas por la propiedad de un producto hasta complicadas listas que muestran productos dadas condiciones especificas.
 
### Fuentes

TO-DO: Se pueden ver, agregar, modificar y eliminar Fuentes, una Fuente representa a un local/supermercado/sucursal en la que se pueden comprar bienes

## Listados Implementados:
- Productos seleccionados de diversas empresas que el programa nos recomienda comprar (Tenemos NADA/POCO del producto + el producto es importante)
	- SQL Query: select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio and p1.importante = '1' and (p1.cuanto_tenemos = 'NADA' or p1.cuanto_tenemos = 'POCO')
- Productos unicos y duplicados mas baratos de todas las tiendas
	- SQL Query: select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio
- Productos de los cuales no tenemos en casa
	- SQL Query: select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio and (p1.cuanto_tenemos = 'NADA')
 - 
# Futuro:

## Agregar tres entidades nuevas 
- Lista de compras (1 unico registro en la base de datos, siendo constantemente modificado, atributos: los productos)
- Surtido realizado (una lista de compras y una fecha)
	
## Funcionalidades:
- Para cada producto el cual aparezca en minimo 2 surtidos, calcular la duracion entre una compra y otra, sumarla con el resto de duraciones calculadas en caso de ser mas de una y calcular una duracion promedio.
- Mostrar en la pantalla principal los productos que estan cerca del fin de su duracion en rojo, como una prediccion de que se esta por acabar, que diga, por ejemplo: Probablemente se acaben: y abajo la lista de productos

	
	
