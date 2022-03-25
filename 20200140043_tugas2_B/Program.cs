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

                SqlCommand cm = new SqlCommand("Insert Into pegawai(Id_pegawai,Nama_pegawai,noHp,jenis_kelamin,alamat)VALUES ('00001','Aldy','087720302716','L','Pekalongan')", cn);
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
