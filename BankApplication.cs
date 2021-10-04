
using System;
using System.Collections.Generic;

public class Bank
{

    public Dictionary<int, string> map = new Dictionary<int, string>();
    public Dictionary<int, int> map1 = new Dictionary<int, int>();
    public int avlAmount = 0;

    public static void Main()
    {
        Bank b = new Bank();
        while (true)
        {

            Console.WriteLine("1. Create Account\n2. Deposit Amount\n3. Withdraw Amount\n4. Transfer Amount\n5. Transaction History\n6. Logout\n");
            Console.WriteLine("Enter option : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int acNum = 0;

            if (n == 1)
            {
                b.CreateAccount();

            }

            else if (n == 2)
            {
                b.DepositAmount();

            }

            else if (n == 3)
            {
                b.WithdrawAmount();

            }

            else if (n == 4)
            {
                b.TransferAmount();

            }

            else if (n == 5)
            {
                b.TransactionHistory();

            }

            else
            {
                Console.WriteLine("Please Enter a valid option");

            }
            if (n == 6)
            {
                b.Logout();
                break;
            }


        }
    }
    public void CreateAccount()
    {
        Console.WriteLine("Please Enter the Account number : ");
        int acNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter your name : ");
        string acName = Console.ReadLine();

        if (map.ContainsKey(acNum))
        {
            Console.WriteLine("Please Enter differnt possible number");
        }

        map.Add(acNum, acName);
        map1.Add(acNum, avlAmount);
    }

    public void DepositAmount()
    {
        Console.WriteLine("Please Enter your Account Number :");
        int acNum = Convert.ToInt32(Console.ReadLine());

        if (map1.ContainsKey(acNum))
        {

            Console.WriteLine("Please Enter your deposit amount : ");
            int deposit = Convert.ToInt32(Console.ReadLine());

            avlAmount += deposit;
            map1[acNum] = avlAmount;

            Console.WriteLine("Your current Balance : " + avlAmount);
        }
        else
        {
            Console.WriteLine("Please Enter Vaild Account Number! ");
        }
    }

    public void WithdrawAmount()
    {
        Console.WriteLine("Please Enter your Account Number :");
        int acNum = Convert.ToInt32(Console.ReadLine());

        if (map.ContainsKey(acNum))
        {

            Console.WriteLine("Please Enter your Withdraw amount : ");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            if (avlAmount >= withdraw)
            {
                avlAmount -= withdraw;
                map1[acNum] = avlAmount;
            }
            else
            {
                Console.WriteLine("Your Account Does not have sufficient Balance to Withdraw ");
            }

            Console.WriteLine("Your current Balance : " + avlAmount);
        }
        else
        {
            Console.WriteLine("Please Enter Vaild Account Number! ");
        }
    }

    public void TransferAmount()
    {
        Console.WriteLine("Please Enter your Account Number :");
        int acNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter your Account Number to transfer Money:");
        int acNum1 = Convert.ToInt32(Console.ReadLine());

        if (map1.ContainsKey(acNum) && map1.ContainsKey(acNum1))
        {
            Console.WriteLine("Please Enter amount to be transfered : ");
            int transfer = Convert.ToInt32(Console.ReadLine());
            int t1 = transfer;
            if (avlAmount >= transfer)
            {
                avlAmount -= transfer;
                map1[acNum] = avlAmount;

                Console.WriteLine("Your current Balance : " + avlAmount);
            }
            else
            {
                Console.WriteLine("Your Account Does not have sufficient Balance to transfer ");
            }

            if (map1.ContainsKey(acNum1))
            {

                map1[acNum1] += t1;

            }
            else
            {
                Console.WriteLine("Please enter valid account number to transfer ");
            }
        }

        else
        {
            Console.WriteLine("Please Enter Vaild Account Number! ");
        }
    }

    public void TransactionHistory()
    {
        Console.WriteLine("Please Enter your Account Number :");
        int acNum = Convert.ToInt32(Console.ReadLine());

        if (map1.ContainsKey(acNum))
        {

            foreach (KeyValuePair<int, int> ele1 in map1)
            {
                if (ele1.Key == acNum)
                {
                    Console.WriteLine("Your Available Account Balance : " + ele1.Value);
                }
            }

        }
    }

    public void Logout()
    {
        Console.WriteLine("Thank you for using our application 😀 \n Have a great day!! 🎉");

    }
}

