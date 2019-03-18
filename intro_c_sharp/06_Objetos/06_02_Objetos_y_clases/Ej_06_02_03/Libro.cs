/*(6.2.3) Para guardar información sobre libros, vamos a comenzar
 * por crear una clase "Libro", que contendrá atributos "autor",
 * "titulo", "ubicacion" (todos ellos strings)
 * y métodos Get y Set adecuados para leer su valor y cambiarlo.
 * Prepara también un Main (en la misma clase),
 * que cree un objeto de la clase Libro, dé valores a sus tres atributos
 * y luego los muestre.
 */
 using System;
 
 public class Libro
 {
	 string autor;
	 string titulo;
	 string ubicacion;
	 
	 public void SetAutor(string nuevoAutor)
	 {
		 autor = nuevoAutor;
	 }
	 
	 public string GetAutor()
	 {
		 return autor;
	 }
	 
	 public void SetTitulo(string nuevoTitulo)
	 {
		 titulo = nuevoTitulo;
	 }
	 
	 public string GetTitulo()
	 {
		 return titulo;
	 }
	 
	 public void SetUbicacion(string nuevaUbicacion)
	 {
		 ubicacion = nuevaUbicacion;
	 }
	 
	 public string GetUbicacion()
	 {
		 return ubicacion;
	 }
	 
	 public static void Main()
	 {
		 Libro libroUno = new Libro();
		 
		 libroUno.SetTitulo("Cien años de soledad");
		 libroUno.SetAutor("Gabriel García Márquez");
		 libroUno.SetUbicacion("1");
		 
		 Console.WriteLine("Libro 1");
		 Console.WriteLine("Nombre: {0}", libroUno.GetTitulo());		 
		 Console.WriteLine("Autor: {0}", libroUno.GetAutor());
		 Console.WriteLine("Ubicación: {0}", libroUno.GetUbicacion());
	 }
	 
 }
