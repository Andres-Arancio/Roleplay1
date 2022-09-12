namespace Roleplay;
using System.Collections;

public class Item
{
    /*
    <summary>
    El item posee nombre, un modificador de ataque, un modificador de defensa y un factor de curar
    </summary>
    */
    string Nombre {get ; set ;}
    int Ataque {get ; set ;}
    int Defensa {get ; set ;}
    int Curar {get ; set ;}

    /*
    <summary>
    Constructor de Item
    </summary>
    */
    public new Item(string nuevoNombre, int nuevoAtaque, int nuevoDefensa, int nuevoCurar)
    {
        this.Nombre = nuevoNombre;
        this.Ataque = nuevoAtaque;
        this.Defensa = nuevoDefensa;
        this.Curar= nuevoCurar;
    }

    public void RemoverItem()
    {
        this = null;
    }
}