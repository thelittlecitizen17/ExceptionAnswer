using System;

namespace ExceptionQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicRunner lr = new LogicRunner();
            int[] numbers = { 1,2,3,4,5,6};
            string number = "9s5";
            lr.LogicRunner1(numbers);
            lr.LogicRunner3(number);
            lr.LogicRunner4("yasha", 3, 1111111111111111);
        }
    }
}
