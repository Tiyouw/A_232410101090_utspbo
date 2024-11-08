using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Model
{
    public class M_Barang
    {
            [Key]
            public int id { get; set; }
            [Required]
            public string nama_barang { get; set; }
            [Required]
            public string kategori { get; set; }
            [Required]
            public int jumlah { get; set; } 
            [Required]
            public int harga { get; set; }
        }
    }
