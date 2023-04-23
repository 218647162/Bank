// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper
{
    class Program: accounts
    {
        static void Main(string[] args)
        {
            enumprogram Bankdays = new enumprogram();
            int num , n;
            data show =new data();
            accounts bank = new accounts();
            show.load();
            Console.Clear();
            show.showIntro();
            Console.Write("\n\n\n\nBank Active days Are as Following");
            Console.Write("\n\n\n\t\tNumber indicates that day is Active Whereas 0 indicates that day is Off ");
            Bankdays.showactivedays();
            
             do
                {
            
                    Console.Write("\n\n\n\tMain Menu");
                    Console.Write("\n\t\t1.New Account");
                    Console.Write("\n\n\n\t2.Deposit Amount");
                    Console.Write("\n\n\n\t3.Withdraw Amount");
                    Console.Write("\n\n\n\t4.Balance Enquiry");
                    Console.Write("\n\n\n\t5.All Account Holder List");
                    Console.Write("\n\n\n\t6.Modify an Account");
                    Console.Write("\n\n\n\t7.Exit");
                    Console.Write("\n\n\n\tSelect between 1 to 7");
                    n = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (n)
                    {
                        case 1: {
                            Console.Clear();
                            show.load();
                            bank.createAccount();
                            break;
                        }
                        case 2:{
                            Console.Clear();
                            show.load();
                            bank.accountdep();
                            break;
                        }
                        case 3:{
                            Console.Clear();
                            show.load();
                            bank.accountdraw();
                            break;
                        }
                        case 4: {
                            Console.Clear();
                            show.load();
                            bank.account_report();
                            break;
                        }
                        case 5:{
                            Console.Clear();
                            show.load();
                            bank.showAccount();
                            break;
                        }
                        case 6:{
                            Console.Clear();
                            show.load();
                            Console.Write("\n\n\tEnter The Account No :");
                            num = int.Parse(Console.ReadLine());
                            bank.modifyaccount();
                            break;
                        }
                }
                 } while(n !=7);//loop end
        }    
    }
}
