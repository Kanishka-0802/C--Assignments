//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultipleInheritance
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CreditCardPayment  creditCardPayment = new CreditCardPayment();
//            UPIPayment upiPayment=new UPIPayment();
//            DebitCardPayment debitCardPayment = new DebitCardPayment();
//            WalletPayment walletPayment = new WalletPayment();
//            creditCardPayment.GetPaymentInfo();
//            creditCardPayment.DisplayPayment();

//            //debitCardPayment.GetPaymentInfo();
//            //debitCardPayment.DisplayPayment();

//            //walletPayment.GetPaymentInfo();
//            //walletPayment.DisplayPayment();

//            //upiPayment.GetPaymentInfo();
//            //upiPayment.GetPaymentPaypal();
//            //upiPayment.DisplayPayment();

//            Console.ReadLine();


//        }
//    }
//}



using MultipleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{

    interface IPayment
    {
        void MakePayment(decimal amount);
    }

    public class CreditCardPayment : IPayment
    {
      
       
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing  CreditCardpayment of {amount :C}.");
        }

     
    }
    public class PaypalPayment : IPayment,ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]{DateTime.Now}:{message}");

        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing  Paypalpayment of {amount:C}.");
        }
        public void Refundpayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} through Paypal");
        }
     
    }
    public class WalletPayment : IPayment
    {


        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing  Walletpayment of {amount:C}.");
        }

    }




    }
    internal class Program
    {

        static void Main(string[] args)
        {

      
        Console.WriteLine("Enter the Payment Option would you choose : ");
        int choice = Convert.ToInt16(Console.ReadLine());
        switch (choice)
        {
            case 1:
                PaypalPayment paypal = new PaypalPayment();
                paypal.MakePayment(100);
                paypal.Refundpayment(500.45m);
                paypal.Log("Payment of 1000 made through Paypal.");
                break;

            case 2:
                IPayment creditcard = new CreditCardPayment();
                creditcard.MakePayment(100);
                break;
            case 3:
                IPayment wallet = new WalletPayment();
                wallet.MakePayment(3000);
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;

        }



            Console.ReadLine();


        }
    }





