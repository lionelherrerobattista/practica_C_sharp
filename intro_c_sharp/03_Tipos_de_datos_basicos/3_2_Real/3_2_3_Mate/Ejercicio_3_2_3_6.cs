/*
 * (3.2.3.6) Crea un programa que "dibuje" la gráfica de y = (x-5)2
 *  para valores de x entre 1 y 10. Deberá hacerlo
 *  dibujando varios espacios en pantalla y luego un asterisco.
 *  La cantidad de espacios dependerá del valor obtenido para "y".
 */
 using System;
 
 public class Ejercicio_3_2_3_6
 {
	 public static void Main()
	 {
		 int contador;
		 int resultadoAnterior=0;
		 int resultado;
		 int cantidadEspacios;
		 /*int xPositiva=10;
		 int xNegativa=0;
		 int flag=0;*/
		 
		 for(contador = 10; contador >= 0; contador--)
		 {
			 resultado = (contador - 5) * (contador - 5);
			 
			 for(cantidadEspacios = resultado; cantidadEspacios>0; cantidadEspacios-- )
			 {
				 Console.Write(" ");				 
			 }
			 Console.WriteLine("*");
			 		 
		 }
		 
		 
		 /*
		 for(contador = 5; contador >= 0; contador--)
		 {
			 resultado = (xNegativa - 5) * (xNegativa - 5);

			 
			 
			 
			 if(flag == 0)
			 {
				 resultadoAnterior = resultado;
				 flag = 1;
			 }

			 for(cantidadEspacios = resultadoAnterior - resultado; cantidadEspacios>0; cantidadEspacios-- )
			 {
					 Console.Write(" ");				 
			 }

			 Console.Write("*");
			 for(cantidadEspacios = resultado; cantidadEspacios>0; cantidadEspacios-- )
			 {
				 Console.Write(" ");				 
			 }
			 
			 xNegativa++;
			 
			 
			 resultado = (xPositiva - 5) * (xPositiva - 5);
			 cantidadEspacios= resultado;
			 
			 for(cantidadEspacios = resultado; cantidadEspacios>0; cantidadEspacios-- )
			 {
				 Console.Write(" ");				 
			 }
			 Console.WriteLine("*");
			 
			 xPositiva--;
			 
			 
			 		 
		 }*/
		 

		 
	 }
	 
 }
