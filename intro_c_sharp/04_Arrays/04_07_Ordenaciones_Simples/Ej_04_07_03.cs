/*(4.7.3) Un programa que pida al usuario varios números,
 * los vaya añadiendo a un array, mantenga el array ordenado
 * continuamente y muestre el resultado tras añadir cada nuevo dato
 * (todos los datos se mostrarán en la misma línea,
 * separados por espacios en blanco).
 * Terminará cuando el usuario teclee "fin".
 */
using System;

public class Ejercicio_4_7_3
{
	const int TAM_ARRAY = 10;
	
	public static void Main()
	{
		//Array donde guardo los numeros:
		int[] numeros = new int [TAM_ARRAY];
		int auxiliarNumero;
		string auxiliarString;
		
		//Cantidad de numeros que tengo cargados:
		int numerosCargados = 0;
		
		//para iterar:
		int i;
		int j;
		int k;
		
		//Pido al usuario los numeros:
		if(numerosCargados < TAM_ARRAY)
		{
			for(k = numerosCargados; k < TAM_ARRAY; k++)
			{
				Console.WriteLine("Ingrese un numero o escriba \"fin\" para salir:");
				//Pido un numero
				auxiliarString = Console.ReadLine();
				
				if(auxiliarString != "fin")
				{
					//Agrego el numero al array:
					numeros[k] = Convert.ToInt32(auxiliarString);
					numerosCargados++; //hay un numero más en el array
					
					//Ordeno los numeros:
					for(i = 1; i < numerosCargados; i++)
					{
						j = i-1;//comparo con el nro a la izq
						
						//ordeno de menor a mayor
						while((j >= 0) && (numeros[j] > numeros[j+1]))
						{
							//si el de la izq es mayor, ordeno:
							auxiliarNumero = numeros[j];
							numeros[j] = numeros[j+1];
							numeros[j+1] = auxiliarNumero;
							
							j--; //me muevo a la izquierda							
						}
					}
					
					//Muestro:
					Console.WriteLine("Numeros ordenados:");
					for(i = 0; i < numerosCargados; i++)
					{
						Console.Write("{0} ", numeros[i]);
					}
					Console.WriteLine();
				}
				else
				{
					//Si escribe "fin" termina de ingresar los numeros
					Console.WriteLine("FIN DEL PROGRAMA");
					break;
				}
			}
		}
	}
}
