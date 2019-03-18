/*(5.9.1.2) Crea un programa que genere un número al azar entre 1 y 100.
 * El usuario tendrá 6 oportunidades para acertarlo.
 */
 using System;
 
 public class Ejercicio_5_9_1_2
 {
	 public static void Main()
	 {
		 Random numero = new Random();
		 
		 int numeroAdivinar;
		 int numeroUsuario;
		 int intentos = 6;
		 
		 numeroAdivinar = numero.Next(1, 101); //entre 1 y 100
		 
		Console.WriteLine("------------------------------------------");
		Console.WriteLine("Intentá adivinar el numero (del 1 al 100)");
		Console.WriteLine("------------------------------------------");
		 do
		 {
			 
			 Console.WriteLine("Intentos: {0}", intentos);
			 Console.WriteLine("------------------------------------------");
			 Console.Write("Respuesta: ");
			 numeroUsuario = Convert.ToInt32(Console.ReadLine());
			 
			 
			 
			 
		
			 
			 
			 if(numeroUsuario == numeroAdivinar)
			 {
				 Console.WriteLine("------------------------------------------");
				 Console.WriteLine("¡¡Acertaste!!");
				 Console.WriteLine("------------------------------------------");
				 break;
			 }
			 else
			 {
				 Console.WriteLine("------------------------------------------");
				 Console.WriteLine("Número incorrecto.");
				 intentos--;			 
			 }
			 
		 }while(intentos > 0);
		 
		 if(intentos == 0)
		 {
			 Console.WriteLine("------------------------------------------");
			 Console.WriteLine("Se acabaron los intentos. Perdiste =(");
			 Console.WriteLine("------------------------------------------");
		 }
	 }
 }
