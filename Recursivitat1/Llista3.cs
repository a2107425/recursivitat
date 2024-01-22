using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    public class Llista3
    {
        public static string TresDedosEnCadaMano(int num)
        {
            if (num == 0)
                return "";
            else
                return TresDedosEnCadaMano(num / 6) + (num % 6).ToString();
        }

    }
}