namespace Conver3
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
      this.components = new System.ComponentModel.Container();
      this.etMostrarFecha = new System.Windows.Forms.Label();
      this.etFecha = new System.Windows.Forms.Label();
      this.btGradosFmas1 = new System.Windows.Forms.Button();
      this.btGradosCmas1 = new System.Windows.Forms.Button();
      this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
      this.ctGradosF = new System.Windows.Forms.TextBox();
      this.etGradosF = new System.Windows.Forms.Label();
      this.ctGradosC = new System.Windows.Forms.TextBox();
      this.etGradosC = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
      this.SuspendLayout();
      // 
      // etMostrarFecha
      // 
      this.etMostrarFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.etMostrarFecha.Location = new System.Drawing.Point(59, 26);
      this.etMostrarFecha.Name = "etMostrarFecha";
      this.etMostrarFecha.Size = new System.Drawing.Size(222, 22);
      this.etMostrarFecha.TabIndex = 16;
      this.etMostrarFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // etFecha
      // 
      this.etFecha.AutoSize = true;
      this.etFecha.Location = new System.Drawing.Point(13, 26);
      this.etFecha.Name = "etFecha";
      this.etFecha.Size = new System.Drawing.Size(40, 13);
      this.etFecha.TabIndex = 15;
      this.etFecha.Text = "Fecha:";
      // 
      // btGradosFmas1
      // 
      this.btGradosFmas1.Location = new System.Drawing.Point(253, 106);
      this.btGradosFmas1.Name = "btGradosFmas1";
      this.btGradosFmas1.Size = new System.Drawing.Size(28, 23);
      this.btGradosFmas1.TabIndex = 14;
      this.btGradosFmas1.Text = "+1";
      this.btGradosFmas1.Click += new System.EventHandler(this.btGradosFmas1_Click);
      // 
      // btGradosCmas1
      // 
      this.btGradosCmas1.Location = new System.Drawing.Point(253, 67);
      this.btGradosCmas1.Name = "btGradosCmas1";
      this.btGradosCmas1.Size = new System.Drawing.Size(28, 23);
      this.btGradosCmas1.TabIndex = 13;
      this.btGradosCmas1.Text = "+1";
      this.btGradosCmas1.Click += new System.EventHandler(this.btGradosCmas1_Click);
      // 
      // ProveedorDeError
      // 
      this.ProveedorDeError.ContainerControl = this;
      // 
      // ctGradosF
      // 
      this.ctGradosF.Location = new System.Drawing.Point(126, 108);
      this.ctGradosF.Name = "ctGradosF";
      this.ctGradosF.Size = new System.Drawing.Size(107, 20);
      this.ctGradosF.TabIndex = 10;
      this.ctGradosF.Text = "32,00";
      this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ctGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
      this.ctGradosF.Validating += new System.ComponentModel.CancelEventHandler(this.CajaTexto_Validating);
      this.ctGradosF.Validated += new System.EventHandler(this.CajaTexto_Validated);
      // 
      // etGradosF
      // 
      this.etGradosF.AutoSize = true;
      this.etGradosF.Location = new System.Drawing.Point(12, 111);
      this.etGradosF.Name = "etGradosF";
      this.etGradosF.Size = new System.Drawing.Size(97, 13);
      this.etGradosF.TabIndex = 12;
      this.etGradosF.Text = "Grados Fahrenheit:";
      // 
      // ctGradosC
      // 
      this.ctGradosC.Location = new System.Drawing.Point(126, 68);
      this.ctGradosC.Name = "ctGradosC";
      this.ctGradosC.Size = new System.Drawing.Size(107, 20);
      this.ctGradosC.TabIndex = 9;
      this.ctGradosC.Text = "0,00";
      this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
      this.ctGradosC.Validating += new System.ComponentModel.CancelEventHandler(this.CajaTexto_Validating);
      this.ctGradosC.Validated += new System.EventHandler(this.CajaTexto_Validated);
      // 
      // etGradosC
      // 
      this.etGradosC.AutoSize = true;
      this.etGradosC.Location = new System.Drawing.Point(12, 72);
      this.etGradosC.Name = "etGradosC";
      this.etGradosC.Size = new System.Drawing.Size(104, 13);
      this.etGradosC.TabIndex = 11;
      this.etGradosC.Text = "Grados centígrados:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 155);
      this.Controls.Add(this.etMostrarFecha);
      this.Controls.Add(this.etFecha);
      this.Controls.Add(this.btGradosFmas1);
      this.Controls.Add(this.btGradosCmas1);
      this.Controls.Add(this.ctGradosF);
      this.Controls.Add(this.etGradosF);
      this.Controls.Add(this.ctGradosC);
      this.Controls.Add(this.etGradosC);
      this.Name = "Form1";
      this.Text = "Conversión de temperaturas";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label etMostrarFecha;
    private System.Windows.Forms.Label etFecha;
    private System.Windows.Forms.Button btGradosFmas1;
    private System.Windows.Forms.Button btGradosCmas1;
    private System.Windows.Forms.ErrorProvider ProveedorDeError;
    private System.Windows.Forms.TextBox ctGradosF;
    private System.Windows.Forms.Label etGradosF;
    private System.Windows.Forms.TextBox ctGradosC;
    private System.Windows.Forms.Label etGradosC;
  }
}

