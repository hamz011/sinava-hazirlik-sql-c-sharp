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
namespace sinavHazirlik
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=sirket;");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dataTable;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comeData();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (i == 0) continue;
                else if(i==3) continue;
                else if(i==6) continue;
                else
                    combo_aramaF.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Yaş";
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Ülke";
            dataGridView1.Columns[6].HeaderText = "Maaş";

        }
        void comeData(string s = "select * from personel")
        {
            connection.Open();
            adapter = new SqlDataAdapter(s, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXT_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXT_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXT_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXT_yas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string c = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (c.ToLower() == "e")
                combo_cins.SelectedIndex = 0;
            else combo_cins.SelectedIndex = 1;
            string u = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            for (int i = 0; i < combo_ulke.Items.Count; i++)
            {
                if (u == combo_ulke.Items[i].ToString())
                {
                    combo_ulke.SelectedIndex = i;
                }
            }
            if (c == "") combo_cins.SelectedIndex = 0;
            if (u == "") combo_ulke.SelectedIndex = 0;
            TXT_maas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void TXT_id_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_id.Text)) { TXT_id.ForeColor = Color.Red; TXT_id.Clear(); }
            else TXT_id.ForeColor = Color.Black;
        }

        private void TXT_yas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_yas.Text))
            {
                TXT_yas.ForeColor = Color.Red; TXT_yas.Clear();
            }
            else TXT_yas.ForeColor = Color.Black;
        }

        private void TXT_maas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_maas.Text)) { TXT_maas.ForeColor = Color.Red; TXT_maas.Clear(); }
            else TXT_maas.ForeColor = Color.Black;
        }

        private void BUT_add_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != "" && TXT_ad.Text != "" && TXT_soyad.Text != "" && combo_cins.SelectedItem != null && combo_ulke.SelectedItem != null && TXT_yas.Text != "" && TXT_maas.Text != "")
            {
                try
                {

                    int id = Convert.ToInt32(TXT_id.Text);
                    int yas = Convert.ToInt32(TXT_yas.Text);
                    int maas = Convert.ToInt32(TXT_maas.Text);

                    string sql = "INSERT INTO personel(id,ad,soyad,yas,cinsiyet,ulke,maas) VALUES(@id,@ad,@soyad,@yas,@cins,@ulke,@maas)";
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                    cmd.Parameters.AddWithValue("@yas", yas);
                    cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@maas", TXT_maas.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Clear();
                    comeData();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (id.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            MessageBox.Show("Kayıt başarılı bir şekilde eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Hata oluştu!\nHata: " + x.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
            dataGridView1.Rows[1].Cells[1].Selected = true;
            MessageBox.Show(dataGridView1.Rows[1].Cells[0].Value.ToString());
        }
        void Clear()
        {
            TXT_id.Clear();
            TXT_ad.Clear();
            TXT_soyad.Clear();
            TXT_yas.Clear();
            combo_cins.SelectedIndex = 0;
            combo_ulke.SelectedIndex = 180;
            TXT_maas.Clear();

        }
        private void BUT_delete_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != "")
            {
                int id = Convert.ToInt32(TXT_id.Text);
                DialogResult d = MessageBox.Show(id.ToString() + " numaralı idye sahip kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "DELETE from personel where id=@id";
                        cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Clear();
                        comeData();
                        MessageBox.Show(id.ToString() + " numaralı idye sahip kayıt veritabanından silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Hata oluştu!\nHata: " + x.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                else if (d == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void combo_ulke_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BUT_update_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != "" && TXT_ad.Text != "" && TXT_soyad.Text != "" && TXT_yas.Text != "" && TXT_maas.Text != "" && combo_cins.SelectedItem != null && combo_ulke.SelectedItem != null)
            {
                try
                {

                    int id = Convert.ToInt32(TXT_id.Text), yas = Convert.ToInt32(TXT_yas.Text), maas = Convert.ToInt32(TXT_maas.Text);
                    string sql = "UPDATE personel set ad=@ad,soyad=@soyad,yas=@yas,cinsiyet=@cins,ulke=@ulke,maas=@maas where id=@id";
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                    cmd.Parameters.AddWithValue("@yas", yas);
                    cmd.Parameters.AddWithValue("@cins", combo_cins.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@maas", maas);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Clear();
                    comeData();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (id.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            MessageBox.Show("Kayıt başarılı bir şekilde güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Hata oluştu!\nHata: " + x.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXT_arama_TextChanged(object sender, EventArgs e)
        {
            if (TXT_arama.Text != "")
            {
                string   fi = combo_aramaF.SelectedItem.ToString() + " LIKE '" + TXT_arama.Text + "%'";
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = fi;
                dataGridView1.DataSource = dv;
            }
            else
            {
                comeData();
            }
        }
    }
}
