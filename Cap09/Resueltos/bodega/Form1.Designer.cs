namespace bodega
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuMostrarPedidos = new System.Windows.Forms.ToolStripMenuItem();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
      this.menuRealizarPedido = new System.Windows.Forms.ToolStripMenuItem();
      this.Panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuMostrarPedidos
      // 
      this.menuMostrarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("menuMostrarPedidos.Image")));
      this.menuMostrarPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.menuMostrarPedidos.Name = "menuMostrarPedidos";
      this.menuMostrarPedidos.Size = new System.Drawing.Size(138, 23);
      this.menuMostrarPedidos.Text = "Mostrar pedidos";
      this.menuMostrarPedidos.Click += new System.EventHandler(this.menuMostrarPedidos_Click);
      // 
      // Panel1
      // 
      this.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.Panel1.Controls.Add(this.PictureBox1);
      this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.Panel1.Location = new System.Drawing.Point(0, 268);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(492, 38);
      this.Panel1.TabIndex = 2;
      // 
      // PictureBox1
      // 
      this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
      this.PictureBox1.Location = new System.Drawing.Point(398, 0);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new System.Drawing.Size(94, 37);
      this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoCliente,
            this.menuRealizarPedido,
            this.menuMostrarPedidos});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(492, 27);
      this.BarraDeMenus.TabIndex = 3;
      this.BarraDeMenus.Text = "Barra de menús";
      // 
      // menuNuevoCliente
      // 
      this.menuNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("menuNuevoCliente.Image")));
      this.menuNuevoCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.menuNuevoCliente.Name = "menuNuevoCliente";
      this.menuNuevoCliente.Size = new System.Drawing.Size(120, 23);
      this.menuNuevoCliente.Text = "Nuevo cliente";
      this.menuNuevoCliente.Click += new System.EventHandler(this.menuNuevoCliente_Click);
      // 
      // menuRealizarPedido
      // 
      this.menuRealizarPedido.Image = ((System.Drawing.Image)(resources.GetObject("menuRealizarPedido.Image")));
      this.menuRealizarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.menuRealizarPedido.Name = "menuRealizarPedido";
      this.menuRealizarPedido.Size = new System.Drawing.Size(129, 23);
      this.menuRealizarPedido.Text = "Realizar pedido";
      this.menuRealizarPedido.Click += new System.EventHandler(this.menuRealizarPedido_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 306);
      this.Controls.Add(this.Panel1);
      this.Controls.Add(this.BarraDeMenus);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.BarraDeMenus;
      this.Name = "Form1";
      this.Text = "Bodega";
      this.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.ToolStripMenuItem menuMostrarPedidos;
    internal System.Windows.Forms.Panel Panel1;
    internal System.Windows.Forms.PictureBox PictureBox1;
    internal System.Windows.Forms.MenuStrip BarraDeMenus;
    internal System.Windows.Forms.ToolStripMenuItem menuNuevoCliente;
    internal System.Windows.Forms.ToolStripMenuItem menuRealizarPedido;
  }
}

