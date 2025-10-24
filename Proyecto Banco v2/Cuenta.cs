/*
 * Created by SharpDevelop.
 * User: blick
 * Date: 15/10/2025
 * Time: 11:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Banco_v2
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	public class Cuenta
{
    //-------------------ATRIBUTOS---------------------
    
    private int nroCuenta;
    private string dniTitular;
    private double saldo;
    private string apellido;

    
    
    
    //-----------PROPIEDADES---------------------------------------------
    
    public int NroCuenta { get { return nroCuenta; } set { nroCuenta = value; } }
    public string DniTitular { get { return dniTitular; } set { dniTitular = value; } }
    public double Saldo { get { return saldo; } set { saldo = value; } }
    public string Apellido { get { return apellido; } set { apellido = value; } }

   

    //----------------CONSTRUCTOR------------------------------------------------------
    
    
    public Cuenta(int nroCuenta, string dniTitular, string apellido, double saldoInicial)
    {
        this.nroCuenta = nroCuenta;
        this.dniTitular = dniTitular;
        this.apellido = apellido;
        this.saldo = saldoInicial;
    }

    
    //------------------------METODOS--------------------------------------------
    
    
    public void Depositar(double monto)
    {
        saldo += monto;
    }

    public void Extraer(double monto)
    {
        saldo -= monto;
    }
}

}
