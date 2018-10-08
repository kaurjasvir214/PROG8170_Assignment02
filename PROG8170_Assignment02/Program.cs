using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment02
{
    class Program
    {
        Boolean whileTrueExecuteProgram = true;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }

        public void Run()
        {
            Program prog = new Program();
            do
            {
                int selectedMenu = prog.PrintMenuOption();
                switch (selectedMenu)
                {
                    case 1:
                        int side1 = prog.ReadValidIntegerInput("Please enter side one value");
                        int side2 = prog.ReadValidIntegerInput("Please enter side two value");
                        int side3 = prog.ReadValidIntegerInput("Please enter side three value");
                        string result = TriangleSolver.Analyze(side1, side2, side3);
                        Console.WriteLine("Triangle is a : " + result);

                        break;
                    case 2:
                        whileTrueExecuteProgram = false;
                        break;

                    default:
                        break;
                }
            }
            while (whileTrueExecuteProgram);
        }

        private int ReadValidIntegerInput(string message)
        {
            string result = string.Empty;
            bool loopStartTwice = false;
            int output = 0;
            do
            {
                if (loopStartTwice)
                {
                    Console.WriteLine("Side lenght must be greater then 0 ");
                    Console.WriteLine();
                }
                loopStartTwice = true;

                Console.Write(message + " : ");
                result = Console.ReadLine();
            } while (!int.TryParse(result, out output) || output <= 0);
            return output;
        }
        private int PrintMenuOption()
        {
            string result = string.Empty;
            bool selectRightOption = false;
            int output = 0;
            do
            {
                if (selectRightOption)
                {
                    Console.WriteLine("Wrong choice! please select again");
                }
                selectRightOption = true;
                Console.WriteLine();
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                result = Console.ReadLine();
            } while (!int.TryParse(result, out output) || output <= 0 || output > 2);

            return output;
        }
    }
}
