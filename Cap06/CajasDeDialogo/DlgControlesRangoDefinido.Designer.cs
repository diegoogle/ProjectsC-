namespace CajasDeDialogo
{
  partial class DlgControlesRangoDefinido
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
      this.components = new System.ComponentModel.Container();
      this.Temporizador = new System.Windows.Forms.Timer(this.components);
      this.bpCuenta = new System.Windows.Forms.ProgressBar();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.desIntervalo = new System.Windows.Forms.TrackBar();
      this.etContador = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.desIntervalo)).BeginInit();
      this.SuspendLayout();
      // 
      // Temporizador
      // 
      this.Temporizador.Enabled = true;
      this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
      // 
      // bpCuenta
      // 
      this.bpCuenta.Location = new System.Drawing.Point(12, 124);
      this.bpCuenta.Name = "bpCuenta";
      this.bpCuenta.Size = new System.Drawing.Size(266, 19);
      this.bpCuenta.TabIndex = 11;
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.Location = new System.Drawing.Point(247, 54);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(34, 13);
      this.Label3.TabIndex = 10;
      this.Label3.Text = "Lento";
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(127, 54);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(40, 13);
      this.Label2.TabIndex = 9;
      this.Label2.Text = "Normal";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(12, 54);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(41, 13);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "Rápido";
      // 
      // desIntervalo
      // 
      this.desIntervalo.LargeChange = 30;
      this.desIntervalo.Location = new System.Drawing.Point(15, 23);
      this.desIntervalo.Maximum = 150;
      this.desIntervalo.Minimum = 1;
      this.desIntervalo.Name = "desIntervalo";
      this.desIntervalo.Size = new System.Drawing.Size(263, 50);
      this.desIntervalo.SmallChange = 5;
      this.desIntervalo.TabIndex = 7;
      this.desIntervalo.TabStop = false;
      this.desIntervalo.TickFrequency = 5;
      this.desIntervalo.Value = 76;
      // 
      // etContador
      // 
      this.etContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.etContador.Location = new System.Drawing.Point(96, 84);
      this.etContador.Name = "etContador";
      this.etContador.Size = new System.Drawing.Size(100, 24);
      this.etContador.TabIndex = 6;
      this.etContador.Text = "0";
      this.etContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DlgControlesRangoDefinido
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.Controls.Add(this.bpCuenta);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.desIntervalo);
      this.Controls.Add(this.etContador);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgControlesRangoDefinido";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Controles de rango definido";
      this.Load += new System.EventHandler(this.DlgControlesRangoDefinido_Load);
      ((System.ComponentModel.ISupportInitialize)(this.desIntervalo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer Temporizador;
    private System.Windows.Forms.ProgressBar bpCuenta;
    private System.Windows.Forms.Label Label3;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.TrackBar desIntervalo;
    private System.Windows.Forms.Label etContador;

  }
}