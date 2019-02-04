/*(4.5.1) Un programa que pida tu nombre y lo muestre con un espacio
 * entre cada par de letras, usando "foreach".
 */
using System;

public class Ejercicio_4_5_1
{
	public static void Main()
	{
		string nombreUsuario;
		
		//Pido el nombre
		Console.Write("Escriba su nombre: ");
		nombreUsuario = Console.ReadLine();
		
		//Separo cada letra del nombre
		foreach(char letra in nombreUsuario)
		{
			//y la escribo con un espacio entre medio
			Console.Write("{0} ", letra);
		}
		
	}
}
