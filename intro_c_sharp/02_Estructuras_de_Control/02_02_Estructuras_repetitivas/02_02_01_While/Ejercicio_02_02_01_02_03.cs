/*
(2.2.1.2.3) Crea un programa calcule cuantas cifras tiene
un número entero positivo 
(pista: se puede hacer dividiendo varias veces entre 10).
*/

using System;

public class Ejercicio_02_02_01_02_03
{
    public static void Main()
    {
	int numero;
	int contadorCifras = 0;

	Console.Write("Escriba un numero: ");
	numero = Convert.ToInt32(Console.ReadLine());
	
	while(numero>0)
	{
	    contadorCifras += 1;
	    numero= numero / 10;
	}

	Console.WriteLine("El numero tiene {0} cifra(s).", contadorCifras);

    }



}