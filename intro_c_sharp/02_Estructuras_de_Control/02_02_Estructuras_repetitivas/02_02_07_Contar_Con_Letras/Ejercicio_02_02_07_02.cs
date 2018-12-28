/*
(2.2.7.2) Crea un programa que muestre 5 veces
las letras de la L (mayúscula) a la N (mayúscula),
en la misma línea.
*/
using System;

public class Ejercicio_02_02_07_02
{
    public static void Main()
    {
	char letra;
	int contador;

	for(contador=1; contador<=5; contador++)
	{
  	    for(letra='L';letra<='N';letra++)
	    {
	        Console.Write("{0}, ", letra);
	    }
	}
    }
}