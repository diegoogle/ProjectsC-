using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ListView
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      if (File.Exists("NodosPredeterminado.bin"))
      {
        // Eliminar la configuaci�n inicialmnte establecida
        ArbolTfnos.Nodes.Clear();
        // Obtener los datos del fichero
        Deseriar("NodosPredeterminado.bin");
      }
      else
        // Llamarla en el primer test para crear el �rbol y guardarlo
        CrearNodos();
    }

    private void CrearNodos()
    {
      TreeNode nodoRaiz = ArbolTfnos.Nodes[0];
      TreeNode nodoCategoria = null; // nodo de bifurcaci�n
      TreeNode nodoLetra = null;     // nodo de bifurcaci�n
      Tfno nodoTelefono = null;      // nodo hoja

      nodoCategoria = new TreeNode("Amigos", 0, 1);
      nodoCategoria.Name = nodoCategoria.Text;
      nodoRaiz.Nodes.Add(nodoCategoria);

      nodoLetra = new TreeNode("A", 0, 1);
      nodoLetra.Name = nodoLetra.Text;
      nodoTelefono = new Tfno("Alfons", "Barcelona", 933333333, true, "Alfons", 0, 1);
      nodoTelefono.Name = nodoTelefono.Text;
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoTelefono = new Tfno("Ana", "Pontevedra", 986666666, true, "Ana", 0, 1);
      nodoTelefono.Name = nodoTelefono.Text;
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);

      nodoLetra = new TreeNode("B", 0, 1);
      nodoLetra.Name = nodoLetra.Text;
      nodoTelefono = new Tfno("Beatriz", "Santander", 942222222, false, "Beatriz", 0, 1);
      nodoTelefono.Name = nodoTelefono.Text;
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);

      nodoCategoria = new TreeNode("Clientes", 0, 1);
      nodoCategoria.Name = nodoCategoria.Text;
      nodoRaiz.Nodes.Add(nodoCategoria);

      nodoLetra = new TreeNode("A", 0, 1);
      nodoLetra.Name = nodoLetra.Text;
      nodoTelefono = new Tfno("Antonio", "Granada", 956666666, true, "Antonio", 0, 1);
      nodoTelefono.Name = nodoTelefono.Text;
      nodoLetra.Nodes.Add(nodoTelefono);
      nodoCategoria.Nodes.Add(nodoLetra);
    }

    private void MostrarDetalles(Tfno nodo)
    {
      ListViewItem elemento = new ListViewItem(nodo.nombre, 0);
      elemento.SubItems.Add(nodo.direcci�n);
      elemento.SubItems.Add(nodo.tel�fono.ToString());
      string casado = "No";
      if (nodo.casado)
      {
        casado = "S�";
      }
      elemento.SubItems.Add(casado);
      listviewTfnos.Items.Add(elemento);
    }

    private void MostrarLista(TreeNode nodoSelec)
    {
      foreach (TreeNode unNodo in nodoSelec.Nodes)
      {
        ListViewItem elemento = new ListViewItem(unNodo.Text, 0);
        listviewTfnos.Items.Add(elemento);
      }
    }

    private void ArbolTfnos_AfterSelect(object sender, TreeViewEventArgs e)
    {
      listviewTfnos.Items.Clear();
      listviewTfnos.View = View.Details;
      if (e.Node.GetType().Equals(Type.GetType("ListView.Tfno")))
        MostrarDetalles((Tfno)e.Node);
      else
        MostrarLista(ArbolTfnos.SelectedNode);
    }

    private void contextA�adirNodo_Click(object sender, EventArgs e)
    {
      if (ArbolTfnos.SelectedNode.GetType().Equals(Type.GetType("ListView.Tfno")))
        return; // El nodo seleccionado es un nodo de la clase Tfno

      // El nodo seleccionado no es un nodo de la clase Tfno
      TreeNode nodoPadre = ArbolTfnos.SelectedNode;
      // Crear el nodo hijo
      TreeNode nodoHijo = null;
      switch (nodoPadre.Level)
      {
        case 0: // ra�z del �rbol: a�adir categor�a
          string categoria = "";
          DatoCategoria dlgCategoria = new DatoCategoria();
          if (dlgCategoria.ShowDialog() == DialogResult.OK)
            categoria = dlgCategoria.ctCategoria.Text;
          if (categoria.Length != 0)
            nodoHijo = new TreeNode(categoria, 0, 1);
          break;

        case 1: // categor�a: a�adir letra
          string letra = "";
          DatoLetra dlgLetra = new DatoLetra();
          if (dlgLetra.ShowDialog() == DialogResult.OK)
            letra = dlgLetra.ctLetra.Text;
          if (letra.Length != 0)
            nodoHijo = new TreeNode(letra, 0, 1);
          break;

        case 2: // letra: a�adir tel�fono
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
      // Insertar el nodo en el �rbol
      if (nodoHijo != null)
        nodoPadre.Nodes.Add(nodoHijo);
    }

    private void ArbolTfnos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {

    }

    private void ArbolTfnos_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      // Se modific� la etiqueta. Si se trata de un objeto Tfno
      // cambiar tambi�n el atributo nombre
      if (e.Node.GetType().Equals(Type.GetType("ListView.Tfno")))
      {
        Tfno nodo = (Tfno)e.Node;
        nodo.nombre = nodo.Text;
      }
    }

    private void contextBorrarNodo_Click(object sender, EventArgs e)
    {
      // Borrar el nodo seleccionado y sus descendientes, excepto la ra�z
      if (ArbolTfnos.SelectedNode.Equals(ArbolTfnos.Nodes[0])) return;
      ArbolTfnos.SelectedNode.Remove();
    }

    private void contextBorrarTodos_Click(object sender, EventArgs e)
    {
      // Borrar todos los nodos excepto la ra�z
      foreach (TreeNode nodo in ArbolTfnos.Nodes[0].Nodes)
        nodo.Remove();
      // Si el nodo seleccionado es la ra�z no se invoca a
      // ArbolTfnos_AfterSelect y no se borrar�a el ListView
      if (ArbolTfnos.SelectedNode.Equals(ArbolTfnos.Nodes[0]))
        listviewTfnos.Items.Clear();
    }

    private void listviewTfnos_DoubleClick(object sender, EventArgs e)
    {
      System.Windows.Forms.ListView lista = (System.Windows.Forms.ListView)sender;
      // Recuperar la etiqueta del nodo de la lista sobre el que el usuario
      // ha hecho doble clic
      string clave = lista.SelectedItems[0].Text;
      // Buscar en el �rbol el nodo que tiene esa etiqueta
      TreeNode[] nodosEncontrados;
      // La clave de un nodo es su propiedad Name.
      // Al construir el �rbol hicimos nodo.Name = nodo.Text
      nodosEncontrados = ArbolTfnos.SelectedNode.Nodes.Find(clave, false);
      if (nodosEncontrados.Length == 0) return;
      // El nodo sobre el que el usuario hizo doble clic,
      // pasa a ser el nodo actualmente seleccionado
      ArbolTfnos.SelectedNode = nodosEncontrados[0]; // se gnera el evento AfterSelect y
      // se ejecuta ArbolTfnos_AfterSelect
    }

    private void Deseriar(string fichero)
    {
      Stream fs = File.OpenRead(fichero);
      BinaryFormatter deseriador = new BinaryFormatter();
      // A�adir los nodos al �rbol
      TreeNode nodoRaiz = (TreeNode)deseriador.Deserialize(fs);
      ArbolTfnos.Nodes.Add(nodoRaiz);
      fs.Close();
      ArbolTfnos.SelectedNode = nodoRaiz;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (File.Exists("NodosPredeterminado.bin"))
      {
        DialogResult respuesta;
        respuesta = MessageBox.Show("�Desea sobrescribir el fichero predeterminado?", "Seleccione una opci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.No)
        {
          ArchivoGuardar.PerformClick(); // clic en Guardar
          return;
        }
      }
      Seriar("NodosPredeterminado.bin");
    }

    private void Seriar(string fichero)
    {
      if (ArbolTfnos.Nodes.Count == 0)
      {
        return;
      }
      Stream fs = File.Create(fichero);
      BinaryFormatter seriador = new BinaryFormatter();
      seriador.Serialize(fs, ArbolTfnos.Nodes[0]);
      fs.Close();
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      OpenFileDialog DlgAbrir = new OpenFileDialog();

      DlgAbrir.InitialDirectory = Directory.GetCurrentDirectory();
      DlgAbrir.Filter = "fichero binario (*.bin)|*.bin";
      DlgAbrir.FilterIndex = 1;
      DlgAbrir.RestoreDirectory = true;

      // Mostrar el di�logo Abrir
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // Eliminar la configuaci�n inicialmnte establecida
        ArbolTfnos.Nodes.Clear();
        // Obtener los datos del fichero
        Deseriar(DlgAbrir.FileName);
      }
    }

    private void ArchivoGuardar_Click(object sender, EventArgs e)
    {
      SaveFileDialog DlgGuardar = new SaveFileDialog();

      DlgGuardar.InitialDirectory = Directory.GetCurrentDirectory();
      DlgGuardar.Filter = "fichero binario (*.bin)|*.bin";
      DlgGuardar.FilterIndex = 1;
      DlgGuardar.RestoreDirectory = true;

      if (DlgGuardar.ShowDialog() == DialogResult.OK)
      {
        // Guardar los datos en el fichero
        Seriar(DlgGuardar.FileName);
      }
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void AyudaAcercade_Click(object sender, EventArgs e)
    {
      string mensaje = "Aplicaci�n Reloj Despertador. Versi�n 1.0" + Environment.NewLine + "Copyright (c) Fco. Javier Ceballos, 2006";
      MessageBox.Show(mensaje, "Acerca de Reloj Despertador");
    }
  }
}