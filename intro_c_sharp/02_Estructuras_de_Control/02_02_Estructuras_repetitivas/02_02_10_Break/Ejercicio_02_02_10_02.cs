/*
(2.2.10.2) Crea un programa que pida al usuario dos n�meros
y escriba su m�nimo com�n m�ltiplo (pista: una soluci�n lenta
pero sencilla es probar con un "for" todos los n�meros a partir
del mayor de ambos, de forma creciente;
cuando encuentres un n�mero que sea m�ltiplo de ambos,
interrumpes la b�squeda).
*/
using System;

public class Ejercicio_02_02_10_01
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;
	int mayor;
	int multiplo; 

	Console.Write("Ingrese un numero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine());

	Console.Write("Ingrese otro numero: ");
	numeroDos = Convert.ToInt32(Console.ReadLine());
	

	//Me fijo cual es mayor
	if(numeroUno > numeroDos)
	{
	    mayor = numeroUno;
	}
	else
	{
	    mayor = numeroDos;
	}	

	//Empiezo desde el mayor y voy aumentando el valor
	//hasta encontrar el m�nimo com�n m�ltiplo
	for(multiplo=mayor; multiplo >= mayor; multiplo++)
	{
	    if((multiplo % numeroUno == 0) && (multiplo % numeroDos == 0))
	    {
	        Console.Write("El minimo comun multiplo es {0}.", multiplo);
	        break;
	    }
	}

    }

}