using System;
using System.Linq;
using System.Diagnostics;

namespace DotNetConsole
{
    class Program
    {
        static void Main(string[] args) {
            new Program().TestLinq();
            // new Program().PrintProcessList();
        }

        private void PrintProcessList()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes) {
                Console.WriteLine($"Process: {process.ProcessName} ID: {process.Id}");
            }
        }

        private void TestLinq()
        {
            int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7};

            var numberQuery = numbers.Where(n => (n % 2 == 0)).ToArray();

            foreach (int number in numberQuery) {
                Console.WriteLine($"{number} is divisible by 2");
            }
        }
    }
}
