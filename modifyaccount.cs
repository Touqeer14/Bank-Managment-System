using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class Modifyaccount  

    {

        public void modifyaccount(List<Account> account_list)
        {

            Console.Write("Please enter useraccount number : ");
            int y = int.Parse(Console.ReadLine());
            Account account = new Account();
            foreach (var list in account_list)
                if (list.useracno==y)
                {

                Console.Write("Modify The Phone No. : ");
                list.mobile_no = int.Parse(Console.ReadLine());
                Console.Write("Modify The Age. : ");
                list.age = int.Parse(Console.ReadLine());
                Console.Write("Modify The Date Of Birth. : ");
                list.dob = Console.ReadLine();
                Console.Write("Modify Account Holder Name : ");
                list.name = Console.ReadLine();
                Console.Write("Modify Account Holder Father Name : ");
                list.fname = Console.ReadLine();
                Console.Write("Modify Type of account : ");
                list.type = char.Parse(Console.ReadLine());
                Console.Write("Modify Balance amonut : ");
                list.deposit = int.Parse(Console.ReadLine());
            }
                 
        }
         
    }
}
