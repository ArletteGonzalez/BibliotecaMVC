using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class LibroController
{
    static List<Libro> listaLibros = new List<Libro>();

    public void Registrar(Libro libro)
    {
        listaLibros.Add(libro);
    }

    public List<Libro> Listar()
    {
        return listaLibros;
    }

    public Libro Obtener(string codigo)
    {
        return listaLibros.FirstOrDefault(l => l.Codigo == codigo);
    }

    public bool Eliminar(string codigo)
    {
        var libro = Obtener(codigo);
        if (libro != null)
        {
            listaLibros.Remove(libro);
            return true;
        }
        return false;
    }
}