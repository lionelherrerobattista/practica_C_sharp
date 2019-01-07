/*
 * (3.2.6.4) Crea un programa que pida números binarios al usuario
 * y muestre su equivalente en sistema hexadecimal y en decimal.
 *  Debe repetirse hasta que el usuario introduzca la palabra "fin".
 */
 using System;
 
 public class Ejercicio_3_2_6_4
 {
	 public static void Main()
	 {
		string numeroUsuario;
		int numeroDecimal;

		
		do
		{
			Console.Write("Introduzca un numero en binario " +
			 "('fin' para salir): ");
			numeroUsuario = Console.ReadLine();
			
			if(numeroUsuario != "fin") //Para que no rompa si escribe fin
			{	 
				numeroDecimal = Convert.ToInt32(numeroUsuario, 2);
				Console.WriteLine("Decimal: {0}", numeroDecimal);
				
				//Utilizo el numero decimal y lo paso a Hexa como string
				Console.WriteLine("Hexadecimal: {0}",
				 numeroDecimal.ToString("X"));							
			}
	
		}while(numeroUsuario != "fin"); 
		 
	 }
 }
