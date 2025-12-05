//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultipleInheritance
//{
//   interface IPayment
//    {
//        void GetPaymentInfo();
//     }

//    public class CreditCardPayment : IPayment
//    {
//        public string Name { get; set; }
//        public int PinNumber { get; set; }
//        public int amount { get; set; }
//public void GetPaymentInfo()
//        {
//            Console.WriteLine("======= Enter the Details for CreditCard ========");
//            Console.WriteLine("Enter the Name of the Holder : ");
//            Name = Console.ReadLine();
//            Console.WriteLine("Enter the PinNumber");
//            PinNumber = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Amount : ");
//            amount = Convert.ToInt32(Console.ReadLine());
//        }
//        public void DisplayPayment()
//        {
//            Console.WriteLine("===== Smart Payment Gateway System ======");
//            Console.WriteLine("Name  :" + Name);
//            Console.WriteLine("PinNumber :"+PinNumber);
//            Console.WriteLine("Amount : " + amount);

//        }
//    }
// public class UPIPayment : IPayment {
//        public string Name {  get; set; }
//        public int PinNumber {  get; set; }
//        public int amount {  get; set; }
//        public int Accountno {  get; set; }
//        public  int balance { get; set; }

//       public  void GetPaymentInfo()
//        {
//            Console.WriteLine("======== Enter the Details for UPI ========");
//            Console.WriteLine("Enter the Name of the Holder : ");
//            Name = Console.ReadLine();
//            Console.WriteLine("Enter the PinNumber");
//            PinNumber = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Amount : ");
//            amount = Convert.ToInt32(Console.ReadLine());
//        }

//       public  void GetPaymentPaypal()
//        {
//            Console.WriteLine("Enter the Account No : ");
//            Accountno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the balance Amount : ");
//            balance = Convert.ToInt32(Console.ReadLine());

//        }
//        public void DisplayPayment()
//        {
//            Console.WriteLine("Smart Payment Gateway System =======");
//            Console.WriteLine("Name  :" + Name);
//            Console.WriteLine("PinNumber :" + PinNumber);
//            Console.WriteLine("Amount : " + amount);
//            Console.WriteLine("Account Number : "+Accountno);
//            Console.WriteLine("Balance : " + balance);


//        }

//    }
//   public  class  WalletPayment : IPayment {
//        public string Name { get; set; }
//        public int amount { get; set; }
//      public   void GetPaymentInfo()
//        {
//            Console.WriteLine("Enter the Payment for Wallet :");
//            Console.WriteLine("Enter the Name of the Holder : ");
//            Name = Console.ReadLine();
//            Console.WriteLine("Enter the Amount : ");
//            amount = Convert.ToInt32(Console.ReadLine());
//        }
//        public void DisplayPayment()
//        {
//            Console.WriteLine("Smart Payment Gateway System");
//            Console.WriteLine("Name  :" + Name);
//            Console.WriteLine("Amount : " + amount);

//        }

//    }
//   public class DebitCardPayment : IPayment {
//        public string Name { get; set; }
//        public int PinNumber { get; set; }
//        public int amount { get; set; }
//       public  void GetPaymentInfo()
//        {
//            Console.WriteLine("Enter the Payment for DebitCard :");
//            Console.WriteLine("Enter the Name of the Holder : ");
//            Name = Console.ReadLine();
//            Console.WriteLine("Enter the PinNumber");
//            PinNumber = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Amount : ");
//            amount = Convert.ToInt32(Console.ReadLine());
//        }
//        public void DisplayPayment()
//        {
//            Console.WriteLine("Smart Payment Gateway System");
//            Console.WriteLine("Name  :" + Name);
//            Console.WriteLine("PinNumber :" + PinNumber);
//            Console.WriteLine("Amount : " + amount);

//        }
//    }

//    }



