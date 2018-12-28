/*
(2.2.9.1) Crea un programa que pida un número al usuario
y escriba los múltiplos de 9 que haya entre 1 ese número.
Debes usar llaves en todas las estructuras de control,
aunque sólo incluyan una sentencia.
*/
using System;

public class Ejericio_02_02_09_01
{
    public static void Main()
    {
	int numero;
	int contador;
	
	Console.Write("Escriba un numero: ");
	numero= Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Multiplos de 9: ");
	for(contador = 1; contador<=numero; contador++)
	{
	    if(contador % 9 == 0)
	    {
	        Console.Write("{0} ", contador);
	    }
	}
    }
}