namespace Roleplay;
using System.Collections;

public class Logica
{
    public Logica(){}
    public static void Atacar(IPersonaje Atacante,IPersonaje Atacado)
    {
        Atacado.Vida=Atacado.Vida-Atacante.Ataque;
        
    }




}

