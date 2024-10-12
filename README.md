# Stock-y-Surtidos-App

## Ventanas

### Principal

Cuando abre el programa abre aca, esta ventana no tiene nada mas que botones para ir al listado de productos y el listado de fuentes.

## TO-DO: 

- Ventana de MANEJAR LISTAS que facilite detalles acerca de la lista de compras
- Importar el database.sql actualizado.
- Buscar una manera de que el programa se conecte solo a la base de datos de mi pc de torre, para que natalia pueda usarlo desde la laptop y que los cambios se vean reflejados en ambas plataformas.

### Productos

Un producto representa a un bien físico del mundo real y proveniente de un supermercado, local, tienda X.
Se puede ver, agregar, modificar y eliminar Productos.
 
### Fuentes

Una Fuente representa a un local/supermercado/sucursal en la que se pueden comprar bienes
Se puede ver, agregar, modificar y eliminar Fuentes

# Futuro: 
- Surtido realizado (una lista de compras y una fecha)
- Boton para generar un Excel conteniendo: productos que tenemos bien en una columna, otra columna con productos que no tenemos o tenemos poco, una columna con los gastos de cada producto que nos recomienda comprar en los lugares donde sale mas barato, con una columna al lado que especifique de que lugar hay que comprarlo (agrupado por eso) y otra columna que haga lo mismo pero con los productos mas caros, entonces se consigue un presupuesto minimo y presupuesto maximo. Los productos caros obviamente se tienen que conseguir por la comparacion de productos de la misma categoria y no de distinta tienda, a parte de ser distintos productos obviamente

- Reescribir todo el proyecto y repositorio en Inglés
	
## Funcionalidades:
- Para cada producto el cual aparezca en minimo 2 surtidos, calcular la duracion entre una compra y otra, sumarla con el resto de duraciones calculadas en caso de ser mas de una y calcular una duracion promedio.
- Mostrar en la pantalla principal los productos que estan cerca del fin de su duracion en rojo, como una prediccion de que se esta por acabar, que diga, por ejemplo: Probablemente se acaben: y abajo la lista de productos

# Lista de cambios

## v0.3-dev

- Ahora se pueden agregar productos a una lista de compras temporal:
	- Se puede guardar esa lista temporal en el ordenador con nombre a eleccion (.csv).
	- La lista temporal persiste en el ordenador en el archivo lists/productlist.csv
	
- Bugs corregidos:
	- El programa modificaba el nombre del producto y lo dejaba en vacio si se cerraba o cancelaba el InputBox respectivo sin escribir nada.
	- El programa se crasheaba al cerrar el InputBox que aparece al querer modificar el precio de un producto.
	
