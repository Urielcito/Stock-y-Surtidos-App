# Stock-y-Surtidos-App

## Ventanas

### Principal

Cuando abre el programa abre aca, esta ventana no tiene nada mas que botones para ir al listado de productos, listado de fuentes y los otros diversos listados que planeo hacer

### Productos

En esta ventana se van a poder visualizar los productos de todas las empresas y categorias con una foto, se va a poder agregar nuevos productos, marcar si tenemos o no en casa y cuanto, ademas de crear nuevas categorias para los productos. Tambien se va a poder buscar productos en concreto y aplicar diversos filtros a esta busqueda y al listado en general (precio, fuente, cantidad en casa)

### Fuentes

Lo mismo que la ventana de productos, solo que mas orientado a añadir borrar y modificar las fuentes.

## Listados que podria implementar con lo que ya tengo:

- Productos mas baratos de cada tienda
- Productos de los cuales no tenemos NADA o POCO filtrado por fuente
- Productos seleccionados de diversas empresas que el programa nos recomienda comprar

## Funcionalidades que me gustaria implementar en el futuro:

- ponerle foto a las fuentes y a los productos
- capacidad de clickear en un boton y que genere un Excel conteniendo: productos que tenemos bien en una columna, otra columna con productos que no tenemos o tenemos poco, una columna con los gastos de cada producto que nos recomienda comprar en los lugares donde sale mas barato, con una columna al lado que especifique de que lugar hay que comprarlo (agrupado por eso) y otra columna que haga lo mismo pero con los productos mas caros, entonces se consigue un presupuesto minimo y presupuesto maximo. Los productos caros obviamente se tienen que conseguir por la comparacion de productos de la misma categoria y no de distinta tienda, a parte de ser distintos productos obviamente

## TO-DO Actual:

- Poder cambiar de fuente y categoria en el listado de productos
- Investigar y escribir querys SQL que satisfagan las vistas que se deseen conseguir para no hacerlo desde el codigo,
	por ejemplo: una query por cada forma de ordenar a los productos, una para los productos que no tenemos, otra para los productos que deberiamos comprar (no tenemos + son importantes), e implementarlas en pProducto y Controladora