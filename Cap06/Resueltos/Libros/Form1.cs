using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
  public partial class Form1 : Form
  {
    private SortedList<string, Libro> listaLibros;
    private DlgBuscarReg DlgBuscar;
    
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      listaLibros = new SortedList<string, Libro>();
    }

    private void CajaTexto_Enter(object sender, EventArgs e)
    {
      TextBox ObjTextBox = (TextBox)sender;
      ObjTextBox.SelectAll();
    }

    private void CajaTexto_MouseClick(object sender, MouseEventArgs e)
    {
      TextBox ObjTextBox = (TextBox)sender;
      ObjTextBox.SelectAll();
    }

    public SortedList<string, Libro> ObtenerDatos()
    {
      return listaLibros;
    }

    private void ArchivoAñadirReg_Click(object sender, EventArgs e)
    {
      if (ctTitulo.Text.Length == 0)
      {
        MessageBox.Show("El campo título no puede estar vacío");
        return;
      }

      Libro unLibro = new Libro(ctTitulo.Text, ctAutor.Text, ctEditorial.Text, ctPrestado.Text);

      // Insertar el objeto Libro en orden ascendente según el título
      try
      {
        listaLibros.Add(ctTitulo.Text, unLibro);
        if (DlgBuscar != null && !DlgBuscar.IsDisposed)
          DlgBuscar.Actualizar(listaLibros.IndexOfKey(ctTitulo.Text), unLibro);
      }
      catch (ArgumentException ex)
      {
        MessageBox.Show(ex.Message); // probablemente la clave ya existe
      }
    }

    private void ArchivoBuscarReg_Click(object sender, EventArgs e)
    {
      if (DlgBuscar == null || DlgBuscar.IsDisposed)
        DlgBuscar = new DlgBuscarReg();
      if (!DlgBuscar.Visible)
        DlgBuscar.Show(this); // this es el propietario (Owner) de DlgBuscar
    }

    public void MostrarRegDatos(string clave)
    {
      Libro libro = listaLibros[clave];
      ctTitulo.Text = libro.ObtenerTitulo();
      ctAutor.Text = libro.ObtenerAutor();
      ctEditorial.Text = libro.ObtenerEditorial();
      ctPrestado.Text = libro.ObtenerPrestado();
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
