using System;

namespace Recursive
{
    class Account
    {
        public int day { get; set; }
        public double money { get; set; }
        
    }
    class Process:Account
    {
        public double interest { get; set; }
        public Process(double _money, double _interest, int _day)
        {
            this.money = _money;
            this.interest =_interest;
            this.day =_day;
        }
        public double daily_interest(int day)
        {
            if (day == 1)
            {
                this.money += (this.money*this.interest)/100; // daily interest
                return this.money; 
            }
            else
            {
                this.money += (this.money*this.interest)/100; // daily interest
                this.day -= 1;
                return daily_interest(this.day);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        Process process = new Process(Convert.ToDouble(Console.ReadLine()),  /* Enter money */
                                      Convert.ToDouble(Console.ReadLine()),  /* Enter interest */
                                      Convert.ToInt32(Console.ReadLine())    /* Enter days */
                                      );

        Console.WriteLine(process.daily_interest(process.day));

        }
    }
}
