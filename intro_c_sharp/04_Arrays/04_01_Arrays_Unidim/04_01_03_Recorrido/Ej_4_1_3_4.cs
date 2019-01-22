/*(4.1.3.4) Un programa que almacene en una tabla el número de días
 * que tiene cada mes (de un año no bisiesto), pida al usuario que
 * le indique un mes (ej. 2 para febrero) y un día (ej. el día 15)
 *  y diga qué número de día es dentro del año (por ejemplo,
 *  el 15 de febrero sería el día número 46,
 *  el 31 de diciembre sería el día 365).
 */
 using System;
 
 public class Ejercicio_4_1_3_4
 {
	 public static void Main()
	 {
		 
		 int[] diasMeses = {31, 29, 31, 30, 31, 30, 31, 31, 30,
			  30, 30, 30};
			  
		 int mes;
		 int i;
		 int acumuladorMeses=0;
		 int dia;
		 
		 Console.Write("Indique el número del mes: ");
		 mes = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Indique el día: ");
		 dia = Convert.ToInt32(Console.ReadLine());
		 
		 //Le sumo al acumulador la cantidad de días que tienen
		 //los meses anteriores
		 for(i = 0; i < mes-1; i++)
		 {
			 acumuladorMeses += diasMeses[i];
		 }
		 
		 //Luego le sumo la cantidad de días que ingresó el usuario
		 //para el mes elegido
		 acumuladorMeses += dia;
		 
		 Console.WriteLine("Es el día {0} dentro del año",
		  acumuladorMeses);
		
		
		 
		 
		 
	 }
	 
 }
