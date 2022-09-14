using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Enano
    {
        public string Nombre {get;set;}
        public int Vida{get;set;}
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public Enano(){}
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
        public void CalcularEstadisticas(){
            foreach(Item i in Items){
                this.Ataque=this.Ataque+i.Ataque;
                this.Defensa=this.Defensa+i.Defensa;
            }
        }
    }
}