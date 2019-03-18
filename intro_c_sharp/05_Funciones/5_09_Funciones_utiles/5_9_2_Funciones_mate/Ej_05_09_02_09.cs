/*(5.9.2.9) Crea un programa que "dibuje" la gráfica de la función
 * y = 10 * seno(x*5), para valores de x entre 0 y 72 grados.
 * Para ayudarte para escribir en cualquier coordenada,
 * puedes usar un array de dos dimensiones, que primero rellenes
 * y luego dibujes en pantalla (mira el ejercicio 5.9.1.5).
 */
 using System;
 
 public class Ejercicio_5_9_2_9
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
		 //Array para guardar el gráfico
		 char[,] grafico = new char [23,73]; //+1 de los limites
		 int i;
		 int j;
		 
		 Console.WriteLine("Grafico de la función y = 10 * seno(x*5)"
		  + ", para valores de x entre 0 y 72 grados:");
		 
		 //Busco los valores
		 for(x = 0; x <= 72; x++)
		 {
			 anguloRadianes = EnRadianes(x);//Trabajo en radianes
			 
			 if(x * 5 == 360 || x * 5 == 180)
			 {
				 y = 0;
				 //En caso de que la función sea == 0 (== 11)
				 grafico[(int)y+11, (int)x] = '*'; //11 es el punto medio
			 }
			 else
			 {
				 y = 10 * Math.Sin(anguloRadianes * 5);
				 
				 if(y > 0)
				 {
					 //Para 'y' positiva (+11)
					 grafico[(int)Math.Round(y+11,0), (int)x] = '*';					 
				 }
				 else
				 {
					 //Para 'y' negativa (-11)
					 grafico[(int)Math.Round(11-(Math.Abs(y)),0),
					  (int)x] = '*';					 
				 }
			 }
			 
		 }
		 
		 //Grafico
		 for(i = 22; i >= 0; i--)//Empiezo desde el valor mayor para 'y'
		 {
			 for(j = 0; j < 73; j++)//Imprimo toda la linea
			 {
				Console.Write(grafico[i,j]);
			 }
			 Console.WriteLine();//Paso a la siguiente
		 }
		 
		 
	 }
 }
