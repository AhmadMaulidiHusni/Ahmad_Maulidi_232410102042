using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobilSedan Mobil1 = new MobilSedan("Toyota", "Supra", "Hitam", 2500);
            MobilSedan Mobil2 = new MobilSedan("Honda", "Civic Turbo", "Merah", 2000);

            Ikan ikan1 = new Ikan("Gurame", "Air Tawar", "Kuning Kemerahan");
            Ikan ikan2 = new Ikan("Salmon", "Air Laut", "Orange");

            Burung burung1 = new Burung("Burung Hantu", "Coklat", "Bengkok Tajam");
            Burung burung2 = new Burung("Burung Merpati", "Putih", "Kecil Lancip");

            Komputer komputer1 = new Komputer("Laptop", "Lenovo", 2022);
            Komputer komputer2 = new Komputer("Tablet", "Samsung", 2023);

            Console.WriteLine($"Merk Mobil : {Mobil1.merk_mobil } \nNama Mobil : {Mobil1.nama_mobil} \nKapasitas Mesin : {Mobil1.kapasitas_mesin} Cc");
            Console.WriteLine();
            Console.WriteLine($"Merk Mobil : {Mobil2.merk_mobil} \nNama Mobil : {Mobil2.nama_mobil} \nKapasitas Mesin : {Mobil2.kapasitas_mesin} Cc");
            Console.WriteLine();
            Console.WriteLine($"Nama Ikan : {ikan1.nama_ikan} \nJenis Air : {ikan1.jenis_air} \nWarna Daging : {ikan1.warna_daging}");
            Console.WriteLine();
            Console.WriteLine($"Nama Ikan : {ikan2.nama_ikan} \nJenis Air : {ikan2.jenis_air} \nWarna Daging : {ikan2.warna_daging}");
            Console.WriteLine();
            Console.WriteLine($"Nama Burung : {burung1.nama_burung} \nWarna Kulit : {burung1.warna_burung} \nBentuk Paruh : {burung1.paruh_burung}");
            Console.WriteLine();
            Console.WriteLine($"Nama Burung : {burung2.nama_burung} \nWarna Kulit : {burung2.warna_burung} \nBentuk Paruh : {burung2.paruh_burung}");
            Console.WriteLine();
            Console.WriteLine($"Jenis Komputer : {komputer1.jenis_komputer} \nMerk Laptop : {komputer1.nama_komputer} \nTahun Rilis : {komputer1.tahun_rilis}");
            Console.WriteLine();
            Console.WriteLine($"Jenis Komputer : {komputer2.jenis_komputer} \nMerk Tablet : {komputer2.nama_komputer} \nTahun Rilis : {komputer2.tahun_rilis}");
        }
    }
}
