/*(5.9.1.4) Crea un programa que genere un array relleno
 * con 100 números reales al azar entre -1000 y 1000.
 * Luego deberá calcular y mostrar su media.
 */
 using System;
 
 public class Ejercicio_5_9_1_4
 {
	 //Función que crea un numero real al azar
	 //Recibe el random desde afuera para no repetir el numero al hacer 
	 //loop
	 public static float CrearNumeroRandom(Random random, float minimo, float maximo)
	 {
		 float retorno;
		 
		 //uso el metodo .NextDouble y lo paso a float
		 // * (máximo - minimo) + mínimo mantiene el nro.
		 // dentro del rango establecido
		 retorno = Convert.ToSingle(random.NextDouble() * (maximo - minimo) + minimo);
		 
		 return retorno;
	 }
	 public static void Main()
	 {
		 Random random = new Random();//lo creo afuera de la función para que, al hacer el loop, no repita los valores
		 float[] matrizReales = new float [100];
		 int i;
		 float total = 0;
		 float media;
		 
		 //Cargo el array con los numeros reales
		 for(i = 0; i < 100; i++)
		 {
			 matrizReales[i] = CrearNumeroRandom(random, -1000f, 1000f);
			 Console.WriteLine(matrizReales[i]);
			 total += matrizReales[i];
		 }
		 
		 //Obtengo la media:
		 media = (float)total / 100;
		 
		 //Muesto el resultado:
		 Console.WriteLine("La media es {0}", media);
		 
		 
		 
		 
	 }
 }
