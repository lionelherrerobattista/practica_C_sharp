/*(4.7.4) Amplia el ejercicio anterior, para añadir una segunda fase
 * en la que el usuario pueda "preguntar" si un cierto valor está
 * en el array. Como el array está ordenado, la búsqueda no se hará
 * hasta el final de los datos, sino hasta que se encuentre el dato
 * buscado o un un dato mayor que él.
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
		
		//Respuesta:
		char respuesta;
		
		//Cantidad de numeros que tengo cargados:
		int numerosCargados = 0;
		
		//Flag de busqueda:
		bool encontroNumero = false;
		
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
					
					//Pregunto si quiere buscar un número
					Console.WriteLine("¿Desea buscar un numero? (s/n)");
					respuesta = Convert.ToChar(Console.ReadLine().ToLower());
					
					if(respuesta == 's')
					{
						//Pido el número a buscar
						Console.WriteLine("Ingrese el numero a buscar: ");
						auxiliarNumero = Convert.ToInt32(Console.ReadLine());
						
						//Recorro el array:
						for(i = 0; i < numerosCargados; i++)
						{
							encontroNumero= false;
							
							//Pregunto si está el numero:
							if(auxiliarNumero == numeros[i])
							{
								Console.WriteLine("El número se encuentra guardado.");
								encontroNumero = true;//cambio el flag
								break;
							}
							else
							{
								//Como está ordenado, si hay un número mayor,
								//no voy a encontrar el número que busco
								if(auxiliarNumero < numeros[i])
								{	
									break;//termino de iterar
								}
							}
						}
						
						if(encontroNumero == false)
						{
							Console.WriteLine("El número no se encuentra.");
						}
					}
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

