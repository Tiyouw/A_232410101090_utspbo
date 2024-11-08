using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.App.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTS_PBO.View
{
    public partial class AddBarangForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int MahasiswaId { get; set; }

        public AddBarangForm()
        {
            InitializeComponent();
            //UpdateButtonText();
            //LoadBarangData();

        }
    }
}
//        private void buttonAdd_Click(object sender, EventArgs e)
//        {
//            if (!ValidateInput())
//            {
//                MessageBox.Show("Inputan tidak valid");
//                return;
//            }
//            M_Barang mahasiswa = new M_Barang
//            {
//                nama_barang = textBox1.Text,
//                kategori = textBox2.Text,
//                jumlah = int.Parse(textBox3.Text),
//                harga = int.Parse(textBox4.Text),
//            };

//        private bool ValidateInput()
//        {
//            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
//            string.IsNullOrWhiteSpace(textBox2.Text) ||
//            string.IsNullOrWhiteSpace(textBox3.Text) ||
//            !int.TryParse(textBox4.Text, out _))
//            {
//                return false;
//            }
//            return true;
//        }
//        private void AddBarangForm_Load(object sender, EventArgs e)
//        {

//        }
//}
