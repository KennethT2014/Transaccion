using System;

namespace Transacción
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacciones transacciones = new Transacciones();
            Console.WriteLine("Bienvenido a Transacciones Industriales");

            Console.WriteLine("Ingrese una cuenta");
            transacciones.CrearCuenta();

            Console.WriteLine("Que acción desea realizar?");
            Console.WriteLine("1-Solicitar Saldo \n2-Retirar Saldo \n3-Depositar Saldo ");
            int op;
            op = Console.Read();

            switch(op){
                case 1:
                    SolicitudSaldo solicitudsaldo = new SolicitudSaldo();
                    solicitudsaldo.Solicitud();
                    break;
                case 2:
                    Retiro retiro = new Retiro();
                    retiro.Retirar();
                    break;
                case 3:
                    Deposito deposito = new Deposito();
                    deposito.Depositar();
                    break;
                default:
                    Console.WriteLine("Usted no ha seleccionado ninguna acción");
                    break;
            }
        }
    }
}
