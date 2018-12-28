/*
(2.6.2) Crear un programa que descomponga un número (que teclee el usuario)
como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5
*/
using System;

public class Ejercicio_02_06_02
{
    public static void Main()
    {
	int numeroUsuario;
	int i = 2;

	Console.Write("Escriba un numero: ");
	numeroUsuario = Convert.ToInt32(Console.ReadLine());
	
	Console.Write("{0} = ", numeroUsuario);

	while(numeroUsuario > 1)
	{
	    while(numeroUsuario % i == 0)
	    {
	        Console.Write("{0} ", i);
	        numeroUsuario = numeroUsuario / i;
	    }

  	    i++;
        }

    }
}