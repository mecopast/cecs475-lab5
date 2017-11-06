using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a menu choice 1-9: " +
                Environment.NewLine + "1. Create Teacher" +
                Environment.NewLine + "2. Update Teacher" +
                Environment.NewLine + "3. Delete Teacher" +
                Environment.NewLine + "4. Display Courses by Teacher" +
                Environment.NewLine + "5. Display All Standards" +
                Environment.NewLine + "6. Create Course" +
                Environment.NewLine + "7. Update Course" +
                Environment.NewLine + "8. Delete Course" +
                Environment.NewLine + "9. Display All Courses");
            var ans = Console.ReadLine();
            int choice = 0;
            if (int.TryParse(ans, out choice))
            {
                switch (choice)
                {
                    case 1: Console.WriteLine("Selected 1"); break;
                    case 2: Console.WriteLine("Selected 2"); break;
                    case 3: Console.WriteLine("Selected 3"); break;
                    case 4: Console.WriteLine("Selected 4"); break;
                    case 5: Console.WriteLine("Selected 5"); break;
                    case 6: Console.WriteLine("Selected 6"); break;
                    case 7: Console.WriteLine("Selected 7"); break;
                    case 8: Console.WriteLine("Selected 8"); break;
                    case 9: Console.WriteLine("Selected 9"); break;
                    default:
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter Selection 1-9" +
                    Environment.NewLine + "Press any key for exit");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
