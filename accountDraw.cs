using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class AccountDraw
    {




        public void accountdraw(List<Account> account_list)
        {
            Console.Write("Please enter useraccount number : ");
            int y = int.Parse(Console.ReadLine());

            Account account = new Account();

            foreach (var list in account_list)
                if (list.useracno == y)
                {
                    int x;
                    Console.Write("Entre the amount u want to wihtdraw::");
                    x = int.Parse(Console.ReadLine());

                    if (list.deposit >= x)
                    {


                        list.deposit -= x;
                    }
                    else
                    {
                        Console.WriteLine("your account balance is lessthen. :{0} ", x);
                        Console.WriteLine("please enter a valid amount");
                    }
                }
                else
                {
                    Console.Write("accunt does not exit");
                }
                }
        }

    }


