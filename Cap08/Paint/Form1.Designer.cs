namespace Formas
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
      this.btLimpiar = new System.Windows.Forms.Button();
      this.btTarta = new System.Windows.Forms.Button();
      this.btRegiones = new System.Windows.Forms.Button();
      this.btCurvas = new System.Windows.Forms.Button();
      this.btPoligonos = new System.Windows.Forms.Button();
      this.btTrazados = new System.Windows.Forms.Button();
      this.btElipsesArcos = new System.Windows.Forms.Button();
      this.btLineasRect = new System.Windows.Forms.Button();
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btLimpiar
      // 
      this.btLimpiar.Location = new System.Drawing.Point(274, 215);
      this.btLimpiar.Name = "btLimpiar";
      this.btLimpiar.Size = new System.Drawing.Size(75, 23);
      this.btLimpiar.TabIndex = 17;
      this.btLimpiar.Text = "Limpiar";
      this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
      // 
      // btTarta
      // 
      this.btTarta.Location = new System.Drawing.Point(274, 70);
      this.btTarta.Name = "btTarta";
      this.btTarta.Size = new System.Drawing.Size(75, 23);
      this.btTarta.TabIndex = 16;
      this.btTarta.Text = "Tartas";
      this.btTarta.Click += new System.EventHandler(this.btTarta_Click);
      // 
      // btRegiones
      // 
      this.btRegiones.Location = new System.Drawing.Point(274, 186);
      this.btRegiones.Name = "btRegiones";
      this.btRegiones.Size = new System.Drawing.Size(75, 23);
      this.btRegiones.TabIndex = 15;
      this.btRegiones.Text = "Regiones";
      this.btRegiones.Click += new System.EventHandler(this.btRegiones_Click);
      // 
      // btCurvas
      // 
      this.btCurvas.Location = new System.Drawing.Point(274, 128);
      this.btCurvas.Name = "btCurvas";
      this.btCurvas.Size = new System.Drawing.Size(75, 23);
      this.btCurvas.TabIndex = 14;
      this.btCurvas.Text = "Curvas";
      this.btCurvas.Click += new System.EventHandler(this.btCurvas_Click);
      // 
      // btPoligonos
      // 
      this.btPoligonos.Location = new System.Drawing.Point(274, 99);
      this.btPoligonos.Name = "btPoligonos";
      this.btPoligonos.Size = new System.Drawing.Size(75, 23);
      this.btPoligonos.TabIndex = 13;
      this.btPoligonos.Text = "Polígonos";
      this.btPoligonos.Click += new System.EventHandler(this.btPoligonos_Click);
      // 
      // btTrazados
      // 
      this.btTrazados.Location = new System.Drawing.Point(274, 157);
      this.btTrazados.Name = "btTrazados";
      this.btTrazados.Size = new System.Drawing.Size(75, 23);
      this.btTrazados.TabIndex = 12;
      this.btTrazados.Text = "Trazados";
      this.btTrazados.Click += new System.EventHandler(this.btTrazados_Click);
      // 
      // btElipsesArcos
      // 
      this.btElipsesArcos.Location = new System.Drawing.Point(274, 41);
      this.btElipsesArcos.Name = "btElipsesArcos";
      this.btElipsesArcos.Size = new System.Drawing.Size(75, 23);
      this.btElipsesArcos.TabIndex = 11;
      this.btElipsesArcos.Text = "Elipses y ...";
      this.btElipsesArcos.Click += new System.EventHandler(this.btElipsesArcos_Click);
      // 
      // btLineasRect
      // 
      this.btLineasRect.Location = new System.Drawing.Point(274, 12);
      this.btLineasRect.Name = "btLineasRect";
      this.btLineasRect.Size = new System.Drawing.Size(75, 23);
      this.btLineasRect.TabIndex = 10;
      this.btLineasRect.Text = "Líneas y ...";
      this.btLineasRect.Click += new System.EventHandler(this.btLineasRect_Click);
      // 
      // PictureBox1
      // 
      this.PictureBox1.BackColor = System.Drawing.Color.White;
      this.PictureBox1.Location = new System.Drawing.Point(13, 13);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new System.Drawing.Size(250, 225);
      this.PictureBox1.TabIndex = 9;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(362, 251);
      this.Controls.Add(this.btLimpiar);
      this.Controls.Add(this.btTarta);
      this.Controls.Add(this.btRegiones);
      this.Controls.Add(this.btCurvas);
      this.Controls.Add(this.btPoligonos);
      this.Controls.Add(this.btTrazados);
      this.Controls.Add(this.btElipsesArcos);
      this.Controls.Add(this.btLineasRect);
      this.Controls.Add(this.PictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Formas gráficas";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btLimpiar;
    private System.Windows.Forms.Button btTarta;
    private System.Windows.Forms.Button btRegiones;
    private System.Windows.Forms.Button btCurvas;
    private System.Windows.Forms.Button btPoligonos;
    private System.Windows.Forms.Button btTrazados;
    private System.Windows.Forms.Button btElipsesArcos;
    private System.Windows.Forms.Button btLineasRect;
    private System.Windows.Forms.PictureBox PictureBox1;
  }
}

