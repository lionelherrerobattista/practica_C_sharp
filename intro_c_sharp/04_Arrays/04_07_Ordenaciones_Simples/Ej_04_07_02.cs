/*(4.7.2) Un programa que pida al usuario 5 nombres
 * y los muestre ordenados alfabéticamente
 * (recuerda que para comparar cadenas no podrás usar el símbolo ">",
 * sino "CompareTo").
 */
using System;

public class Ejercicio_4_7_2
{
	//Constante para el total de nombres que voy a pedir:
	const int TOTAL_NOMBRES = 5;
	
	public static void Main()
	{
		//Para guardar los nombres:
		string[] nombres = new string [TOTAL_NOMBRES];
		string auxiliarNombre; //auxiliar para ordenar
		
		//Para iterar:
		int i;
		int j;
		
		//Pido los nombres:
		Console.WriteLine("Ingrese 5 nombres: ");
		for(i = 0; i < TOTAL_NOMBRES; i++)
		{
			nombres[i] = Console.ReadLine();
			
		}
		
		//Ordeno los nombres (Metodo de inserción):
		for(i = 1; i < TOTAL_NOMBRES; i++)//empiezo por el indice 1
		{
			j=i-1;//comparo con el de la izq
			
			while((j>=0) && String.Compare(nombres[j], nombres[j+1])>0)
			{
				//si el de la izq es mayor, ordeno
				auxiliarNombre = nombres[j];
				nombres[j] = nombres[j+1];
				nombres[j+1] = auxiliarNombre;
				
				j--;//Me sigo moviendo a la izq
			}
		}
		
		Console.WriteLine();
		//Muestro los nombres ordenados:
		Console.WriteLine("Nombres ordenados:");
		foreach(string nombre in nombres)
		{
			Console.WriteLine("{0}", nombre);
		}
		
		
		
	}
}
