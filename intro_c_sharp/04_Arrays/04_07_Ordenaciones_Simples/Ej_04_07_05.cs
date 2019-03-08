/* (4.7.5) Realiza una variante del ejercicio 4.7.4, que en vez
 * de hacer una búsqueda lineal (desde el principio),
 * use "búsqueda binaria": se comenzará a comparar con
 * el punto medio del array; si nuestro dato es menor,
 * se vuelve a probar en el punto medio de la mitad inferior del array,
 * y así sucesivamente.
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
		

		//para iterar:
		int i;
		int j;
		int k;
		
		//Para búsqueda binaria:
		int limiteInferior;
		int limiteSuperior;
		int puntoMedio;
		bool terminado = false;
		
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
						
						Console.WriteLine();
						Console.WriteLine("Buscando si aparece {0}...", auxiliarNumero);
						Console.WriteLine();
						
						//Búsqueda binaria:
						limiteInferior = 0;
						limiteSuperior = numerosCargados;
						terminado = false;
						
						while(!terminado)
						{
							puntoMedio = limiteInferior + (limiteSuperior - limiteInferior) / 2;
							
							//Compruebo si encontró el numero:
							if(numeros[puntoMedio] == auxiliarNumero)
							{
								Console.WriteLine("El número está en el array");
								terminado = true;								
							}
							else if( limiteInferior == limiteSuperior -1)
							{
								Console.WriteLine("No se encontró.");
								terminado = true;
							}
							
							//Caso contrario, sigobuscando
							if( numeros[puntoMedio] < auxiliarNumero)
							{
								//Muevo el limite inferior al punto medio
								//el numero que busco tiene que estar después								
								limiteInferior = puntoMedio;
							}
							else//si el punto medio es mayor al numero que busco
							{
								//Muevo el limite superior
								//el número que busco tiene que estar antes
								limiteSuperior = puntoMedio;
							}
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


