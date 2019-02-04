/*(4.1.4.1) Crea una variante del ejemplo anterior (04_01_04a)
 * que pida al usuario el dato a buscar, avise si ese dato no aparece,
 * y que diga cuántas veces se ha encontrado en caso contrario.
 */
 using System;
 
 public class Ejercicio_4_1_4_1
 {
	 public static void Main()
	 {
		 int[] datos = {10, 15, 12, 15, 0};
		 //int capacidad = 5;
		 int cantidad = 4;
		 int i;
		 int datoUsuario;
		 int contadorDato = 0;//Cuantas veces aparece el dato
		 
		 Console.WriteLine("¿Qué dato desea buscar?");
		 datoUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 for(i = 0; i< cantidad; i++)
		 {
			 if(datoUsuario == datos[i])
			 {
				 contadorDato++;
			 }
		 }
		 
		 if(contadorDato == 0)
		 {
			 Console.WriteLine("No se encuentra el dato.");
		 }
		 else
		 {
			 Console.WriteLine("Cantidad de veces que se econtró: {0}",
			  contadorDato);
		 }
	 }
 }
