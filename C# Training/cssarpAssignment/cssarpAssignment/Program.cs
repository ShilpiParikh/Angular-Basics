using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace cssarpAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* Example */
            // Set up Console UI (CUI)
            Console.Title = "My First C# App Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("This is My First C# App Assignment");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Enter your choice: \n1. For Electricity Bill Calculation\n" +
                "2. For Linq implementation\n" +
                "3. Add Function Using Generics\n" +
                "4. Extension Method\n");
            var userinput = int.Parse(Console.ReadLine());

            switch(userinput)
            {
                case 1:
                    Console.WriteLine("***** Electricity Bill Calculation *****");
                    electricitybill basicIO = new electricitybill();
                    basicIO.GetUserData();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("***** Use of Linq to arrange elements in list *****");
                    arrangeList basic2IO = new arrangeList();
                    basic2IO.GetUserData2();
                    Console.ReadLine();
                    break;
                    
                case 3:
                    Console.WriteLine("***** Use of Generics to implement Add function *****");
                    genericExm basic3IO = new genericExm();
                    basic3IO.Addfunc<int>(30,80);
                    basic3IO.Addfunc<string>("Ge", "neric");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("***** Extension Method *****");
                    bool? input = null;
                    bool output = input.getValueOrDeafult(false);
                    Console.WriteLine(output);
                    output = input.getValueOrDeafult(true);
                    Console.WriteLine(output);
                    input = true;
                    output = input.getValueOrDeafult(false);
                    Console.WriteLine(output);
                    break;



            }
        }
    }
}


