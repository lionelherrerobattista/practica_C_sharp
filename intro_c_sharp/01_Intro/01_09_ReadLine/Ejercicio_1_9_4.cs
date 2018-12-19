/* Pide al usuario una cantidad de millas nauticas
 y muestra la equivalencia en metros */
public class Ejercicio_1_9_4
{
	public static void Main()
	{
		int millasNauticas;
		int metros;//1 milla nautica = 1852 metros
		
		System.Console.WriteLine("Escriba las millas nauticas para obtener su equivalencia en metros");
		millasNauticas = System.Convert.ToInt32(System.Console.ReadLine());

		metros = millasNauticas * 1852;

		System.Console.WriteLine("Metros: {0}", metros);
	}
}
		

		