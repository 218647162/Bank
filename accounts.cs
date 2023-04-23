// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper
{
    class accounts
    {
        private int acct;

        public int useracct
        {
            get{return acct;}
            set{acct = value;}
        }
        protected string name;
        internal int deposit;
        protected internal char type;

        private void create_account()
        {
                Console.Write("\nEnter The Account No,: ");
                useracct = int.Parse(Console.ReadLine());
                Console.Write("Enter The name of the account Holder : ");
                name = Console.ReadLine();
                Console.Write("\nEnter Type of The account (C/S) :");
                type = Char.Parse(Console.ReadLine());
                Console.Write("Enter The Initial Amount (>=500 for Saving and >=1000 for Current ): ");
                deposit = int.Parse(Console.ReadLine());
                Console.Write("\n\n\nAccount Created...");
        }
        public void createAccount()
        {
            create_account();
        }
        protected void show_Account()
        {
                Console.Write("\nAccount NO :{0}",useracct);
                Console.Write("\nAccount Holder Name :{0}",name);
                Console.Write("\nType of Account  :{0}",type);
                Console.Write("\nBalance Amount  :{0}",deposit);
        }
        public void showAccount()
        {
            show_Account();
        }
        internal void modifyaccount()
        {
                Console.Write("\nAccount Number,: ",acct);
                Console.Write("Modify Account Holder name : ");
                name = Console.ReadLine();
                Console.Write("\nModify Type of The account (Cheque or Savings or Fixed Deposit) :");
                type = Char.Parse(Console.ReadLine());
                Console.Write("Modify Balance Amount): ");
                deposit = int.Parse(Console.ReadLine());

        }
        public void modify_account()
        {
            modifyaccount();
        }
        public void accountdep()
        {
            int x;
            Console.Write("\nEnter the amount u want to Deposit:: ");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }
        public void accountdraw()
        {
            int x;
            Console.Write("\nEnter the amount u want to Withdraw::");
            x = int.Parse(Console.ReadLine());
            
            if(deposit != 0)
            {
                Console.Write("Add money");
            }
            if(deposit > x)
            {
                Console.Write("Don't have enough money")
            }
            else{
                    deposit -=x;
            }
            
        }
        public void account_report()
        {
            Console.Write("Acct ::{0} \nname::{1} \ntype::{2} \n deposit::{3}\n",acct,name,type,deposit);

        }
        public int retacct()
        {
            return acct;
        }
        public int retdeposit()
        {
            return deposit;
        } 
        public int retType()
        {
            return type;
        } 
        
    }
}

