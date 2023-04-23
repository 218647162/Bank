using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper
{
        class enumprogram
        {
            enum Bankdays
            {
                Monday = 1, Tuesday = 2,Wednesday = 3,Thurday = 4,Friday =5,
                Saturday = 0, Sunday =0
            }
            int a = (int)Bankdays.Monday;
            int b = (int)Bankdays.Tuesday;
            int c = (int)Bankdays.Wednesday;
            int d = (int)Bankdays.Thurday;
            int e = (int)Bankdays.Friday;
            int f = (int)Bankdays.Saturday;
            int g = (int)Bankdays.Sunday;

            public void showactivedays()
            {
                Console.WriteLine("\nMonday = {0}",a);
                Console.WriteLine("\nTuesday = {0}",b);
                Console.WriteLine("\nWednesday = {0}",c);
                Console.WriteLine("\nThurday = {0}",d);
                Console.WriteLine("\nFriday = {0}",e);
                Console.WriteLine("\nSaturday = {0}",f);
                Console.WriteLine("\nSunday = {0}",g);
            }
        }    
}
