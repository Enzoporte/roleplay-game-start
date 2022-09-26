namespace Library.Tests;
using NUnit.Framework;
using Roleplay;


public class ExampleTest
{
    // No esta creado el metodo setvida
    [Test]
    public void TestAtaqueAMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.SetVida(0);
        Enano enano1 = new Enano("Roberto");
        string Actual = enano1.Ataque(elfo1);
        string Expected = "Dejalo, ya está muerto";
        Assert.AreEqual(Actual, Expected);
    }


    // No esta creado el metodo setvida
    [Test]
    public void TestAtaqueConMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        Enano enano1 = new Enano("Roberto");
        enano1.SetVida(0);
        string Actual = enano1.Ataque(elfo1);
        string Expected = "No se puede atacar con un personaje muerto";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void AtaqueDentroRangoArmas()
    {
        string Actual = new Armas("Espada", 999999);
        string Expected = "Ataque fuera de rango";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void AtaqueDentroRangoEscudo()
    {
        string Actual = new Escudo("Viking", 999999, 50);
        string Expected = "Ataque fuera de rango";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void DefensaDentroRangoEscudo()
    {
        string Actual = new Escudo("Viking", 50, 999999);
        string Expected = "Defensa fuera de rango";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void DefensaDentroRangoArmadra()
    {
        string Actual = new Aramdura("Arma_dura", 999999);
        string Expected = "Defensa fuera de rango";
        Assert.AreEqual(Actual, Expected);
    }

    //No esta creado el metodo GetVida, GetAtaque
    [Test]
    public void DañoCorrectoElfo()
    {
        Elfo elfo1 = new Elfo("Elfonso");
        Enano enano2 = new Enano("eaa con palo");
        int inicial = enano2.GetVida();
        elfo1.Atacar(enano2);
        int Actual = enano2.GetVida();
        int Expected = inicial - elfo1.GetAtaque;
        Assert.AreEqual(Actual, Expected);
    }


    //daño correcto
    //No esta creado el metodo GetVida, GetAtaque
    [Test]
    public void DañoCorrectoEnano()
    {
        Enano enano1 = new Enano("Petizo con palo");
        Elfo elfo2 = new Elfo("Elfonso");
        int inicial = elfo2.GetVida();
        enano1.Atacar(elfo2);
        int Actual = elfo2.GetVida();
        int Expected = inicial - enano1.GetAtaque;
        Assert.AreEqual(Actual, Expected);
    }

    //No esta creado el metodo GetVida, GetAtaque
    [Test]
    public void DañoCorrectoMago()
    {
        Mago mago1 = new Mago("Ma gordito");
        Elfo elfo3 = new Elfo("Elfonso");
        int inicial = elfo3.GetVida();
        mago1.Atacar(elfo3);
        int Actual = elfo3.GetVida();
        int Expected = inicial - mago1.GetAtaque;
        Assert.AreEqual(Actual, Expected);
    }

    // Defensa correcta

    [Test]
    public void DefensaCorrectoElfo()
    {
        Elfo elfo1 = new Elfo("Elfonso");
        Enano enano2 = new Enano("Pete con palo");
        elfo1.UsarHabilidad(enano2);
        int Actual = enano2.GetVida();
        int Expected = Actual + elfo1.UsarHabilidad;
        Assert.AreEqual(Actual, Expected);
    }

    // desde aca estoy yo //

    // Falta hacer el if con los return
    [Test]
    public void NotNullElfo()
    {
        string Actual = new Elfo("");
        string Expected = "No se puede crear un elfo con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }


    // Falta hacer el if con los return
    [Test]
    public void NotNullEnano()
    {
        string Actual = new Enano("");
        string Expected = "No se puede crear un enano con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }



    // Falta hacer el if con los return
    [Test]
    public void NotNullMago()
    {
        string Actual = new Mago("");
        string Expected = "No se puede crear un mago con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }




    // Falta hacer el if con los return
    [Test]
    public void NotNullArmadura()
    {
        string Actual = new Armadura("", 5);
        string Expected = "No se puede crear una armadura con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }


    // Falta hacer el if con los return
    [Test]
    public void NotNullArmas()
    {
        string Actual = new Armas("", 5);
        string Expected = "No se puede crear un arma con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }


    // Falta hacer el if con los return
    [Test]
    public void NotNullElemento()
    {
        string Actual = new Elemento("", 5);
        string Expected = "No se puede crear un elemento con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }

    //Falta hacer el if con los return
    [Test]
    public void NotNullEscudo()
    {
        string Actual = new Escudo("", 5);
        string Expected = "No se puede crear un escudo con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }

    //Falta hacer el if con los return
    [Test]
    public void NotNullLibro()
    {
        string Actual = new LibroDeHechizos("", 5, 1);
        string Expected = "No se puede crear un libro de hechizos con atributos vacios";
        Assert.AreEqual(Actual, Expected);
    }


    // No esta creado el metodo setvida
    [Test]
    public void HabilidadAMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.SetVida(0);
        Enano enano1 = new Enano("Roberto");
        string Actual = enano1.UsarHabilidad(elfo1);
        string Expected = "No se puede tirar la habilidad a un personaje muerto";
        Assert.AreEqual(Actual, Expected);
    }
    //ta todo mal

    // No esta creado el metodo setvida
    [Test]
    public void HabilidadConMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        Enano enano1 = new Enano("Roberto");
        enano1.SetVida(0);
        string Actual = enano1.UsarHabilidad(elfo1);
        string Expected = "No se puede tirar la habilidad con un personaje muerto";
        Assert.AreEqual(Actual, Expected);
    }


    [Test]
    public void MuertoDespuesAtacar()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.SetVida(1);
        Enano enano1 = new Enano("Roberto");
        string Actual = enano1.Ataque(elfo1);
        string Expected = "0";// Habria que poner que cuando lo ataca retorne un string con la vida, si es igual a 0, esta muerto.
        Assert.AreEqual(Actual, Expected);
    }


    [Test]
    public void DañoCorrectoConDefensa()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.SetVida(100);
        elfo1.SetDefensa(10);
        Enano enano1 = new Enano("Roberto");
        enano1.SetAtaque(20);
        string Actual = enano1.Ataque(elfo1);
        string Expected = (90);// Habria que poner que cuando lo ataca retorne un string con la vida, si es igual a 0, esta muerto.
        Assert.AreEqual(Actual, Expected);
    }



}

/*
daño correcto con escudo (ataque-defensa) pablito
agregar hechizo a libro correcto
hechizo repetido no permitido
calculo de ataque y defensa correcto en libro con ciertos hechizos
vida queda en 0 *+
vida maxima alccanzada con cura
1 de daño cuando defensa > ataque
*/