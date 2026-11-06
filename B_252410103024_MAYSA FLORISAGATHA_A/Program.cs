using System;
using System.Collections.Generic;

namespace utspbo
{
    class Sekolah
    {
        public string idSekolah;
        public string namaSekolah;
        public int jumlahPaketDiterima;

        public Sekolah(string idsekolah, string namasekolah, int jumlahpaketditerima)
        {
            idSekolah = idsekolah;
            namaSekolah = namasekolah;
            jumlahPaketDiterima = jumlahpaketditerima;

        }
        public void TampilInfo()
        {
            Console.WriteLine($"ID SEKOLAH : {idSekolah}, NAMA SEKOLAH : {namaSekolah}, JUMLAH PAKET DITERIMA : {jumlahPaketDiterima}.");
        }

    }

    abstract class PaketMBG
    {
        private string idPaket { get; set; }
        private string namaPaket { get; set; }
        private int stokDapur { get; set; }

        public PaketMBG(string idpaket, string namapaket, int stokdapur)
        {
            idPaket = idpaket;
            namaPaket = namapaket;
            stokDapur = stokdapur;
        }
        private List<PaketMBG> DaftarPaket = new List<PaketMBG>();

        public void KurangiStok(int jumlah) { }
        public abstract double HitungBiaya(int jumlah);
    }

    class PaketReguler : PaketMBG
    {
        public double harga;

        public PaketReguler(string idpaket, string namapaket, int stokdapur) : base(idpaket, namapaket, stokdapur)
        {
        }

        public PaketReguler(string idPaket, string namaPaket, int stokDapur, double harga) :base(idPaket, namaPaket, stokDapur)
        {
            harga = harga;
            idPaket = idPaket;
            namaPaket = namaPaket;
            stokDapur = stokDapur;

        }
        public override double HitungBiaya(int jumlah)
        {
            return jumlah * 15000;
        }   
        public void isi()
        {
            Console.WriteLine($"nasi, ayam, sayur, dan buah");
        }

    }

    class PaketKhusus : PaketMBG
    {
        public double harga = 20000;
        public string jenisDiet;
        private string v;

        public PaketKhusus(string idpaket, string namapaket, int stokdapur, string v) : base(idpaket, namapaket, stokdapur)
        {
            this.v = v;
        }

        public PaketKhusus(string idPaket, string namaPaket, int stokDapur, double harga, string jenisDiet) : base(idPaket, namaPaket, stokDapur)
        {
            harga = harga;
            jenisDiet = jenisDiet;
            idPaket = idPaket;
            namaPaket = namaPaket;
            stokDapur = stokDapur;
        }

        public override double HitungBiaya(int jumlah)
        {
            return jumlah * 20000;
        }
    }

   

   class program
   {
        public void main(string[] args)
        {
            Sekolah sekolah1 = new Sekolah("1", "SD 1 JEMBER", 10);
            Sekolah sekolah2 = new Sekolah("2", "SMP 2 JEMBER", 15);

            PaketReguler reguler = new PaketReguler("PKT-REG", "paket nasi ayam, sayur, buah", 100);
            PaketKhusus khusus = new PaketKhusus("PKT-KHS", "Paket Bebas Gluten", 50, "Bebas Gluten");
            sekolah1.TampilInfo();
            sekolah2.TampilInfo();
        }

   }
}
