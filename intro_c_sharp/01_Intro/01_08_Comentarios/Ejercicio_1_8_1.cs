/*(1.8.1) Crea un programa que convierta una cantidad
 prefijada de metros*/

public class Ejercicio_1_8_1
{
	public static void Main()
	{
		int metros;
		int millas; //Equivalencia: 1 milla = 1609 metros

		metros = 3000;

		//Formula que pasa los metros a millas
		millas = metros/1609;

		System.Console.WriteLine("El resultado es {0}",millas);
	}
}
		
		