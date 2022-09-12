namespace Roleplay;
using System.Collections;

public class Hechizo
{
    string Nombre {get ; set ;}
    int Ataque {get ; set ;}
    int Curar {get ; set ;}

    public Hechizo(string nuevoNombre, string nuevoAtaque, string nuevoCurar)
    {
        this.Nombre = nuevoNombre;
        this.Ataque = nuevoAtaque;
        this.Curar = nuevoCurar;
    }

}