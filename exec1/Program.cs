using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exec1
{
    class Program
    {
        //deklarasi array int dengan ukuran 22
        private int[] dimas = new int[22];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;


        //fungsi/method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang di simpan pada array
            while (true)
            {
                Console.Write("\nMasukkan banyak elemen pada array\n");
                Console.WriteLine("---------------------------------");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 22)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 22 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukan elemen array");
            Console.WriteLine("--------------------");

            //pengguna memasukkan elemen pada array
            for (int i = 0; i < dimas.Length; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dimas[n - 1] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("----------------------------------");
            for (int dv = n-2; dv < dimas.Length; dv++)
            {
                Console.WriteLine(dimas[n -2]);
            }
            Console.WriteLine("");
        }
        public void exec1Array()
        {
            for (int i = 0; i < dimas.Length; i++)
          
            {
                //pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int dv = n - 2; dv < n - i; dv++)
                {
                    if (dimas[n-2] > dimas[n + 1])
                    {
                        //tukar elemen
                        int temp, min_Index;
                        min_Index = dv;
                        temp = dimas[n - 2];
                        dimas[n-2] = dimas[ n+ 1];
                        dimas[n+ 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of sort class
            Program myList = new Program();

            // pemanggilan fungsi untuk menerima elemen array
            myList.read();

            // pemanggilan mengurutkan array
            myList.exec1Array();

            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();

            // exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
