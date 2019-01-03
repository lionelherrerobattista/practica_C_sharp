/*
 * (3.2.4.2) Crea una nueva versión del un programa que calcula
 *  una aproximación de PI mediante la expresión:
 *  pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...)
 *  contantos términos como indique el usuario.
 *  Debes hacer todas las operacion con "double",
 *  pero mostrar el resultado como "float".
 */
using System;
 
 public class Ejercicio_3_2_3_7
 {
	 public static void Main()
	 {
		double pi=1; //Aproximacion pi/4, empiezo en 1/1
		float resultadoFloat;
		int cantidadTerminos; //Mientras más grande, más me acerco a pi/4
		int contador;
		double divisor=1;
		
		Console.Write("Escriba la cantidad de terminos: ");
		cantidadTerminos = Convert.ToInt32(Console.ReadLine());
		
		//Utilización de la expresión de aproximación
		for(contador=1; contador < cantidadTerminos; contador++)
		{
			divisor += 2;//el divisor aumenta de dos en dos (3,5,7...)
				
			if(contador % 2 != 0) //Si el contador es impar resta
			{
				pi -= 1/divisor;
				
			}
			else
			{
				pi += 1/divisor;	
			}
		
		}
				 
		
		Console.WriteLine("El resultado en doble precision es {0}", pi);
		
		resultadoFloat = (float)pi;
		
		Console.WriteLine("El resultado en simple precision es {0}", resultadoFloat);
		 
	 }
 }
