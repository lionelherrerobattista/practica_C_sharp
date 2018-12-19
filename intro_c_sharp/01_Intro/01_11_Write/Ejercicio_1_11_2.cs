/* Pedir al usuario un número y mostrar su tabla de multiplicar,
 usando {0},{1} y {2}. */
using System;

public class Ejercicio_1_11_2
{
	public static void Main()
	{
		int numeroUsuario;
		int multiplo;
		int resultado;
		
		Console.Write("Escriba un numero para ver su tabla de multiplicar: ");
		numeroUsuario = Convert.ToInt32(Console.ReadLine());
		
		multiplo = 0;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado); 
		multiplo = 1;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 2;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 3;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 4;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 5;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 6;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 7;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 8;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 9;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);
		multiplo = 10;
		resultado = numeroUsuario * multiplo;
		Console.WriteLine("{0} * {1} = {2}", numeroUsuario, multiplo, resultado);

	}
}