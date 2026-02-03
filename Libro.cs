using System;

public class Libro
{
    // Atributos (estado del objeto)
    private string titulo;
    private string autor;
    private int paginas;
    private bool disponible;
    private string usuarioPrestamo;

    // Constructor
    public Libro(string titulo, string autor, int paginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.paginas = paginas;
        this.disponible = true;
        this.usuarioPrestamo = "";
    }

   // Método para mostrar información del libro
    public void MostrarInfo()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Páginas: " + paginas);
        Console.WriteLine("Disponible: " + (disponible ? "Sí" : "No"));
        
        if (!disponible)
        {
            Console.WriteLine("Prestado a: " + usuarioPrestamo);
        }
    }

    // Método para prestar el libro
    public void Prestar(string usuario)
    {
        if (disponible)
        {
            disponible = false;
            usuarioPrestamo = usuario;
            Console.WriteLine("Libro prestado correctamente a " + usuario);
        }
        else
        {
            Console.WriteLine("El libro no está disponible.");
        }
    }

    // Método para devolver el libro
    public void Devolver()
    {
        if (!disponible)
        {
            disponible = true;
            usuarioPrestamo = "";
            Console.WriteLine("El libro ha sido devuelto y está disponible.");
        }
        else
        {
            Console.WriteLine("El libro ya estaba disponible.");
        }
    }
}
