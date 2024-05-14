#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
#endregion
#region NAMESPACE
namespace sinav_hazirlik3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ATAMALAR
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=sirket");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dataT;
        #endregion
        #region Functions
        bool SayiMi(string text)
        {
            foreach (var chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        void ComeData(string s = "select * from personel")
        {
            dataT = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter(s, connection);
            adapter.Fill(dataT);
            dataGridView1.DataSource = dataT;
            connection.Close();
        }
        void clearAll()
        {
            TXT_id.Clear();
            TXT_ad.Clear(); TXT_soyad.Clear();
            TXT_yas.Clear(); TXT_maas.Clear(); combo_cins.SelectedIndex = 0; combo_ulke.SelectedIndex = 0;
        }
        #endregion
        #region FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            ComeData();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i == 0) continue;
                else if(i==3) continue;
                else if(i==6) continue;
                combo_aramaF.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
        #region Events
        private void TXT_id_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_id.Text))
            {
                TXT_id.Clear();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TXT_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TXT_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TXT_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TXT_yas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string c = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                combo_cins.SelectedIndex = combo_cins.Items.IndexOf(c);
                string u = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                combo_ulke.SelectedIndex = combo_ulke.Items.IndexOf(u);
                TXT_maas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void TXT_arama_TextChanged(object sender, EventArgs e)
        {
            if (TXT_arama.Text.Length > 0 && TXT_arama.Text != " ")
            {
                DataView dv = new DataView();
                dv = dataT.DefaultView;
                dv.RowFilter = combo_aramaF.SelectedItem + " LIKE '" + TXT_arama.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else ComeData();
        }

        private void combo_aramaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TXT_arama.Text != null && TXT_arama.Text != "") TXT_arama.Clear();
        }
        private void TXT_yas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_yas.Text))
            {
                TXT_yas.Clear();
            }
        }

        private void TXT_maas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_maas.Text))
            {
                TXT_maas.Clear();
            }
        }
        #endregion
        #region ADD
        private void BUT_add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TXT_id.Text), yas = int.Parse(TXT_yas.Text), maas = int.Parse(TXT_maas.Text);
                string sql = "INSERT INTO personel (id,ad,soyad,yas,cinsiyet,ulke,maas) VALUES (@id,@ad,@soyad,@yas,@cins,@ulke,@maas) ";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                cmd.Parameters.AddWithValue("@yas", yas);
                cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem);
                cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem);
                cmd.Parameters.AddWithValue("@maas", maas);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                clearAll(); ComeData();
                MessageBox.Show("New Data add successfully!");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        #endregion
        #region DELETE
        private void BUT_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = 0;
                    string sql = "DELETE personel where id=@id";
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    clearAll(); ComeData();
                    MessageBox.Show("Data deleted successfully!");
                }
                else
                    MessageBox.Show("Lütfen silinecek kaydı seçiniz!");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        #endregion
        #region UPDATE

        private void BUT_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TXT_id.Text), yas = int.Parse(TXT_yas.Text), maas = int.Parse(TXT_maas.Text);
                string sql = "UPDATE personel set ad=@ad,soyad=@soyad,yas=@yas,cinsiyet=@cins,ulke=@ulke,maas=@maas where id=@id";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                cmd.Parameters.AddWithValue("@yas", yas);
                cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem);
                cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem);
                cmd.Parameters.AddWithValue("@maas", maas);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                clearAll(); ComeData();
                MessageBox.Show("Data updated successfully!");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        #endregion
    }
}
#endregion
