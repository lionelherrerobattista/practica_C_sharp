/*
 * (3.2.3.1) Calcula el volumen de una esfera, dado su radio,
 * que será un número de doble precisión
 * (volumen = pi * radio al cubo * 4/3)
 */
 using System;
 
 public class Ejercicio_3_2_3_1
 {
	 public static void Main()
	 {
		 double volumen;
		 double radio;
		 float pi = 3.14f; //f para indicar que es un float
		 
		 Console.Write("Escriba el radio de la esfera"+
		 " para calcular su volumen: "); //usar "," en SO en español
		 radio = Convert.ToDouble(Console.ReadLine()); //Paso la String a Double
		 
		 volumen = pi * (radio * radio * radio) * (4/3);
		 Console.WriteLine("El volumen de la esfera es {0}", volumen);
	 }
 }
