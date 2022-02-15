using System;
using System.Collections.Generic;
using System.Text;

namespace Transacción
{
    class Deposito : Transacciones
    {
        public Deposito()
        {
        }

        public Deposito(double SaldoActual) : base(SaldoActual)
        {
            double deposito;
            Console.WriteLine($"Usted quiere hacer un deposito a la cuenta {NumeroCuenta}");
            Console.WriteLine("Ingrese la cantidad a depositar: ");
            deposito = double.Parse(Console.ReadLine());

            SaldoActual = SaldoActual + deposito;
        }

        internal void Depositar()
        {
            throw new NotImplementedException();
        }
    }
}
