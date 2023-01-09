using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExtensionM;

namespace ExtensionFunction
{
    public static class ExtensionFunc
    {
        public static string ToCurrency(this Extension str,string s)
        {
            string st = str.Extensions(s);
            if (Regex.IsMatch(st,@"^\d+$"))
            {
                string newstr = "$" + st;
                return newstr;
            }
            else
            {
                throw new ArgumentException("String is  not a number");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Extension ext = new Extension();
            try
            {
                Console.WriteLine(ext.ToCurrency(s));
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

        }
    }
}