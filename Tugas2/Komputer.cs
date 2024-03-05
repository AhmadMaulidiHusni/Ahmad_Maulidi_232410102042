using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tugas2;
    internal class Komputer
    {
        public string jenis_komputer;
        public string nama_komputer;
        public int tahun_rilis;

        public Komputer(string jenis_komputer, string nama_komputer, int tahun_rilis)
        {
            this.jenis_komputer = jenis_komputer;
            this.nama_komputer = nama_komputer;
            this.tahun_rilis = tahun_rilis;
        }
    }
