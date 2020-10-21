using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class ShowAccount 
    {


       
      public void showaccount(List<Account> acount_list)
            
        {
            Account account = new Account();
 

            foreach(var list in acount_list)
            {
                Console.Write("\nAccount No, :{0}", list.useracno);
                Console.Write("\nAccount Holder name :{0}", list.name);
                Console.Write("\nAccount Holder Father name :{0}", list.fname);
                Console.Write("\nPhone No, :{0}", list.mobile_no);
                Console.Write("\nAge, :{0}", list.age);
                Console.Write("\ndob, :{0}", list.dob);
                Console.Write("\nType of account : {0} ", list.type);
                Console.Write("\nBlance amount : {0}", list.deposit);
            }


           
        }
         

    }
}
