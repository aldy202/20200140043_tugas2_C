using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140043_tugas2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection("data source=MEGANE\\ALDYAHMADFAUZI;database=aldyahmadfauzi;Integrated Security = TRUE");
                cn.Open();

                SqlCommand cm = new SqlCommand("Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00001','Aldy','087720302716','L','Pekalongan')" +
                    "Insert Into pegawai(Id_pegawai, Nama_pegawai, noHp, jenis_kelamin, alamat)VALUES('00002','ahmad', '087720302718', 'L', 'sleman')"+
                    "Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00003','Fauzi','087720302723','L','Yogyakarta')"+
                    "Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00004','Wanti','087720302342','P','Bantul')"+ 
                    "Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00005','sakrina','087720302345','P','Kasihan')"+
                    "Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00006','murti','087720302743','P','Yogyakarta')"+
                    "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('10000','Fatika')"+ "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('20000','hilmi')"+
                    "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('30000','alya')"+ "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('40000','Ican')"+ "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('50000','bahrul')"+
                    "Insert Into pembeli(Nomer_pembeli,Nama_pembeli)Values('60000','semesta')"+"Insert Into transaksi(Id_transaksi,tanggal_transaksi,Harga_Total)values('11001','2022-02-24','Rp15000')"+ "Insert Into transaksi(Id_transaksi,tanggal_transaksi,Harga_Total)values('11002','2022-02-26','Rp10000')"+
                    "Insert Into transaksi(Id_transaksi,tanggal_transaksi,Harga_Total)values('11003','2022-02-28','Rp15000')"+ "Insert Into transaksi(Id_transaksi,tanggal_transaksi,Harga_Total)values('11004','2022-02-22','Rp15000')"+
                    "Insert Into transaksi(Id_transaksi,tanggal_transaksi,Harga_Total)values('11005','2022-02-29','Rp14000')"+
                    "Insert into kue(kode_kue,Nama_kue,Harga_kue,tanggal_kadaluwarsa)values('KU800','Brownis','Rp250000','2022-02-22')"+ 
                    "Insert into kue(kode_kue,Nama_kue,Harga_kue,tanggal_kadaluwarsa)values('KU900','Bakpia','Rp300000','2023-07-23')"+
                    "Insert into kue(kode_kue,Nama_kue,Harga_kue,tanggal_kadaluwarsa)values('KU440','BikaAmbon','Rp270000','2023-06-23')"+
                    "Insert into kue(kode_kue,Nama_kue,Harga_kue,tanggal_kadaluwarsa)values('KU450','Donat','Rp230000','2023-05-23')" +
                    "Insert into kue(kode_kue,Nama_kue,Harga_kue,tanggal_kadaluwarsa)values('KU550','Kuemanis','Rp210000','2023-07-23')"+
                    "insert into finish_kue(Id_pegawai,kode_kue,tanggal_finish)values('00001','KU800','2022-07-23')" +
                    "insert into finish_kue(Id_pegawai,kode_kue,tanggal_finish)values('00002','KU900','2022-08-23')" +
                    "insert into finish_kue(Id_pegawai,kode_kue,tanggal_finish)values('00003','KU440','2022-09-23')" +
                    "insert into finish_kue(Id_pegawai,kode_kue,tanggal_finish)values('00004','KU450','2022-11-23')" +
                    "insert into finish_kue(Id_pegawai,kode_kue,tanggal_finish)values('00005','KU550','2022-12-23')" +
                    "insert into beli_kue(kode_kue,nomer_pembelian,jumlah_beli,Sub_total)values('KU800', '10000', '3', '90000'),('KU900', '20000', '2', '60000'),('KU440', '30000', '2', '60000'),('KU450', '40000', '4', '120000'),('KU550', '50000', '2', '60000')"+
                    "insert into detail_transaksi(nomer_pembeli,jenis_pembayaran)values('10000','TUNAI'), ('20000','TUNAI'),('30000','TUNAI'),('40000','TUNAI'),('50000','TUNAI')", cn);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();


            }catch(Exception e)
            {
                Console.WriteLine("Gagal menambahkan data " + e);
                //Console.ReadKey();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
