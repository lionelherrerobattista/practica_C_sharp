/*(5.5.3) Crea una función "EsPrimo", que reciba un número
 * y devuelva el valor booleano "true" si es un número primo o "false"
 * en caso contrario.
 */
 using System;
 
 public class Ejercicio_5_5_3
 {
	 public static bool EsPrimo(int numero)
	 {
		 int contadorDivisores = 0;
		 int divisor;
		 bool esPrimo = true;
		 
		if(numero == 0 || numero == 1)
		{
			esPrimo = false;						
		}
		else
		{
			 for(divisor = 1; divisor <= numero; divisor++)
			 {
				 if(numero % divisor == 0)
				 {
					 contadorDivisores++;				 
				 }
				 
				 if(contadorDivisores > 2)
				 {
					 esPrimo = false;
					 break;
				 }
			 }
		 }
		 
		 return esPrimo;
		 
	 }
	 
	 public static void Main()
	 {
		 int numeroUsuario;
		 
		 //Pido un número al ususario:
		 Console.WriteLine("Ingrese un número para saber si es primo.");
		 
		 numeroUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 
		 if(EsPrimo(numeroUsuario))
		 {
			 Console.WriteLine("Es primo.");
		 }
		 else
		 {
			 Console.WriteLine("No es primo.");
		 }
	 }
 }
