using System.Data;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        Karyawan editKaryawan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable data = DB.GetKaryawan();
            dgvKaryawan.DataSource = data;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Karyawan karyawan = new Karyawan()
            {
                Nama = tbKaryawan.Text,
                Departemen = tbDepartemen.Text,
            };
            if (DB.InsertKaryawan(karyawan))
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dgvKaryawan.CurrentRow.Cells["id_karyawan"].Value);
            if (DB.DeleteKaryawan(id))
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Karyawan karyawan = new Karyawan()
            {
                ID = Convert.ToInt16(dgvKaryawan.CurrentRow.Cells["id_karyawan"].Value),
                Nama = dgvKaryawan.CurrentRow.Cells["nama"].Value.ToString(),
                Departemen = dgvKaryawan.CurrentRow.Cells["id_dep"].Value.ToString()
            };
            editKaryawan = karyawan;
            tbKaryawan.Text = karyawan.Nama;
            tbDepartemen.Text = karyawan.Departemen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editKaryawan.Nama = tbKaryawan.Text;
            editKaryawan.Departemen = tbDepartemen.Text;
            if (DB.EditKaryawan(editKaryawan))
            {
                LoadData();
            }
        }
    }
}