/*
(2.2.2.1) Crear un programa que pida n�meros positivos al usuario,
 y vaya calculando y mostrando la suma de todos ellos
(terminar� cuando se teclea un n�mero negativo o cero).
*/

using System;

public class Ejercicio_02_02_02_01
{
    public static void Main()
    {
	int numeroUsuario;
	int sumaNumeros=0;

	do
	{
	    Console.Write("Escriba un numero (0 o negativo para salir): ");
	    numeroUsuario = Convert.ToInt32(Console.ReadLine());
	    
	    sumaNumeros += numeroUsuario;
	    Console.WriteLine("La suma de los numeros ingresados es {0}", sumaNumeros);
	
	}while(numeroUsuario>0);

    }
}