using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    struct data
    {
        private void intro()
        {
            Console.Write("\n\n\n\t\t\t BANK");
            Console.Write("\n\n\t\t\tMANAGEMENT");
            Console.Write("\n\n\n\t\t\tSYSTEM");
            Console.Write("\n\n\t\tMADE BY : TOUQEER AHMED");
            Console.Write("\n\n\tALL object orinted programming Tools");
        }
        public void showintro()
        {
            intro();
        }
        internal void load()
        {
            Console.Write("loading");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
