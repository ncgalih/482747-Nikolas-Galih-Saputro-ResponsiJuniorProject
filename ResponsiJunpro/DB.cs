using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ResponsiJunpro
{
    internal class DB
    {
        public static string ConnString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;database=ResponsiJunpro";
        public static NpgsqlConnection Conn = new NpgsqlConnection(ConnString);

        public static DataTable GetKaryawan()
        {
            DataTable data = new DataTable();
            try
            {
                Conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "SELECT * FROM karyawan INNER JOIN departemen ON karyawan.id_dep = departemen.id_dep";
                NpgsqlDataReader reader = cmd.ExecuteReader();
                data.Load(reader);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally 
            {
                Conn.Close(); 
            }
            return data;
        }
        public static bool InsertKaryawan(Karyawan karyawan)
        {
            bool status = false;
            try
            {
                Conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "insert into karyawan (nama, id_dep) values (@nama, @id_dep)";
                cmd.Parameters.AddWithValue("@nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@id_dep", karyawan.Departemen);
                if (cmd.ExecuteNonQuery() == 1)
                    status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally 
            { 
                Conn.Close(); 
            }
            return status;
        }
        public static bool DeleteKaryawan(int id)
        {
            bool status = false;
            try
            {
                Conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "delete from karyawan where id_karyawan = @id";
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteNonQuery() == 1)
                    status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return status;
        }
        public static bool EditKaryawan(Karyawan karyawan)
        {
            bool status = false;
            try
            {
                Conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "update karyawan set nama=@nama, id_dep=@id_dep where id_karyawan = @id";
                cmd.Parameters.AddWithValue("@nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@id_dep", karyawan.Departemen);
                cmd.Parameters.AddWithValue("@id", karyawan.ID);
                if (cmd.ExecuteNonQuery() == 1)
                    status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return status;
        }
    }
}
