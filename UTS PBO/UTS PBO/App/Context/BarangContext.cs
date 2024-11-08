using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Core
{
    internal class BarangContext : DatabaseWrapper
    {
         private static string table = "mahasiswa";
                public static DataTable All()
                {
                    string query = @"
                             SELECT
                             m.id,
                             m.nama_barang,
                             m.kategori,
                             m.jumlah,
                             m.harga,
                             m.id_prodi,
                             p.nama_prodi";
                                        DataTable dataMahasiswa = queryExecutor(query);
                                        return dataMahasiswa;
                }
                public static DataTable getBarangById(int id)
                {
            string query = @"
                         SELECT
                        m.id,
                        m.nama_barang,
                        m.kategori,
                        m.jumlah,
                        m.harga,";
                                    NpgsqlParameter[] parameters =
                                    {
                         new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
                         };
                                    DataTable dataMahasiswa = queryExecutor(query, parameters);
                                    return dataMahasiswa;
                                }


    }

}
