using System;
namespace CSharp
{
    interface ICuentaBancaria
    {
        double Balnce { get; set; }
        double AgregarABalance(double balanceAAgregar);
    }


    public class CuentaBancaria : ICuentaBancaria
    {
        private double balance;
        public double Balnce
        {
            get { return balance; }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public double AgregarABalance(double balanceAAgregar)
        {
            Balnce = Balnce + balanceAAgregar;
            return Balnce;
        }
    }




}
