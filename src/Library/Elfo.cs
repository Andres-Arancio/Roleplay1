using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Elfo:IPersonaje
    {
        public string Nombre {get;set;}
        public int Vida{get;set;}
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public Elfo(){}
        public Elfo(string Nombre){
            this.Nombre=Nombre;
            this.Vida=140;
            this.Ataque=20;
            this.Defensa=30;
        }
        List<Item> Items = new List<Item>();
        public void AgregarItem(Item item){
            Items.Add(item);
            this.Ataque=this.Ataque+item.Ataque;
            this.Defensa=this.Defensa+item.Defensa;
        }

        
        public void BorrarItem(Item item){
            Items.Remove(item);
            this.Ataque=this.Ataque-item.Ataque;
            this.Defensa=this.Defensa-item.Defensa;
        }

        ///Metodo para calcular el daño según los items
        public string InvocarPersonaje(){
            return $"El {this.Nombre} tiene un ataque de {this.Ataque}, una defensa de {this.Defensa} y actualmente tiene {this.Vida} HP.";
        }
    }
}