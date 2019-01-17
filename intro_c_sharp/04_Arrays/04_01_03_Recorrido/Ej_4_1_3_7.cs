/*(4.1.3.7) Un programa que prepare espacio para guardar un máximo
 *  de 100 nombres. El usuario deberá ir introduciendo un nombre cada
 *  vez, hasta que se pulse Intro sin teclear nada,
 *  momento en el que dejarán de pedirse más nombres
 *  y se mostrará en pantalla la lista de los nombres
 *  que se han introducido.
 */
 using System;
 
 public class Ejercicio_4_1_3_7
 {
	 public static void Main()
	 {
		string[] nombres = new string[100];
		int index=0;
		int i;
		
		Console.WriteLine("Ingrese los nombres (máximo 100):");
		do
		{
			
			nombres[index] = Console.ReadLine();
			index++;
			
		}while(nombres[index-1] != ""); //Cuando toca ENTER sale
		//Me fijo en el indice anterior
		
		//Muestro los datos ingresados
		for(i = 0; i < index; i++)
		{
			Console.Write("{0} ", nombres[i]);
		}
		 
	 }
 }
