/*
Crea un programa que pida al usuario dos números enteros.
Si el segundo no es cero, mostrará el resultado de dividir
 entre el primero y el segundo. Por el contrario,
 si el segundo número es cero, escribirá
 "Error: No se puede dividir entre cero".
*/

using System;

public class Ejercicio_02_01_03_02
{
    public static void Main()
    {
	int dividendo;
	int divisor;
	int resultado;

	
	Console.Write("Ingrese un numero entero: ");
	dividendo = Convert.ToInt32(Console.ReadLine());

	Console.Write("Ingrese otro numero entero: ");
	divisor = Convert.ToInt32(Console.ReadLine());

	if(divisor != 0)
	{
	    resultado = dividendo / divisor;
	    Console.WriteLine("El resultado de dividir {0} entre {1} es: {2}", dividendo, divisor, resultado);
	}

	if(divisor == 0)
	{
	    Console.WriteLine("Error:No se puede dividir entre cero");
	}
    }


}