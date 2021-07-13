using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        public static string Nim { get; private set; }

        static void Main(string[] args)
        {



            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine{ "Pilih Menu Aplikasi : "};
            Console.WriteLine();
            Console.WriteLine{ "1.Tambah Mahasiswa"};
            Console.WriteLine{ "2.Hapus Mahasiswa"};
            Console.WriteLine{ "3.Tampilkan Mahasiswa"};
            Console.WriteLine{ "4.Keluar"};
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();

            Mahasiswa mhs = new Mahasiswa();
            Console.Write("Nim                                 : ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nama                                : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]                 : ");
            mhs.Kelamin = Console.ReadLine();
            if (mhs.Kelamin == "L")
            {
                mhs.Kelamin = "Laki-Laki";
            }
            else if (mhs.Kelamin == "P")
            {
                mhs.Kelamin = "Perempuan";
            }
            Console.Write("Ipk : ");
            mhs.Ipk = double.Parse(Console.ReadLine());

        }
        Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

    static void HapusMahasiswa()
    {
        Console.Clear();

        Console.WriteLine("Hapus Data Mahasiswa\n");
        Console.Write("Nim : ");
        string nim = Console.ReadLine();

        Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.Nim == nim);
        if (daftarMahasiswa.Contains(delete) == true)
        {
            daftarMahasiswa.Remove(delete);
            Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
        }
        else
        {
            Console.WriteLine("NIM Tidak Ditemukan");
        }
        Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
        Console.ReadKey();
    }

    static void TampilMahasiswa()
    {
        Console.Clear();
        Console.WriteLine("Data Mahasiswa\n");
        int no = 1;

        Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
        foreach (Mahasiswa mahasiswa in daftarMahasiswa)
        {
            Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.Nim, mahasiswa.Nama, mahasiswa.Kelamin, mahasiswa.Ipk);
            no++;
        }

        Console.WriteLine();
        Console.Write("Tekan enter untuk keluar. . .");

        Console.WriteLine("\nTekan enter untuk kembali ke menu");
        Console.ReadKey();
    }
}
}
