using System;               // Clases fundamentales.
using System.Windows.Forms; // Clase Form.
using System.Drawing;       // Objetos gráficos.

public class Form1 : Form
{
  // Atributos
  private Label etSaludo;
  private Button btSaludo;
  private ToolTip ttToolTip1;

  // Métodos
  public Form1() : base()
  {
    IniciarComponentes();
  }

  public void IniciarComponentes()
  {
    // Construir aquí los controles
    etSaludo = new Label();
    btSaludo = new Button();
    ttToolTip1 = new ToolTip();

    // Iniciar la etiqueta etSaludo
    etSaludo.Name = "etSaludo";
    etSaludo.Text = "etiqueta";

    etSaludo.Font = new Font("Microsoft Sans Serif", 14,
                             FontStyle.Regular);
    etSaludo.TextAlign = ContentAlignment.MiddleCenter;
    etSaludo.Location = new Point(53, 48);
    etSaludo.Size = new Size(187, 35);
    etSaludo.TabIndex = 1;

    // Iniciar el botón btSaludo
    btSaludo.Name = "btSaludo";
    btSaludo.Text = "Haga &clic aquí";
    btSaludo.Location = new Point(53, 90);
    btSaludo.Size = new Size(187, 23);
    btSaludo.TabIndex = 0;
    ttToolTip1.SetToolTip(btSaludo, "Botón de pulsación");
    btSaludo.Click += new EventHandler(this.btSaludo_Click);
 
    // Iniciar formulario: objeto de la clase Form1
    ClientSize = new Size(292, 191); // tamaño
    Name = "Form1";                  // nombre
    Text = "Saludo";                 // título

    Controls.Add(etSaludo);
    Controls.Add(btSaludo);
  }

  protected override void Dispose(bool eliminar)
  {
    if (eliminar)
    {
    }
    base.Dispose(eliminar);
  }

  private void btSaludo_Click(object sender, EventArgs e)
  {
    etSaludo.Text = "¡¡¡Hola mundo!!!";
  }

  public static void Main()
  {
    Application.Run(new Form1());
  }
}
