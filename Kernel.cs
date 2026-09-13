using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
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
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p,x,y);
            




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
        public static void starts() 
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();  

            
            
            

        }
        public static void displays() 
        {

            canvas.Display();


        }
        public static void cls(Color c) 
        {


            canvas.Clear(c);

        }

    }






    class tests



    {


        public static void mainLoop()
        {
            //
            
            graf.starts();
            graf.cls(Color.White);
            for (int i = 0; i < 1024; i = i + 8) 
            {
                graf.hlines( 0, i, 1024);
                graf.vline( i, 0, 800);

            }
            
            graf.displays();
        }



    }



    class lines
    {

        public static void Main()
        {
            tests.mainLoop();



        }



    }


}
