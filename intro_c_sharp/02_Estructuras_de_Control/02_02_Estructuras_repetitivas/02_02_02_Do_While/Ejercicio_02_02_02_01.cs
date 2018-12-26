/*
(2.2.2.1) Crear un programa que pida números positivos al usuario,
 y vaya calculando y mostrando la suma de todos ellos
(terminará cuando se teclea un número negativo o cero).
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