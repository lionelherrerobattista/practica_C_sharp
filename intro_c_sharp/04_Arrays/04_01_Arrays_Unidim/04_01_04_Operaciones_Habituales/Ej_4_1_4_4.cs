/*(4.1.4.4) Crea una variante del ejemplo anterior (04_01_04a)
 * que borre el dato que se encuentre en la posición que elija
 * el usuario. Debe avisar si la posición escogida no es válida.
 */
 using System;
 
 public class Ejercicio_4_1_4_4
 {
	 public static void Main()
	 {
		int[] datos = {10, 15, 12, 0, 0};
		int capacidad = 5;
		int cantidad = 3;
		int i;
		int posicionDato;

		for (i = 0; i < capacidad; i++)
        {

            Console.WriteLine(datos[i]);
        }

		Console.Write("Escriba la posición del dato que desea borrar: ");
		posicionDato = Convert.ToInt32(Console.ReadLine());
			
			
		while(posicionDato < 1 || posicionDato > capacidad)
		{
			   Console.Write("Posición inválida." +
			     "Escriba la posición: ");
			   posicionDato = Convert.ToInt32(Console.ReadLine());
				
		}
			
		datos[posicionDato-1] = 0;
		cantidad--;
		
		for (i = 0; i < capacidad; i++)
        {

            Console.WriteLine(datos[i]);
        }
			
		
	 }
 }
