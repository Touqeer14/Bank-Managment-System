using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> account_list = new List<Account>();

            
            
            EnumClass bankday = new EnumClass();
            int num, n;
            
            CreatAccount ca = new CreatAccount(); 
            ShowAccount sa = new ShowAccount();
            AccountReport ar = new AccountReport();
            Modifyaccount ma = new Modifyaccount();
            AccountDep dep = new AccountDep();
            AccountDraw draw = new AccountDraw();
            data show = new data();
            show.load();
            Console.Clear();
            show.showintro();
            Console.Write("\n\n\n\t\tBank Active days are as Following");
            Console.Write("\n\n\n\t\tNumber idicates that day is Active whereas 0 indicate that day is off ");
            bankday.showacityedays();
            do
            {
                Console.Write("\n\n\n\tMain Menu");
                Console.Write("\n\t01. NEW ACCOUNT");
                Console.Write("\n\t02. DEPOSIT AMOUNT");
                Console.Write("\n\t03. WITHDRAW AMOUNT");
                Console.Write("\n\t04. BALANCE ENQUIRY");
                Console.Write("\n\t05. ALL ACCOUNT HOLERS LIST");
                Console.Write("\n\t06. MODIFY AN ACCOUNT");
                Console.Write("\n\t07. EXIT");
                Console.Write("\n\tSelect your Option (1-7) ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            show.load();
                            var create_acc = ca.accountcreate();
                            account_list.Add(new Account(create_acc.useracno, create_acc.deposit, create_acc.age, create_acc.name,create_acc.fname,create_acc.dob,create_acc.type,create_acc.mobile_no));
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            show.load();
                            dep.accountdep(account_list);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            show.load();
                            draw.accountdraw(account_list);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            show.load();
                            ar.accountrepor(account_list);
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            show.load();
                            sa.showaccount(account_list);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            show.load();
                            ma.modifyaccount(account_list); ;
                            break;
                        }

                }

            } while (n != 7);


        }
    }
}
