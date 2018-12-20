/*
Crea un programa que lea una letra tecleada por el usuario
y diga si se trata de un signo de puntuación (. , ; :),
una cifra numérica (del 0 al 9) o algún otro carácter,
usando "switch" (pista: habrá que usar un dato de tipo "char").
*/

using System;

public class Ejercicio_02_01_09_02
{
    public static void Main()
    {
	char letra;

	Console.Write("Ingrese una letra: ");
	letra = Convert.ToChar(Console.ReadLine()); //Tengo que convertir la string a char

	switch(letra)
	{
	    case '.':
	    case ',':
	    case ';':
	    case ':':
		Console.WriteLine("Es un signo de puntuacion");
		break;
	    case '1': //Poner ' ' para los numeros, se está pasando un carácter
	    case '2':
	    case '3':
	    case '4':
	    case '5':
	    case '6':
	    case '7':
	    case '8':
	    case '9':
	    case '0':
		Console.WriteLine("Es una cifra numerica");
		break;
	    default:
		Console.WriteLine("Es otro tipo de caracter");
		break;
	}
    }
}