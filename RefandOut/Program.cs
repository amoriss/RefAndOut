using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning a bool and subtracting from the parameter.
        //So it will have two outputs. the bool of true if health is > 0. and also set x to decrease by 1.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable and returns a bool.
        public static bool SubtractHealth(ref int x)
        {
            x--;
            if (x > 0)
            {
                return true; 
            }
            return false; 

        }

        //TODO create method that uses the out keyword. Call the method in the main.
        

        public static int Sum(int x, int y, out  bool even)
        {
            //use this method or make your own.
            int sum = x + y;
            if (sum%2==0)
            {
                even = true;
            }
            else
            {
                even = false; 
            }

            return sum; 
            //bool even = int.TryParse( , out sum);

        }


        static void Main(string[] args)
        {
            //ref
            int x = 17;
            var result = (SubtractHealth(ref x));
            Console.WriteLine(x);
            Console.WriteLine(result);

            //out
            bool isEven; 
            var sum = Sum(1236, 1232, out isEven);
    
        }

    }
}
