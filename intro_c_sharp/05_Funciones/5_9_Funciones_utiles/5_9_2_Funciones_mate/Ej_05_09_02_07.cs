/*(5.9.2.7) Crea un programa que pida al usuario un ángulo (en grados)
 * y muestre su seno, coseno y tangente. Recuerda que
 * las funciones trigonométricas esperan que el ángulo se indique
 * en radianes, no en grados.
 * La equivalencia es que 360 grados son 2*PI radianes.
 */
 using System;
 
 public class Ejercicio_5_9_2_7
 {
	 public static double EnRadianes(double anguloGrados)
	 {
		 double anguloRadianes;
		 
		 //Formula de conversión
		 anguloRadianes = (anguloGrados * (2*Math.PI))/360;
		 
		 return anguloRadianes;
		 
	 }
	 public static void Main()
	 {
		 double anguloGrados;
		 double anguloRadianes;
		 char respuesta;
		 
		 do
		 {
			 //Pido al usuario el angulo
			 Console.WriteLine("Escriba el ángulo en grados para" +
			  " calcular su Seno, Coseno y Tangente.");
			 Console.Write("En grados: ");
			 anguloGrados = Convert.ToSingle(Console.ReadLine());
			 
			 //Paso a radianes: 
			 anguloRadianes = EnRadianes(anguloGrados);
			 Console.WriteLine("En radianes: {0}", anguloRadianes);
			 
			 //Muestro seno, coseno y tangente
			 Console.WriteLine();
			 Console.WriteLine("Seno: {0}", Math.Sin(anguloRadianes));
			 Console.WriteLine("Coseno: {0}", Math.Cos(anguloRadianes));
			 Console.WriteLine("Tangente: {0}", Math.Tan(anguloRadianes));
			 
			 //Pregunto si desea continuar
			 Console.WriteLine();
			 Console.WriteLine("¿Desea seguir calculando? (s/n)");
			 Console.Write("Respuesta: ");
			 respuesta = Convert.ToChar(Console.ReadLine());
			 Console.WriteLine();
		 
		 }while(respuesta == 's');
		 
		 Console.WriteLine("FIN DEL PROGRAMA");
	 }
	 
 }
