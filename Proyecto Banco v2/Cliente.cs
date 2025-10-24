/*
 * Created by SharpDevelop.
 * User: blick
 * Date: 15/10/2025
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Banco_v2
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
{
    //--------------ATRIBUTOS--------------------
    
    private string nombre;
    private string apellido;
    private string dni;
    private string direccion;
    private string telefono;
    private string mail;

   


    //--------------PROPIEDADES--------------------------------------------------
    
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Apellido { get { return apellido; } set { apellido = value; } }
    public string Dni { get { return dni; } set { dni = value; } }
    public string Direccion { get { return direccion; } set { direccion = value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
    public string Mail { get { return mail; } set { mail = value; } }

    
    
    //------------------CONSTRUCTOR--------------------------------------------------------------
    
    public Cliente(string nombre, string apellido, string dni, string direccion, string telefono, string mail)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.direccion = direccion;
        this.telefono = telefono;
        this.mail = mail;
    }
}

}
