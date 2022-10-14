using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class LibroHechizos:IMagia,IItems
    {
        public string Nombre {get;set;}       
        public int Ataque {get ; set ;}
        public int Defensa {get ; set ;}
        public int Curar {get ; set ;}
        public int PoderMagico {get ; set ;}
        List<Hechizo> Hechizos = new List<Hechizo>();
        public void AgregarHechizo(Hechizo hechizo)
        {
            Hechizos.Add(hechizo);
            this.PoderMagico=this.PoderMagico+hechizo.PoderMagico;
            this.Ataque=this.Ataque+hechizo.PoderMagico;
            this.Defensa=this.Defensa+hechizo.PoderMagico;   
        }
        public void BorrarHechizo(Hechizo hechizo)
        {
            Hechizos.Remove(hechizo);
            this.PoderMagico=this.PoderMagico-hechizo.PoderMagico;
            this.Ataque=this.Ataque-hechizo.PoderMagico;
            this.Defensa=this.Defensa-hechizo.PoderMagico;
        }
    }
}