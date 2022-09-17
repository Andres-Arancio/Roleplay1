using System;
using System.Collections.Generic;

namespace Roleplay;
public class Magos{

    public string nombre {get;set;}
    public int vida {get;set;}
    public int ataque{get;}
    public int defensa{get;}
   

    //public LibroHechizos libro {get;set;} //Preciso la clase LibroHechizos

    public Magos(){}

    public Magos(string nombre){ 
        this.nombre = nombre;
        this.vida = 150;
        this.ataque = 20;
        this.defensa = 80;

    }

    List<Item> Items= new List<Item>();
    public void AgregarItem(Item item){
         Items.Add(item);
    }

        
    public void BorrarItem(Item item){
            Items.Remove(item);
        }


}