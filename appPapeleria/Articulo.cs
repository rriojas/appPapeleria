using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPapeleria
{
  public class Articulo
  {
    //Variables GLOBALES
    int codigo;
    string nombre;
    decimal existencia;
    decimal precio;

    //Propiedades
    public int Codigo
    {
      get
      {
        return codigo;
      }
      set
      {
        codigo = value;
      }
    }
    public string Nombre
    {
      get
      {
        return nombre;
      }
      set
      {
        nombre = value;
      }
    }
    public decimal Existencia
    {
      get
      {
        return existencia;
      }
      set
      {
        existencia = value;
      }
    }
    public decimal Precio
    {
      get
      {
        return precio;
      }
      set
      {
        precio = value;
      }
    }
    //Constructores
    public Articulo()
    {
      codigo = 0;
      nombre = "";
      existencia = 0;
      precio = 0;
    }
    public Articulo(int codigo, string nombre, decimal existencia, decimal precio)
    {
      this.codigo  = codigo;
      this.nombre = nombre;
      this.existencia = existencia;
      this.precio = precio;
    }
    //Metodos
    public string MostrarInformacion(int codigo)
    {
      return nombre + " " + existencia + " $" + precio;
    }
   
  }
}
