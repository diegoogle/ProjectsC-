using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesEnlazadosADatos
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsTelefonos.telefonos' Puede moverla o quitarla según sea necesario.
      this.telefonosTableAdapter.Fill(this.dsTelefonos.telefonos);
      MostrarPosicion();
    }

    private void MostrarPosicion()
    {
      // Total registros
      int iTotal = telefonosBindingSource.Count;
      // Número (1, 2, ...) de registro
      int iPos;

      if (iTotal == 0)
        etPosicion.Text = "No registros";
      else
      {
        iPos = telefonosBindingSource.Position + 1;
        // Mostrar información en la etiqueta
        etPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
      }
    }

    private void btPrimero_Click(object sender, EventArgs e)
    {
      telefonosBindingSource.Position = 0;
      MostrarPosicion();
    }

    private void btAnterior_Click(object sender, EventArgs e)
    {
      telefonosBindingSource.Position -= 1;
      MostrarPosicion();
    }

    private void btSiguiente_Click(object sender, EventArgs e)
    {
      telefonosBindingSource.Position += 1;
      MostrarPosicion();
    }

    private void btUltimo_Click(object sender, EventArgs e)
    {
      telefonosBindingSource.Position = telefonosBindingSource.Count - 1;
      MostrarPosicion();
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      DataTable miTabla = dsTelefonos.telefonos;
      DataRowCollection cfilas = miTabla.Rows;
      DataRow nuevaFila;
      try
      {
        // Nueva fila
        nuevaFila = miTabla.NewRow();
        // Datos por omisión para las columnas de la nueva fila
        nuevaFila[0] = "Nombre";        // columna 0
        nuevaFila[1] = "Dirección";     // columna 1
        nuevaFila[2] = "Teléfono";      // columna 2
        nuevaFila[3] = "Observaciones"; // columna 3
        cfilas.Add(nuevaFila);
        btUltimo.PerformClick(); //hacer clic en Último
        MostrarPosicion();
        ctNombre.Focus(); // enfocar la caja de texto ctNombre
      }
      catch (ConstraintException ex)
      {
        // Capturar posible error por clave duplicada (teléfono)
        MessageBox.Show(ex.Message);
      }
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      DataRowView vistaFilaActual;
      string NL = Environment.NewLine;

      if (MessageBox.Show("¿Desea borrar este registro?" +
          NL, "Buscar", MessageBoxButtons.YesNo,
          MessageBoxIcon.Question) == DialogResult.Yes)
      {
        vistaFilaActual = ((DataRowView)telefonosBindingSource.Current);
        vistaFilaActual.Row.Delete();
        MostrarPosicion();
      }
    }

    private void btBuscar_Click(object sender, EventArgs e)
    {
      DataTable miTabla = dsTelefonos.telefonos;
      DataRowCollection cfilas = miTabla.Rows;
      DataRow[] filaBuscada; // matriz de filas
      string NL = Environment.NewLine;

      // Buscar en la columna Nombre de cada fila
      string criterio = "Nombre Like '*" + ctBuscar.Text + "*'";

      // Utilizar el método Select para encontrar todas las filas que
      // pasen el filtro y almacenarlas en la matriz filaBuscada
      filaBuscada = miTabla.Select(criterio);

      if (filaBuscada.GetUpperBound(0) == -1)
      {
        MessageBox.Show("No se encontraron registros coincidentes", "Buscar");
        return;
      }

      // Seleccionar de las filas encontradas la que buscamos
      int i, j;
      for (i = 0; i <= filaBuscada.GetUpperBound(0); i++)
      {
        if (MessageBox.Show("¿Es este el nombre buscado?" + NL +
             (string)filaBuscada[i]["nombre"] + NL, "Buscar",
             MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          // Si: mostrar en el formulario la fila seleccionada
          telefonosBindingSource.Position = cfilas.IndexOf(filaBuscada[i]);
          MostrarPosicion();
          break;
        }
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (dsTelefonos.HasChanges())
      {
        telefonosTableAdapter.Update(dsTelefonos.telefonos);
        MessageBox.Show("Origen de datos actualizado");
      }
    }
  }
}
