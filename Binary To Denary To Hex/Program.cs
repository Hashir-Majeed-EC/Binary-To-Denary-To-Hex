using System;
using System.Collections.Generic;

namespace Binary_To_Denary_To_Hex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DecToHex(255));
            Console.WriteLine(DecToHex(16));
            Console.WriteLine(HexToBin("FF"));
            Console.WriteLine(HexToBin("27"));
            Console.WriteLine(HexToBin("A2"));
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
            char[] vals = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            
            hex += Convert.ToString(vals[div]);
            hex += Convert.ToString(vals[dec % 16]);
           
            return hex;
        }

        static string HexToBin(string hex)
        {
            string binary = "";

            var codes = new Dictionary<string, string>()
            {
                { "0", "0000" },
                { "1", "0001" },
                { "2", "0010" },
                { "3", "0011" },
                { "4", "0100" },
                { "5", "0101" },
                { "6", "0110" },
                { "7", "0111" },
                { "8", "1000" },
                { "9", "1001" },
                { "A", "1010" },
                { "B", "1011" },
                { "C", "1100" },
                { "D", "1101" },
                { "E", "1110" },
                { "F", "1111" }
            };

            for (int i = 0; i < hex.Length; i++)
            {
                binary += codes[Convert.ToString(hex[i])];
            }
            return binary;
        }
    }
}
