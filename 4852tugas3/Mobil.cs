using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852tugas3
{
    internal class Mobil
    {
        //properties
        public string Warna {get; set;}
        public int JumlahPintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }
        public string Suara { get; set; }
        public int Kecepatan { get; set; }


        //method
        public void Gas()
        {
            Console.WriteLine($"kecepatan { Kecepatan } Km/jam");
        }

        public void Klakson()
        {
            Console.WriteLine($"Suara Klakson {Suara}");
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, Merk {Merek}, Model {Model}, Keluaran tahun {TahunKeluaran}, dengan jumlah pintu sebanyak{JumlahPintu}");
               
        }
    }
}
