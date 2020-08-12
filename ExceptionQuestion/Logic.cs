using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionQuestion
{
    public class Logic
    {
        public int Logic1(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result += i;
            }
            return result;
        }

        public void Logic2(string inputFileName, string outputFileName)
        {
            try
            {
                StreamReader sr = new StreamReader(inputFileName);
                string input = sr.ReadToEnd();
                sr.Close();

                StreamWriter sw = new StreamWriter(outputFileName);
                sw.Write(inputFileName);
                sw.Close();
            }
            catch (Exception e)
            {
                if(e is DirectoryNotFoundException || e is FileNotFoundException)
                {
                    Console.WriteLine("We can't find the file's directory of the file");
                }
                else
                {
                    Console.WriteLine(e.ToString());
                }
            }
            
        }

        public int Logic3(string data)
        {
            try
            {
                return Int32.Parse(data);
            }
            catch(Exception e)
            {
                if(e is FormatException || e is OverflowException)
                {
                    Console.WriteLine("There is a problem with the string's format or thh legth");
                    throw;
                }
                else
                {
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
        }

        public void Logic4(string data1, int data2, long data3)
        {
            Console.WriteLine(new NotImplementedException("This method is not implemeted"));
        }

        public void Logic5(string dllName)
        {

            try
            {
                Assembly.LoadFrom(dllName);
            }
            catch(Exception e)
            {
                if(e is FileLoadException || e is BadImageFormatException)
                {
                    Console.WriteLine("A file that was found could not be loaded or the file is not a valid assembly");
                }
                else
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

    }
}
