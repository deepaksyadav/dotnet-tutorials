using System;
namespace DefaultConstructorDemo
{
    class Sum
    {
        private int x;
        private int y;
        // Default
        public Sum()
        {
            x = 5;
            y = 7;
        }
        // parameterised 
        public Sum(int a, int b)
        {
            x = a;
            y = b;
        }

        // Copy Constructor
        public Sum(Sum s)
        {
            x = s.x;
            y = s.y;
        }

        public int getSum()
        {
            return x + y;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            // default call
            Sum s = new Sum();
            Console.WriteLine("Sum: {0}", s.getSum());

            // parameterised call
            Sum s1 = new Sum(15, 9);
            Console.WriteLine("Sum: {0}", s1.getSum());

            //copy constructor
            Sum s2 = new Sum(s1);
            Console.WriteLine("Sum: {0}", s2.getSum());
            Console.ReadKey();
        }
    }
}
