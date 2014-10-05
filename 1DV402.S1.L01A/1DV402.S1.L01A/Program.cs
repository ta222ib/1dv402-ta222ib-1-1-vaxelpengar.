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
          
            //OBS! roundup är med en sjuk massa decimaler...

            
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
            int roundupSum = (int)Math.Round(sum);
            if (roundupSum <1)
            {
                Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras");  
            }
            return roundupSum;
        }
        static double CalculateRoundup(double sumOfPurchase2, int roundupSum2)
        {
            double roundup; 
            return roundup = sumOfPurchase2 - roundupSum2;
        }
        static int FetchPaidCash(int roundupSum)
        {
            int sum;
        
            Console.Write("Ange erhållet belopp:");
            sum = int.Parse(Console.ReadLine());
            if (roundupSum>sum)
                {
                    Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras!");
                }
            return (sum);
        }

    }
}
//fråga efter totalsumma,
//använd try-catch satser för att ge ny möjlighet att mata in om det är fel, t.ex. text i.s.f. siffror
//avrunda till närmsta hela krontal
//hantera om totalsumman är mindre än en krona, 
//om det blev mindre än 1 SEK, avsluta programmet efter felmeddelande
//fråga efter erhållet belopp
//hantera om erhållet belopp är mindre än totalsumman,
//avsluta programmet efter att felmeddelande visats
//presentera KVITTO innehållande: "Köpets totala summa", "Öresavrundningen", 
//"Summa att betala", "Erhållet belopp", "Växel"
//Dela upp växeln i 500, 100, 50, 20 lappar samt 10, 5 och 1kronorsmynt. 
//Presentera bara antalet sedlar och mynt som är fler än 0.