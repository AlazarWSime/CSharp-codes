using Lidet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace enumm
{
    internal class Program
    {
        enum Etdayofweek
        {
            segno,
            maksegno,
            rebu,
            hamus,
            arb,
            kidame,
            ehud
        }
        static Etdayofweek calculatedate(Etdayofweek day, int offSet) {
            int totlaDays = 7;
            Etdayofweek NewDay = day + offSet;
            while (NewDay < 0 || (int)NewDay > 6) 
            {
                if (NewDay < 0)
                {
                    NewDay += totlaDays;
                }
                else
                {
                    NewDay -= totlaDays;
                }
            }
            return (Etdayofweek)NewDay;
        }
        static void Main(string[] args)
        {


            // Create object
            BankAccount account = new BankAccount();
            account.Owner = "Alazar";

            // Call methods to perform tasks
            account.Deposite(1000.00);
            account.Deposite(500.00);
            account.Withdraw(200.00);
            account.Withdraw(5000.00); // Should fail

            // Call method that returns a value
            double checkAmount = 300.00;
            if (account.HasSufficientFunds(checkAmount))
                Console.WriteLine($"You can withdraw ${checkAmount}");
            else
                Console.WriteLine($"Not enough funds for ${checkAmount}");

            // Call summary method
            account.PrintSummary();
            //Console.WriteLine(calculatedate(Etdayofweek.segno, -1));
            //Console.WriteLine(calculatedate(Etdayofweek.ehud, 1));
            //Console.WriteLine(calculatedate(Etdayofweek.maksegno, 9));
            //Console.ReadKey();

            int[][] jagged = new int[3][];
            for(byte i =0; i< jagged.Length; i++) 
            {
                jagged[i] = new int[(i+2)*2];
                for (byte j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = new Random(DateTime.UtcNow.Millisecond).Next(1, 200);
                }
            }

            foreach (int[] outer in jagged) 
            {
                foreach (int inner in outer) {
                  Console.Write(inner + " ");
                }
                Console.WriteLine();
            }
            

        }
    }
}