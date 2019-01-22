/*(4.1.3.5) A partir del ejercicio anterior,
 *  crea otro que pida al usuario que le indique la fecha,
 *  formada por día (1 al 31) y el mes (1=enero, 12=diciembre),
 *  y como respuesta muestre en pantalla el número de días que
 *  quedan hasta final de año.
 */
 using System;
 
 public class Ejercicio_4_1_3_5
 {
	 public static void Main()
	 {
		 int[] diasMeses = {31, 29, 31, 30, 31, 30, 31, 31, 30,
			 30, 30, 30};
			  
		 int mes;
		 int i;
		 int acumuladorMeses=0;
		 int dia;
		 int diasRestantes;
		 
		 Console.Write("Indique el número del mes" +
		  " (1=enero, 12=diciembre): ");
		 mes = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Indique el día (1 al 31): ");
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
		 
		 diasRestantes = 365 - acumuladorMeses;
		 
		 Console.WriteLine("Faltan {0} días para fin de año.s",
		  diasRestantes);
		 
	 }
	 
 }

