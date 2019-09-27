namespace Libros
{
  partial class DlgBuscarReg
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
      this.btBorrar = new System.Windows.Forms.Button();
      this.btCancelar = new System.Windows.Forms.Button();
      this.btAceptar = new System.Windows.Forms.Button();
      this.lsListaLibros = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btBorrar
      // 
      this.btBorrar.Location = new System.Drawing.Point(205, 69);
      this.btBorrar.Name = "btBorrar";
      this.btBorrar.Size = new System.Drawing.Size(75, 23);
      this.btBorrar.TabIndex = 11;
      this.btBorrar.Text = "&Borrar";
      this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(205, 40);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 10;
      this.btCancelar.Text = "&Cancelar";
      this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
      // 
      // btAceptar
      // 
      this.btAceptar.Location = new System.Drawing.Point(205, 11);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 9;
      this.btAceptar.Text = "&Aceptar";
      this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
      // 
      // lsListaLibros
      // 
      this.lsListaLibros.FormattingEnabled = true;
      this.lsListaLibros.Location = new System.Drawing.Point(12, 10);
      this.lsListaLibros.Name = "lsListaLibros";
      this.lsListaLibros.Size = new System.Drawing.Size(185, 147);
      this.lsListaLibros.TabIndex = 8;
      // 
      // DlgBuscarReg
      // 
      this.AcceptButton = this.btAceptar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancelar;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.Controls.Add(this.btBorrar);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.lsListaLibros);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgBuscarReg";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Buscar registro";
      this.Load += new System.EventHandler(this.DlgBuscarReg_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btBorrar;
    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Button btAceptar;
    private System.Windows.Forms.ListBox lsListaLibros;
  }
}