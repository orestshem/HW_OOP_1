using System.Security.Principal;

namespace testClasses2;
class Program
{


    abstract class Ekreative
    {


    }

    abstract class Workers : Ekreative
    {
        protected string role;
        protected int salary;
        protected int yearsWorked;

        public abstract void work();

        protected void eatLunch()
        {
            Console.WriteLine("Worker is enjoying his/her delicious meal at the dining room.");
        }

    }

    class InternWorker : Workers
    {
        public bool isAlive = true;

        public override void work()
        {
            if (isAlive)
            {
                Console.WriteLine("Intern is working");
            } else
            {
                Console.WriteLine("Intern is having a rest");
            }
            
        }

    }

    class SMM : Workers
    {
        private int hungerLevel = 5;
        private bool isBusy;

        static private int globalCount = 0;
        private bool WorkerIsAlive;

        static public void Something()
        {
            Console.WriteLine("There are " + globalCount + " stories posted");
        }

        public override void work()
        {
            base.eatLunch();
            if (hungerLevel > 0)
            {
                Console.WriteLine("SMM is enjoying his/her delicious meal at the dining room.");
                hungerLevel = hungerLevel - 1;
            }
            else
            {

            }
        }

        public int getHungerLevel()
        {
            return hungerLevel;
        }


        public SMM(int hungerLevel, int salary, bool isBusy)
        {
            this.hungerLevel = hungerLevel;
            this.salary = salary;
            this.isBusy = isBusy;
            globalCount++;
        }

        public SMM()
        {
            globalCount++;
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("This is E K R E A T I V E");
        SMM p1 = new SMM(3, 2000, true);
        SMM p2 = new SMM(100, 1, false);
        SMM p3 = new SMM(100, 1, false);
        InternWorker intern = new InternWorker();

        SMM p4 = new SMM();
        p4.work();
        


    }
}