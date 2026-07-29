using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04_Interface_Segregating_Principle_ISP_
{
    internal class _01_ViolatingISP_Printer
    {
        // Violation of ISP: An interface that forces clients to implement methods they don't need
        public interface IPrinter
        {
            void Print(string content);
            void Scan();
            void Fax();

        }

        public class BasicPrinter : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan()
            {
                // BasicPrinter doesn't support scanning, but must implement this method
                throw new NotImplementedException();
            }

            public void Fax()
            {
                // BasicPrinter doesn't support faxing, but must implement this method
                throw new NotImplementedException();
            }
        }


        public class AdvancedPrinter : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan()
            {
                Console.WriteLine($"Scanning..");
            }

            public void Fax()
            {
                Console.WriteLine($"Faxing...");
            }
        }

        public class Program
        {
            public static void main()
            {
                IPrinter basicPrinter = new BasicPrinter();
                basicPrinter.Print("Hi, My Name is Abu-Hahdoud");
                // basicPrinter.Scan();

                //basicPrinter.Fax();

                AdvancedPrinter advancedPrinter = new AdvancedPrinter();
                advancedPrinter.Print("Hi, My Name is Abu-Hahdoud");
                advancedPrinter.Scan();
                advancedPrinter.Fax();

                Console.ReadKey();

            }
        }

    }
}
