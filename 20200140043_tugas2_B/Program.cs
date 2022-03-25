using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140043_tugas2_B
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
                    "Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00006','murti','087720302743','P','Yogyakarta')", cn);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();


            }catch(Exception e)
            {
                Console.WriteLine("Gagal menambahkan data " + e);
                Console.ReadKey();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
