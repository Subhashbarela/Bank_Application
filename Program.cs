using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank shiva = new Bank(1,"shivlal barela",1000,"boi");
            Bank vinu = new Bank(2, "vinesh barela", 2000,"bob");
            
            String Bank_Name1 = shiva.Bank_Name;
            Console.WriteLine(Bank_Name1);
            Console.WriteLine("Enter the bank name :");
            String B_Name=Console.ReadLine();
           
            if(Bank_Name1 == B_Name) { 

            int choice;
            do
            {
                Console.WriteLine("(1): Withdraw Money ..");
                Console.WriteLine("(2): Deposit  Money ..");
                Console.WriteLine("(3): Check Your Balance ..");
                Console.WriteLine("(4): Your Information ..");
                Console.WriteLine("(*): For exit press 0 ..\n");
                Console.WriteLine("Enter Your Choice..");
                Console.WriteLine("\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       
                        Console.WriteLine("Enter Your Account Number");
                        int Acc_number = Convert.ToInt32(Console.ReadLine());
                        shiva.withdraw(Acc_number);
                        vinu.withdraw(Acc_number);
                        break;

                  
                    
                    case 2:
                        Console.WriteLine("Enter Your Account Number");
                        int Acc1_number = Convert.ToInt32(Console.ReadLine());
                        shiva.deposit(Acc1_number);
                        vinu.deposit(Acc1_number);
                        break;
                  
                    
                    case 3:
                        Console.WriteLine("Enter Your Account Number");
                        int Acc2_number = Convert.ToInt32(Console.ReadLine());

                        shiva.Check_balance(Acc2_number);
                        vinu.Check_balance(Acc2_number);

                        break;
                 
                    
                    case 4:
                        Console.WriteLine("Enter Your Account Number");
                        int Acc3_number = Convert.ToInt32(Console.ReadLine());

                        shiva.displayInfo(Acc3_number);
                        vinu.displayInfo(Acc3_number);

                        break;
                  
                    default: Console.WriteLine("You Choose invalid option.. Please insert currect option");
                        break;

                }
                Console.WriteLine("\n");
            } while (choice != 0);

            }
            else
            {
                Console.WriteLine("Bank name is invalid..");
            }

              Console.Read();
        }
    }
}
