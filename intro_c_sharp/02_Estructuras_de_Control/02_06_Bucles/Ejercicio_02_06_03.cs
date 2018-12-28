/*
(2.6.3) Crea un programa que calcule un número
elevado a otro, usando multiplicaciones sucesivas.
*/

using System;

public class Ejercicio_02_06_03
{
    public static void Main()
    {
	int numeroUsuario;
	int exponente;
	int contador;
	int resultado;

	//Pido la base y el exponente al usuario:
	Console.Write("Escriba la base: ");
	numeroUsuario = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba el exponente: ");
	exponente = Convert.ToInt32(Console.ReadLine());
	
	if(exponente == 0) //Numero elevado a 0 = 1
	{
	    resultado = 1;
	}
	else
	{
	    resultado = numeroUsuario; //Elevado a 1 = mismo numero

	    for(contador = exponente; contador > 1; contador--)
	    {
	        resultado = resultado * numeroUsuario; //Multiplico por la base la cantidad de veces necesarias
	    }
	}

	Console.Write("Resultado: {0}", resultado);

    } 

}