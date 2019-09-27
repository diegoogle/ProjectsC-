namespace ControlesEnlazadosADatos
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
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
      this.components = new System.ComponentModel.Container();
      this.Label5 = new System.Windows.Forms.Label();
      this.btBorrar = new System.Windows.Forms.Button();
      this.btAñadir = new System.Windows.Forms.Button();
      this.btUltimo = new System.Windows.Forms.Button();
      this.btSiguiente = new System.Windows.Forms.Button();
      this.etPosicion = new System.Windows.Forms.Label();
      this.btAnterior = new System.Windows.Forms.Button();
      this.btPrimero = new System.Windows.Forms.Button();
      this.ctNotas = new System.Windows.Forms.TextBox();
      this.ctBuscar = new System.Windows.Forms.TextBox();
      this.btBuscar = new System.Windows.Forms.Button();
      this.Label4 = new System.Windows.Forms.Label();
      this.ctTelefono = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.ctDireccion = new System.Windows.Forms.TextBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.ctNombre = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.dsTelefonos = new ControlesEnlazadosADatos.dsTelefonos();
      this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.telefonosTableAdapter = new ControlesEnlazadosADatos.dsTelefonosTableAdapters.telefonosTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // Label5
      // 
      this.Label5.AutoSize = true;
      this.Label5.Location = new System.Drawing.Point(262, 78);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(43, 13);
      this.Label5.TabIndex = 51;
      this.Label5.Text = "Buscar:";
      // 
      // btBorrar
      // 
      this.btBorrar.Location = new System.Drawing.Point(312, 43);
      this.btBorrar.Name = "btBorrar";
      this.btBorrar.Size = new System.Drawing.Size(64, 23);
      this.btBorrar.TabIndex = 50;
      this.btBorrar.Text = "Borrar";
      this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
      // 
      // btAñadir
      // 
      this.btAñadir.Location = new System.Drawing.Point(312, 13);
      this.btAñadir.Name = "btAñadir";
      this.btAñadir.Size = new System.Drawing.Size(64, 23);
      this.btAñadir.TabIndex = 49;
      this.btAñadir.Text = "Añadir";
      this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
      // 
      // btUltimo
      // 
      this.btUltimo.Location = new System.Drawing.Point(312, 184);
      this.btUltimo.Name = "btUltimo";
      this.btUltimo.Size = new System.Drawing.Size(64, 23);
      this.btUltimo.TabIndex = 48;
      this.btUltimo.Text = "Último";
      this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
      // 
      // btSiguiente
      // 
      this.btSiguiente.Location = new System.Drawing.Point(242, 184);
      this.btSiguiente.Name = "btSiguiente";
      this.btSiguiente.Size = new System.Drawing.Size(64, 23);
      this.btSiguiente.TabIndex = 47;
      this.btSiguiente.Text = "Siguiente";
      this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
      // 
      // etPosicion
      // 
      this.etPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.etPosicion.Location = new System.Drawing.Point(162, 183);
      this.etPosicion.Name = "etPosicion";
      this.etPosicion.Size = new System.Drawing.Size(72, 23);
      this.etPosicion.TabIndex = 46;
      this.etPosicion.Text = "No registros";
      this.etPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btAnterior
      // 
      this.btAnterior.Location = new System.Drawing.Point(87, 184);
      this.btAnterior.Name = "btAnterior";
      this.btAnterior.Size = new System.Drawing.Size(64, 23);
      this.btAnterior.TabIndex = 45;
      this.btAnterior.Text = "Anterior";
      this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
      // 
      // btPrimero
      // 
      this.btPrimero.Location = new System.Drawing.Point(17, 184);
      this.btPrimero.Name = "btPrimero";
      this.btPrimero.Size = new System.Drawing.Size(64, 23);
      this.btPrimero.TabIndex = 44;
      this.btPrimero.Text = "Primero";
      this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
      // 
      // ctNotas
      // 
      this.ctNotas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "observaciones", true));
      this.ctNotas.Location = new System.Drawing.Point(97, 108);
      this.ctNotas.Multiline = true;
      this.ctNotas.Name = "ctNotas";
      this.ctNotas.Size = new System.Drawing.Size(208, 56);
      this.ctNotas.TabIndex = 43;
      // 
      // ctBuscar
      // 
      this.ctBuscar.Location = new System.Drawing.Point(312, 78);
      this.ctBuscar.Name = "ctBuscar";
      this.ctBuscar.Size = new System.Drawing.Size(64, 20);
      this.ctBuscar.TabIndex = 52;
      // 
      // btBuscar
      // 
      this.btBuscar.Location = new System.Drawing.Point(312, 108);
      this.btBuscar.Name = "btBuscar";
      this.btBuscar.Size = new System.Drawing.Size(64, 23);
      this.btBuscar.TabIndex = 53;
      this.btBuscar.Text = "Buscar";
      this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
      // 
      // Label4
      // 
      this.Label4.AutoSize = true;
      this.Label4.Location = new System.Drawing.Point(12, 108);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(38, 13);
      this.Label4.TabIndex = 42;
      this.Label4.Text = "Notas:";
      // 
      // ctTelefono
      // 
      this.ctTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "telefono", true));
      this.ctTelefono.Location = new System.Drawing.Point(97, 78);
      this.ctTelefono.Name = "ctTelefono";
      this.ctTelefono.Size = new System.Drawing.Size(104, 20);
      this.ctTelefono.TabIndex = 41;
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.Location = new System.Drawing.Point(12, 78);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(49, 13);
      this.Label3.TabIndex = 40;
      this.Label3.Text = "Teléfono";
      // 
      // ctDireccion
      // 
      this.ctDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "direccion", true));
      this.ctDireccion.Location = new System.Drawing.Point(97, 43);
      this.ctDireccion.Name = "ctDireccion";
      this.ctDireccion.Size = new System.Drawing.Size(208, 20);
      this.ctDireccion.TabIndex = 39;
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(12, 43);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(55, 13);
      this.Label2.TabIndex = 38;
      this.Label2.Text = "Dirección:";
      // 
      // ctNombre
      // 
      this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "nombre", true));
      this.ctNombre.Location = new System.Drawing.Point(97, 13);
      this.ctNombre.Name = "ctNombre";
      this.ctNombre.Size = new System.Drawing.Size(208, 20);
      this.ctNombre.TabIndex = 37;
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(12, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(47, 13);
      this.Label1.TabIndex = 36;
      this.Label1.Text = "Nombre:";
      // 
      // dsTelefonos
      // 
      this.dsTelefonos.DataSetName = "dsTelefonos";
      this.dsTelefonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // telefonosBindingSource
      // 
      this.telefonosBindingSource.DataMember = "telefonos";
      this.telefonosBindingSource.DataSource = this.dsTelefonos;
      // 
      // telefonosTableAdapter
      // 
      this.telefonosTableAdapter.ClearBeforeFill = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 221);
      this.Controls.Add(this.Label5);
      this.Controls.Add(this.btBorrar);
      this.Controls.Add(this.btAñadir);
      this.Controls.Add(this.btUltimo);
      this.Controls.Add(this.btSiguiente);
      this.Controls.Add(this.etPosicion);
      this.Controls.Add(this.btAnterior);
      this.Controls.Add(this.btPrimero);
      this.Controls.Add(this.ctNotas);
      this.Controls.Add(this.ctBuscar);
      this.Controls.Add(this.btBuscar);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.ctTelefono);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.ctDireccion);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.ctNombre);
      this.Controls.Add(this.Label1);
      this.Name = "Form1";
      this.Text = "BD teléfonos";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Label5;
    private System.Windows.Forms.Button btBorrar;
    private System.Windows.Forms.Button btAñadir;
    private System.Windows.Forms.Button btUltimo;
    private System.Windows.Forms.Button btSiguiente;
    private System.Windows.Forms.Label etPosicion;
    private System.Windows.Forms.Button btAnterior;
    private System.Windows.Forms.Button btPrimero;
    private System.Windows.Forms.TextBox ctNotas;
    private System.Windows.Forms.TextBox ctBuscar;
    private System.Windows.Forms.Button btBuscar;
    private System.Windows.Forms.Label Label4;
    private System.Windows.Forms.TextBox ctTelefono;
    private System.Windows.Forms.Label Label3;
    private System.Windows.Forms.TextBox ctDireccion;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.TextBox ctNombre;
    private System.Windows.Forms.Label Label1;
    private dsTelefonos dsTelefonos;
    private System.Windows.Forms.BindingSource telefonosBindingSource;
    private dsTelefonosTableAdapters.telefonosTableAdapter telefonosTableAdapter;



  }
}

