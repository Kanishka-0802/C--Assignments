using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Remotingtrn;
using static System.Console;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            
            ChannelServices.RegisterChannel(channel, false);

            var service = (StudentService)Activator.GetObject(
                typeof(StudentService),
                "tcp://localhost:8085/StudentService"
            );

            if (service == null)
            {
                WriteLine("Could not connect to remote service.");
                return;
            }

            WriteLine("Connected to StudentService ...");

            WriteLine("\n============ All Student Details =============");
            WriteLine("Check Whether The given Student mark is Greater than 300 or Not :");
            service.ShowAllStudents();

            Write("\nEnter student id: ");
            int id = int.TryParse(Console.ReadLine(), out int parsedId) ? parsedId : 0;

            try
            {
                var student = service.GetStudent(id); 
                WriteLine($"\nResult: {student}");
            }
            catch (Exception ex)
            {
                WriteLine($"Error from service: {ex.Message}");
            }
            WriteLine("\nPress Enter to exit...");
            ReadLine();
        }
    }
}
