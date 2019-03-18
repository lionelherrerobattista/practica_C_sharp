/*(5.9.2.1) Crea un programa que halle (y muestre) la raíz cuadrada
 * del número que introduzca el usuario. Se repetirá hasta
 * que introduzca 0.
 */
 using System;
 
 public class Ejercicio_5_9_2_1
 {
	 public static void Main()
	 {
		 double raizCuadrada;
		 int numero;
		 
		 //Pido el número al usuario:
		 do
		 {
			 Console.Write("Ingrese un numero para obtener su raíz" +
			 " cuadrada: ");
			 numero = Convert.ToInt32(Console.ReadLine());
			 
			 raizCuadrada = Math.Sqrt(numero);
			 
			 Console.WriteLine("La raíz cuadrada de {0} es {1}", numero,
			  raizCuadrada);
			 
		 }while(numero != 0);
	 }
 }
