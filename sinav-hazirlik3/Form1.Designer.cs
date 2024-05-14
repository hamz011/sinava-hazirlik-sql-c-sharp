
namespace sinav_hazirlik3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_id = new System.Windows.Forms.TextBox();
            this.TXT_ad = new System.Windows.Forms.TextBox();
            this.TXT_soyad = new System.Windows.Forms.TextBox();
            this.TXT_yas = new System.Windows.Forms.TextBox();
            this.TXT_maas = new System.Windows.Forms.TextBox();
            this.TXT_arama = new System.Windows.Forms.TextBox();
            this.combo_cins = new System.Windows.Forms.ComboBox();
            this.combo_ulke = new System.Windows.Forms.ComboBox();
            this.combo_aramaF = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BUT_add = new System.Windows.Forms.Button();
            this.BUT_delete = new System.Windows.Forms.Button();
            this.BUT_update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUT_update);
            this.groupBox1.Controls.Add(this.BUT_delete);
            this.groupBox1.Controls.Add(this.BUT_add);
            this.groupBox1.Controls.Add(this.combo_ulke);
            this.groupBox1.Controls.Add(this.combo_cins);
            this.groupBox1.Controls.Add(this.TXT_maas);
            this.groupBox1.Controls.Add(this.TXT_yas);
            this.groupBox1.Controls.Add(this.TXT_soyad);
            this.groupBox1.Controls.Add(this.TXT_ad);
            this.groupBox1.Controls.Add(this.TXT_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ülke:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maaş:";
            // 
            // TXT_id
            // 
            this.TXT_id.Location = new System.Drawing.Point(92, 28);
            this.TXT_id.Name = "TXT_id";
            this.TXT_id.Size = new System.Drawing.Size(87, 26);
            this.TXT_id.TabIndex = 7;
            this.TXT_id.TextChanged += new System.EventHandler(this.TXT_id_TextChanged);
            // 
            // TXT_ad
            // 
            this.TXT_ad.Location = new System.Drawing.Point(92, 64);
            this.TXT_ad.Name = "TXT_ad";
            this.TXT_ad.Size = new System.Drawing.Size(169, 26);
            this.TXT_ad.TabIndex = 8;
            // 
            // TXT_soyad
            // 
            this.TXT_soyad.Location = new System.Drawing.Point(92, 100);
            this.TXT_soyad.Name = "TXT_soyad";
            this.TXT_soyad.Size = new System.Drawing.Size(169, 26);
            this.TXT_soyad.TabIndex = 9;
            // 
            // TXT_yas
            // 
            this.TXT_yas.Location = new System.Drawing.Point(92, 136);
            this.TXT_yas.Name = "TXT_yas";
            this.TXT_yas.Size = new System.Drawing.Size(87, 26);
            this.TXT_yas.TabIndex = 10;
            this.TXT_yas.TextChanged += new System.EventHandler(this.TXT_yas_TextChanged);
            // 
            // TXT_maas
            // 
            this.TXT_maas.Location = new System.Drawing.Point(92, 244);
            this.TXT_maas.Name = "TXT_maas";
            this.TXT_maas.Size = new System.Drawing.Size(129, 26);
            this.TXT_maas.TabIndex = 11;
            this.TXT_maas.TextChanged += new System.EventHandler(this.TXT_maas_TextChanged);
            // 
            // TXT_arama
            // 
            this.TXT_arama.Location = new System.Drawing.Point(11, 70);
            this.TXT_arama.Name = "TXT_arama";
            this.TXT_arama.Size = new System.Drawing.Size(217, 26);
            this.TXT_arama.TabIndex = 12;
            this.TXT_arama.TextChanged += new System.EventHandler(this.TXT_arama_TextChanged);
            // 
            // combo_cins
            // 
            this.combo_cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cins.FormattingEnabled = true;
            this.combo_cins.Items.AddRange(new object[] {
            "E",
            "K"});
            this.combo_cins.Location = new System.Drawing.Point(92, 172);
            this.combo_cins.Name = "combo_cins";
            this.combo_cins.Size = new System.Drawing.Size(87, 27);
            this.combo_cins.TabIndex = 12;
            // 
            // combo_ulke
            // 
            this.combo_ulke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ulke.FormattingEnabled = true;
            this.combo_ulke.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City (Holy See)",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.combo_ulke.Location = new System.Drawing.Point(92, 207);
            this.combo_ulke.Name = "combo_ulke";
            this.combo_ulke.Size = new System.Drawing.Size(169, 27);
            this.combo_ulke.TabIndex = 13;
            // 
            // combo_aramaF
            // 
            this.combo_aramaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_aramaF.FormattingEnabled = true;
            this.combo_aramaF.Location = new System.Drawing.Point(11, 25);
            this.combo_aramaF.Name = "combo_aramaF";
            this.combo_aramaF.Size = new System.Drawing.Size(217, 27);
            this.combo_aramaF.TabIndex = 14;
            this.combo_aramaF.SelectedIndexChanged += new System.EventHandler(this.combo_aramaF_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(425, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 461);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BUT_add
            // 
            this.BUT_add.ForeColor = System.Drawing.Color.Black;
            this.BUT_add.Location = new System.Drawing.Point(266, 40);
            this.BUT_add.Name = "BUT_add";
            this.BUT_add.Size = new System.Drawing.Size(125, 63);
            this.BUT_add.TabIndex = 14;
            this.BUT_add.Text = "Add";
            this.BUT_add.UseVisualStyleBackColor = true;
            this.BUT_add.Click += new System.EventHandler(this.BUT_add_Click);
            // 
            // BUT_delete
            // 
            this.BUT_delete.ForeColor = System.Drawing.Color.Black;
            this.BUT_delete.Location = new System.Drawing.Point(267, 125);
            this.BUT_delete.Name = "BUT_delete";
            this.BUT_delete.Size = new System.Drawing.Size(125, 63);
            this.BUT_delete.TabIndex = 15;
            this.BUT_delete.Text = "Del";
            this.BUT_delete.UseVisualStyleBackColor = true;
            this.BUT_delete.Click += new System.EventHandler(this.BUT_delete_Click);
            // 
            // BUT_update
            // 
            this.BUT_update.ForeColor = System.Drawing.Color.Black;
            this.BUT_update.Location = new System.Drawing.Point(267, 210);
            this.BUT_update.Name = "BUT_update";
            this.BUT_update.Size = new System.Drawing.Size(125, 63);
            this.BUT_update.TabIndex = 16;
            this.BUT_update.Text = "Update";
            this.BUT_update.UseVisualStyleBackColor = true;
            this.BUT_update.Click += new System.EventHandler(this.BUT_update_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_aramaF);
            this.groupBox2.Controls.Add(this.TXT_arama);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 137);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1032, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeriTabanı Işlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_ulke;
        private System.Windows.Forms.ComboBox combo_cins;
        private System.Windows.Forms.TextBox TXT_maas;
        private System.Windows.Forms.TextBox TXT_yas;
        private System.Windows.Forms.TextBox TXT_soyad;
        private System.Windows.Forms.TextBox TXT_ad;
        private System.Windows.Forms.TextBox TXT_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_arama;
        private System.Windows.Forms.ComboBox combo_aramaF;
        private System.Windows.Forms.Button BUT_update;
        private System.Windows.Forms.Button BUT_delete;
        private System.Windows.Forms.Button BUT_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

