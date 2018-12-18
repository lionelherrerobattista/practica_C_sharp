/*
Crea un programa que convierta de grados Celsius (centígrados)
 a Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados 
*/
using System;

public class Ejercicio_1_11_4
{
	public static void Main()
	{
		int celsius;
		int kelvin; //kelvin = celsius + 273
		int fahrenheit; //fahrenheit = celsius x 18 / 10 + 32

		Console.Write("Escriba la temperatura en grados Celsius: ");
		celsius = Convert.ToInt32(Console.ReadLine());

		//Conversiones		
		kelvin = celsius + 273;
		fahrenheit = celsius * 18 / 10 + 32;
		
		Console.Write("La conversion a Kelvin es: ");
		Console.Write(kelvin);
		Console.Write(". La conversion a Fahrenheit es: ");
		Console.Write(fahrenheit);
		Console.Write(".");
	}
}
		