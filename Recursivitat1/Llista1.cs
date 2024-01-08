using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    public static class Llista1
    {
        public static int SumaDigits(int num)
        {
            int suma = 0;
            if (num == 0)
            {
                suma = num;
            }
            else
            {
                suma += num % 10 + SumaDigits(num / 10);
            }
            return suma;

        }

        public static int ProducteAmbSumes(int a, int b)
        {
            int res = 0;
            if (a == 0)
            {
                res = 0;
            }
            else
            {
                res += b + ProducteAmbSumes(a - 1, b);
            }
            return res;
        }

        public static int DivisioEntera(int a, int b)
        {
            int res = 0;
            if (b > a)
            {
                res = 0;
            }
            else
            {
                res += 1 + DivisioEntera(a - b, b);
            }
            return res;
        }
        public static int MCD(int a, int b)
        {
            int res = 0;
            if (b == 0)
            {
                res = a;
            }
            else
            {
                res = MCD(b, a % b);
            }
            return res;
        }
        public static string InterpretacioBase(int num, int numBase)
        {
            string res = "";
            string[] digitsHexadecimal = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            if (num >= numBase)
            {
                res = InterpretacioBase(num / numBase, numBase) + digitsHexadecimal[num % numBase];
            }
            else
            {
                res = digitsHexadecimal[num];
            }
            return res;
        }
        public static bool EstaEnBaseB(int num, int numBase)
        {
            bool estaEnBase = true;
            if (num != 0)
            {
                if (num % 10 >= numBase)
                {
                    estaEnBase = false;
                }
                else
                {
                    estaEnBase = EstaEnBaseB(num / 10, numBase);
                }
            }
            return estaEnBase;
        }
    }
}
