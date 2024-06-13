# Stock-y-Surtidos-App

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

## Listados por implementar:

- Productos duplicados mas baratos de cada tienda
	- SQL Query: select p.id as 'ID', p.nombre as 'Nombre', p.precio as 'Mejor precio', f.nombre As 'Lugar' FROM producto p, producto p2, fuente f WHERE p.id_fuente = f.id and p.nombre = p2.nombre and p.precio < p2.precio order by p.precio
- Productos de los cuales tenemos NADA o POCO
	- SQL Query: select p.id as 'ID', p.nombre as 'Nombre', p.precio as 'Precio', f.nombre As 'Se compra en', p.cuanto_tenemos as 'Cantidad' FROM producto p, fuente f WHERE p.id_fuente = f.id and p.cuanto_tenemos = 'NADA' or p.cuanto_tenemos = 'POCO' order by p.cuanto_tenemos
- Productos seleccionados de diversas empresas que el programa nos recomienda comprar (Tenemos NADA/POCO del producto + el producto es importante)
	- SQL Query: select p.id as 'ID', p.nombre as 'Nombre', p.precio as 'Precio', f.nombre As 'Se compra en', p.cuanto_tenemos as 'Cantidad' FROM producto p, fuente f WHERE p.id_fuente = f.id and p.importante = '1' and p.cuanto_tenemos = 'NADA' or p.cuanto_tenemos = 'POCO' order by p.cuanto_tenemos

- Productos de X categoria e Y fuente ordenados por Z cosa (Lo que esta encerrado en {} se modifica por medio del codigo)
  	-SQL Query:  select p.id as 'ID', p.nombre as 'Nombre', p.precio as 'Precio', f.nombre as 'Lugar', c.nombre as 'Categoria' from producto p, fuente f, categoria c where {p.id_fuente = f.id and p.id_categoria = c.id and c.nombre = 'comida' order by p.precio} Como hacer en el codigo: Puedo hacer una strVista = strQuery + condicionesWhere:

strQuery = "select p.id as 'ID', p.nombre as 'Nombre', p,precio as 'Precio', f.nombre as 'Lugar', c.nombre as 'Categoria' from producto p, fuente f, categoria c
condicionesWhere = ""
strFuente = ""
strCategoria = ""
strOrderBy = global, modificada por hacer click en los headers
strAnd = ""
If(cmbFuentes.SelectedIndex <> 0) Then
	strAnd = "and "
  	' conseguir id_fuente ' 
  	strFuente = "p.id_fuente = f.id and f.id = " & id_fuente
End If
If(cmbCategorias.SelectedIndex <> 0) Then
	' conseguir id_categoria '
 	strCategoria = strAnd & "p.id_categoria = c.id and c.id = "&id_categoria
End If

If(strFuente <> "" Or strCategoria <> "") Then
	condicionesWhere = "where " & strFuente & "" & strCategoria 
End If

strVista = strQuery + condicionesWhere + strOrderBy

' ES MAS O MENOS UNA IDEA DEL CODIGO, NO CREO QUE SEA TAN FACIL DE HACER, ALGO QUE PENSAR ES SI QUIERO HACERLO EN LA LISTA DE PRODUCTOS PARA MANTENER LA FUNCIONALIDAD DE LA LISTA O HACER UN LISTADO APARTE PARA ESTO QUE SOLO SIRVA PARA VER Y NO MODIFICAR NI ANADIR NI VER INFORMACION DETALLADA DE NADA
# Futuro:

## Agregar tres entidades nuevas 
- Lista de compras (1 unico registro en la base de datos, siendo constantemente modificado, atributos: los productos)
- Surtido realizado (una lista de compras y una fecha)
	
## Funcionalidades:
- Para cada producto el cual aparezca en minimo 2 surtidos, calcular la duracion entre una compra y otra, sumarla con el resto de duraciones calculadas en caso de ser mas de una y calcular una duracion promedio.
- Mostrar en la pantalla principal los productos que estan cerca del fin de su duracion en rojo, como una prediccion de que se esta por acabar, que diga, por ejemplo: Probablemente se acaben: y abajo la lista de productos

	
	
