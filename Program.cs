using System;
using System.Globalization;

namespace Tannenbaum
{
    internal class Program
    {
        private int zeilenNr;
        private int counter;

        public Program()
        {
            zeilenNr = 0;
            counter = 1;
        }

        public void Run()
        {
            zeilenNr = GetZeilen();
            while (zeilenNr > 0)
            {
                var tempLine = GetLine();
                Console.WriteLine(tempLine + GetStars() + tempLine);
                zeilenNr--;
                counter = counter + 2;
            }

            Console.ReadKey();
        }

        public int GetZeilen()
        {
            Console.Write("Pls enter the number of lines ");
            var tempString = Console.ReadLine();
            int tempInt;
            if (int.TryParse(tempString, out tempInt))
            {
                return tempInt;
            }
            else
            {
                return 0;
            }
        }

        public string GetLine()
        {
            var tempPrint = "";
            for (var i = 0; i < zeilenNr; i++)
            {
                tempPrint = tempPrint + "-";
            }
            return tempPrint;
        }

        public string GetStars()
        {
            var tempPrint = "";

            for (var i = 0; i < counter; i++)
            {
                tempPrint = tempPrint + "*";
            }
            return tempPrint;
        }

        private static void Main()
        {
            new Program().Run();
        }
    }
}
