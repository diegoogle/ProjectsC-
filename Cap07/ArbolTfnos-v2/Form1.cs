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
      CargarImagenes();
      CrearNodos();
    }

    public void CargarImagenes()
    {
      System.Drawing.Image miImagen;
      miImagen = Image.FromFile("..\\..\\Imagenes\\CarpetaCerrada.png");
      ImagsNodos.Images.Add(miImagen);
      miImagen = Image.FromFile("..\\..\\Imagenes\\CarpetaAbierta.png");
      ImagsNodos.Images.Add(miImagen);
    }

    private void CrearNodos()
    {
      // Nodo Amigos e hijos
      TreeNode NodoTfno1A = new TreeNode("teléfono 1A");
      NodoTfno1A.Name = "NodoTfno1A";
      NodoTfno1A.ImageIndex = 0;
      NodoTfno1A.SelectedImageIndex = 1;
      TreeNode NodoTfno2A = new TreeNode("teléfono 2A");
      NodoTfno2A.Name = "NodoTfno2A";
      NodoTfno2A.ImageIndex = 0;
      NodoTfno2A.SelectedImageIndex = 1;
      TreeNode NodoA = new TreeNode("A", new TreeNode[] { NodoTfno1A, NodoTfno2A });
      NodoA.Name = "NodoA";
      NodoA.ImageIndex = 0;
      NodoA.SelectedImageIndex = 1;
      TreeNode NodoAmigos = new TreeNode("Amigos", new TreeNode[] { NodoA });
      NodoAmigos.Name = "NodoAmigos";
      NodoAmigos.ImageIndex = 0;
      NodoAmigos.SelectedImageIndex = 1;

      // Nodo Clientes e hijos
      TreeNode NodoTfno1B = new TreeNode("teléfono 1B");
      NodoTfno1B.Name = "NodoTfno1B";
      NodoTfno1B.ImageIndex = 0;
      NodoTfno1B.SelectedImageIndex = 1;
      TreeNode NodoB = new TreeNode("B", new TreeNode[] { NodoTfno1B });
      NodoB.Name = "NodoB";
      NodoB.ImageIndex = 0;
      NodoB.SelectedImageIndex = 1;
      TreeNode NodoClientes = new TreeNode("Clientes", new TreeNode[] { NodoB });
      NodoClientes.Name = "NodoClientes";
      NodoClientes.ImageIndex = 0;
      NodoClientes.SelectedImageIndex = 1;

      // Nodo raíz del árbol
      TreeNode NodoRaiz = new TreeNode("Teléfonos", new TreeNode[] { NodoAmigos, NodoClientes });
      NodoRaiz.Name = "NodoRaiz";
      NodoRaiz.Text = "Teléfonos";
      NodoRaiz.ImageIndex = 0;
      NodoRaiz.SelectedImageIndex = 1;

      // Añadir la raíz a ArbolTfnos
      this.ArbolTfnos.Nodes.AddRange(new TreeNode[] { NodoRaiz });
    }
  }
}