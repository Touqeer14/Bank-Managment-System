using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{ 
    class Account
{
       public int useracno, deposit ,age ;
        public string name ,fname ,dob;
         public char type;
        public double mobile_no ;
        public Account()
        {
        }

        public Account(int useracno, int deposit, int age,  string name, string fname, string dob, char type,double mobile_no)
        {
            this.useracno = useracno;
            this.deposit = deposit;
            this.age = age;
            this.name = name;
            this.fname = fname;
            this.dob = dob;
            this.type = type;
            this.mobile_no = mobile_no;
            
        }
    }

    class CreatAccount  
    {
        Account account = new Account();
       

        public Account accountcreate()
        {
            
            Console.Write("\nEntre The Account No. : ");
            account.useracno = int.Parse(Console.ReadLine());
            Console.Write("Entre The Moblie No. : ");
            account.mobile_no =double.Parse( Console.ReadLine());
            Console.Write("Entre The Age. : ");
            account.age = int.Parse(Console.ReadLine());
            Console.Write("Enter The Date of Birth in the formate of MM/DD/YY. : ");
            account.dob = Console.ReadLine();
            Console.Write("Entre The Name Of The Accont Holder. : ");
            account.name = Console.ReadLine();
            Console.Write("Enter The Father Name of THe Account Holder. : ");
            account.fname = Console.ReadLine();
            Console.Write("Entre Typeof account{C/S} : ");
            account.type = char.Parse(Console.ReadLine());
            Console.Write("Entre The Initial amount(>=500 for saving and >=1000 for current ) : ");
            account.deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\naccount created , ,");

           return account;
        }
        
    }
    
            
    }

