/*(4.4.7.1) Un programa que pida al usuario una frase
 * y muestre sus palabras en orden inverso.
 */
 using System;
 
 public class Ejercicio_4_4_7_1
 {
	 public static void Main()
	 {
		 string fraseUsuario;
		 string[] elementosFrase;
		 char delimitador;
		 int i;
		 
		 delimitador = ' ';
		 
		 Console.WriteLine("Escriba una frase: ");
		 fraseUsuario = Console.ReadLine();

		 //Elimino los espacios adicionales:
		 while(fraseUsuario.IndexOf("  ") != -1)
		 {
		     fraseUsuario = fraseUsuario.Replace("  "," ");	 
		 }
	 
		 //Separo los elementos de la frase usando el delimitador
		 elementosFrase = fraseUsuario.Split(delimitador);
		 
		 //Muestro la frase en sentido inverso
		 //(empiezo en elementos totales -1, sino me paso)
		 for(i = elementosFrase.Length-1; i >= 0; i--)
		 {
			 Console.Write("{0} ", elementosFrase[i]);
		 }
	 }
 }
