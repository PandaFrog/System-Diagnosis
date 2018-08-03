using System;
using System.Diagnostics;
using System.Threading;

namespace System_Diagnosis
{
    class Program
    {
        static void Main(string[] args)
        {

            // Counters for grabbing system info
            PerformanceCounter perfCpupercent = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            PerformanceCounter perfMem = new PerformanceCounter("Memory", "Available Mbytes");
            PerformanceCounter perfCDrive = new PerformanceCounter("LogicalDisk", "% Free Space", "C:");
            PerformanceCounter perfDDrive = new PerformanceCounter("LogicalDisk", "% Free Space", "D:");
            PerformanceCounter perfEDrive = new PerformanceCounter("LogicalDisk", "% Free Space", "D:");

            while (true)
            {
                //Writes next value of system info
                Console.WriteLine("{0}Mb Ram is free", perfMem.NextValue());
                Console.WriteLine("CPU is load is {0}%", perfCpupercent.NextValue());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("C Drive has has {0}% free space", perfCDrive.NextValue());
                Console.WriteLine("D Drive has has {0}% free space", perfDDrive.NextValue());
                Console.WriteLine("E Drive has has {0}% free space", perfEDrive.NextValue());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Thread.Sleep(1000);
            }






        }
    }
}