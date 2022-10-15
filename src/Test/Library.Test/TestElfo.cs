using NUnit.Framework;

namespace Roleplay
{
    [TestFixture]
    public class TestElfo
    {
        [Test]
        /// <summary>
        /// CrearElfo prueba el estado inicial de un Elfo al ser creado
        /// </summary>
        public void CrearElfo()
        {
            Elfo Elfo1 = new Elfo("Legolas");
            int VidaEsperado = 140;
            int AtaqueEsperado = 20;
            int DefensaEsperado = 30;
            Assert.AreEqual(VidaEsperado,Elfo1.Vida);
            Assert.AreEqual(AtaqueEsperado,Elfo1.Ataque);
            Assert.AreEqual(DefensaEsperado,Elfo1.Defensa);
        }

        [Test]
        /// <summary>
        /// AgregarItemElfo prueba si al agregar un item nuevo, las estadisticas del elfo se actualizan
        /// </summary>
        public void AgregarItemElfo()
        {
            Elfo Elfo2 = new Elfo("Elrond");
            Item Anillo1 = new Item("Vilya the Ring of Air",5,30,0);
            int AtaqueEsperado = 25;
            int DefensaEsperado = 60;
            Elfo2.AgregarItem(Anillo1);
            Assert.AreEqual(AtaqueEsperado,Elfo2.Ataque);
            Assert.AreEqual(DefensaEsperado,Elfo2.Defensa);
        }

        [Test]
        /// <summary>
        /// RemoverItemElfo prueba si al quitar un item, las estadisticas del elfo vuelven a su estado antes de tener el item
        /// </summary>
        public void RemoverItemElfo()
        {
            Elfo Elfo3 = new Elfo("Galadriel");
            Item Anillo2 = new Item("Nenya the Ring of Water",10,25,0);
            int AtaqueEsperado = Elfo3.Ataque;
            int DefensaEsperado = Elfo3.Defensa;
            Elfo3.AgregarItem(Anillo2);
            Elfo3.BorrarItem(Anillo2);
            Assert.AreEqual(AtaqueEsperado,Elfo3.Ataque);
            Assert.AreEqual(DefensaEsperado,Elfo3.Defensa);
        }

        [Test]
        /// <summary>
        /// AtacarElfoEsquiva prueba si un personaje elfo ataca a un personaje con menos ataque que su defensa, no se inflije danho
        /// </summary>
        public void AtacarElfoEsquiva()
        {
            Elfo Elfo4 = new Elfo("Celeborn");
            Enano Enano1 = new Enano("Rosto");
            Item Armadura1 = new Item("Armadura de Mithril",0,20,0);
            Enano1.AgregarItem(Armadura1);
            int VidaEsperado = Enano1.Vida;
            string resultado = Elfo4.Atacar(Enano1);
            Assert.AreEqual(VidaEsperado,Enano1.Vida);
            Assert.AreEqual("No se ha inflingido daño.",resultado);
        }

        [Test]
        /// <summary>
        /// AtacarElfoDano prueba que un elfo con mas ataque que la defensa de otro personaje, al atacarlo el otro personaje pierde vida igual que la diferencia entre el ataque del elfo y la defensa del otro
        /// </summary>
        public void AtacarElfoDano()
        {
            Elfo Elfo5 = new Elfo("Glorfindel");
            Enano Enano2 = new Enano("Lobelia");
            Item Espada1 = new Item("Hoja Elfica",40,5,0);
            Elfo5.AgregarItem(Espada1);
            int VidaEsperado = Enano2.Vida-Elfo5.Ataque+Enano2.Defensa;
            string resultado = Elfo5.Atacar(Enano2);
            Assert.AreEqual(VidaEsperado,Enano2.Vida);
            Assert.AreEqual($"El {Elfo5.Nombre} a inflingido un daño de {Elfo5.Ataque-Enano2.Defensa} a {Enano2.Nombre}.", resultado);
        }

        [Test]
        /// <summary>
        /// CurarElfo prueba que un elfo se cura totalmente la vida si se cura
        /// </summary>
        public void CurarElfo()
        {
            Elfo Elfo6 = new Elfo("Arwen");
            Enano Enano3 = new Enano("Lotho");
            int VidaEsperado = Elfo6.Vida;
            string resultado = Enano3.Atacar(Elfo6);
            Elfo6.CuracionTotal();
            Assert.AreEqual($"El {Enano3.Nombre} a inflingido un daño de {Enano3.Ataque-Elfo6.Defensa} a {Elfo6.Nombre}.", resultado);
            Assert.AreEqual(Elfo6.Vida,VidaEsperado);
        }
    }
}