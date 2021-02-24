using System;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Coffee  
    {
        public abstract double GetPrice();
        public abstract string GetDescription();
    }

    public class HouseBlend :  Coffee
    {
        public override double GetPrice()
        {
            return 35;
        }

        public override string GetDescription()
        {
            return "HouseBlend";
        }
    }

    public class HouseBlendWithMilk :  HouseBlend
    {
        public override double GetPrice()
        {
            return 35;
        }

        public override string GetDescription()
        {
            return "HouseBlend";
        }
    }

    public class DarkRoast :  Coffee
    {
        public override double GetPrice()
        {
            return 39;
        }

        public override string GetDescription()
        {
            return "DarkRoast";
        }
    }
}
