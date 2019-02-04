/*(4.4.9.1) Un programa que pida una cadena al usuario y la modifique
 * de modo que todas las vocales se conviertan en "o".
 */
 using System;
 using System.Text; //para el StringBuilder
 
 public class Ejercicio_4_4_9_1
 {
	 public static void Main()
	 {
		 
		 StringBuilder cadenaModificable; //declaro el StringBuilder
		 string cadenaNormal; //donde se guarda la cadena modificada
		 int i;
		 
		 //Pido una frase
		 Console.WriteLine("Escriba una frase:");
		 cadenaModificable = new StringBuilder (Console.ReadLine());
		 
		 for(i = 0; i < cadenaModificable.Length; i++)
		 {
			 //Reemplazo si es una vocal distinta de o
			 if(cadenaModificable[i] == 'a' ||
			  cadenaModificable[i] == 'e' ||
			   cadenaModificable[i] == 'i' ||
			    cadenaModificable[i] == 'u')
			 {
				 cadenaModificable[i] = 'o';
			 }
		 }
		 
		 //Convierto el StringBuilder en una String
		 cadenaNormal = cadenaModificable.ToString();
		 
		 //Muestro
		 Console.WriteLine("Nueva cadena: {0}", cadenaNormal);
	 }
 }
