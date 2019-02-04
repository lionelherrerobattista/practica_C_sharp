/*(4.4.7.2) Un programa que pida al usuario varios números separados
 * por espacios y muestre su suma.
 */
 using System;
 
 public class Ejercicio_4_4_7_2
 {
	 public static void Main()
	 {
		 string numerosUsuario;
		 char delimitador;
		 string[] numerosSeparados;
		 int suma = 0;
		 int i;
		 
		 delimitador = ' ';
		 
		 Console.WriteLine("Escriba numeros separados por espacios para saber su suma:");
		 numerosUsuario = Console.ReadLine();
		 
		 //Saco los espacios adicionales.
		 while(numerosUsuario.IndexOf("  ") != -1)
		 {
			 //Reemplazo por un solo espacio
		     numerosUsuario = numerosUsuario.Replace("  "," ");	 
		 }
		 
		 numerosSeparados = numerosUsuario.Split(delimitador);
		 
		 for(i=0; i < numerosSeparados.Length; i++)
		 {
			 suma += Convert.ToInt32(numerosSeparados[i]);
		 }
		 
		 Console.WriteLine("La suma es: {0}", suma);

	 }
 }
