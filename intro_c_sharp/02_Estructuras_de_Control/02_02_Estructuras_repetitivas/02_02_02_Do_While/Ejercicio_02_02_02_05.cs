/*
(2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña,
y no le permita seguir hasta que introduzca
como nombre "Pedro" y como contraseña "Peter".
*/

using System;

public class Ejercicio_02_02_02_05
{
    public static void Main()
    {
	string identificador;
	string password;
	int flag=0; //flag de error
	
	do
	{

	    Console.Write("Escriba el identificador: ");
	    
	    if(flag==1)
	    {
	        Console.Write("Error. Escriba el identificador nuevamente: ");
            }

	    identificador = Console.ReadLine();
		
	    flag = 1;  //Si se repite, muestra el mensaje de error
	
	}while(identificador != "Pedro");

	flag= 0;

	do
	{

	    if(flag==1)
	    {
	        Console.Write("Error. Escriba la password nuevamente: ");
            }
	    else
	    {
	        Console.Write("Escriba la password: ");
	    }

	    password = Console.ReadLine();

	    flag = 1; //Si se repite, muestra el mensaje de error		    
	

	}while(password != "Peter");

    }

}