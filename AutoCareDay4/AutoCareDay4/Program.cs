using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareDay4
{
   
        class Vehicle
        {
            String vehicleName;
            String vehicleNum;
            String vehicleType;
           
            public Vehicle(string vehicleName,string vehicleNum,string vehicleType)
            {
                this.vehicleName = vehicleName;
                this.vehicleNum = vehicleNum;   
                this.vehicleType = vehicleType;
                Console.WriteLine("Vehicle object was initialized.");
            }
            public void GetvehicleDetails()
            {
                Console.WriteLine("Enter the Name of the Vehicle : ");
                vehicleName=Console.ReadLine();
                Console.WriteLine("Enter the Num of the Vehicle : ");
                vehicleNum =Console.ReadLine();
                Console.WriteLine("Enter the Type of the Vechicle :");
                vehicleType = Console.ReadLine();
                DisplayVehicleDetail();

            }
            protected void  DisplayVehicleDetail()
            {
                Console.WriteLine("=========VEHICLE DETAILS==========");
                Console.WriteLine("Registered Number : " + vehicleNum);
                Console.WriteLine("Brand : " + vehicleName);
                Console.WriteLine("Fuel Type : "+vehicleType);

             }
        }
        class Car:Vehicle
        {
            string CarName;
            string CarType;
            string CarNum;
            string CarColor;
            int CarSpeed;
            public Car(string vehicleName, string vehicleType, string vehicleNum, string carColor, int carSpeed):base(vehicleName,vehicleNum,vehicleType)
            {
                this.CarName = vehicleName;
                this.CarType = vehicleType;
                this.CarNum = vehicleNum;
                this.CarColor = carColor;
                this.CarSpeed = carSpeed;
            }
            public  void GetCarDetails()
            {
                Console.WriteLine("Enter the Car Name :");
                CarName = Console.ReadLine();
                Console.WriteLine("Enter the Car Type :");
                CarType = Console.ReadLine();
                Console.WriteLine("Enter the Car Number :");
                CarNum = Console.ReadLine();
                Console.WriteLine("Enter the Car Color :");
                CarColor = Console.ReadLine();
                Console.WriteLine("Enter the Car Speed :");
                CarSpeed = Convert.ToInt32(Console.ReadLine());
            }

            public void DisplayCarDetails()
            {
                Console.WriteLine("==========CAR DETAILS===========");
                Console.WriteLine("CarName : "+CarName);
                Console.WriteLine("CarType : " + CarType);
                Console.WriteLine("CarNum : " + CarNum);
                Console.WriteLine("CarColor : " + CarColor);
                Console.WriteLine("CarSpeed : " + CarSpeed);
            }
        }
    internal class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car("KIA", "Petrol", "TN38KP0831","Blue",200);
            car.GetvehicleDetails();
            //car.GetCarDetails();
            car.DisplayCarDetails();
            Console.ReadLine();
            
        }
    }
}
