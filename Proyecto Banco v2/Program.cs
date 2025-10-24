/*
 * Created by SharpDevelop.
 * User: blick
 * Date: 18/10/2025
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Banco_v2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Banco banco = new Banco("Banco Sharp");
        	Cliente c1 = new Cliente("Fabián", "Rodríguez", "12345678", "Calle Falsa 123", "555-1234", "fabian@mail.com");
        	Cuenta cuenta1 = new Cuenta(1, "12345678", "Rodríguez", 1000);

        	banco.AgregarCliente(c1);
        	banco.AgregarCuenta(cuenta1);

        	Console.WriteLine("Cliente agregado: " + c1.Nombre);
        	Console.WriteLine("Cuenta creada con saldo: " + cuenta1.Saldo);
			
			
        	
        	
        	
        	
        	
        	
        	Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}