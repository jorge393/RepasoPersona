using System;

namespace RepasoPersona.Core
{
    public class Persona
    {
        public string Nombre   { get; private set; }
        public string Apellido { get; private set; } 
        public double Efectivo { get; private set; }
    }
    public Persona() => Efectivo = 0;
    public Persona(string nombre, string apellido, double efectivo)
    {
        Nombre = nombre;

        Apellido = apellido;

        Efectivo = efectivo;
    }
    public void Debitar(double monto)
    {
        if(monto <= 0)
        {
            throw new Exception("El monto debe ser mayor a 0");

        }
        if (Efectivo < monto)
        {
            throw new Exception("Saldo insuficiente");
        }
        Efectivo -= monto;
    }

    public void Acreditar(double monto)
    {
        if(monto <= 0)
        {
            throw new Exception("El monto debe ser mayor a 0");
        }
        Efectivo += monto; 
    }
}
