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

            Hechizo fuego = new Hechizo("Bola de Fuego", 20, 0);
            Hechizo curar = new Hechizo("Toque Curativo", 0, 10);
        }
    }
}
