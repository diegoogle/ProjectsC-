using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArbolTfnos
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CrearNodos();
      //MostrarArbol(ArbolTfnos);
    }

    private void CrearNodos()
    {
      TreeNode nodoRaiz = ArbolTfnos.Nodes[0];
      TreeNode nodoCategoria = null; // nodo de bifurcación
      TreeNode nodoLetra = null;     // nodo de bifurcación
      Tfno nodoTelefono = null;      // nodo hoja

      nodoCategoria = new TreeNode("Amigos", 0, 1);
      nodoRaiz.Nodes.Add(nodoCategoria);

      nodoLetra = new TreeNode("A", 0, 1);
      nodoTelefono = new Tfno("Alfons", "Barcelona", 933333333, true, "Alfons", 0, 1);
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoTelefono = new Tfno("Ana", "Pontevedra", 986666666, true, "Ana", 0, 1);
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);

      nodoLetra = new TreeNode("B", 0, 1);
      nodoTelefono = new Tfno("Beatriz", "Santander", 942222222, false, "Beatriz", 0, 1);
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);

      nodoCategoria = new TreeNode("Clientes", 0, 1);
      nodoRaiz.Nodes.Add(nodoCategoria);

      nodoLetra = new TreeNode("A", 0, 1);
      nodoTelefono = new Tfno("Antonio", "Granada", 956666666, true, "Antonio", 0, 1);
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);
    }

    private void MostrarArbol(TreeView arbol)
    {
      foreach (TreeNode unNodo in arbol.Nodes)
        MostrarNodo(unNodo);
    }

    private void MostrarNodo(TreeNode nodo)
    {
      //System.Diagnostics.Debug.WriteLine(nodo.Text);
      MessageBox.Show(nodo.Text);
      foreach (TreeNode unNodo in nodo.Nodes)
        MostrarNodo(unNodo);
    }

    private void ArbolTfnos_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.GetType().Equals(Type.GetType("ArbolTfnos.Tfno")))
      {
        Tfno nodo = (Tfno)e.Node;
        MessageBox.Show(nodo.datosTfno(), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      //if (ArbolTfnos.SelectedNode.GetType().Equals(Type.GetType("ArbolTfnos.Tfno")))
      //{
      //  Tfno nodo = (Tfno)ArbolTfnos.SelectedNode;
      //  MessageBox.Show(nodo.datosTfno(), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //}
    }

    private void contextAñadirNodo_Click(object sender, EventArgs e)
    {
      if (ArbolTfnos.SelectedNode.GetType().Equals(Type.GetType("ArbolTfnos.Tfno")))
        return; // El nodo seleccionado es un nodo de la clase Tfno

      // El nodo seleccionado no es un nodo de la clase Tfno
      TreeNode nodoPadre = ArbolTfnos.SelectedNode;
      // Crear el nodo hijo
      TreeNode nodoHijo = null;
      switch (nodoPadre.Level)
      {
        case 0: // raíz del árbol: añadir categoría
          string categoria = "";
          DatoCategoria dlgCategoria = new DatoCategoria();
          if (dlgCategoria.ShowDialog() == DialogResult.OK)
            categoria = dlgCategoria.ctCategoria.Text;
          if (categoria.Length != 0)
            nodoHijo = new TreeNode(categoria, 0, 1);
          break;

        case 1: // categoría: añadir letra
          string letra = "";
          DatoLetra dlgLetra = new DatoLetra();
          if (dlgLetra.ShowDialog() == DialogResult.OK)
            letra = dlgLetra.ctLetra.Text;
          if (letra.Length != 0)
            nodoHijo = new TreeNode(letra, 0, 1);
          break;

        case 2: // letra: añadir teléfono
          DatosNodo dlgTfno = new DatosNodo();
          if (dlgTfno.ShowDialog() == DialogResult.OK)
          {
            string nombre = dlgTfno.ctNombre.Text;
            string direccion = dlgTfno.ctDirec.Text;
            long telefono = System.Convert.ToInt32(dlgTfno.ctTfno.Text);
            bool casado = dlgTfno.cvCasado.Checked;
            nodoHijo = new Tfno(nombre, direccion, telefono, casado, nombre, 0, 1);
          }
          break;
        default:
          return;
      }
      // Insertar el nodo en el árbol
      if (nodoHijo != null)
        nodoPadre.Nodes.Add(nodoHijo);
    }

    private void ArbolTfnos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      // Se hizo clic con el botón secundario del ratón
      // sobre un nodo; seleccionarlo.
      if (e.Button == MouseButtons.Right)
        ArbolTfnos.SelectedNode = e.Node;
    }

    private void ArbolTfnos_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      // Se modificó la etiqueta. Si se trata de un objeto Tfno
      // cambiar también el atributo nombre
      if (e.Node.GetType().Equals(Type.GetType("ArbolTfnos.Tfno")))
      {
        Tfno nodo = (Tfno)e.Node;
        nodo.nombre = nodo.Text;
      }
    }

    private void contextBorrarNodo_Click(object sender, EventArgs e)
    {
      // Borrar el nodo seleccionado y sus descendientes, excepto la raíz
      if (ArbolTfnos.SelectedNode.Equals(ArbolTfnos.Nodes[0])) return;
      ArbolTfnos.SelectedNode.Remove();
    }

    private void contextBorrarTodos_Click(object sender, EventArgs e)
    {
      // Borrar todos los nodos excepto la raíz
      foreach (TreeNode nodo in ArbolTfnos.Nodes[0].Nodes)
        nodo.Remove();
    }
  }
}