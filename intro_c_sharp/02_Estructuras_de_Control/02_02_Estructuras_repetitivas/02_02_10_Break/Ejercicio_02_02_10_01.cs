/*
(2.2.10.1) Crea un programa que pida al usuario dos n�meros
y escriba su m�ximo com�n divisor
(pista: una soluci�n lenta pero sencilla es probar con un "for"
todos los n�meros descendiendo a partir del menor de ambos, hasta llegar a 1;
cuando encuentres un n�mero que sea divisor de ambos, interrumpes la b�squeda).
*/
using System;

public class Ejercicio_02_02_10_01
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;
	int menor;
	int divisor; 

	Console.Write("Ingrese un numero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine());

	Console.Write("Ingrese otro numero: ");
	numeroDos = Convert.ToInt32(Console.ReadLine());
	

	//Me fijo cual es menor
	if(numeroUno < numeroDos)
	{
	    menor = numeroUno;
	}
	else
	{
	    menor = numeroDos;
	}	

	//Empiezo desde el menor hasta llegar al 1
	for(divisor=menor; divisor >= 1; divisor--)
	{
	    //Busco el m�ximo com�n divisor
	    if((numeroUno % divisor == 0) && (numeroDos % divisor == 0))
	    {
	        Console.Write("El maximo comun divisor es {0}.", divisor);
	        break;
	    }
	}

    }

}