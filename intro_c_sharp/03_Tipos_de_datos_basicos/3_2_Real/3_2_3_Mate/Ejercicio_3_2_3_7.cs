/*
 * 3.2.3.7) Escribe un programa que calcule una aproximación de PI
 *  mediante la expresión:
 *  pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ...
 *  El usuario deberá indicar la cantidad de términos a utilizar,
 *  y el programa mostrará todos los resultados
 *  hasta esa cantidad de términos.
 *  Debes hacer todas las operacion con "double".
 */
 using System;
 
 public class Ejercicio_3_2_3_7
 {
	 public static void Main()
	 {
		double pi=1; //Aproximacion pi/4, empiezo en 1/1
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
				 
		
		Console.WriteLine("El resultado es {0}", pi);
		 
	 }
 }
