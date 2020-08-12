using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionQuestion
{
    class LogicRunner
    {
        private Logic _logic;
        public LogicRunner()
        {
            _logic = new Logic();
        }
        public void LogicRunner1(int[] numbers)
        {
            if (numbers== null)
            {
                throw new IScubaException("The arry is empty");

            }
            else
            {
                int result = _logic.Logic1(numbers);
                Console.WriteLine($"The result is {result}");
            }
        }
        public void LogicRunner2(string inputFileName, string outputFileName)
        {
            _logic.Logic2(inputFileName, outputFileName);
        }
        public void LogicRunner3(string data)
        {
            if (data.All(char.IsDigit) && data != null)
            {
                var result = _logic.Logic3(data);
                Console.WriteLine($"The number {result} is typeof {result.GetType()} ");
            }
            else
            {
                Console.WriteLine(new IScubaException("The string is null or containes Characters"));
            }
            
        }
        public void LogicRunner4(string data1, int data2, long data3)
        {
            _logic.Logic4(data1, data2, data3);
        }
        public void LogicRunner5(string dllName)
        {
            if (dllName == null)
            {

                Console.WriteLine(new IScubaException("The value of the string is null"));
            }
            else
            {
                _logic.Logic5(dllName);
            }
        }
    }
}
