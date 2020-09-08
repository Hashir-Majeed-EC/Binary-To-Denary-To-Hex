using System;
using System.Collections.Generic;

namespace Binary_To_Denary_To_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        //WORKING for multiple bytes
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

        //NOT working for multiple bytes
        static string DecToHex(int dec)
        {
            int div = dec / 16;
            string hex = "";
            char[] vals = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            
            hex += Convert.ToString(vals[div]);
            hex += Convert.ToString(vals[dec % 16]);
           
            return hex;
        }

        //WORKING for Multiple Bytes
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

        static string BinToHex(string binary) => DecToHex(Convert.ToInt32(BinToDec(binary)));
        static string DecToBin(int dec) => HexToBin(DecToHex(dec));
        static int HexToDec(string hex) => BinToDec(HexToBin(hex));
    }
}
