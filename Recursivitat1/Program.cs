using A6;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        MostrarMenu();          
    }
    
    private static void MostrarMenuLlista1(string opcioLlista1)
    {
        switch(opcioLlista1)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Entra un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Llista1.SumaDigits(n));
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Entra un numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entra segon numero");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("RESULTAT: "+Llista1.ProducteAmbSumes(n,n2));
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Entra numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entra segon numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("RESULTAT: "+Llista1.DivisioEntera(n,n2));
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Entra numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entra segon numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("RESULTAT: " + Llista1.MCD(n, n2));
                break;
          case "5":
                Console.Clear();
                Console.WriteLine("Entra numero decimal: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entra la base que a la que vols passar: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{n} en base {n2}: " + Llista1.InterpretacioBase(n, n2));
                break;
        case "6":
                Console.Clear();
                Console.WriteLine("Entra el numero que vols comprovar: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entra la base: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                bool estaEnBase= Llista1.EstaEnBaseB(n, n2);
                Console.WriteLine(estaEnBase?$"{n} esta en base {n2}":$"{n} NO esta en base {n2}");
                break;
            case "m":
                Console.Clear();
                MostrarMenu();
                break;
                    
        }
    }

    private static void MostrarMenuLlista2(string opcioLlista2)
    {
        int[] vectorEnters = new int[] { 45, 91, 1, 101, 81 };
        int[] sumaZero = new int[] { 2, -2, 3, -3, 4, -4, 5,-5,1 };
        int[] capCuap = new int[] { 3, 2, 1, 1, 2, 3 };
        switch (opcioLlista2)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Entra un nombre per saber si es primer");
                int n = Convert.ToInt32(Console.ReadLine());
                bool esPrimer = Llista2.EsPrimer(n);
                Console.WriteLine(esPrimer?$"{n} és primer":$"{n} NO és primer");
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Entra un nombre per saber si es perfecte");
                n = Convert.ToInt32(Console.ReadLine());
                bool esPerfecte = Llista2.EsPerfecte(n);
                Console.WriteLine(esPerfecte?$"{n} és perfecte":$"{n} NO és perfecte");
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Vector:");
                for (int i = 0; i < vectorEnters.Length; i++)
                {
                    if (i != vectorEnters.Length - 1)
                    {
                        Console.Write(vectorEnters[i] + ",");
                    }
                    else
                    {
                        Console.Write(vectorEnters[i]);
                    }
                }
                Console.WriteLine($"\nValor maxim: {Llista2.ValorMaxim(vectorEnters)}");
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Vector:");
                for (int i = 0; i < vectorEnters.Length; i++)
                {
                    if (i != vectorEnters.Length - 1)
                    {
                        Console.Write(vectorEnters[i] + ",");
                    }
                    else
                    {
                        Console.Write(vectorEnters[i]);
                    }
                }
                Console.WriteLine("\nEntra valor per comprovar la seva posicio al array");
                int posicio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Posicio del valor: "+Llista2.PosicioValor(vectorEnters,posicio));
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("Vector:");
                for (int i = 0; i < capCuap.Length; i++)
                {
                    if (i != capCuap.Length - 1)
                    {
                        Console.Write(capCuap[i] + ",");
                    }
                    else
                    {
                        Console.Write(capCuap[i]);
                    }
                }

                bool esCapCua = Llista2.VectorCapCua(capCuap);
                Console.WriteLine(esCapCua?"El vector és cap i cua":"El vector NO és cap i cua");
                break;
            case "6":
                Console.Clear();
                Console.WriteLine("Vector:");
                for (int i = 0; i < sumaZero.Length; i++)
                {
                    if (i != sumaZero.Length - 1)
                    {
                        Console.Write(sumaZero[i] + ",");
                    }
                    else
                    {
                        Console.Write(sumaZero[i]);
                    }
                }
                Console.WriteLine("\nLongitud: "+Llista2.LongitudPrefixSumaZero(sumaZero));
                break;

            case "m":
                Console.Clear();
                MostrarMenu();
                break;
        }
    }
    private static void MostrarMenuLlista3(string opcioLlista3)
    {
        switch (opcioLlista3)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Entra numero de casos: ");
                int nCasos = Convert.ToInt32(Console.ReadLine());
                List<string> resultats = new List<string>();
                while (nCasos > 0)
                {
                    Console.WriteLine("Entra valor");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    string num = Llista3.TresDedosEnCadaMano(valor);
                    resultats.Add(num);
                    nCasos--;
                }
                Console.WriteLine("Resultat:");
                foreach (string res in resultats)
                {
                    Console.WriteLine(res);
                }
                break;
        }
        }

    public static void MostrarMenu()
    {
        string opcio = "";
        Console.Clear();
        while (opcio != "0")
        {
            Console.WriteLine("1) Accedir a la llista 1");
            Console.WriteLine("2) Accedir a la llista 2");
            Console.WriteLine("3) Accedir a la llista 3");
            Console.WriteLine("m) Mostrar menú");
            Console.WriteLine("0) Sortir");
            opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("____________");
                    Console.WriteLine("\n LLISTA 1");
                    Console.WriteLine("____________");
                    Console.WriteLine("1) SumaDigits");
                    Console.WriteLine("2) ProducteAmbSumes");
                    Console.WriteLine("3) DivisioEntera");
                    Console.WriteLine("4) MCD");
                    Console.WriteLine("5) InterpretacioBase");
                    Console.WriteLine("6) EstaEnBaseB");
                    Console.WriteLine("m) Mostrar menú");
                    Console.WriteLine("0) Sortir");
                    string opcioMenuLlista1 = Console.ReadLine();
                    MostrarMenuLlista1(opcioMenuLlista1);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("____________");
                    Console.WriteLine("\n LLISTA 2");
                    Console.WriteLine("____________");
                    Console.WriteLine("1) EsPrimer");
                    Console.WriteLine("2) EsPerfecte");
                    Console.WriteLine("3) ValorMaxim");
                    Console.WriteLine("4) PosicioValor");
                    Console.WriteLine("5) VectorCapCua");
                    Console.WriteLine("6) PrefixSumaZero");
                    Console.WriteLine("m) Mostrar menú");
                    Console.WriteLine("0) Sortir");
                    string opcioMenuLlista2 = Console.ReadLine();
                    MostrarMenuLlista2(opcioMenuLlista2);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("____________");
                    Console.WriteLine("\n LLISTA 3");
                    Console.WriteLine("____________");
                    Console.WriteLine("1) Tres dedos en cada mano");
                    Console.WriteLine("m) Mostrar menú");
                    Console.WriteLine("0) Sortir");
                    string opcioMenuLlista3 = Console.ReadLine();
                    MostrarMenuLlista3(opcioMenuLlista3);
                    Console.WriteLine();
                    break;
                case "m":
                    Console.Clear();
                    MostrarMenu();
                    break;
            }

        }

    }


}