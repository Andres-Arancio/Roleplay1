using NUnit.Framework;

namespace Roleplay
{
    [TestFixture]
    public class TestMago
    {
        [Test]
        /// <summary>
        /// CrearMago prueba el estado inicial de un Enano al ser creado
        /// </summary>
        public void CrearMago()
        {
            Mago Mago1 = new Mago("Gandalf");
            int VidaEsperado = 110;
            int AtaqueEsperado = 50;
            int DefensaEsperado = 10;
            Assert.AreEqual(VidaEsperado,Mago1.Vida);
            Assert.AreEqual(AtaqueEsperado,Mago1.Ataque);
            Assert.AreEqual(DefensaEsperado,Mago1.Defensa);
        }

        [Test]
        /// <summary>
        /// AgregarItemMago prueba si al agregar un item nuevo, las estadisticas del mago se actualizan
        /// </summary>
        public void AgregarItemMago()
        {
            Mago Mago2 = new Mago("Saruman");
            Item Staff1 = new Item("Baston del Blanco",25,20,0);
            int AtaqueEsperado = 75;
            int DefensaEsperado = 30;
            Mago2.AgregarItem(Staff1);
            Assert.AreEqual(AtaqueEsperado,Mago2.Ataque);
            Assert.AreEqual(DefensaEsperado,Mago2.Defensa);
        }

        [Test]
        /// <summary>
        /// RemoverItemMago prueba si al quitar un item, las estadisticas del mago vuelven a su estado antes de tener el item
        /// </summary>
        public void RemoverItemEnano()
        {
            Mago Mago3 = new Mago("Annatar");
            Item Anillo1 = new Item("El Unico",100,100,0);
            int AtaqueEsperado = Mago3.Ataque;
            int DefensaEsperado = Mago3.Defensa;
            Mago3.AgregarItem(Anillo1);
            Mago3.BorrarItem(Anillo1);
            Assert.AreEqual(AtaqueEsperado,Mago3.Ataque);
            Assert.AreEqual(DefensaEsperado,Mago3.Defensa);
        }

        [Test]
        /// <summary>
        /// AtacarMagoEsquiva prueba si un personaje mago ataca a un personaje con menos ataque que su defensa, no se inflije danho
        /// </summary>
        public void AtacarMagoEsquiva()
        {
            Mago Mago4 = new Mago("Artano");
            Elfo Elfo1 = new Elfo("Maderos");
            Item Armadura1 = new Item("Plata Elfica",0,40,0);
            Elfo1.AgregarItem(Armadura1);
            int VidaEsperado = Elfo1.Vida;
            string resultado = Mago4.Atacar(Elfo1);
            Assert.AreEqual(VidaEsperado,Elfo1.Vida);
            Assert.AreEqual("No se ha inflingido daño.",resultado);
        }

        [Test]
        /// <summary>
        /// AtacarMagoDano prueba que un mago con mas ataque que la defensa de otro personaje, al atacarlo el otro personaje pierde vida igual que la diferencia entre el ataque del mago y la defensa del otro
        /// </summary>
        public void AtacarMagoDano()
        {
            Mago Mago5 = new Mago("Marion");
            Elfo Elfo2 = new Elfo("Finderell");
            Item Maza1 = new Item("Martillo de Valinor",80,10,0);
            Mago5.AgregarItem(Maza1);
            int VidaEsperado = Elfo2.Vida-Mago5.Ataque+Elfo2.Defensa;
            string resultado = Mago5.Atacar(Elfo2);
            Assert.AreEqual(VidaEsperado,Elfo2.Vida);
            Assert.AreEqual($"El {Mago5.Nombre} a inflingido un daño de {Mago5.Ataque-Elfo2.Defensa} a {Elfo2.Nombre}.", resultado);
        }

        [Test]
        /// <summary>
        /// AgregarLibro prueba que el poder magico del mago cambia dependiendo de los hechizos en su libro
        /// </summary>
        public void AgregarLibro()
        {
            Mago Mago6 = new Mago("Mordekainen");
            LibroHechizos Libro1 = new LibroHechizos();
            Hechizo Hechizo1 = new Hechizo("Bola de Fuego", 50);
            int PoderEsperado = Mago6.PoderMagico+Hechizo1.PoderMagico;
            Libro1.AgregarHechizo(Hechizo1);
            Mago6.AgregarLibroHechizo(Libro1);
            Assert.AreEqual(PoderEsperado,Mago6.PoderMagico);
            
        }

        [Test]
        /// <summary>
        /// QuitarLibro prueba que un mago sin su libro de hechizos no tiene poder magico
        /// </summary>
        public void QuitarLibro()
        {
            Mago Mago7 = new Mago("Tasha");
            LibroHechizos Libro2 = new LibroHechizos();
            Hechizo Hechizo2 = new Hechizo("Cono de Frio", 60);
            int PoderEsperado = Mago7.PoderMagico;
            Libro2.AgregarHechizo(Hechizo2);
            Mago7.AgregarLibroHechizo(Libro2);
            Mago7.BorrarLibroHechizo(Libro2);
            Assert.AreEqual(PoderEsperado,Mago7.PoderMagico);
        }
    }
}