using System;
using System.Collections.Generic;
namespace Roleplay
{
    class Enano
    {
        public string Nombre {get;}
        public int Vida{get;}
        public int Ataque{get;}
        public int Defensa{get;}
        public Enano(string Nombre){
            this.Nombre=Nombre;
            this.Vida=150;
            this.Ataque=40;
            this.Defensa=50;
        }
        List<Item> Items= new List<Item>();
        public void AgregarItem(Item item){
            Items.Add(item);
        }

        
        public void BorrarItem(Item item){
            Items.Remove(item);
        }

        ///Metodo para calcular el daño según los items
    }
}