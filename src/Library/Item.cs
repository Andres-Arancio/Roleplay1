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
    public new Item(string newName, int newAttack, int newDefense, int newHeal)
    {
        this.Name = newName;
        this.baseAttack = newAttack;
        this.baseDefense = newDefense;
        this.baseHeal= newHeal;
    }

    public void RemoveItem()
    {
        this = null;
    }
}