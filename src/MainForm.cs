// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.btnupdate
// Assembly: Tasa Metabolica Basal, Version=1.2.0.0, Culture=neutral, PublicKeyToken=f35f2858f39d1a22
// MVID: A2156353-5DEB-442E-BC29-41EC26DCDE33
// Assembly location: D:\Users\Andres\Downloads\Tasa Metabolica Basal.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace TMB.src
{
    public class MainForm : Form
    {
        private IContainer components = null;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtestatura;
        private Label label3;
        private TextBox txtpeso;
        private Label label4;
        private TextBox txtedad;
        private Label label5;
        private TextBox txttmb;
        private RadioButton btnhombre;
        private RadioButton btnmujer;
        private Label label6;
        private LinkLabel Link;
        private Label etiversion;
        private TextBox txtformula;
        private Label label8;
        private Button button2;
        private Label etiupdates;
        private ComboBox combocalorias;
        private Label label7;
        private Label label9;
        private TextBox txtcalorias;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttmb = new System.Windows.Forms.TextBox();
            this.btnhombre = new System.Windows.Forms.RadioButton();
            this.btnmujer = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.etiversion = new System.Windows.Forms.Label();
            this.txtformula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.etiupdates = new System.Windows.Forms.Label();
            this.combocalorias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcalorias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula tu tasa metabolica basal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estatura (centimetros)";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(128, 63);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(327, 20);
            this.txtestatura.TabIndex = 3;
            this.txtestatura.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(128, 105);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(327, 20);
            this.txtpeso.TabIndex = 5;
            this.txtpeso.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(128, 144);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(327, 20);
            this.txtedad.TabIndex = 7;
            this.txtedad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa Metabolica Basal (TMB)";
            // 
            // txttmb
            // 
            this.txttmb.Location = new System.Drawing.Point(196, 205);
            this.txttmb.Name = "txttmb";
            this.txttmb.ReadOnly = true;
            this.txttmb.Size = new System.Drawing.Size(259, 20);
            this.txttmb.TabIndex = 10;
            // 
            // btnhombre
            // 
            this.btnhombre.AutoSize = true;
            this.btnhombre.Location = new System.Drawing.Point(16, 174);
            this.btnhombre.Name = "btnhombre";
            this.btnhombre.Size = new System.Drawing.Size(62, 17);
            this.btnhombre.TabIndex = 12;
            this.btnhombre.Text = "Hombre";
            this.btnhombre.UseVisualStyleBackColor = true;
            // 
            // btnmujer
            // 
            this.btnmujer.AutoSize = true;
            this.btnmujer.Location = new System.Drawing.Point(84, 174);
            this.btnmujer.Name = "btnmujer";
            this.btnmujer.Size = new System.Drawing.Size(51, 17);
            this.btnmujer.TabIndex = 13;
            this.btnmujer.Text = "Mujer";
            this.btnmujer.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Programa realizado por Andrés Peláez para el proyecto de";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(290, 291);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(103, 13);
            this.Link.TabIndex = 15;
            this.Link.TabStop = true;
            this.Link.Text = "El Rincón de la Vida";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // etiversion
            // 
            this.etiversion.AutoSize = true;
            this.etiversion.Location = new System.Drawing.Point(13, 30);
            this.etiversion.Name = "etiversion";
            this.etiversion.Size = new System.Drawing.Size(10, 13);
            this.etiversion.TabIndex = 16;
            this.etiversion.Text = "-";
            // 
            // txtformula
            // 
            this.txtformula.Location = new System.Drawing.Point(196, 231);
            this.txtformula.Name = "txtformula";
            this.txtformula.ReadOnly = true;
            this.txtformula.Size = new System.Drawing.Size(259, 20);
            this.txtformula.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fórmula del TMB";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // etiupdates
            // 
            this.etiupdates.AutoSize = true;
            this.etiupdates.Location = new System.Drawing.Point(69, 30);
            this.etiupdates.Name = "etiupdates";
            this.etiupdates.Size = new System.Drawing.Size(140, 13);
            this.etiupdates.TabIndex = 20;
            this.etiupdates.Text = "Buscando actualizaciones...";
            this.etiupdates.Visible = false;
            // 
            // combocalorias
            // 
            this.combocalorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocalorias.FormattingEnabled = true;
            this.combocalorias.Items.AddRange(GetSelectableLifestyles());
            this.combocalorias.Location = new System.Drawing.Point(253, 172);
            this.combocalorias.Name = "combocalorias";
            this.combocalorias.Size = new System.Drawing.Size(121, 21);
            this.combocalorias.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Calorias para tu tipo de actividad";
            // 
            // txtcalorias
            // 
            this.txtcalorias.Location = new System.Drawing.Point(196, 257);
            this.txtcalorias.Name = "txtcalorias";
            this.txtcalorias.ReadOnly = true;
            this.txtcalorias.Size = new System.Drawing.Size(259, 20);
            this.txtcalorias.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Estilo de vida:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(467, 309);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcalorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combocalorias);
            this.Controls.Add(this.etiupdates);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtformula);
            this.Controls.Add(this.etiversion);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmujer);
            this.Controls.Add(this.btnhombre);
            this.Controls.Add(this.txttmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasa metabolica basal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public MainForm()
        {
            InitializeComponent();
            etiversion.Text = string.Format("v{0}", Utils.GetVersion());
            combocalorias.SelectedIndex = 0;
        }

        private void CalculateHandler(object sender, EventArgs e)
        {
            if (!btnhombre.Checked && !btnmujer.Checked) {
                MessageBox.Show("Debes de seleccionar por lo menos si eres mujer u hombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string text1 = txtestatura.Text;
            string text2 = txtpeso.Text;

            int age;
            double height, weight;

            bool validAge = int.TryParse(txtedad.Text, out age);
            bool validHeight = double.TryParse(text1, out height);
            bool validWeight = double.TryParse(text2, out weight);

            if (!validAge || !validHeight || !validWeight) {
                MessageBox.Show("Uno o más valores numéricos son inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sex = btnhombre.Checked ? Utils.MALE : Utils.FEMALE;

            double tmb = CalculateTMB(sex, age, height, weight);
            txttmb.Text = tmb.ToString();
            txtcalorias.Text = MakeCal(tmb).ToString();

            if (sex == Utils.MALE) {
                txtformula.Text = string.Format("66 + (13.7 * {0}) + (5 * {1}) - 6.8({2})", weight, height, age);
            } else if (sex == Utils.FEMALE) {
                txtformula.Text = string.Format("655 + (9.6 * {0}) + (1.8 * {1}) - 4.7({2})", weight, height, age);
            }
            MessageBox.Show("¡Tasa metabolica calculada!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public double CalculateTMB(int sex, int age, double height, double weight)
        {
            if (sex == Utils.MALE) {
                return 66.0 + 13.7 * weight + 5 * height - 6.8 * age;
            } else if (sex == Utils.FEMALE) {
                return 655.0 + 9.6 * weight + 1.8 * height - 4.7 * age;
            }
            return 0;
        }

        public double MakeCal(double TMB)
        {
            double num = 0.0;
            switch (combocalorias.SelectedIndex)
            {
                case 0:
                    num = TMB * 1.2;
                    break;
                case 1:
                    num = TMB * 1.375;
                    break;
                case 2:
                    num = TMB * 1.55;
                    break;
                case 3:
                    num = TMB * 1.725;
                    break;
                case 4:
                    num = TMB * 1.9;
                    break;
            }
            return num;
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Utils.SCHOOL_PROJECT_URL);

        public void CheckForUpdates()
        {
            this.etiupdates.Visible = true;
            Utils.VerifyNewVersion(this);
        }

        public void UpdateResponse(bool updateAvailable, string newVersion = null)
        {
            this.etiupdates.BeginInvoke(new Action(() => { this.etiupdates.Visible = false; }));
            if (!updateAvailable) {
                MessageBox.Show("Este programa ya esta actualizado.", "¡Al día!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else {
                bool response = MessageBox.Show("Hay una actualización disponible para descargar.\n¿Deseas ir a descargarla ahora?", "Actualización disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
                if (response) {
                    Process.Start(Utils.REPO_URL_DOWNLOAD.Replace("{version}", newVersion));
                }
            }
        }

        public string[] GetSelectableLifestyles()
        {
            string[] data = Enum.GetNames(typeof(Utils.LIFESTYLE));
            string[] results = new string[data.Length];
            int idx = 0;
            foreach (string item in data) {
                results[idx] = item.Replace("_", " ");
                idx++;
            }
            return results;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Las actualizaciones suelen contener arreglos para el programa\n¿Buscar ahora?", "¿Buscar actualización?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                CheckForUpdates();
            } else {
                MessageBox.Show("No se buscaran actualizaciones", "Desactualizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
