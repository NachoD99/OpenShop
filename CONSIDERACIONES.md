# DOCUMENTACION ACLARATORIA

Se tuvieron en cuenta las siguientes consideraciones:

* El programa está desarrollado en lenguaje C#, en una aplicación de consola Windows Forms.

* Este es solo un fragmento funcional de todo el programa **OpenShop**, para poder realizar
las implementaciones independientemente del resto de los grupos, se ha aislado dicha área.

* Ha habido un trabajo colaborativo entre grupos para determinar los datos que necesitamos transferir
de un grupo a otro.
* Los datos que necesita recibir el área de Cobranza son:
	* Lista de artículos vendidos:
		* Id artículo
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
	* El estado de confirmación de la compra

* Se ha decidido trabajar con un monto fijo para el valor del costo de envío, a fines de simplificar
los cálculos del costo total de la compra.

* Debido a la realidad complicada de manejar la operación de una transacción de dinero ya sea por cualquier
tipo de forma de pago (efectivo / tarjeta), se ha tomado una simplificación del problema. En la realidad,
cualquier sistema de E-commerce debe sincronizar sus operaciones con las compañias de pago que existen en la
actualidad, como lo son Mercado Pago, Rapipago, bancos, etc. Para gestionar el cobro en Open Shop se ha decidido
generar un código aleatorio que luego el usuario lo cargue en la pantalla final, de otra forma no puede finalizar
la compra.

* Las órdenes de compra se manipulan en formato JSON.

* A modo de poder trabajar con las órdenes en todos los proyectos, se ha utilizado la ruta c:\datos\nombreDelArchivo

* La instancia de pago se genera en la ventana de confirmación de la compra junto con la orden de compra. No se instancia
en la ventana de pago debido a que yo para confirmarlo debo introducir el código de seguridad en la ventana siguiente.
