using NUnit.Framework;

namespace Roleplay
{
    [TestFixture]
    public class TestEnano
    {
        [Test]
        /// <summary>
        /// CrearEnano prueba el estado inicial de un Enano al ser creado
        /// </summary>
        public void CrearEnano()
        {
            Enano Enano1 = new Enano("Gimli");
            int VidaEsperado = 150;
            int AtaqueEsperado = 40;
            int DefensaEsperado = 50;
            Assert.AreEqual(VidaEsperado,Enano1.Vida);
            Assert.AreEqual(AtaqueEsperado,Enano1.Ataque);
            Assert.AreEqual(DefensaEsperado,Enano1.Defensa);
        }

        [Test]
        /// <summary>
        /// AgregarItemEnano prueba si al agregar un item nuevo, las estadisticas del enano se actualizan
        /// </summary>
        public void AgregarItemEnano()
        {
            Enano Enano2 = new Enano("Thorin");
            Item Shield1 = new Item("Oakenshield",5,40,0);
            int AtaqueEsperado = 45;
            int DefensaEsperado = 90;
            Enano2.AgregarItem(Shield1);
            Assert.AreEqual(AtaqueEsperado,Enano2.Ataque);
            Assert.AreEqual(DefensaEsperado,Enano2.Defensa);
        }

        [Test]
        /// <summary>
        /// RemoverItemEnano prueba si al quitar un item, las estadisticas del enano vuelven a su estado antes de tener el item
        /// </summary>
        public void RemoverItemEnano()
        {
            Enano Enano3 = new Enano("Dain");
            Item Botas1 = new Item("Ironfoot",30,20,0);
            int AtaqueEsperado = Enano3.Ataque;
            int DefensaEsperado = Enano3.Defensa;
            Enano3.AgregarItem(Botas1);
            Enano3.BorrarItem(Botas1);
            Assert.AreEqual(AtaqueEsperado,Enano3.Ataque);
            Assert.AreEqual(DefensaEsperado,Enano3.Defensa);
        }

        [Test]
        /// <summary>
        /// AtacarEnanoEsquiva prueba si un personaje enano ataca a un personaje con menos ataque que su defensa, no se inflije danho
        /// </summary>
        public void AtacarEnanoEsquiva()
        {
            Enano Enano4 = new Enano("Ulfric");
            Mago Mago1 = new Mago("Radagast");
            Item Armadura1 = new Item("Tunica del Maya",0,80,0);
            Mago1.AgregarItem(Armadura1);
            int VidaEsperado = Mago1.Vida;
            string resultado = Enano4.Atacar(Mago1);
            Assert.AreEqual(VidaEsperado,Mago1.Vida);
            Assert.AreEqual("No se ha inflingido daño.",resultado);
        }

        [Test]
        /// <summary>
        /// AtacarEnanoDano prueba que un enano con mas ataque que la defensa de otro personaje, al atacarlo el otro personaje pierde vida igual que la diferencia entre el ataque del enano y la defensa del otro
        /// </summary>
        public void AtacarElfoDano()
        {
            Enano Enano5 = new Enano("Bombur");
            Mago Mago2 = new Mago("Celuran");
            Item Espada1 = new Item("Mandoble Enano",30,5,0);
            Enano5.AgregarItem(Espada1);
            int VidaEsperado = Mago2.Vida-Enano5.Ataque+Mago2.Defensa;
            string resultado = Enano5.Atacar(Mago2);
            Assert.AreEqual(VidaEsperado,Mago2.Vida);
            Assert.AreEqual($"El {Enano5.Nombre} a inflingido un daño de {Enano5.Ataque-Mago2.Defensa} a {Mago2.Nombre}.", resultado);
        }
    }
}