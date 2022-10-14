using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Enano:IPersonaje
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
        public string Atacar(IPersonaje Atacado)
        {
            if ((this.Ataque-Atacado.Defensa)>0)
            {Atacado.Vida=Atacado.Vida-(this.Ataque-Atacado.Defensa);
            return $"El {this.Nombre} a inflingido un daño de {this.Ataque-Atacado.Defensa} a {Atacado.Nombre}.";}
            else 
            {
                return $"No se ha inflingido daño.";
            }
        }
        public string InvocarPersonaje(){
            return $"El {this.Nombre} tiene un ataque de {this.Ataque}, una defensa de {this.Defensa} y actualmente tiene {this.Vida} HP.";
        }
    }
}