using System;
using System.Collections.Generic;
namespace Roleplay
{
    public interface IPersonaje
    {
        public string Nombre {get;set;}
        public int Vida{get;set;}
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        
        public void AgregarItem(Item item)
        {
            
        }

        
        public void BorrarItem(Item item)
        {
            
        }

        public void Atacar()
        {

        }
        public void CuracionTotal()
        {

        }

    }



}
