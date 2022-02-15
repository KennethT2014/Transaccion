using System;
using System.Collections.Generic;
using System.Text;

namespace Transacción
{
    class Retiro : Transacciones
    {
        public Retiro()
        {
        }

        public Retiro(double SaldoActual) : base(SaldoActual)
        {
            double Retiro;
            Retiro = SaldoActual + 1;
            Console.WriteLine("Usted Desea retirar dinero");
            do
            {
                Console.WriteLine("Cuanto desea retirar?");
                Retiro = double.Parse(Console.ReadLine());
                if (Retiro > SaldoActual)
                {
                    Console.WriteLine("**Usted no puede retirar mas dinero del que posee esta cuenta**");
                }
                else
                {
                    Console.WriteLine("Su retiro fué llevado a cabo con éxito");
                    SaldoActual = SaldoActual - Retiro;
                }
            } while (SaldoActual > Retiro);
        }

        internal void Retirar()
        {
            throw new NotImplementedException();
        }
    }
}
