namespace Funciones
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
      this.etCoordY = new System.Windows.Forms.Label();
      this.ctCoordX = new System.Windows.Forms.TextBox();
      this.cgValoresX = new System.Windows.Forms.GroupBox();
      this.ctXMax = new System.Windows.Forms.TextBox();
      this.ctXMin = new System.Windows.Forms.TextBox();
      this.etMax = new System.Windows.Forms.Label();
      this.etMin = new System.Windows.Forms.Label();
      this.cgPuntoXY = new System.Windows.Forms.GroupBox();
      this.ctCoordY = new System.Windows.Forms.TextBox();
      this.etCoordX = new System.Windows.Forms.Label();
      this.cgCalidad = new System.Windows.Forms.GroupBox();
      this.boCalidadAlta = new System.Windows.Forms.RadioButton();
      this.boCalidadNormal = new System.Windows.Forms.RadioButton();
      this.btDibujar = new System.Windows.Forms.Button();
      this.etFuncion = new System.Windows.Forms.Label();
      this.ciFuncion = new System.Windows.Forms.PictureBox();
      this.cgValoresX.SuspendLayout();
      this.cgPuntoXY.SuspendLayout();
      this.cgCalidad.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ciFuncion)).BeginInit();
      this.SuspendLayout();
      // 
      // etCoordY
      // 
      this.etCoordY.AutoSize = true;
      this.etCoordY.Location = new System.Drawing.Point(7, 49);
      this.etCoordY.Name = "etCoordY";
      this.etCoordY.Size = new System.Drawing.Size(14, 13);
      this.etCoordY.TabIndex = 1;
      this.etCoordY.Text = "Y";
      // 
      // ctCoordX
      // 
      this.ctCoordX.Location = new System.Drawing.Point(26, 17);
      this.ctCoordX.Name = "ctCoordX";
      this.ctCoordX.Size = new System.Drawing.Size(64, 20);
      this.ctCoordX.TabIndex = 2;
      this.ctCoordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // cgValoresX
      // 
      this.cgValoresX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cgValoresX.Controls.Add(this.ctXMax);
      this.cgValoresX.Controls.Add(this.ctXMin);
      this.cgValoresX.Controls.Add(this.etMax);
      this.cgValoresX.Controls.Add(this.etMin);
      this.cgValoresX.Location = new System.Drawing.Point(424, 42);
      this.cgValoresX.Name = "cgValoresX";
      this.cgValoresX.Size = new System.Drawing.Size(96, 69);
      this.cgValoresX.TabIndex = 16;
      this.cgValoresX.TabStop = false;
      this.cgValoresX.Text = "Valores de X";
      // 
      // ctXMax
      // 
      this.ctXMax.Location = new System.Drawing.Point(49, 43);
      this.ctXMax.Name = "ctXMax";
      this.ctXMax.Size = new System.Drawing.Size(41, 20);
      this.ctXMax.TabIndex = 3;
      this.ctXMax.Text = "6,30";
      this.ctXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // ctXMin
      // 
      this.ctXMin.Location = new System.Drawing.Point(49, 17);
      this.ctXMin.Name = "ctXMin";
      this.ctXMin.Size = new System.Drawing.Size(41, 20);
      this.ctXMin.TabIndex = 2;
      this.ctXMin.Text = "-0,83";
      this.ctXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etMax
      // 
      this.etMax.AutoSize = true;
      this.etMax.Location = new System.Drawing.Point(7, 49);
      this.etMax.Name = "etMax";
      this.etMax.Size = new System.Drawing.Size(27, 13);
      this.etMax.TabIndex = 1;
      this.etMax.Text = "Máx";
      // 
      // etMin
      // 
      this.etMin.AutoSize = true;
      this.etMin.Location = new System.Drawing.Point(7, 20);
      this.etMin.Name = "etMin";
      this.etMin.Size = new System.Drawing.Size(26, 13);
      this.etMin.TabIndex = 0;
      this.etMin.Text = "Mín";
      // 
      // cgPuntoXY
      // 
      this.cgPuntoXY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cgPuntoXY.Controls.Add(this.ctCoordY);
      this.cgPuntoXY.Controls.Add(this.ctCoordX);
      this.cgPuntoXY.Controls.Add(this.etCoordY);
      this.cgPuntoXY.Controls.Add(this.etCoordX);
      this.cgPuntoXY.Location = new System.Drawing.Point(424, 192);
      this.cgPuntoXY.Name = "cgPuntoXY";
      this.cgPuntoXY.Size = new System.Drawing.Size(96, 69);
      this.cgPuntoXY.TabIndex = 17;
      this.cgPuntoXY.TabStop = false;
      this.cgPuntoXY.Text = "Punto:";
      // 
      // ctCoordY
      // 
      this.ctCoordY.Location = new System.Drawing.Point(26, 43);
      this.ctCoordY.Name = "ctCoordY";
      this.ctCoordY.Size = new System.Drawing.Size(64, 20);
      this.ctCoordY.TabIndex = 3;
      this.ctCoordY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etCoordX
      // 
      this.etCoordX.AutoSize = true;
      this.etCoordX.Location = new System.Drawing.Point(7, 20);
      this.etCoordX.Name = "etCoordX";
      this.etCoordX.Size = new System.Drawing.Size(14, 13);
      this.etCoordX.TabIndex = 0;
      this.etCoordX.Text = "X";
      // 
      // cgCalidad
      // 
      this.cgCalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cgCalidad.Controls.Add(this.boCalidadAlta);
      this.cgCalidad.Controls.Add(this.boCalidadNormal);
      this.cgCalidad.Location = new System.Drawing.Point(424, 117);
      this.cgCalidad.Name = "cgCalidad";
      this.cgCalidad.Size = new System.Drawing.Size(96, 69);
      this.cgCalidad.TabIndex = 15;
      this.cgCalidad.TabStop = false;
      this.cgCalidad.Text = "Calidad";
      // 
      // boCalidadAlta
      // 
      this.boCalidadAlta.AutoSize = true;
      this.boCalidadAlta.Location = new System.Drawing.Point(6, 42);
      this.boCalidadAlta.Name = "boCalidadAlta";
      this.boCalidadAlta.Size = new System.Drawing.Size(43, 17);
      this.boCalidadAlta.TabIndex = 4;
      this.boCalidadAlta.Text = "Alta";
      this.boCalidadAlta.CheckedChanged += new System.EventHandler(this.boCalidadAlta_CheckedChanged);
      // 
      // boCalidadNormal
      // 
      this.boCalidadNormal.AutoSize = true;
      this.boCalidadNormal.Checked = true;
      this.boCalidadNormal.Location = new System.Drawing.Point(6, 19);
      this.boCalidadNormal.Name = "boCalidadNormal";
      this.boCalidadNormal.Size = new System.Drawing.Size(58, 17);
      this.boCalidadNormal.TabIndex = 3;
      this.boCalidadNormal.TabStop = true;
      this.boCalidadNormal.Text = "Normal";
      this.boCalidadNormal.CheckedChanged += new System.EventHandler(this.boCalidadNormal_CheckedChanged);
      // 
      // btDibujar
      // 
      this.btDibujar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btDibujar.Location = new System.Drawing.Point(424, 13);
      this.btDibujar.Name = "btDibujar";
      this.btDibujar.Size = new System.Drawing.Size(96, 23);
      this.btDibujar.TabIndex = 14;
      this.btDibujar.Text = "Dibujar";
      this.btDibujar.Click += new System.EventHandler(this.btDibujar_Click);
      // 
      // etFuncion
      // 
      this.etFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.etFuncion.AutoSize = true;
      this.etFuncion.Location = new System.Drawing.Point(13, 270);
      this.etFuncion.Name = "etFuncion";
      this.etFuncion.Size = new System.Drawing.Size(42, 13);
      this.etFuncion.TabIndex = 13;
      this.etFuncion.Text = "función";
      // 
      // ciFuncion
      // 
      this.ciFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.ciFuncion.BackColor = System.Drawing.Color.White;
      this.ciFuncion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ciFuncion.Location = new System.Drawing.Point(13, 13);
      this.ciFuncion.Name = "ciFuncion";
      this.ciFuncion.Size = new System.Drawing.Size(392, 247);
      this.ciFuncion.TabIndex = 12;
      this.ciFuncion.TabStop = false;
      this.ciFuncion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ciFuncion_MouseMove);
      this.ciFuncion.Paint += new System.Windows.Forms.PaintEventHandler(this.ciFuncion_Paint);
      this.ciFuncion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ciFuncion_MouseUp);
      this.ciFuncion.SizeChanged += new System.EventHandler(this.ciFuncion_SizeChanged);
      // 
      // Form1
      // 
      this.AcceptButton = this.btDibujar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 296);
      this.Controls.Add(this.cgValoresX);
      this.Controls.Add(this.cgPuntoXY);
      this.Controls.Add(this.cgCalidad);
      this.Controls.Add(this.btDibujar);
      this.Controls.Add(this.etFuncion);
      this.Controls.Add(this.ciFuncion);
      this.Name = "Form1";
      this.Text = "Representación de una función";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.cgValoresX.ResumeLayout(false);
      this.cgValoresX.PerformLayout();
      this.cgPuntoXY.ResumeLayout(false);
      this.cgPuntoXY.PerformLayout();
      this.cgCalidad.ResumeLayout(false);
      this.cgCalidad.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ciFuncion)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label etCoordY;
    private System.Windows.Forms.TextBox ctCoordX;
    private System.Windows.Forms.GroupBox cgValoresX;
    private System.Windows.Forms.TextBox ctXMax;
    private System.Windows.Forms.TextBox ctXMin;
    private System.Windows.Forms.Label etMax;
    private System.Windows.Forms.Label etMin;
    private System.Windows.Forms.GroupBox cgPuntoXY;
    private System.Windows.Forms.TextBox ctCoordY;
    private System.Windows.Forms.Label etCoordX;
    private System.Windows.Forms.GroupBox cgCalidad;
    private System.Windows.Forms.RadioButton boCalidadAlta;
    private System.Windows.Forms.RadioButton boCalidadNormal;
    private System.Windows.Forms.Button btDibujar;
    private System.Windows.Forms.Label etFuncion;
    private System.Windows.Forms.PictureBox ciFuncion;
  }
}

