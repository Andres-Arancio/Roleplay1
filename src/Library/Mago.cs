using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Mago:IPersonaje
    {
        public string Nombre {get;set;}
        public int Vida{get;set;}
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public Mago(){}
        public Mago(string Nombre){
            this.Nombre=Nombre;
            this.Vida=120;
            this.Ataque=60;
            this.Defensa=20;
        }
        List<Item> Items = new List<Item>();
        
        public void AgregarItem(Item item){
            Items.Add(item);
            this.Ataque=this.Ataque+item.Ataque;
            this.Defensa=this.Defensa+item.Defensa;
        }

        public string Atacar(IPersonaje Atacado)
        {
            Atacado.Vida=Atacado.Vida-(this.Ataque-Atacado.Defensa);
            return $"El {this.Nombre} a inflingido un daño de {this.Ataque-Atacado.Defensa} a {Atacado.Nombre}.";

        }


        
        public void BorrarItem(Item item){
            Items.Remove(item);
            this.Ataque=this.Ataque-item.Ataque;
            this.Defensa=this.Defensa-item.Defensa;
        }

        ///Metodo para calcular el daño según los items
        /*public void CalcularEstadisticas(){
            foreach(Item i in Items){
                this.Ataque=this.Ataque+item.Ataque;
                this.Defensa=this.Defensa+item.Defensa;
            }
        }*/


        public string InvocarPersonaje(){
            return $"El {this.Nombre} tiene un ataque de {this.Ataque}, una defensa de {this.Defensa} y actualmente tiene {this.Vida} HP.";
        }
    }
}