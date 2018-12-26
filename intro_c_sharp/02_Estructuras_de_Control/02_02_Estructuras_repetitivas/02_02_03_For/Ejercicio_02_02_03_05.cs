/*
(2.2.3.5) Crea un programa que muestre
 los primeros ocho números pares: 2 4 6 8 10 12 14 16
 (pista: en cada pasada habrá que aumentar de 2 en 2,
 o bien mostrar el doble del valor que hace de contador).
*/

using System;

public class Ejercicio_02_02_03_05
{
    public static void Main()
    {
	int i;
	int numerosPares=0;

	for(i=1; i<=8; i++)
	{
	    numerosPares += 2; //o i * 2
	    Console.Write("{0}, ", numerosPares);

	}
	

    }


}