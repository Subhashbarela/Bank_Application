using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bank
    {
        public int Account_Number;
        public String Banker_Name;
        public int balance;
        public String Bank_Name;

        public Bank(int Account_Number, String Banker_Name, int balance, String Bank_Name)
        {

            this.Account_Number = Account_Number;
            this.Banker_Name = Banker_Name;
            this.balance = balance;
            this.Bank_Name = Bank_Name;
        }

        public void withdraw(int number)
        {
            if (Account_Number == number)
            {
                Console.WriteLine("How many money you want to withdraw");
                int Amount = Convert.ToInt32(Console.ReadLine());

                if (Amount < balance)
                {
                    Console.WriteLine("your current balace is :" + balance);
                    balance = balance - Amount;
                    Console.WriteLine("After WithDraw your balance is :" + balance);
                }
                else
                {
                    Console.WriteLine("Insufficiant balance :....");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Currect Account number..");
            }

        }
        public void deposit(int number)
        {
            if (Account_Number == number)
            {
                Console.WriteLine("How many money you want to withdraw");
                int D_Amount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your current balance is :" + balance);
                balance = balance + D_Amount;
                Console.WriteLine("After deposit your balance is :" + balance);
            }
            else
            {
                Console.WriteLine("Please Enter Currect Account number..");
            }
        }
        public void Check_balance(int number)
        {
            if (Account_Number == number)
            {
                Console.WriteLine("Your current balance is :" + balance);
            }
            else
            {
                Console.WriteLine("Please Enter Currect Account number..");
            }
        }
        public void displayInfo(int number)
        {
            if (Account_Number == number)
            {
                Console.WriteLine("Account number is :" + Account_Number);
                Console.WriteLine("Banker name is :" + Banker_Name);
                Console.WriteLine("Account balance is :" + balance);
            }
            else
            {
                Console.WriteLine("Please Enter Currect Account number..");
            }
        }


    }
}
