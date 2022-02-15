using System;
using System.Collections.Generic;
using System.Text;

namespace Transacción
{
    class SolicitudSaldo : Transacciones
    {
        public SolicitudSaldo()
        {
        }

        public SolicitudSaldo(double SaldoActual) : base(SaldoActual)
        {
            Console.WriteLine("Usted desea saber su Saldo actual");
            Console.WriteLine($"{SaldoActual}");
        }

        internal void Solicitud()
        {
            throw new NotImplementedException();
        }
    }
}
