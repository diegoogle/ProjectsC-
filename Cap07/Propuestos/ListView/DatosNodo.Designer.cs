namespace ListView
{
  partial class DatosNodo
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
      this.btCancelar = new System.Windows.Forms.Button();
      this.btAceptar = new System.Windows.Forms.Button();
      this.cvCasado = new System.Windows.Forms.CheckBox();
      this.ctTfno = new System.Windows.Forms.TextBox();
      this.ctDirec = new System.Windows.Forms.TextBox();
      this.ctNombre = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(262, 35);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 8;
      this.btCancelar.Text = "Cancelar";
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(262, 7);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 7;
      this.btAceptar.Text = "Aceptar";
      // 
      // cvCasado
      // 
      this.cvCasado.AutoSize = true;
      this.cvCasado.Location = new System.Drawing.Point(73, 87);
      this.cvCasado.Name = "cvCasado";
      this.cvCasado.Size = new System.Drawing.Size(62, 17);
      this.cvCasado.TabIndex = 6;
      this.cvCasado.Text = "Casado";
      // 
      // ctTfno
      // 
      this.ctTfno.Location = new System.Drawing.Point(73, 61);
      this.ctTfno.Name = "ctTfno";
      this.ctTfno.Size = new System.Drawing.Size(173, 20);
      this.ctTfno.TabIndex = 5;
      this.ctTfno.Text = "0";
      // 
      // ctDirec
      // 
      this.ctDirec.Location = new System.Drawing.Point(73, 35);
      this.ctDirec.Name = "ctDirec";
      this.ctDirec.Size = new System.Drawing.Size(173, 20);
      this.ctDirec.TabIndex = 4;
      // 
      // ctNombre
      // 
      this.ctNombre.Location = new System.Drawing.Point(73, 9);
      this.ctNombre.Name = "ctNombre";
      this.ctNombre.Size = new System.Drawing.Size(173, 20);
      this.ctNombre.TabIndex = 3;
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.Location = new System.Drawing.Point(15, 67);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(52, 13);
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Teléfono:";
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(15, 38);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(55, 13);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Dirección:";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(15, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(47, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Nombre:";
      // 
      // DatosNodo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 111);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.cvCasado);
      this.Controls.Add(this.ctTfno);
      this.Controls.Add(this.ctDirec);
      this.Controls.Add(this.ctNombre);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "DatosNodo";
      this.Text = "Datos nodo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Button btAceptar;
    internal System.Windows.Forms.CheckBox cvCasado;
    internal System.Windows.Forms.TextBox ctTfno;
    internal System.Windows.Forms.TextBox ctDirec;
    internal System.Windows.Forms.TextBox ctNombre;
    private System.Windows.Forms.Label Label3;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
  }
}