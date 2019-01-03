/*
 * (3.2.4.1) Crea un programa que calcule la raíz cuadrada del número
 *  que introduzca el usuario. La raíz se deberá calcular como "double",
 *  pero el resultado se mostrará como "float"
 */
 using System;

public class Ejercicio_3_2_4_1
{
	public static void Main()
	{
		double numero;
		double raizCuadrada;
		float resultado;
		
		Console.Write("Escriba un numero para calcular su raiz cuadrada: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		raizCuadrada = Math.Sqrt(numero);
		
		//Para mostrar el resultado como float
		resultado = (float)raizCuadrada; //Typecast
		
		Console.WriteLine("El resultado en doble precision es {0}",
		 raizCuadrada);
		Console.WriteLine("El resultado en simple precision es {0}",
		 resultado);
		
	}
	
	
}
