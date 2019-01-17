/*(4.1.3.2) Crea un programa que pregunte al usuario cuántos números
 *  enteros va a introducir (por ejemplo, 10), le pida todos
 *  esos números, los guarde en un array y finalmente calcule
 *  y muestre la media de esos números.
 */
 using System;
 
 public class Ejercicio_4_1_3_2
 {
	 public static void Main()
	 {
		int[] numeros;
		int cantidadNumeros;
		int i; //contador para el ingreso de numeros
		int acumuladorNumeros=0;
		float promedio;
		
		Console.WriteLine("Cuantos numeros enteros desea ingresar? ");
		cantidadNumeros = Convert.ToInt32(Console.ReadLine());
		
		//Creo el array segun la cantidad de nros. que quiere el usuario
		numeros = new int[cantidadNumeros];
		
		for(i = 0; i < cantidadNumeros; i++)
		{
			Console.Write("Ingrese el numero {0}: ", i+1);
			numeros[i] = Convert.ToInt32(Console.ReadLine());
			acumuladorNumeros += numeros[i];
		}
		
		//Casteo para que me tome la parte decimal
		promedio = (float)acumuladorNumeros / cantidadNumeros;
		
		Console.WriteLine("El promedio de los numeros ingresados es: {0}",
		promedio.ToString("N2")); //Muestro con dos decimales
	 }
 }
