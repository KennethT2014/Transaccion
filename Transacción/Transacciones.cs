using System;
using System.Collections.Generic;
using System.Text;

namespace Transacción
{
    class Transacciones
    {
        public string Name;
        public double SaldoActual;
        public string DNI;
        public int NumeroCuenta;

        public Transacciones()
        {
        }

        public Transacciones(double saldoActual)
        {
            SaldoActual = saldoActual;
        }

        public void CrearCuenta()
        {
            SaldoActual = 0;
            Console.WriteLine("****Bienvenido al Sistema que le permite crear su cuenta****");
            Console.WriteLine("Ingrese su nombre: ");
            Name = Console.ReadLine();
            Console.WriteLine("Ingrese el deposito inicial: ");
            SaldoActual = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su número de identificación: ");
            DNI = Console.ReadLine();
            Console.WriteLine("Ingrese su número de cuenta: ");
            NumeroCuenta = int.Parse(Console.ReadLine());
        }

    }
}
