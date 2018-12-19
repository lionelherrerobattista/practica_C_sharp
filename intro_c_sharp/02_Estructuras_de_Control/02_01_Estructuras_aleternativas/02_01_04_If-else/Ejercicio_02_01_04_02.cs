/*
Mejora la solución al ejercicio 2.1.3.2, usando "else"
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
	else
	{
	    if(divisor == 0)
	    {
	        Console.WriteLine("Error:No se puede dividir entre cero");
	    }

	}

    }


}