/*
(2.2.7.2) Crea un programa que muestre 5 veces
las letras de la L (may�scula) a la N (may�scula),
en la misma l�nea.
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