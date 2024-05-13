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

namespace sinav_hazirlik_basit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=sirket");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dataTable;

        //Function Clear
        //********************************************************
        void Clear()
        {
            TXT_ad.Clear(); TXT_id.Clear(); TXT_maas.Clear(); TXT_soyad.Clear();
            TXT_yas.Clear(); combo_cins.SelectedIndex = 0; combo_ulke.SelectedIndex = 180;
        }
        //********************************************************

        //Function ComeData
        //********************************************************
        void ComeData(string sql = "select * from personel")
        {
            try
            {

                connection.Open();
                dataTable = new DataTable();
                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu!\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
        //********************************************************

        //Funktion Sayimi
        //********************************************************
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        //********************************************************

        //Ekleme
        //********************************************************
        private void BUT_add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TXT_id.Text), yas = int.Parse(TXT_yas.Text), maas = int.Parse(TXT_maas.Text);

                string sql = "INSERT INTO personel (id,ad,soyad,yas,cinsiyet,ulke,maas)" +
                    " VALUES (@id,@ad,@soyad,@yas,@cins,@ulke,@maas)";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                cmd.Parameters.AddWithValue("@yas", TXT_yas.Text);
                cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem);
                cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem);
                cmd.Parameters.AddWithValue("@maas", TXT_maas.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Clear(); ComeData();
                MessageBox.Show("New Data added!");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //********************************************************

        //Silme
        //********************************************************
        private void BUT_delete_Click(object sender, EventArgs e)

        {
            try
            {
                //int id = int.Parse(TXT_id.Text), yas = int.Parse(TXT_yas.Text), maas = int.Parse(TXT_maas.Text);
                int id = 0;
                string sql = "DELETE personel where id=@id";
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        MessageBox.Show("id: " + id.ToString());
                        cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    Clear(); ComeData();
                    MessageBox.Show("Deleted sucsessfully!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //********************************************************

        //Güncelle
        //********************************************************
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
                cmd.Parameters.AddWithValue("@yas", TXT_yas.Text);
                cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem);
                cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem);
                cmd.Parameters.AddWithValue("@maas", TXT_maas.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Clear(); ComeData();
                MessageBox.Show("Update Sucsessfully!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //********************************************************


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


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Veri Tabanı Işlemleri";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ComeData();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i == 0) continue;
                else if (i == 3) continue;
                else if (i == 6) continue;

                combo_aramaF.Items.Add(dataGridView1.Columns[i].HeaderText);
            }

        }


        private void TXT_id_TextChanged(object sender, EventArgs e)
        {
            bool isIn = false;
            string id = TXT_id.Text.Trim();
            if (!string.IsNullOrEmpty(id))
            {
                if (!SayiMi(id))
                {
                    TXT_id.Clear();
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value.ToString() == id)
                        {
                            isIn = true;
                            break;
                        }
                    }
                    BUT_add.Enabled = !isIn;
                    BUT_delete.Enabled = isIn;
                }
            }
            else
            {
                BUT_add.Enabled = false;
                BUT_delete.Enabled = true;
            }

        }

        private void TXT_yas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_yas.Text))
            {
                TXT_yas.Clear();
                TXT_yas.Enabled = false;
            }
            else
                TXT_yas.Enabled = true;
        }

        private void TXT_maas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_maas.Text))
            {
                TXT_maas.Clear();
                TXT_maas.Enabled = false;
            }
            else
                TXT_maas.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TXT_arama_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_arama.Text))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = combo_aramaF.SelectedItem.ToString() + " LIKE '" + TXT_arama.Text + "%' ";
                dataGridView1.DataSource = dv;
            }
            else
                ComeData();
        }

        //private void BUT_delete_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (BUT_delete.Enabled)
        //        BUT_delete.BackColor = Color.LightGray;

        //    else
        //        BUT_delete.BackColor = Color.White;
        //}
        //private void BUT_add_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (BUT_add.Enabled)
        //    {
        //        BUT_add.BackColor = Color.LightGray;
        //        TXT_arama.Enabled =true;
        //        combo_aramaF.Enabled = true;
        //    }

        //    else
        //    {
        //        TXT_arama.Enabled = false;
        //        combo_aramaF.Enabled = false;
        //        BUT_add.BackColor = Color.White;
        //    }
        //}
    }
}
