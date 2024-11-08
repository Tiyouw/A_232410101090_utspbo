using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_PBO.App.Context
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBarangForm addMahasiswaForm = new AddBarangForm();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        private void LoadDataBarang()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                DataTable barangData = BarangContext.All();
                if (barangData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                dataGridView1.Columns.Clear();
                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);
                dataGridView1.DataSource = barangData;

                if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["nama_barang"] != null)
                    dataGridView1.Columns["nama_barang"].HeaderText = "Nama Barang";
                if (dataGridView1.Columns["kategori"] != null)
                    dataGridView1.Columns["kategori"].HeaderText = "Kategori";
                if (dataGridView1.Columns["jumlah"] != null)
                    dataGridView1.Columns["jumlah"].HeaderText = "Stok";
                if (dataGridView1.Columns["harga"] != null)
                    dataGridView1.Columns["harga"].HeaderText = "Harga";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);
            }
        }
    }
}




