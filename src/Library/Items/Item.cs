namespace Roleplay;
using System.Collections;

public class Item:IItems
{
    /*
    <summary>
    El item posee nombre, un modificador de ataque, un modificador de defensa y un factor de curar
    </summary>
    */
    public string Nombre {get ; set ;}
    public int Ataque {get ; set ;}
    public int Defensa {get ; set ;}
    public int Curar {get ; set ;}
    /*
    <summary>
    Constructor de Item
    </summary>
    */
    public Item(string nuevoNombre, int nuevoAtaque, int nuevoDefensa, int nuevoCurar)
    {
        this.Nombre = nuevoNombre;
        this.Ataque = nuevoAtaque;
        this.Defensa = nuevoDefensa;
        this.Curar= nuevoCurar;
    }
}