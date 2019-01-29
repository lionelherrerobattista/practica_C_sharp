/*(4.4.5.1) Un programa que pida al usuario 10 frases,
 * las guarde en un array, y luego le pregunte textos
 * de forma repetitiva, e indique si cada uno de esos textos aparece
 * como parte de alguno de los elementos del array. Terminará cuando
 * el texto introducido sea "fin".
 */
 using System;
 
 public class Ejercicio_04_04_05_01
 {
	 public static void Main()
	 {
		 string[] frases = new string[10];
		 string texto;
		 int i;
		 
		 //Pide las 10 frases
		 Console.WriteLine("Escriba 10 frases:");
		 for(i = 0; i < 10; i++)
		 {
			 frases[i] = Console.ReadLine();
		 }
		 
		 //Estructura repetitiva que pide el texto a comparar
		 do
		 {
			 Console.Write("Ingrese un texto: ");
			 texto = Console.ReadLine();
			 
			 if(texto != "fin") //si escribe fin termina el programa
			 {
				 for(i = 0; i < 10; i++)
				 {
					 //Busco si el texto está en el array
					 if(frases[i].Contains(texto))
					 {
						 Console.WriteLine("Aparece.");	
						 break;//1 vez es suficiente
					 }
					 else
					 {
						 if(i == 9)//Si llegó a la última iteración
						 {
							 Console.WriteLine("No aparece.");
						 }
						 
					 }
				 }
			 }
		 }while(texto != "fin"); //termina el programa
	 }
 }
