/*(4.2.3) Un programa que pregunte al usuario el tamaño
 *  que tendrán dos bloques de números enteros (por ejemplo,
 *  uno de 10 elementos y otro de 12). Luego pedirá los datos
 *  para ambos bloques de datos. Finalmente deberá mostrar
 *  el mayor dato que se ha introducido en cada uno de ellos.
 */
 using System;
 
 public class Ejercicio_4_2_3
 {
	 public static void Main()
	 {
		 //Declaro Arrays de distintos tamaños
		 int[][] numeros;
		 //variables para guardar el tamaño de los bloques
		 int tamUno;
		 int tamDos;
		 //Variable dato mayor
		 int[] mayor = new int[2]; //Dos bloques
		 int i;
		 int j;
		 
		 //se que son dos bloques
		 numeros = new int[2][];
		 
		 //Pido el tamaño al usuario
		 Console.WriteLine("Escriba el tamaño del primer bloque: ");
		 tamUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine("Escriba el tamaño del segundo bloque: ");
		 tamDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Le asigno el espacio a los bloques
		 numeros[0] = new int[tamUno];
		 numeros[1] = new int[tamDos];
		 
		 for(i = 0; i < numeros.Length; i++)
		 {
			 Console.WriteLine("-----------------------------------------");
			 Console.WriteLine("Bloque {0}:", i);
			 //propiedad .length calcula el tamaño del array
			 for(j = 0; j < numeros[i].Length; j++)
			 {
			     numeros[i][j] = Convert.ToInt32(Console.ReadLine());
			 }
		 }
		 
		 //Calculo los mayores
		 for(i = 0; i < numeros.Length; i++)
		 {
			 
			 mayor[i] = numeros[i][0];
			 //propiedad .length calcula el tamaño del array
			 for(j = 0; j < numeros[i].Length; j++)
			 {
			     if(mayor[i] < numeros[i][j])
			     {
					 mayor[i] = numeros[i][j];
				 }
			 }
		 }
		 //Muestro el mayor de cada bloque
		 Console.WriteLine("-----------------------------------------");
		 for(i = 0; i < 2; i++)
		 {
			 Console.WriteLine("Mayor bloque {0}: {1}", i+1, mayor[i]);
		 }
	 }
 }
