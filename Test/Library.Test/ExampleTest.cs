namespace Library.Tests;
using NUnit.Framework;
using Roleplay;
using System.Collections.Generic;

public class ExampleTest
{
    // No esta creado el metodo setvida
    [Test]
    public void TestAtaqueAMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.Vida = 0;
        Enano enano1 = new Enano("Roberto");
        string Actual = enano1.Atacar(elfo1);
        string Expected = "0";
        Assert.AreEqual(Actual, Expected);
    }


    // No esta creado el metodo setvida
    [Test]
    public void TestAtaqueConMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        Enano enano1 = new Enano("Roberto");
        enano1.Vida = 0;
        string Actual = enano1.Atacar(elfo1);
        string Expected = "No se puede atacar con un personaje muerto";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void AtaqueDentroRangoArmas()
    {
        Armas arma1 = new Armas("Espada", 999999);
        int Actual = arma1.Daño;
        int Expected = 50;
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void AtaqueDentroRangoEscudo()
    {
        Escudo escudo1 = new Escudo("Viking", 999999, 50);
        int Actual = escudo1.Daño;
        int Expected = 50;
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void DefensaDentroRangoEscudo()
    {
        Escudo escudo1 = new Escudo("Viking", 50, 999999);
        int Actual = escudo1.Defensa;
        int Expected = 50;
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void DefensaDentroRangoArmadura()
    {
        Armadura armadura1 = new Armadura("Arma_dura", 999999);
        int Actual = armadura1.Defensa;
        int Expected = 50;
        Assert.AreEqual(Actual, Expected);
    }

    //No esta creado el metodo GetVida, GetAtacar
    [Test]
    public void DañoCorrectoElfo()
    {
        Elfo elfo1 = new Elfo("Elfonso");
        Enano enano2 = new Enano("eaa con palo");
        float inicial = enano2.Vida;
        elfo1.Atacar(enano2);
        float Actual = enano2.Vida;
        float Expected = inicial - elfo1.Daño+ enano2.Defensa;
        Assert.AreEqual(Actual, Expected);
    }


    //daño correcto
    //No esta creado el metodo GetVida, GetAtaque
    [Test]
    public void DañoCorrectoEnano()
    {
        Enano enano1 = new Enano("Petizo con palo");
        Elfo elfo2 = new Elfo("Elfonso");
        float inicial = elfo2.Vida;
        enano1.Atacar(elfo2);
        float Actual = elfo2.Vida;
        float Expected = inicial - enano1.Daño+ elfo2.Defensa;
        Assert.AreEqual(Actual, Expected);
    }

    //No esta creado el metodo GetVida, GetAtaque
    [Test]
    public void DañoCorrectoMago()
    {
        List<Hechizo> hechizos = new List<Hechizo>();
        LibroDeHechizos libro1 = new LibroDeHechizos(hechizos);
        Mago mago1 = new Mago("Ma gordito", libro1);
        Elfo elfo3 = new Elfo("Elfonso");
        float inicial = elfo3.Vida;
        mago1.Atacar(elfo3);
        float Actual = elfo3.Vida;
        float Expected = inicial - mago1.Daño+ elfo3.Defensa;
        Assert.AreEqual(Actual, Expected);
    }

    // Defensa correcta

    [Test]
    public void DefensaCorrectoElfo()
    {
        Elfo elfo1 = new Elfo("Elfonso");
        Enano enano2 = new Enano("Pet con palo");
        int num = elfo1.UsarHabilidad(enano2);
        float Actual = enano2.Vida;
        float Expected = Actual + num;
        Assert.AreEqual(Actual, Expected);
    }

    // desde aca estoy yo //

    

    // No esta creado el metodo setvida
    [Test]
    public void HabilidadAMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.Vida = 0;
        Enano enano1 = new Enano("Roberto");
        int Actual = enano1.UsarHabilidad(elfo1);
        int Expected = 0;
        Assert.AreEqual(Actual, Expected);
    }
    //ta todo mal

    // No esta creado el metodo setvida
    [Test]
    public void HabilidadConMuerto()
    {
        Elfo elfo1 = new Elfo("Juan");
        Enano enano1 = new Enano("Roberto");
        enano1.Vida = 0;
        int Actual = enano1.UsarHabilidad(elfo1);
        int Expected = 0;
        Assert.AreEqual(Actual, Expected);
    }


    [Test]
    public void MuertoDespuesAtacar()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.Vida = 1;
        Enano enano1 = new Enano("Roberto");
        string Actual = enano1.Atacar(elfo1);
        string Expected = "0";// Habria que poner que cuando lo ataca retorne un string con la vida, si es igual a 0, esta muerto.
        Assert.AreEqual(Actual, Expected);
    }


    [Test]
    public void DañoCorrectoConDefensa()
    {
        Elfo elfo1 = new Elfo("Juan");
        elfo1.Vida = 100;
        elfo1.Defensa = 10;
        Enano enano1 = new Enano("Roberto");
        enano1.Daño = 20;
        string Actual = enano1.Atacar(elfo1);
        string Expected = "90";// Habria que poner que cuando lo ataca retorne un string con la vida, si es igual a 0, esta muerto.
        Assert.AreEqual(Actual, Expected);
    }

    
    
}
/*
agregar hechizo a libro correcto
hechizo repetido no permitido
calculo de ataque y defensa correcto en libro con ciertos hechizos
vida maxima alccanzada con cura
1 de daño cuando defensa > ataque
*/