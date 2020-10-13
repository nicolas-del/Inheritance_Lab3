using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Program
    {
        private static readonly Savings_Account _savings = new Savings_Account(5.00, 0.2);
        private static readonly Chequing_Account _chequing = new Chequing_Account(5.00, 0.2);
        private static readonly GlobalSavingsAccount _global = new GlobalSavingsAccount(5.00, 0.2);

        static void Main(string[] args)
        {
            string firstOption, fOption, secondOption;


            do
            {
                bool isValid;
                do
                { //Bank menu
                    Console.WriteLine("\nBank Menu\nA : Savings\nB: Checking\nC: GlobalSavings\nQ: Exit the program");
                    firstOption = Console.ReadLine();

                    switch (firstOption)
                    {
                        case "a":
                        case "A":
                            isValid = true;
                            break;
                        case "b":
                        case "B":
                            isValid = true;
                            break;
                        case "c":
                        case "C":
                            isValid = true;
                            break;
                        case "q":
                        case "Q":
                            isValid = true;
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option, type a, b, c or q");
                            firstOption = null;
                            isValid = false;
                            break;
                    }
                } while (isValid == false);

                do
                {
                    fOption = firstOption;

                    switch (fOption)
                    {
                        case "a":
                        case "A":
                            Console.WriteLine("Savings Menu\nA: Deposits\nB: Withdrawal\nC: Close + Report\nR: Return to bank menu");
                            break;
                        case "b":
                        case "B":
                            Console.WriteLine("Checking menu\nA: Deposits\nB: Withdrawal\nC: Close + Report\nR: Return to bank menu");
                            break;
                        case "c":
                        case "C":
                            Console.WriteLine("Global Savings menu\nA: Deposits\nB: Withdrawal\nC: Close + Report\nD: Report Balance in USD\nR: Return to bank menu");
                            break;
                    }

                    do
                    {
                        secondOption = Console.ReadLine();
                        switch (secondOption)
                        {
                            case "A":
                            case "a":
                                DepositsDependingOnInstance();
                                isValid = true;
                                break;
                            case "B":
                            case "b":
                                WithdrawalsDependingOnInstance();
                                isValid = true;
                                break;
                            case "C":
                            case "c":
                                ReportsDependingOnInstance();
                                isValid = true;
                                break;
                            case "D":
                            case "d":
                                BalanceInUSD();
                                isValid = true;
                                break;
                            case "R":
                            case "r":
                                isValid = true;
                                break;
                            default:
                                Console.WriteLine("Invalid option, type a, b, c, d or r instead");
                                isValid = false;
                                break;
                        }
                    } while (isValid == false);

                } while (secondOption.Contains("A") || secondOption.Contains("a") || secondOption.Contains("B") || secondOption.Contains("b") || secondOption.Contains("C") || secondOption.Contains("c") || secondOption.Contains("D") || secondOption.Contains("d"));

            } while(!firstOption.Contains("Q") || !firstOption.Contains("q"));
          
        }

        private static void DepositsDependingOnInstance() 
        {
       
        }
        private static void WithdrawalsDependingOnInstance() { }
        private static void ReportsDependingOnInstance() { }

        private static void BalanceInUSD() 
        {
            Console.WriteLine("Enter the rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(_global.USValue(rate));
        }

    }
}

