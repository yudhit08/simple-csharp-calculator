using System;

namespace Kalkulator_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Yudhitya M. Renandra");
            Console.WriteLine("Fun Project\n");
            Calc();
        }
        static void Calc()
        {
            mathOperation math = new mathOperation();
            double a = 0;
            double b = 0;
            string operasi = "0";
            Console.WriteLine("=============KALKULATOR=============\n");
            Console.Write("Masukkan Angka Pertama : ");
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                string isNum = "y";
                while (isNum == "y")
                {
                    Console.WriteLine("Tolong hanya masukkan angka");
                    Console.Write("Masukkan angka Pertama : ");
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                        isNum = "n";
                    }
                    catch (System.FormatException)
                    {
                        isNum = "y";
                    }  
                }
            }
            
            Console.Write("Masukkan Angka kedua : ");
            try
            {
                b = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                string isNum = "y";
                while (isNum == "y")
                {
                    Console.WriteLine("Tolong hanya masukkan angka");
                    Console.Write("Masukkan angka Kedua : ");
                    try
                    {
                        b = double.Parse(Console.ReadLine());
                        isNum = "n";
                    }
                    catch (System.FormatException)
                    {
                        isNum = "y";
                    }
                }
            }
            
            Console.WriteLine("Pilihan operasi ");
            Console.WriteLine("[1] Tambah   (+)");
            Console.WriteLine("[2] Kurang   (-)");
            Console.WriteLine("[3] Kali     (*)");
            Console.WriteLine("[4] Bagi     (/)");
            Console.Write("Pilih sebuah operasi(1/2/3/4) : ");
            
            operasi = Console.ReadLine();
        
            while (operasi != "1" && operasi != "2" && operasi != "3" && operasi != "4" )
            {
                Console.WriteLine("Pilihan operasi tidak tersedia");
                Console.Write("Pilih sebuah operasi(1/2/3/4) : ");
                operasi = Console.ReadLine();
            }
            
            double hasil = 0;
            switch (operasi)
            {
                case "1":
                hasil = math.Tambah(a,b);
                Console.WriteLine($"Hasil dari {a} + {b} = {hasil}"); 
                break;
                
                case "2":
                hasil = math.Kurang(a,b);
                Console.WriteLine($"Hasil dari {a} - {b} = {hasil}"); 
                break;

                case "3":
                hasil = math.Kali(a,b);
                Console.WriteLine($"Hasil dari {a} * {b} = {hasil}"); 
                break;

                case "4":
                if (b == 0)
                {
                    Console.WriteLine("Tidak bisa membagi dengan nol(0)");
                }
                else
                {
                    hasil = math.Bagi(a,b);
                    Console.WriteLine($"Hasil dari {a} / {b} = {hasil}"); 
                }
                break;
            }
            Console.WriteLine();
            ulangCalc();

            Console.ReadKey();
        }
        static void ulangCalc()
        {
            Console.Write("Apakah Anda masih ingin berhitung?(y/n) : ");
            string ulang = Console.ReadLine();
            if (ulang == "y")
            {
                Calc();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    
    }
    class mathOperation
    {
        public double Tambah(double a, double b)
        {
            return a + b;
        }
        public double Kurang(double a, double b)
        {
            return a - b;
        }
        public double Kali(double a, double b)
        {
            return a * b;
        }
        public double Bagi(double a, double b)
        {
            return a / b;
        }
    }
}
