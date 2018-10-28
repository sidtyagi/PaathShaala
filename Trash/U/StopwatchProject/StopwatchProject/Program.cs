using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StopWatch obj = new StopWatch();

                var startTime = obj.Start().ToString();
                Thread.Sleep(2000);
                var endTime = obj.Stop().ToString();
                var duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
                Console.WriteLine(duration);

                // Attempt 2 for restart
                Console.WriteLine("Start again");
                startTime = obj.Start().ToString();
                Console.WriteLine("Sleep for 3 sec");
                Thread.Sleep(3000);
                Console.WriteLine("Stopping");
                endTime = obj.Stop().ToString();
                duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
                Console.WriteLine(duration);


                // Attempt 3 for start when already started
                Console.WriteLine("Start again when already started");
                startTime = obj.Start().ToString();
                startTime = obj.Start().ToString();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error encountered {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}