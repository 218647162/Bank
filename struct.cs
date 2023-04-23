using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper
{
    struct data
    {
        private void intro()
        {
        Console.Write ("\n\t\t\t\tBANK");
        Console.Write("\nt\t\tManagement");
        Console.Write ("\n\t\t\tSystem");
        Console.Write ("\n\t\t\t\tBy : Evance");
        Console.Write("\n\t\t\t\tUsing Object Oriented Program");    
        }
        public void showIntro()
        {
            intro();
        }
        internal void load()
        {
            Console.Write("Loading");
            for(int i = 0;i < 5 ;i++)
            {
                Console.Write(",");
                System.Threading.Thread.Sleep(500);
            }
        }
        
    }
    
}