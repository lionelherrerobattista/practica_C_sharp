/*
Crea un programa que pregunte al usuario su edad y su año de nacimiento.
 Si la edad que introduce no es un número válido, mostrará un mensaje de aviso.
 Lo mismo ocurrirá si el año de nacimiento no es un número válido.
*/
using System;

public class Ejercicio_02_07_01
{
    public static void Main()
    {
	int edad;
	int nacimiento;

	try
	{
	    Console.Write("Escriba su edad: ");
	    edad = Convert.ToInt32(Console.ReadLine());

	    Console.Write("Escriba la fecha de nacimiento: ");
	    nacimiento = Convert.ToInt32(Console.ReadLine());

	    Console.WriteLine("Edad: {0}. Fecha de nacimiento: {1}", edad, nacimiento);
	}
	catch(FormatException)
	{
	    Console.WriteLine("No es un numero valido");
	}
	

    }
}