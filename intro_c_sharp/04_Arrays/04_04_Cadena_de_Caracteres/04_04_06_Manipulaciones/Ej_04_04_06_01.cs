/*(4.4.6.1) Una variante del ejercicio 4.4.5.2,
 * que no distinga entre mayúsculas y minúsculas a la hora de buscar.
 */
 using System;
 
 public class Ejercicio_04_04_06_01
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
			 //Guardo en minusculas
			 frases[i] = Console.ReadLine().ToLower();
		 }
		 
		 //Estructura repetitiva que pide el texto a comparar
		 do
		 {	 //paso a minúscula para que no importe como lo escriba el usuario
			 Console.Write("Ingrese un texto: ");
			 texto = Console.ReadLine().ToLower();
			 
			 
			 if(texto != "fin") //si escribe fin termina el programa
			 {
				 for(i = 0; i < 10; i++)
				 {
					 //Busco si el texto está en el array
					 if(frases[i].Contains(texto.ToLower()))
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
