using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04_Interface_Segregating_Principle_ISP_
{
    using System;

    public interface ICreditCardPayment
    {
        void PayWithCreditCard();
    }

    public interface IPaypalPaymnet
    {
        void PayWithPayPal();
    }

    public interface IBitcoinPayment
    {
        void PayWithBitcoin();
    }

    public class CreditCardPayment : ICreditCardPayment
    {
        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with credit card.");
        }
    }

    public class PayPalPayment : IPaypalPaymnet
    {
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }
    }

    public class AllInOnePayment : ICreditCardPayment, IPaypalPaymnet, IBitcoinPayment
    {
        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with credit card.");
        }
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin.");
        }
    }

    public class Program2
    {
        public static void main()
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.PayWithCreditCard();

            PayPalPayment payPalPayment = new PayPalPayment();
            payPalPayment.PayWithPayPal();

            AllInOnePayment allInOnePayment = new AllInOnePayment();
            allInOnePayment.PayWithCreditCard();
            allInOnePayment.PayWithPayPal();
            allInOnePayment.PayWithBitcoin();

            Console.ReadKey();

        }
    }

}
