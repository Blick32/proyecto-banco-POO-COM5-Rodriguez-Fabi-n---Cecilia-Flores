/*
 * Created by SharpDevelop.
 * User: blick
 * Date: 16/10/2025
 * Time: 09:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Proyecto_Banco_v2
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco
{
    //---------PROPIEDADES------------------
    
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    
    

 
    //-----------LISTAS-----------------------------
    
    private List<Cliente> clientes;
    private List<Cuenta> cuentas;

   


   

    //----------------CONSTRUCTORES-------------------------
    
    public Banco(string nombre)
    {
        this.nombre = nombre;
        clientes = new List<Cliente>();
        cuentas = new List<Cuenta>();
    }

    
   
    
    //-----------------MÉTODOS CLIENTES---------------------------------------
    
    public void AgregarCliente(Cliente c)
    {
        clientes.Add(c);
    }

    public void EliminarCliente(Cliente c)
    {
        clientes.Remove(c);
    }

    public Cliente BuscarCliente(string dni)
    {
        return clientes.Find(x => x.Dni == dni);
    }

    public List<Cliente> ListarClientes()
    {
        return clientes;
    }

    public int CantidadClientes()
    {
        return clientes.Count;
    }

    public void LimpiarClientes()
    {
        clientes.Clear();
    }

    
    
    
    
    //-------------------METODOS CUENTAS--------------------------
    
    public void AgregarCuenta(Cuenta c)
    {
        cuentas.Add(c);
    }

    public void EliminarCuenta(Cuenta c)
    {
        cuentas.Remove(c);
    }

    public Cuenta BuscarCuenta(int nroCuenta)
    {
        return cuentas.Find(x => x.NroCuenta == nroCuenta);
    }

    public List<Cuenta> ListarCuentas()
    {
        return cuentas;
    }

    public int CantidadCuentas()
    {
        return cuentas.Count;
    }

    public void LimpiarCuentas()
    {
        cuentas.Clear();
    }
}

}
