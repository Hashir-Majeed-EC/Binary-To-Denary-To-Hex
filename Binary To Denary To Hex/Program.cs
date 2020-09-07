using System;

namespace Binary_To_Denary_To_Hex
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DecToHex(255));
            Console.WriteLine(DecToHex(127));
            Console.WriteLine(DecToHex(16));
        }

        static int BinToDec(string binary)
        {
            int position = 0;
            int total = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    total += Convert.ToInt32(Math.Pow(2, position));
                }
                position++;
            }
            return total;
        }

        static string DecToHex(int dec)
        {
            int div = dec / 16;
            string hex = "";
            char[] vals = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            
            hex += Convert.ToString(vals[dec / 16]);
            Console.WriteLine(hex);
            hex += Convert.ToString(vals[dec % 16]);
           
            return hex;
        }

    }
}
