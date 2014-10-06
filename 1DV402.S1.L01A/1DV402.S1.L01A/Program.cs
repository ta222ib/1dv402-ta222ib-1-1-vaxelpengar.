using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L01A
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfPurchase;
            int roundupSum;
            double roundup;
            int paidCash;
            int sumOfChange;
            
            sumOfPurchase = FetchPurchaseInfo();
            roundupSum = CalculateRoundupSum(sumOfPurchase);
            roundup = CalculateRoundup(sumOfPurchase, roundupSum);
            paidCash = FetchPaidCash(roundupSum);
            sumOfChange = CalculateChange(paidCash, roundupSum);
            WriteReceipt(sumOfPurchase, roundup, roundupSum, paidCash, sumOfChange);
            CalculateAndWritePhysicalChange(sumOfChange);
                   
        }
        static double FetchPurchaseInfo() 
        {
            double sum;
            while (true)
	        {
             try
                {
                Console.Write ("Ange totalsumma :");
                return sum=Double.Parse(Console.ReadLine());
                break;
                }
             catch
                {
                Console.WriteLine("Du har matat in ett felaktigt värde, försök igen!");
                }
            }
            return sum;
        }
        static int CalculateRoundupSum(double sum)
        {
            int roundupSum = (int)Math.Round(sum, 0, MidpointRounding.AwayFromZero); 
            if (roundupSum <1)
            {
                Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras");
                Environment.Exit(0);
            }
            return roundupSum;
        }
        static double CalculateRoundup(double localSumOfPurchase, int localRoundupSum)
        {
            double roundup; 
            return roundup = localRoundupSum - localSumOfPurchase ;
        }
        static int FetchPaidCash(int roundupSum)
        {
            int sum;
        
            Console.Write("Ange erhållet belopp:");
            sum = int.Parse(Console.ReadLine());
            if (roundupSum>sum)
                {
                    Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras!");
                    Environment.Exit(0);
                }
            return (sum);
        }
        static int CalculateChange(int localPaidCash, int localRoundupSum)
        {
            int localSumOfChange;
            return localSumOfChange = localPaidCash - localRoundupSum;
        }
        static void WriteReceipt(double localSumOfPurchase, double localRoundup, int localRoundupSum, int localPaidCash, int localSumOfChange)
        {
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Totalt:\t\t{0}", localSumOfPurchase);
            Console.WriteLine("Öresavrundning:\t{0}", localRoundup);
            Console.WriteLine("Att betala:\t{0}", localRoundupSum);
            Console.WriteLine("Kontant:\t{0}", localPaidCash);
            Console.WriteLine("Tillbaks:\t{0}", localSumOfChange);
            Console.WriteLine("-----------------------------------------");
        }
        static void CalculateAndWritePhysicalChange (int sumOfChange)
        {
            int numberOfFiveHundredBills = sumOfChange / 500;
            int numberOfHundredBills = sumOfChange % 500 / 100;
            int numberOfFiftyBills = sumOfChange % 500 % 100 / 50;
            int numberOfTwentyBills = sumOfChange % 500 % 100 % 50 / 20;
            int numberOfTenCoins = sumOfChange % 500 % 100 % 50 % 20 / 10;
            int numberOfFiveCoins = sumOfChange % 500 % 100 % 50 % 20 % 10 / 5;
            int numberOfOneCoins = sumOfChange % 500 % 100 % 50 % 20 % 10 % 5 / 1;

            if (numberOfFiveHundredBills>0)
            {
              Console.WriteLine("500-lappar:\t{0}",numberOfFiveHundredBills);  
            }
            if (numberOfHundredBills > 0)
            {
              Console.WriteLine("100-lappar:\t{0}", numberOfHundredBills);
            }
            if (numberOfFiftyBills>0)
            {
                Console.WriteLine("50-lappar:\t{0}", numberOfFiftyBills);
            }
            if (numberOfTwentyBills>0)
            {
                Console.WriteLine("20-lappar:\t{0}", numberOfTwentyBills);
            }
            if (numberOfTenCoins>0)
            {
                Console.WriteLine("10-kronor:\t{0}", numberOfTenCoins);
            }
            if (numberOfFiveCoins>0)
            {
                Console.WriteLine("5-kronor:\t{0}", numberOfFiveCoins);
            }
            if (numberOfOneCoins>0)
            {
                Console.WriteLine("1-kronor:\t{0}", numberOfOneCoins);
            }
            Console.WriteLine("");
        }
    }
}
