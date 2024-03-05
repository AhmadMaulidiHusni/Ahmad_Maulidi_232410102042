using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2
{
    internal class MobilSedan
    {
        public string merk_mobil;
        public string nama_mobil;
        public string warna_mobil;
        public int kapasitas_mesin;
        public MobilSedan(string merk_mobil, string nama_mobil, string warna_mobil, int kapasitas_mesin)
        {
            this.merk_mobil = merk_mobil;
            this.nama_mobil = nama_mobil;
            this.warna_mobil = warna_mobil;
            this.kapasitas_mesin = kapasitas_mesin;
        }
    }
}
