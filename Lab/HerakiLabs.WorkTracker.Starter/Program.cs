using System;

namespace HerakiLabs.WorkTracker.Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To HerakiLabs Work Tracker, Tooday Is: " + DateTime.Now.ToString())  ;
            Console.Write("Enter Your Name: ");
            var userName = Console.ReadLine();
            Console.WriteLine("{0} is the first user of HerakiLabs WorkTracker", userName);
            
            Console.WriteLine("Press Enter to Start Recording your time");
            Console.ReadLine();

            DateTime timeRecorder = DateTime.Now;
            Console.WriteLine("The program is recording your time\nWhen you finished please press <Enter> to stop recording");
            Console.ReadLine();

            
            TimeSpan spendedTime = DateTime.Now - timeRecorder;
            Console.WriteLine("You worked for today is:{0} Hours,{1} Minutes,{2} Seconds", spendedTime.Hours, spendedTime.Minutes, spendedTime.Seconds);
            
            Console.ReadKey();
        }
    }
}

