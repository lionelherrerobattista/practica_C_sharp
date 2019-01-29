/*(4.4.5.2) Crea una versión del ejercicio 4.4.5.1 en la que,
 *  en caso de que alguno de los textos aparezca como subcadena,
 *  se avise además si se encuentra exactamente al principio.
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
						 
						 
						 if(frases[i].IndexOf(texto) == 0) // 0 = 1° posición en la cadena
						 {
							 Console.WriteLine("Aparece en la primera"
							  + " posición.");
						 }
						 else
						 {
							 Console.WriteLine("Aparece.");
						 }
						 
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
