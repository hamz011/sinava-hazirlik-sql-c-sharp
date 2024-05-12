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
namespace sinav_hazirlik1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=sirket;");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dataTable;
        void comeData(string s = "select * from personel")
        {
            connection.Open();
            adapter = new SqlDataAdapter(s, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        void clean()
        {
            TXT_id.Clear();
            TXT_ad.Clear();
            TXT_soyad.Clear();
            TXT_yas.Clear();
            TXT_maas.Clear();
            TXT_arama.Clear();
            combo_cins.SelectedIndex = 0;
            combo_ulke.SelectedIndex = 0;
            combo_aramaF.SelectedIndex = 0;
        }

        bool SayiMi(string txt)
        {
            foreach (char text in txt)
            {
                if (!Char.IsNumber(text)) return false;
            }
            return true;
        }
        #region ADD
        private void BUT_add_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != string.Empty && TXT_ad.Text != string.Empty && TXT_soyad.Text != string.Empty && TXT_yas.Text != string.Empty && TXT_maas.Text != string.Empty && combo_cins.SelectedItem != null && combo_ulke.SelectedItem != null)
            {
                int id = int.Parse(TXT_id.Text);
                //bool isIn = false;
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    if (dataGridView1.Rows[i].Cells[0].Value.ToString()== id.ToString())
                //    {
                //        MessageBox.Show("Test");
                //        isIn = true;
                //        break;
                //    }
                //    else continue;
                //}


                try
                {
                    int yas = int.Parse(TXT_yas.Text);
                    int maas = int.Parse(TXT_maas.Text);

                    string sql = "INSERT INTO personel (id,ad,soyad,yas,cinsiyet,ulke,maas)" +
                        " VALUES(@id,@ad,@soyad,@yas,@cinsiyet,@ulke,@maas)";
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ad", TXT_ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", TXT_soyad.Text);
                    cmd.Parameters.AddWithValue("@yas", yas);
                    cmd.Parameters.AddWithValue("@cinsiyet", combo_cins.SelectedItem);
                    cmd.Parameters.AddWithValue("@ulke", combo_ulke.SelectedItem);
                    cmd.Parameters.AddWithValue("@maas", maas);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    clean();
                    comeData();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id.ToString())
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            MessageBox.Show("New ID add sucsessfully!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        else continue;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region DELETE
        private void BUT_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                DialogResult d;
                if (dataGridView1.SelectedRows.Count == 1)
                    d = MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else
                    d = MessageBox.Show("Kayıtları silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {

                    try
                    {

                        int id = 0;
                        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        {
                            id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                            string sql = "DELETE personel where id=@id";
                            cmd = new SqlCommand(sql, connection);
                            cmd.Parameters.AddWithValue("@id", id);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            clean();
                            continue;
                        }
                        comeData();
                        MessageBox.Show("Deleted sucsesfully", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
                else
                    MessageBox.Show("Kayıt silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Lütfen silinecek kayıt veya kayıtları seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region UPDATE
        private void BUT_update_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != string.Empty && TXT_ad.Text != string.Empty && TXT_soyad.Text != string.Empty && TXT_yas.Text != string.Empty && TXT_maas.Text != string.Empty && combo_cins.SelectedItem != null && combo_ulke.SelectedItem != null)
            {

                try
                {
                    int id = int.Parse(TXT_id.Text);
                    int yas = int.Parse(TXT_yas.Text);
                    int maas = int.Parse(TXT_maas.Text);

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
                    clean(); comeData();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id.ToString())
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            MessageBox.Show("Update sucsessfully", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        else continue;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        private void TXT_arama_TextChanged(object sender, EventArgs e)
        {
            if (TXT_arama.Text != string.Empty)
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = combo_aramaF.SelectedItem.ToString() + " LIKE '" + TXT_arama.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else comeData();
        }

        private void TXT_id_TextChanged(object sender, EventArgs e)
        {
            bool isIn = false;
            string enteredId = TXT_id.Text.Trim();

            if (!string.IsNullOrEmpty(enteredId))
            {
                if (!SayiMi(enteredId))
                {

                    TXT_id.Clear();
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null &&
                            dataGridView1.Rows[i].Cells[0].Value.ToString() == enteredId)
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


        private void Form2_Load(object sender, EventArgs e)
        {
            TXT_id.Text = "1";
            TXT_id.Select(); TXT_id.Clear();


            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                ;

            comeData();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (i == 0) continue;
                else if (i == 3) continue;
                else if (i == 6) continue;
                else
                    combo_aramaF.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            clean();


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
            if (e.KeyCode == Keys.Enter) MessageBox.Show("Merhaba ben enter", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private void TXT_maas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_maas.Text)) TXT_maas.Clear();
        }

        private void TXT_yas_TextChanged(object sender, EventArgs e)
        {
            if (!SayiMi(TXT_yas.Text)) TXT_yas.Clear();
        }

        private void combo_aramaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TXT_arama.Text != string.Empty) TXT_arama.Clear();
        }

        private void BUT_add_EnabledChanged(object sender, EventArgs e)
        {
            if (!BUT_add.Enabled)
            {
                BUT_add.BackColor = Color.LightGray;
                TXT_arama.Enabled = TXT_arama.Enabled = true;
                combo_aramaF.Enabled = true;
            }

            else
            {
                TXT_arama.Enabled = false;
                combo_aramaF.Enabled = false;
                BUT_add.BackColor = Color.White;
            }



        }

        private void TXT_arama_EnabledChanged(object sender, EventArgs e)
        {
            if (!TXT_arama.Enabled) TXT_arama.Clear();



        }

        private void BUT_delete_EnabledChanged(object sender, EventArgs e)
        {
            if (!BUT_delete.Enabled)
                BUT_delete.BackColor = Color.LightGray;

            else
                BUT_delete.BackColor = Color.White;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TXT_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TXT_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TXT_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TXT_yas.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string c = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                combo_cins.SelectedIndex = c.ToLower() == "e" ? 0 : 1;

                string ulke = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                combo_ulke.SelectedIndex = combo_ulke.Items.IndexOf(ulke);

                TXT_maas.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                TXT_arama.Enabled = false;
                combo_aramaF.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedRows.Count.ToString());
        }
    }
}
