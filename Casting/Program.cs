using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 0;
            int i = b; // implicity type conversion only works from smaller type to larger
            Console.WriteLine(i);

            int iii = 5000;
            byte bbb = (byte)iii;
            Console.WriteLine(bbb);

            var number = "1234";
            int iiii = Convert.ToInt32(number);

            Console.WriteLine(iiii);

            Console.ReadKey();


            int f = 1;
            float ff = f;

            int ii = 1;
            //byte bb = ii; // won't compile
            byte bb = (byte)ii;


            string s = "1";
            //int i = (int)s; // will not work
            int j = Convert.ToInt32(s);
            int jj = int.Parse(s);

            string str = "false";
            bool mer = Convert.ToBoolean(str);
            Console.WriteLine(mer);


            try
            {
                var number2 = "1234";
                byte bb2 = Convert.ToByte(number2);
                Console.WriteLine(bb2);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte.");
            }
            Console.ReadKey();
        }
    }
}
