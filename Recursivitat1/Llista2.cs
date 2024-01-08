using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    public static class Llista2
    {
        public static bool EsPrimer(int num)
        {
            return ImmersioEsPrimer(num, 2);
        }

        private static bool ImmersioEsPrimer(int num, int divisor)
        {
            bool esPrimer = true;
            if (num <= 2)
            {
                esPrimer = (num == 2) ? true : false;
            }
            else if (num % divisor == 0)
            {
                esPrimer = false;
            }
            else if (divisor * divisor <= num)
            {
                esPrimer = ImmersioEsPrimer(num, divisor + 1);
            }
            return esPrimer;
        }
        public static bool EsPerfecte(int num)
        {
            bool esPerfecte = false;
            if (num == SumaDivisors(num, 1))
            {
                esPerfecte = true;
            }
            return esPerfecte;
        }

        private static int SumaDivisors(int num, int divisor)
        {
            int suma = 0;
            if (divisor < num)
            {
                if (num % divisor == 0)
                {
                    suma = divisor + SumaDivisors(num, divisor + 1);
                }
                else
                {
                    suma = SumaDivisors(num, divisor + 1);
                }
            }
            return suma;
        }

        public static int ValorMaxim(int[] nums)
        {
            return ImmersioValorMaxim(nums, 0, nums[0]);
        }

        private static int ImmersioValorMaxim(int[] nums, int pos, int maxim)
        {
            if (pos < nums.Length)
            {
                maxim = Math.Max(maxim, nums[pos]);
                maxim = ImmersioValorMaxim(nums, pos + 1, maxim);
            }
            return maxim;
        }

        public static int PosicioValor(int[] nums, int num)
        {
            return ImmersioPosicioValor(nums, num, 0);
        }

        private static int ImmersioPosicioValor(int[] nums, int num, int pos)
        {
            int resultat = -1;
            if (pos < nums.Length)
            {
                if (nums[pos] == num)
                {
                    resultat = pos;
                }
                else
                {
                    resultat = ImmersioPosicioValor(nums, num, pos + 1);
                }
            }
            return resultat;
        }

        public static bool VectorCapCua(int[] nums)
        {
            return ImmersioVectorCapCua(nums,0,nums.Length-1);
        }

        private static bool ImmersioVectorCapCua(int[] nums,int inici, int fi)
        {
            bool esCapCua = true;
            if(inici < fi)
            {
                if (nums[inici] != nums[fi])
                {
                    esCapCua = false;
                }
                else
                {
                    esCapCua = ImmersioVectorCapCua(nums,inici+1,fi-1); 
                }
            }
            
            return esCapCua;
        }
        public static int LongitudPrefixSumaZero(int[] nums)
        {
            return ImmersioLongitudPrefixSumaZero(nums, 0, 0, 0);
        }

        private static int ImmersioLongitudPrefixSumaZero(int[] nums, int inici, int fi, int suma)
        {
            int longitud = 0;
            if (inici == nums.Length)
            {
                if (suma == 0)
                {
                    longitud = fi;
                }
            }
            else
            {
                suma += nums[inici];
                suma += nums[inici];

                int incloure = ImmersioLongitudPrefixSumaZero(nums, inici + 1, fi + 1, suma);

                int excloure = ImmersioLongitudPrefixSumaZero(nums, inici + 1, fi, suma - nums[inici]);

                longitud = Math.Max(incloure, excloure);
            }
            return longitud;
        }



    }
}
