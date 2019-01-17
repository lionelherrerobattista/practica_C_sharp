/*
 * (4.1.2.1) Un programa que almacene en una tabla el número de días
 * que tiene cada mes (supondremos que es un año no bisiesto),
 *  pida al usuario que le indique un mes (1=enero, 12=diciembre)
 *  y muestre en pantalla el número de días que tiene ese mes.
 */
 using System;
 
 public class Ejercicio_4_1_2_1
 {
	 public static void Main()
	 {
		 
		 int[] diasMeses = {31, 28, 31, 30, 31, 30, 31, 31,
			 30, 31, 30, 31};
		 string[] nombreMes = {"enero", "febrero", "marzo", "abril",
			  "mayo", "junio", "julio", "agosto", "septiembre",
			   "octubre", "noviembre", "diciembre"};
		 
		 int mesUsuario;
		 int indice;
		 
		 Console.WriteLine("Indique el numero del mes"+
		 " para saber la cantidad de dias que tiene ");
		 Console.Write("Mes: ");
		 mesUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 for(indice=0; indice < 12; indice++)
		 {
			 if(indice == mesUsuario-1) //-1 porque indice empieza en 0
			 {
				 Console.WriteLine("El mes de {0} tiene {1} dias.",
				  nombreMes[indice], diasMeses[indice]);
			 }
		 }
			 
		
		 
	 }
 }
