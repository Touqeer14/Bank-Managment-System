using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class AccountDep
    {


        public void accountdep(List<Account> account_list)
        {
            Console.Write("Please enter useraccount number :");
            int y = int.Parse(Console.ReadLine());

            Account account = new Account();
            foreach (var list in account_list)
            {
                if (list.useracno ==y)
                {

                    int x;
                    Console.Write("Enter The amont u want to Deposite::");
                    x = int.Parse(Console.ReadLine());
                    list.deposit += x;
                }
                else
                {
                    Console.WriteLine("account does not exit");
                }
            }
        }
    }
}
