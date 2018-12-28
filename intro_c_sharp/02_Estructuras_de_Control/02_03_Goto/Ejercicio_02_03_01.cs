/*
(2.3.1) Crea un programa que escriba los números del 1 al 10,
separados por un espacio, sin avanzar de línea.
No puedes usar "for", ni "while", ni "do..while", sólo "if" y "goto".
*/
using System;

public class Ejercicio_02_03_01
{
    public static void Main()
    {
	int numero=1;
	
	iterar: //Vuelvo a este punto con el goto
	    Console.Write("{0} ", numero);
	if(numero < 10)
	{
	    numero++;
	    goto iterar; //vuelvo al principio para seguir imprimiendo

	}
    }
}