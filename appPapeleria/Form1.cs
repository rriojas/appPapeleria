using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPapeleria
{
  public partial class Form1 : Form
  {
    Articulo[] a;
    int indice;
    public Form1()
    {
      InitializeComponent();
      a = new Articulo[10];
      indice = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      int codigo = indice+1;// int.Parse( txtCodigo.Text);
      string nombre = txtNombre.Text;
      decimal existencia = decimal.Parse(txtExistencia.Text);
      decimal precio = decimal.Parse(txtPrecio.Text);
      a[indice]= new Articulo(codigo, nombre , existencia, precio );
      //txtCodigo.Clear();
      txtNombre.Clear();
      txtExistencia.Clear();
      txtPrecio.Clear();

      ListViewItem renglon = new ListViewItem(a[indice].Codigo.ToString());
      renglon.SubItems.Add(a[indice].Nombre);
      renglon.SubItems.Add(a[indice].Existencia.ToString());
      renglon.SubItems.Add(a[indice].Precio.ToString());

      lstvArticulos.Items.Add(renglon);
      indice++;
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem renglonSeleccionado in lstvArticulos.SelectedItems)
      {
        renglonSeleccionado.SubItems[2].Text = txtCambioExistencia.Text;
      }
      
    }
  }
}
