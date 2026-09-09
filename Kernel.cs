using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmoscaca
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true) 
            {
                lines.Main();
                var input = Console.ReadLine();


            }
            
            
        }
    }
    class graf
    {
        public static void Points(int x, int y)
        {
            Console.CursorLeft = x; Console.CursorTop = y;

            Console.WriteLine(" ");





        }
        public static void hlines(int x, int y, int x1)
        {

            int i = 0;
            for (int j = x; j < x1; j++) Points(j, y);


        }
        public static void vline(int x, int y, int y1)
        {

            int i = 0;
            for (int j = y; j < y1; j++) Points(x, j);



        }

        public static void box(int x, int y, int x1, int y1)
        {

            for (int j = y; j < y1; j++) hlines(x, j, x1);


        }

    }






    class tests



    {


        public static void mainLoop()
        {
            graf.box(1, 1, 10, 10);



        }



    }



    class lines
    {

        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;

            tests.mainLoop();
            Console.BackgroundColor = ConsoleColor.White;


        }



    }


}
