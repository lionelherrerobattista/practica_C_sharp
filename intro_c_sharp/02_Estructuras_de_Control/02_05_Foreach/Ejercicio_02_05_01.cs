/*
(2.5.1) Crea un programa que cuente cuantas veces aparece la letra 'a'
en una frase que teclee el usuario, utilizando "foreach".
*/
using System;

public class Ejercicio_02_05_01
{
    public static void Main()
    {
	string frase;
	int contadorLetra = 0; //cuenta las letras 'a'
	
	Console.Write("Escriba una frase: ");
	frase = Console.ReadLine();

	foreach(char letra in frase)//Tomo cada letra de la cadena
	{
	    if(letra == 'a') //Compruebo que sean 'a'
	    {
		contadorLetra++; //Sumo uno al contador
	    }
	}

	Console.WriteLine("La frase tiene {0} letras 'a'", contadorLetra);
    }

}