using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class AccountReport
    {


        public void accountrepor(List<Account> account_list)
        {
            Console.Write("Please enter useraccount number : ");
            int y = int.Parse(Console.ReadLine());
            Account account = new Account();
            foreach (var list in account_list)
            {
                {
                    if (list.useracno == y) { 

                        Console.Write("Acno ::{0}  \nDeposit::{3}\n", list.useracno, list.name, list.type, list.deposit);

                    }
                    

                }
            }
        }
    }
}
            
          


            
        
    

        


