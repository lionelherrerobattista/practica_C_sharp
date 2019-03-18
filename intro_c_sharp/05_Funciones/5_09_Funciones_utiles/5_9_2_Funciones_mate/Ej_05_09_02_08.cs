/*(5.9.2.8) Crea un programa que muestre los valores de la función
 *y = 10 * seno(x*5), para valores de x entre 0 y 72 grados.
 */
 using System;
 
 public class Ejercicio_5_9_2_8
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
		 double y;
		 double x;//angulo en grados
		 double anguloRadianes;
		 
		 
		 for(x = 0; x <= 72; x++)
		 {
			 anguloRadianes = EnRadianes(x);
			 if(x * 5 == 360)
			 {
				 y = 0;
			 }
			 else
			 {
				 y = 10 * Math.Sin(anguloRadianes * 5);
			 }
			 
			 Console.WriteLine(y);
		 }		 
	 }
 }
