/*
 * (3.3.1.2) Crea un programa que muestre una de cada dos letras
 *  entre la que teclee el usuario y la "z". Por ejemplo, si el usuario
 *  introduce una "a", se escribirá "aceg...".
 */
 using System;
 
 public class Ejercicio_3_3_1_2
 {
	 public static void Main()
	 {
		 char letra;
		 char contador;
		 
		 Console.Write("Escriba una letra: ");
		 letra = Convert.ToChar(Console.ReadLine());
		
		 //Muestra las letras intercaladas
		 for(contador = letra; contador <= 'z'; contador+=(char)2) //Tengo que pasar el nro a char para que funcione
		 {
		
			 Console.Write("{0}", contador);
			 
		 }	 
		 
	 }
	 
 }
