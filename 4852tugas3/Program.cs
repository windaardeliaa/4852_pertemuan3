using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852tugas3
{
     class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            mobil.Warna = "Silver";
            mobil.JumlahPintu = 4;
            mobil.Suara = "Nyaring";
            mobil.Merek = "Toyota Fortuner";
            mobil.Model = "Sedan";
            mobil.TahunKeluaran = 2019;
            mobil.Kecepatan = 21;

            mobil.Gas();
            mobil.Klakson();
            mobil.TampilkanInfo();

           // Console.ReadKey();
        }
    }
}
