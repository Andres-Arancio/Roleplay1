namespace Roleplay;
using System.Collections;

public class Hechizo:IMagia
{
    public string Nombre {get ; set ;}

    public int PoderMagico {get ; set ;}
    

    public Hechizo(string nuevoNombre, int nuevoPoderMagico)
    {
        this.Nombre = nuevoNombre;
        this.PoderMagico=nuevoPoderMagico;
    }

}