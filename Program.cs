using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingInner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "";
            Console.WriteLine("Enter a FullName");
            try
            {
                FullName = Console.ReadLine();
                if (string.IsNullOrEmpty(FullName))
                {
                    throw new Exception("string is null or empty");
                }
                else if (string.IsNullOrWhiteSpace(FullName))
                {
                    throw new Exception("white spces are not allowed");
                }
                else if (FullName.Length < 4 && FullName.Length > 30)
                {
                    throw new LengthException("Invalid string");
                }
                else
                {
                    Console.WriteLine("Full Name : " + FullName);
                }
            }
            catch(LengthException ex2)
            {
                ex2.showMessageException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
