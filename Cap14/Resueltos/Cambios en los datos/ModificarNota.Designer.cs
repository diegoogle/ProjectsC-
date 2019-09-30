namespace ApEntidades
{
  partial class ModificarNota
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.ctAlum = new System.Windows.Forms.TextBox();
      this.ctAsig = new System.Windows.Forms.TextBox();
      this.ctNota = new System.Windows.Forms.TextBox();
      this.btAceptar = new System.Windows.Forms.Button();
      this.btCancelar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Alumno:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Asignatura:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Nota:";
      // 
      // ctAlum
      // 
      this.ctAlum.Location = new System.Drawing.Point(98, 18);
      this.ctAlum.Name = "ctAlum";
      this.ctAlum.ReadOnly = true;
      this.ctAlum.Size = new System.Drawing.Size(172, 20);
      this.ctAlum.TabIndex = 3;
      // 
      // ctAsig
      // 
      this.ctAsig.Location = new System.Drawing.Point(98, 53);
      this.ctAsig.Name = "ctAsig";
      this.ctAsig.ReadOnly = true;
      this.ctAsig.Size = new System.Drawing.Size(172, 20);
      this.ctAsig.TabIndex = 3;
      // 
      // ctNota
      // 
      this.ctNota.Location = new System.Drawing.Point(98, 88);
      this.ctNota.Name = "ctNota";
      this.ctNota.Size = new System.Drawing.Size(49, 20);
      this.ctNota.TabIndex = 3;
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(98, 140);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 4;
      this.btAceptar.Text = "&Aceptar";
      this.btAceptar.UseVisualStyleBackColor = true;
      this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(195, 140);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 4;
      this.btCancelar.Text = "&Cancelar";
      this.btCancelar.UseVisualStyleBackColor = true;
      // 
      // ModificarNota
      // 
      this.AcceptButton = this.btAceptar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancelar;
      this.ClientSize = new System.Drawing.Size(282, 175);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.ctNota);
      this.Controls.Add(this.ctAsig);
      this.Controls.Add(this.ctAlum);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ModificarNota";
      this.Text = "Nota";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox ctAlum;
    private System.Windows.Forms.TextBox ctAsig;
    private System.Windows.Forms.TextBox ctNota;
    private System.Windows.Forms.Button btAceptar;
    private System.Windows.Forms.Button btCancelar;
  }
}