
namespace sinav_hazirlik1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.combo_aramaF = new System.Windows.Forms.ComboBox();
            this.TXT_arama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BUT_update = new System.Windows.Forms.Button();
            this.BUT_delete = new System.Windows.Forms.Button();
            this.TXT_maas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_ulke = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_cins = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_yas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_ad = new System.Windows.Forms.TextBox();
            this.TXT_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 716);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 716);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // combo_aramaF
            // 
            this.combo_aramaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_aramaF.FormattingEnabled = true;
            this.combo_aramaF.Location = new System.Drawing.Point(135, 306);
            this.combo_aramaF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_aramaF.Name = "combo_aramaF";
            this.combo_aramaF.Size = new System.Drawing.Size(169, 32);
            this.combo_aramaF.TabIndex = 56;
            this.combo_aramaF.SelectedIndexChanged += new System.EventHandler(this.combo_aramaF_SelectedIndexChanged);
            // 
            // TXT_arama
            // 
            this.TXT_arama.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_arama.ForeColor = System.Drawing.Color.Black;
            this.TXT_arama.Location = new System.Drawing.Point(135, 346);
            this.TXT_arama.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_arama.MaxLength = 20;
            this.TXT_arama.Name = "TXT_arama";
            this.TXT_arama.Size = new System.Drawing.Size(196, 29);
            this.TXT_arama.TabIndex = 55;
            this.TXT_arama.EnabledChanged += new System.EventHandler(this.TXT_arama_EnabledChanged);
            this.TXT_arama.TextChanged += new System.EventHandler(this.TXT_arama_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 54;
            this.label9.Text = "Arama:";
            // 
            // BUT_update
            // 
            this.BUT_update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BUT_update.ForeColor = System.Drawing.Color.Black;
            this.BUT_update.Location = new System.Drawing.Point(243, 387);
            this.BUT_update.Margin = new System.Windows.Forms.Padding(6);
            this.BUT_update.Name = "BUT_update";
            this.BUT_update.Size = new System.Drawing.Size(104, 42);
            this.BUT_update.TabIndex = 53;
            this.BUT_update.Text = "Update";
            this.BUT_update.UseVisualStyleBackColor = true;
            this.BUT_update.Click += new System.EventHandler(this.BUT_update_Click);
            // 
            // BUT_delete
            // 
            this.BUT_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BUT_delete.ForeColor = System.Drawing.Color.Black;
            this.BUT_delete.Location = new System.Drawing.Point(127, 387);
            this.BUT_delete.Margin = new System.Windows.Forms.Padding(6);
            this.BUT_delete.Name = "BUT_delete";
            this.BUT_delete.Size = new System.Drawing.Size(104, 42);
            this.BUT_delete.TabIndex = 52;
            this.BUT_delete.Text = "Delete";
            this.BUT_delete.UseVisualStyleBackColor = true;
            this.BUT_delete.EnabledChanged += new System.EventHandler(this.BUT_delete_EnabledChanged);
            this.BUT_delete.Click += new System.EventHandler(this.BUT_delete_Click);
            // 
            // TXT_maas
            // 
            this.TXT_maas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_maas.ForeColor = System.Drawing.Color.Black;
            this.TXT_maas.Location = new System.Drawing.Point(135, 269);
            this.TXT_maas.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_maas.MaxLength = 9;
            this.TXT_maas.Name = "TXT_maas";
            this.TXT_maas.Size = new System.Drawing.Size(124, 29);
            this.TXT_maas.TabIndex = 51;
            this.TXT_maas.TextChanged += new System.EventHandler(this.TXT_maas_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 50;
            this.label8.Text = "Maas:";
            // 
            // combo_ulke
            // 
            this.combo_ulke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ulke.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.combo_ulke.Location = new System.Drawing.Point(135, 233);
            this.combo_ulke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_ulke.Name = "combo_ulke";
            this.combo_ulke.Size = new System.Drawing.Size(196, 30);
            this.combo_ulke.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ulke:";
            // 
            // combo_cins
            // 
            this.combo_cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cins.FormattingEnabled = true;
            this.combo_cins.Items.AddRange(new object[] {
            "E",
            "K"});
            this.combo_cins.Location = new System.Drawing.Point(135, 195);
            this.combo_cins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_cins.Name = "combo_cins";
            this.combo_cins.Size = new System.Drawing.Size(124, 32);
            this.combo_cins.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cinsiyet:";
            // 
            // TXT_yas
            // 
            this.TXT_yas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_yas.ForeColor = System.Drawing.Color.Black;
            this.TXT_yas.Location = new System.Drawing.Point(135, 160);
            this.TXT_yas.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_yas.MaxLength = 3;
            this.TXT_yas.Name = "TXT_yas";
            this.TXT_yas.Size = new System.Drawing.Size(124, 29);
            this.TXT_yas.TabIndex = 45;
            this.TXT_yas.TextChanged += new System.EventHandler(this.TXT_yas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Yas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(362, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 444);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TXT_soyad
            // 
            this.TXT_soyad.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_soyad.ForeColor = System.Drawing.Color.Black;
            this.TXT_soyad.Location = new System.Drawing.Point(135, 125);
            this.TXT_soyad.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_soyad.MaxLength = 20;
            this.TXT_soyad.Name = "TXT_soyad";
            this.TXT_soyad.Size = new System.Drawing.Size(196, 29);
            this.TXT_soyad.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Veritabanı işlemleri";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TXT_ad
            // 
            this.TXT_ad.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ad.ForeColor = System.Drawing.Color.Black;
            this.TXT_ad.Location = new System.Drawing.Point(135, 90);
            this.TXT_ad.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_ad.MaxLength = 20;
            this.TXT_ad.Name = "TXT_ad";
            this.TXT_ad.Size = new System.Drawing.Size(196, 29);
            this.TXT_ad.TabIndex = 39;
            // 
            // TXT_id
            // 
            this.TXT_id.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_id.ForeColor = System.Drawing.Color.Black;
            this.TXT_id.Location = new System.Drawing.Point(135, 55);
            this.TXT_id.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_id.MaxLength = 10;
            this.TXT_id.Name = "TXT_id";
            this.TXT_id.Size = new System.Drawing.Size(121, 29);
            this.TXT_id.TabIndex = 38;
            this.TXT_id.TextChanged += new System.EventHandler(this.TXT_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id:";
            // 
            // BUT_add
            // 
            this.BUT_add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BUT_add.ForeColor = System.Drawing.Color.Black;
            this.BUT_add.Location = new System.Drawing.Point(11, 387);
            this.BUT_add.Margin = new System.Windows.Forms.Padding(6);
            this.BUT_add.Name = "BUT_add";
            this.BUT_add.Size = new System.Drawing.Size(104, 42);
            this.BUT_add.TabIndex = 35;
            this.BUT_add.Text = "Add";
            this.BUT_add.UseVisualStyleBackColor = true;
            this.BUT_add.EnabledChanged += new System.EventHandler(this.BUT_add_EnabledChanged);
            this.BUT_add.Click += new System.EventHandler(this.BUT_add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1126, 444);
            this.Controls.Add(this.combo_aramaF);
            this.Controls.Add(this.TXT_arama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BUT_update);
            this.Controls.Add(this.BUT_delete);
            this.Controls.Add(this.TXT_maas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_ulke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_cins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_yas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_ad);
            this.Controls.Add(this.TXT_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BUT_add);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox combo_aramaF;
        private System.Windows.Forms.TextBox TXT_arama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BUT_update;
        private System.Windows.Forms.Button BUT_delete;
        private System.Windows.Forms.TextBox TXT_maas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_ulke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_cins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_yas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_ad;
        private System.Windows.Forms.TextBox TXT_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUT_add;
    }
}