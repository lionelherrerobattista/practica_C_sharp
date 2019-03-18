/*(5.9.2.10) Crea un programa que "dibuje" un círculo dentro de un array
 * de dos dimensiones, usando las ecuaciones
 *  x = xCentro + radio * coseno(ángulo),
 *  y = yCentro + radio * seno(ángulo). Si tu array es de 24x79,
 *  las coordenadas del centro serían (12,40).
 *  Recuerda que el ángulo se debe indicar en radianes
 * (mira el ejercicio 5.9.1.5 y el 5.9.2.9).
 */
 using System;
 
 public class Ejercicio_5_9_2_10
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
		 char[,] circulo = new char [24,79];
		 int angulo;
		 double anguloRadianes;
		 double x;
		 double y;
		 int radio;
		 int i;
		 int j;
		 
		 //Pido al usuario el radio
		 Console.WriteLine("Ingrese el radio del circulo.");
		 Console.Write("Radio: ");
		 radio = Convert.ToInt32(Console.ReadLine());
		 
		 //Guardo los * en el array para formar el circulo
		 for(angulo = 0; angulo <= 360; angulo++)
		 {
			 //formula para trabajar en radianes
			 anguloRadianes = EnRadianes(angulo);
			 
			 //Formula para dibujar el circulo
			 x = 12d + radio * Math.Cos(angulo);
			 y = 40d + radio * Math.Sin(angulo);
			 
			 //Redondeo los valores y los paso a int de acuerdo a las
			 //coordenadas resultantes
			 circulo [(int)Math.Round(x),(int)Math.Round(y)] = '*';
		 }
		 
		 //Dibujo el circulo
		 for(i = 23; i >= 0; i--)//Empiezo desde el valor mayor para 'y'
		 {
			 for(j = 0; j < 79; j++)//Imprimo toda la linea
			 {
				Console.Write(circulo[i,j]);
			 }
			 Console.WriteLine();//Paso a la siguiente
		 }
		 
	 }
 }
