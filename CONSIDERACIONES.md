# DOCUMENTACION ACLARATORIA

Se tuvieron en cuenta las siguientes consideraciones:

* El programa est� desarrollado en lenguaje C#, en una aplicaci�n de consola Windows Forms.

* Este es solo un fragmento funcional de todo el programa **OpenShop**, para poder realizar
las implementaciones independientemente del resto de los grupos, se ha aislado dicha �rea.

* Ha habido un trabajo colaborativo entre grupos para determinar los datos que necesitamos transferir
de un grupo a otro.
* Los datos que necesita recibir el �rea de Cobranza son:
	* Lista de art�culos vendidos:
		* Id art�culo
		* Nombre
		* Marca
		* Precio
		* Descripcion
		* Cantidad
	* Fecha de venta
	* Monto
	* Cliente:
		* Id cliente
		* Nombre
		* Apellido
		* Correo
		* DNI
		* Domicilio
		* Ciudad
		* Provincia
		* Tarjetas:
			* Numero de tarjeta
        	* Nombre del titular
        	* Codigo de seguridad
        	* Entidad emisora
        	* Fecha de vencimiento
        	* DNI del titular
        	* Tipo de tarjeta

* Los datos que Cobranza debe enviar a Despacho son:
	* La orden de compra (la cual contiene todos los datos recibidos, descritos anteriormente).
	* El estado de confirmaci�n de la compra

* Se ha decidido trabajar con un monto fijo para el valor del costo de env�o, a fines de simplificar
los c�lculos del costo total de la compra.

* Debido a la realidad complicada de manejar la operaci�n de una transacci�n de dinero ya sea por cualquier
tipo de forma de pago (efectivo / tarjeta), se ha tomado una simplificaci�n del problema. En la realidad,
cualquier sistema de E-commerce debe sincronizar sus operaciones con las compa�ias de pago que existen en la
actualidad, como lo son Mercado Pago, Rapipago, bancos, etc. Para gestionar el cobro en Open Shop se ha decidido
generar un c�digo aleatorio que luego el usuario lo cargue en la pantalla final, de otra forma no puede finalizar
la compra.

* Las �rdenes de compra se manipulan en formato JSON.

* A modo de poder trabajar con las �rdenes en todos los proyectos, se ha utilizado la ruta c:\datos\nombreDelArchivo

* La instancia de pago se genera en la ventana de confirmaci�n de la compra junto con la orden de compra. No se instancia
en la ventana de pago debido a que yo para confirmarlo debo introducir el c�digo de seguridad en la ventana siguiente.
