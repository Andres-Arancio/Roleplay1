using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Item espada = new Item("Espada de Hierro Frio", 10, 2, 0);
            Item armadura = new Item("Armadura de Acero", 0, 10, 0);
            Item baston = new Item("Baston Magico", 2, 1, 0);
            Mago mago=new Mago("Mago");
            Hechizo fuego = new Hechizo("Bola magica", 20);
            Hechizo curar = new Hechizo("Toque de poder",10);
            Enano enano=new Enano("Enano");
            LibroHechizos libro=new LibroHechizos();
            libro.AgregarHechizo(curar);
            libro.AgregarHechizo(fuego);
            Console.WriteLine(mago.InvocarPersonaje());
            mago.AgregarItem(libro);
            Console.WriteLine(mago.InvocarPersonaje());
            Console.WriteLine(enano.InvocarPersonaje());
            Console.WriteLine(mago.Atacar(enano));
            Console.WriteLine(enano.InvocarPersonaje());
        }
    }
}
