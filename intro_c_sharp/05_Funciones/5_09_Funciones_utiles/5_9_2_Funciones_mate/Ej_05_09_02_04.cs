/*(5.9.2.4) Haz un programa que pida al usuario 5 datos numéricos enteros,
 * los guarde en un array, pida un nuevo dato y muestre el valor
 * del array que se encuentra más cerca de ese dato,
 * siendo mayor que él, o el texto "Ninguno es mayor" si ninguno lo es.
 */
 using System;
 
 public class Ejercicio_5_9_2_4
 {
	 //Función que ordena el array de menor a mayor
	 public static void OrdenarArrayNumeros(int[] arrayNumeros)
	 {
		 int auxiliarNumero;
		 int i;
		 int j;
		 
		 for(i = 1; i < arrayNumeros.Length; i++)
		 {
			j = i - 1;
			
			while((j >= 0) && (arrayNumeros[j] > arrayNumeros[j+1]))
			{
				auxiliarNumero = arrayNumeros[j];
				arrayNumeros[j] = arrayNumeros[j+1];
				arrayNumeros[j+1] = auxiliarNumero;
				j--;//Me muevo para atrás
			}
		 }
	 }
	 
	 //Encuentra el numero más cercano con el array ordenado
	 public static int NumeroMasCercano(int[] arrayNumeros, int numeroUsuario)
	 {
		 int i;
		 int numeroMasCercano;
		 int distanciaMinima = 0;
		 int distancia;
		 bool flagPrimeraIteracion = true;//en caso de que no esté ordenado
		 
		 numeroMasCercano = numeroUsuario;
		 
		 //Busco en el array
		 for(i = 0; i < arrayNumeros.Length; i++)
		 {

			 //Busco los mayores
			 if(arrayNumeros[i] > numeroUsuario)
			 {
				 //calculo la distancia
				 distancia = arrayNumeros[i] - numeroUsuario;
				 
				 
				 if(flagPrimeraIteracion == true)//primera iteracion
				 {
					 //minimo igual a la distancia
					 distanciaMinima = distancia;
					 numeroMasCercano = arrayNumeros[i];
					 flagPrimeraIteracion = false;
					 break;//si esta ordenado, el primero que encuentra es el mayor más cercano
				 }
				 /*else //si no está ordenado sigo buscando
				 {
					 //compruebo que sea menor al mínimo
					 if(distancia < distanciaMinima)
					 {
							 distanciaMinima = distancia;
							 numeroMasCercano = arrayNumeros[i];
					 } 
						 
				 }*/

			 }		

		 }
			 
		 return numeroMasCercano;
	 }
	 
	 public static void Main()
	 {
		 int[] arrayEnteros = new int [5];
		 int numeroUsuario;
		 int numeroMayorCercano = 0;
		 int i;
		 
		 //Pido cinco números al usuario
		 Console.WriteLine("Ingrese 5 datos numéricos enteros:");
		 for(i = 0; i < 5; i++)
		 {
			 arrayEnteros[i] = Convert.ToInt32(Console.ReadLine());
		 }
		 
		 //Pido el número para comparar
		 Console.WriteLine("Ingrese otro número para saber cuál es el mayor más cercano:");
		 numeroUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 //Ordeno el array
		 //Primer mayor que encuentre es el más cercano
		 OrdenarArrayNumeros(arrayEnteros);
		 
		 numeroMayorCercano = NumeroMasCercano(arrayEnteros, numeroUsuario);
		 
		 //Muestro los resultados
		 if(numeroMayorCercano == numeroUsuario)
		 {
			 Console.WriteLine("Ninguno es mayor");
		 }
		 else
		 {
			 Console.WriteLine("El número mayor más cercano es {0}", numeroMayorCercano);			 
		 }

		 
	 }	 
 }
