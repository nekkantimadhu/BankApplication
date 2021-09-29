
using System;
using System.Collections.Generic;
using System.Text;

public class Bank
{
	public static void Main()
	{
		var map = new Dictionary<int, string>();
		var map1 = new Dictionary<int, int>();
		int avlAmount = 0;
		while (true)
		{
			Console.WriteLine("1. Create Account\n2. Deposit Amount\n3. Withdraw Amount\n4. Transfer Amount\n5. Transaction History\n");
			Console.WriteLine("Enter option : ");
			int n = Convert.ToInt32(Console.ReadLine());
			int acNum = 0;

			if (n == 1)
			{
				Console.WriteLine("Please Enter the Account number : ");
				acNum = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Please Enter your name : ");
				string acName = Console.ReadLine();

				map.Add(acNum, acName);
				map1.Add(acNum, avlAmount);
			}

			else if (n == 2)
			{
				Console.WriteLine("Please Enter your Account Number :");
				acNum = Convert.ToInt32(Console.ReadLine());
				
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

			else if (n == 3)
			{
				Console.WriteLine("Please Enter your Account Number :");
				acNum = Convert.ToInt32(Console.ReadLine());
				
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

			else if (n == 4)
			{
				Console.WriteLine("Please Enter your Account Number :");
				acNum = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("Please Enter your Account Number to transfer Money:");
				int acNum1 = Convert.ToInt32(Console.ReadLine());

				if (map1.ContainsKey(acNum))
				{
					Console.WriteLine("Please Enter amount to be transfered : ");
					int transfer = Convert.ToInt32(Console.ReadLine());

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

						map1[acNum1] += transfer;

					}
				}

				else
				{
					Console.WriteLine("Please Enter Vaild Account Number! ");
				}
			}

			else if (n == 5)
			{
				Console.WriteLine("Please Enter your Account Number :");
				acNum = Convert.ToInt32(Console.ReadLine());
				
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

			else
			{
				Console.WriteLine("Please Enter a valid option");
				
			}


		}
	}
}

