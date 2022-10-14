using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Mago:IPersonaje,IMagia
    {
        public string Nombre {get;set;}
        public int Vida{get;set;}
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int PoderMagico {get ; set ;}
        public Mago(){}
        public Mago(string Nombre){
            this.Nombre=Nombre;
            this.Vida=110;
            this.Ataque=50;
            this.Defensa=10;
            this.PoderMagico=0;
        }
        List<IItems> Items = new List<IItems>();
        
        public void AgregarItem(IItems item){
            Items.Add(item);
            this.Ataque=this.Ataque+item.Ataque;
            this.Defensa=this.Defensa+item.Defensa;

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


        
        public void BorrarItem(IItems item){
            Items.Remove(item);
            this.Ataque=this.Ataque-item.Ataque;
            this.Defensa=this.Defensa-item.Defensa;
        }

        public void AgregarLibroHechizo(LibroHechizos libroHechizos)
        {
            Items.Add(libroHechizos);
            this.PoderMagico=this.PoderMagico+libroHechizos.PoderMagico;
            
        }

        
        public void BorrarLibroHechizo(LibroHechizos libroHechizos)
        {
            Items.Remove(libroHechizos);
            this.PoderMagico=this.PoderMagico-libroHechizos.PoderMagico;
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