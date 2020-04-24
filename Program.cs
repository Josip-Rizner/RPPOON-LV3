using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*rješavao sam samo prva 4 zadataka*/



            Dataset data1 = new Dataset("CSV.txt");

            /*          2. Zad provjera
            RandomMatrixGenerator matrixGenerator = RandomMatrixGenerator.GetInstance();


            double[][] matrix = new double[5][];
            for (int i = 0; i < 5; i++)
            {
                matrix[i] = new double[6];
            }
            
            matrix = matrixGenerator.NextMatrix(5,6);

            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    Console.WriteLine(matrix[j][k]);
                }
            }

            */






            /*          3. Zad provjera
            Logger FileLogger = Logger.GetInstance();

            FileLogger.Log("User1");
            FileLogger.Log("User2");

            */


            ConsoleNotification consoleNotification1 = new ConsoleNotification("user", "Alert", "Some text", DateTime.Now, Category.ALERT, ConsoleColor.Blue);
            ConsoleNotification consoleNotification2 = new ConsoleNotification("user2", "Error", "Some text", DateTime.Now, Category.ERROR, ConsoleColor.Red);
            ConsoleNotification consoleNotification3 = new ConsoleNotification("user3", "Info", "Some text", DateTime.Now, Category.INFO, ConsoleColor.White);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(consoleNotification1);
            notificationManager.Display(consoleNotification2);
            notificationManager.Display(consoleNotification3);


        }
    }
}
