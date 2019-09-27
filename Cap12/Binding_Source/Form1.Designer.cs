namespace Binding_Source
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btModificar = new System.Windows.Forms.Button();
      this.btBorrar = new System.Windows.Forms.Button();
      this.btAñadir = new System.Windows.Forms.Button();
      this.ctTfno = new System.Windows.Forms.TextBox();
      this.ctNombre = new System.Windows.Forms.TextBox();
      this.ctTfnoSelec = new System.Windows.Forms.TextBox();
      this.listTfnos = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btModificar
      // 
      this.btModificar.Location = new System.Drawing.Point(221, 124);
      this.btModificar.Name = "btModificar";
      this.btModificar.Size = new System.Drawing.Size(170, 23);
      this.btModificar.TabIndex = 13;
      this.btModificar.Text = "Modificar";
      this.btModificar.UseVisualStyleBackColor = true;
      this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
      // 
      // btBorrar
      // 
      this.btBorrar.Location = new System.Drawing.Point(221, 95);
      this.btBorrar.Name = "btBorrar";
      this.btBorrar.Size = new System.Drawing.Size(170, 23);
      this.btBorrar.TabIndex = 12;
      this.btBorrar.Text = "Borrar";
      this.btBorrar.UseVisualStyleBackColor = true;
      this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
      // 
      // btAñadir
      // 
      this.btAñadir.Location = new System.Drawing.Point(221, 65);
      this.btAñadir.Name = "btAñadir";
      this.btAñadir.Size = new System.Drawing.Size(170, 23);
      this.btAñadir.TabIndex = 11;
      this.btAñadir.Text = "Añadir";
      this.btAñadir.UseVisualStyleBackColor = true;
      this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
      // 
      // ctTfno
      // 
      this.ctTfno.Location = new System.Drawing.Point(221, 39);
      this.ctTfno.Name = "ctTfno";
      this.ctTfno.Size = new System.Drawing.Size(170, 20);
      this.ctTfno.TabIndex = 10;
      // 
      // ctNombre
      // 
      this.ctNombre.Location = new System.Drawing.Point(221, 13);
      this.ctNombre.Name = "ctNombre";
      this.ctNombre.Size = new System.Drawing.Size(170, 20);
      this.ctNombre.TabIndex = 9;
      // 
      // ctTfnoSelec
      // 
      this.ctTfnoSelec.Location = new System.Drawing.Point(12, 127);
      this.ctTfnoSelec.Name = "ctTfnoSelec";
      this.ctTfnoSelec.ReadOnly = true;
      this.ctTfnoSelec.Size = new System.Drawing.Size(170, 20);
      this.ctTfnoSelec.TabIndex = 8;
      // 
      // listTfnos
      // 
      this.listTfnos.FormattingEnabled = true;
      this.listTfnos.Location = new System.Drawing.Point(12, 13);
      this.listTfnos.Name = "listTfnos";
      this.listTfnos.Size = new System.Drawing.Size(170, 95);
      this.listTfnos.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(403, 161);
      this.Controls.Add(this.btModificar);
      this.Controls.Add(this.btBorrar);
      this.Controls.Add(this.btAñadir);
      this.Controls.Add(this.ctTfno);
      this.Controls.Add(this.ctNombre);
      this.Controls.Add(this.ctTfnoSelec);
      this.Controls.Add(this.listTfnos);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btModificar;
    private System.Windows.Forms.Button btBorrar;
    private System.Windows.Forms.Button btAñadir;
    private System.Windows.Forms.TextBox ctTfno;
    private System.Windows.Forms.TextBox ctNombre;
    private System.Windows.Forms.TextBox ctTfnoSelec;
    private System.Windows.Forms.ListBox listTfnos;
  }
}

