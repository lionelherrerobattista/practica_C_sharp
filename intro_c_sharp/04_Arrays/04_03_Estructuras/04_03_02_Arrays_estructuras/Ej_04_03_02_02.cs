/*(4.3.2.2) Crea un programa que permita guardar datos de "imágenes"
 *  (ficheros de ordenador que contengan fotografías
 *  o cualquier otro tipo de información gráfica).
 *  De cada imagen se debe guardar: nombre (texto),
 *  ancho en píxeles (por ejemplo 2000),
 *  alto en píxeles (por ejemplo, 3000),
 *  tamaño en Kb (por ejemplo 145,6). El programa debe ser capaz
 *  de almacenar hasta 700 imágenes (deberá avisar
 *  cuando su capacidad esté llena). Debe permitir las opciones:
 *  añadir una ficha nueva, ver todas las fichas (número y nombre
 *  de cada imagen), buscar la ficha que tenga un cierto nombre.
 */
 using System;
 
 public class Ejercicio_4_3_2_2
 {
	 struct sImagen
	 {
		 public string nombre;
		 public int ancho;
		 public int alto;
		 public float tamImagen;
	 }
	 
	 public static void Main()
	 {
		 sImagen[] listaImagenes = new sImagen[700];
		 int opcion;
		 int ocupado = 0;//cantidad de canciones guardadas
		 int i;
		 string buscarNombre;
		 
		 do
		 {
			 Console.WriteLine("-------------------------------------"); 
			 Console.WriteLine("1-Añadir ficha.");			 
			 Console.WriteLine("2-Ver fichas.");
			 Console.WriteLine("3-Buscar ficha.");
			 Console.WriteLine("4-Salir.");
			 Console.WriteLine("-------------------------------------"); 
			 Console.Write("Opcion: ");
			 opcion = Convert.ToInt32(Console.ReadLine());
			 Console.WriteLine("-------------------------------------"); 
			 
			 switch(opcion)
			 {
				 case 1://Agregar ficha
				     if(ocupado < 700)
				     {    
						  Console.Write("Nombre: ");
						  listaImagenes[ocupado].nombre =
						   Console.ReadLine();
						  Console.Write("Ancho: ");
						  listaImagenes[ocupado].ancho =
						   Convert.ToInt32(Console.ReadLine());
						  Console.Write("Alto: ");
						  listaImagenes[ocupado].alto =
						   Convert.ToInt32(Console.ReadLine());
						  Console.Write("Tamaño: ");
						  listaImagenes[ocupado].tamImagen =
						   Convert.ToSingle(Console.ReadLine()); 
						  ocupado++;
				     }
				     else
				     {
						 Console.WriteLine("No hay espacio.");
					 }
				     break;
				 case 2://Mostrar todas
				     for(i = 0; i < ocupado; i++)
				     {
						 if(listaImagenes[i].nombre != "")
						 {
							 Console.WriteLine("Numero: {0}", i+1);
							 Console.WriteLine("Nombre: {0}",
							  listaImagenes[i].nombre);
						 }
					 }
				     break;
				 case 3://Buscar ficha por nombre
				     Console.Write("Escriba el nombre de la ficha: ");
				     buscarNombre = Console.ReadLine();
				     
				     for(i = 0; i < ocupado; i++)
				     {
						  if(String.Compare(buscarNombre,
						   listaImagenes[i].nombre) == 0)
						  {  
							   Console.WriteLine("Numero: {0}", i+1);
							   Console.WriteLine("Nombre: {0}",
							    listaImagenes[i].nombre);
							   Console.WriteLine("Ancho: {0}",
							    listaImagenes[i].ancho);
							   Console.WriteLine("Alto: {0}",
							    listaImagenes[i].alto);
							   Console.WriteLine("Tamaño: {0}",
							    listaImagenes[i].tamImagen);
						  }
						   					 
					 }
				     break;
			 }
			 
		 }while(opcion != 4);
		
	 }
 }
