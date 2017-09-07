using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Eatm
    {
        int num, press, n;
        int cNum, pNum, am;
        int[] times = {0, 0, 0};
        int[] card_num = { 100, 200, 300 };
        int[] pin_num = { 123, 234, 345 };
        int[] amount = { 500, 800, 300 };
        
        public void cardNumber()
        {
            
            Console.WriteLine("Enter your card number: ");
            cNum = exeption();
            
            if (checkNumCard(cNum) == true)
            {
                pinNumber();
            }
            else
            {
                Console.WriteLine("The Card Number does not exist. Try again!");
                cardNumber();
            }

        }

        public void pinNumber()
        {
            Console.WriteLine("Enter Your pin number: ");
            pNum = exeption();
            if (checkNumPin(pNum) == true)
            {
                option();
            }
            else
            {
                Console.WriteLine("The Pin Number does not match. Try again!");
                cardNumber();
            }
        }

        public void option()
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Withdrawal");
            Console.WriteLine("3. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    balance();
                    break;
                case 2:
                    cashWithdrawal();
                    break;
                case 3:
                    exit();
                    break;
            }

        }

        public void balance()
        {
            Console.WriteLine("Your current balace is " + amount[n]);
            Console.WriteLine();
            Console.WriteLine("1. Cash withdrawn");
            Console.WriteLine("2. Exit");
            int p = exeption();
            switch (p)
            {
                case 1:
                    cashWithdrawal();
                    break;
                case 2:
                    exit();
                    break;
            }
        }

        public void cashWithdrawal()
        {
            if (times[n] == 3)
            {
                Console.WriteLine("Your transection limit is over");
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Exit");
                press = exeption();
                switch (press)
                {
                    case 1:
                        balance();
                        break;
                    case 2:
                        exit();
                        break;
                }
            }
            Console.WriteLine("Enter Your amount: ");
            am = Convert.ToInt32(Console.ReadLine());
            if (am > 1000)
            {
                Console.WriteLine("Can not withdraw more than 1000tk. Try again!");
                cashWithdrawal();
            }
            else if (am <= 1000 && am > amount[n])
            {
                Console.WriteLine("You have not sufficient balance in your account to withdraw. Try again!");
                cashWithdrawal();
            }
            else
            {
                Console.WriteLine("Withdraw successful!");
                amount[n] = amount[n] - am;
                Console.WriteLine("Your current balance is " + (amount[n]));
                times[n]++;
            }
            Console.WriteLine("Do you want to exit?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    exit();
                    break;
                case 2:
                    cashWithdrawal();
                    break;
            }
            
        }

        public void exit()
        {
            cardNumber();
        }

        public int exeption()
        {
            try
            {
               num = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("You must enter a number, please try again");
                exeption();
            }
            return num;
        }

        public bool checkNumCard(int num)
        {
            for (int i = 0; i < card_num.Length; i++)
            {
                if (num == card_num[i])
                {
                    n = i;
                    return true;
                }
            }
            return false;
        }
        public bool checkNumPin(int num)
        {
            for (int i = 0; i < pin_num.Length; i++)
            {
                if (num == pin_num[n])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
