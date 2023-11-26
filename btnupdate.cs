// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.btnupdate
// Assembly: Tasa Metabolica Basal, Version=1.2.0.0, Culture=neutral, PublicKeyToken=f35f2858f39d1a22
// MVID: A2156353-5DEB-442E-BC29-41EC26DCDE33
// Assembly location: D:\Users\Andres\Downloads\Tasa Metabolica Basal.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class btnupdate : Form
  {
    private IContainer components = (IContainer) null;
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
    private TextBox txtcalorias;
    public string VERSION = "1.2.0.0";
    public string VersionCheck = "https://www.dropbox.com/s/hkcsn1euj6d8ah9/VersionUpdate.txt?dl=1";
    public string VersionDownload = "https://www.dropbox.com/s/crap7n3fxzewpsp/Tasa%20Metabolica%20Basal.exe?dl=1";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula tu tasa metabolica basal";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(370, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estatura (centimetros)";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(128, 43);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(327, 20);
            this.txtestatura.TabIndex = 3;
            this.txtestatura.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(128, 85);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(327, 20);
            this.txtpeso.TabIndex = 5;
            this.txtpeso.Text = "0";
            this.txtpeso.TextChanged += new System.EventHandler(this.txtpeso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(128, 124);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(327, 20);
            this.txtedad.TabIndex = 7;
            this.txtedad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa Metabolica Basal (TMB)";
            // 
            // txttmb
            // 
            this.txttmb.Location = new System.Drawing.Point(196, 185);
            this.txttmb.Name = "txttmb";
            this.txttmb.ReadOnly = true;
            this.txttmb.Size = new System.Drawing.Size(259, 20);
            this.txttmb.TabIndex = 10;
            // 
            // btnhombre
            // 
            this.btnhombre.AutoSize = true;
            this.btnhombre.Location = new System.Drawing.Point(16, 155);
            this.btnhombre.Name = "btnhombre";
            this.btnhombre.Size = new System.Drawing.Size(62, 17);
            this.btnhombre.TabIndex = 12;
            this.btnhombre.Text = "Hombre";
            this.btnhombre.UseVisualStyleBackColor = true;
            // 
            // btnmujer
            // 
            this.btnmujer.AutoSize = true;
            this.btnmujer.Location = new System.Drawing.Point(158, 156);
            this.btnmujer.Name = "btnmujer";
            this.btnmujer.Size = new System.Drawing.Size(51, 17);
            this.btnmujer.TabIndex = 13;
            this.btnmujer.Text = "Mujer";
            this.btnmujer.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Programa hecho por Andrés Felipe Estupiñán para";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(252, 270);
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
            this.etiversion.Location = new System.Drawing.Point(345, 27);
            this.etiversion.Name = "etiversion";
            this.etiversion.Size = new System.Drawing.Size(10, 13);
            this.etiversion.TabIndex = 16;
            this.etiversion.Text = "-";
            // 
            // txtformula
            // 
            this.txtformula.Location = new System.Drawing.Point(196, 211);
            this.txtformula.Name = "txtformula";
            this.txtformula.ReadOnly = true;
            this.txtformula.Size = new System.Drawing.Size(259, 20);
            this.txtformula.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fórmula del TMB";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 265);
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
            this.etiupdates.Location = new System.Drawing.Point(155, 27);
            this.etiupdates.Name = "etiupdates";
            this.etiupdates.Size = new System.Drawing.Size(140, 13);
            this.etiupdates.TabIndex = 20;
            this.etiupdates.Text = "Buscando actualizaciones...";
            this.etiupdates.Visible = false;
            // 
            // combocalorias
            // 
            this.combocalorias.FormattingEnabled = true;
            this.combocalorias.Items.AddRange(new object[] {
            "Sedentario",
            "Ligero",
            "Moderada",
            "Intensa",
            "Muy intensa"});
            this.combocalorias.Location = new System.Drawing.Point(234, 152);
            this.combocalorias.Name = "combocalorias";
            this.combocalorias.Size = new System.Drawing.Size(121, 21);
            this.combocalorias.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Calorias para tu tipo de actividad";
            // 
            // txtcalorias
            // 
            this.txtcalorias.Location = new System.Drawing.Point(196, 237);
            this.txtcalorias.Name = "txtcalorias";
            this.txtcalorias.ReadOnly = true;
            this.txtcalorias.Size = new System.Drawing.Size(259, 20);
            this.txtcalorias.TabIndex = 23;
            // 
            // btnupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(467, 296);
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
            this.Name = "btnupdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasa metabolica basal";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public btnupdate()
    {
      this.InitializeComponent();
      this.etiversion.Text = string.Format("Versión {0}", (object) this.VERSION);
      this.combocalorias.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text1 = this.txtestatura.Text;
      string text2 = this.txtpeso.Text;
      int num1 = int.Parse(this.txtedad.Text);
      int num2 = int.Parse(text1);
      int num3 = int.Parse(text2);
      if (this.btnhombre.Checked)
      {
        double TMB = 66.0 + 13.7 * (double) num3 + (double) (5 * num2) - 6.8 * (double) num1;
        this.txttmb.Text = TMB.ToString();
        int num4 = (int) MessageBox.Show("¡Tasa metabolica calculada!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtformula.Text = string.Format("66 + (13.7 * {0}) + (5 * {1}) - 6.8({2})", (object) num3, (object) num2, (object) num1);
        this.txtcalorias.Text = string.Format("{0}", (object) this.MakeCal(TMB).ToString());
      }
      else if (this.btnmujer.Checked)
      {
        double TMB = 655.0 + 9.6 * (double) num3 + 1.8 * (double) num2 - 4.7 * (double) num1;
        this.txttmb.Text = TMB.ToString();
        int num5 = (int) MessageBox.Show("¡Tasa metabolica calculada!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtformula.Text = string.Format("655 + (9.6 * {0}) + (1.8 * {1}) - 4.7({2})", (object) num3, (object) num2, (object) num1);
        this.txtcalorias.Text = string.Format("{0}", (object) this.MakeCal(TMB).ToString());
      }
      else
      {
        int num6 = (int) MessageBox.Show("Debes de seleccionar por lo menos si eres mujer u hombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    public double MakeCal(double TMB)
    {
      double num = 0.0;
      switch (this.combocalorias.SelectedIndex)
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

    private void txtpeso_TextChanged(object sender, EventArgs e)
    {
    }

    private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://esperanzadevidacosfa10a.blogspot.com.co/");

    public void CheckForUpdates()
    {
      WebResponse response = WebRequest.Create(this.VersionCheck).GetResponse();
      string str = string.Empty;
      string version = this.VERSION;
      using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
      {
        str = streamReader.ReadToEnd();
        streamReader.Close();
      }
      if (str == version)
      {
        int num = (int) MessageBox.Show("Este programa ya esta actualizado.", "¡Al día!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.etiupdates.Visible = false;
      }
      else if (MessageBox.Show("Hay una actualización disponible para descargar\n¿Quieres descargarla ahora?", "Actualización disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        Process.Start(this.VersionDownload);
        this.etiupdates.Visible = false;
      }
      else
      {
        int num = (int) MessageBox.Show("El programa no se actualizara.", "Actualización cancelada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.etiupdates.Visible = false;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Las actualizaciones suelen contener arreglos para el programa\n¿Buscar ahora?", "¿Buscar actualización?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        this.CheckForUpdates();
      }
      else
      {
        int num = (int) MessageBox.Show("No se buscaran actualizaciones", "Desactualizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }
}
