using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops {
    internal class Program {
        static void Main() { 
            Console.Title = "Loops";

            //// For loop
            //for (long i = 0; i < 9223372036854775807; i++) {
            //    Console.WriteLine(i);
            //}

            //// While loop
            //int x = 0;
            //while (x <= 20) {
            //    Console.WriteLine(x);
            //    x++;
            //}

            //// Don't close the project
            //Console.ReadLine();

            void loop() {
                long i = -9223372036854775807;
                while (i < 9223372036854775807) {
                    Console.WriteLine(i);
                    i++;
                }
            }
            Action action = new Action(loop);
            while (true) {
                try {
                    Task.Run(action);
                } catch (System.OutOfMemoryException e) {
                    Console.WriteLine(e);
                    Console.ReadLine();
                    Main();
                }
            }
        }
    }
}
