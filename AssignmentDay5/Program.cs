using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //---------------------------Notification Factory-------------------------

            //Console.WriteLine("Enter notification type (email/sms/push): ");
            //string type = Console.ReadLine();

            //INotification notification = NotificationFactory.GetNotification(type);
            //notification.Send("Hello, this is a test message!");


            //-----------------------------Logger-----------------------------

            //var log = Logger.GetInstance;
            //log.WriteLog("Logined to your Application");



            //--------------------------GameCharacter-----------------------

            //GameCharacter warrior= new GameCharacter
            //{
            //    Health = 150,
            //    Attack = 40,
            //    Defense = 30,
            //    Skills = new string[] { "Slash", "Block", "Charge" }
            //};

            //Console.WriteLine(" Warrior Prototype:");
            //warrior.ShowInfo();
            //GameCharacter warrior1 = (GameCharacter)warrior.Clone();
            //warrior1.Health = 120;
            //warrior1.Skills[0] = "Battle Cry"; 

            //Console.WriteLine("Warrior Values Updated:");
            //warrior1.ShowInfo();

            //Console.WriteLine("Original Warrior Prototype after clone modification:");
            //warrior.ShowInfo();

            //---------------------------------DataExporter-------------------------

            DataExporter exporter;

            exporter = new CsvExporter();
            exporter.Export();
            Console.WriteLine("==================");

            exporter = new JsonExporter();
            exporter.Export();
            Console.WriteLine("==================");

            exporter = new XmlExporter();
            exporter.Export();
            Console.ReadLine();
        }
    }
}
