using System;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
		int a, b;
        int pilihan;

        Console.WriteLine("Pilih menu calculator:");

        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.WriteLine("Input Menu :");
        pilihan = int.Parse(Console.ReadLine());
		
		if (pilihan == 1)
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + penambahan(a, b));
            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0}-{1}={2}", a, b, pengurangan(a, b));
            }

            else if (pilihan == 3)
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0}*{1}={2}", a, b, perkalian(a, b));
            }

            else if (pilihan == 4)
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0}/{1}={2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Menu yang Anda pilih tidak tersedia");
            }
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }        
    }
}