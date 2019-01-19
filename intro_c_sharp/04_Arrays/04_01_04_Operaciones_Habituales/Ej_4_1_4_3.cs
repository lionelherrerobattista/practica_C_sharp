/*(4.1.4.3) Crea una variante del ejemplo anterior (04_01_04a)
 * que inserte un dato introducido por el usuario en la posición
 * que elija el usuario. Debe avisar si la posición escogida
 * es incorrecta (porque esté más allá del final de los datos).
 */
 using System;
 
 public class Ejercicio_4_1_4_3
 {
	 public static void Main()
	 {
		int[] datos = {10, 15, 12, 0, 0};
		int capacidad = 5;
		int cantidad = 3;
		int i;
		int datoUsuario;
		int posicionDato;


		Console.Write("Escriba el dato a añadir: ");
		datoUsuario = Convert.ToInt32(Console.ReadLine());
			
		Console.Write("Escriba la posición: ");
		posicionDato = Convert.ToInt32(Console.ReadLine());
			
		while(posicionDato < 1 || posicionDato > capacidad)
		{
			   Console.Write("Posición inválida." +
			     "Escriba la posición: ");
			   posicionDato = Convert.ToInt32(Console.ReadLine());
				
		}
			
		datos[posicionDato-1] = datoUsuario;
		cantidad++;
			

        for (i = 0; i < capacidad; i++)
        {

            Console.WriteLine(datos[i]);
        }
		
	 }
 }
