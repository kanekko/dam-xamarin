using System;

namespace CSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CuentaBancaria cuentaUno = new CuentaBancaria();
            cuentaUno.Balnce = 1000;
            cuentaUno.AgregarABalance(3000);
            Console.WriteLine($"Resultado: {cuentaUno.Balnce}");
            Console.ReadLine();
        }

    }


    class Matematicas
    {
        public static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Suma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Resta(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicacion(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Division(int n1, int n2)
        {
            return n1 / n2;
        }

    }

    class Geometria : Matematicas
    {
        public static int AreaCuadrada(int lado)
        {
            // return lado * lado;
            return Multiplicacion(lado, lado);
        }

        public override int Suma(int n1, int n2)
        {
            return n2 ** n1;
        }
    }

}
