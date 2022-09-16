using System;

namespace Roleplay;

public class Mago
{

    public int Vida { get; set; }
    public int Ataque { get; set; }
    List<Elemento> ElementosList = new List<Elemento>();

    public Mago(int vida, int ataque, Elemento[] elementos)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        foreach (Elemento item in elementos)
        {
            ElementosList.Add(item);
        }
    }

    public string GetElementos()
    {
        string str = "";
        foreach (Elemento item in ElementosList)
        {
            str+=item.GetDescripcion();
        }
        return str;
    }

    public void AtacarMago(Mago mago)
    {
        if (this.Ataque-mago.Defensa>0)
        {
            mago.Vida = mago.Vida - this.Ataque + mago.Defensa;
        }
    }

    public void AtacarEnano(Enano enano)
    {
        if (this.Ataque-enano.Defensa>0)
        {
            enano.Vida = enano.Vida - this.Ataque + enano.Defensa;
        }
    }

    public void AtacarElfo(Elfo elfo)
    {
        if (this.Ataque-elfo.Defensa>0)
        {
            elfo.Vida = elfo.Vida - this.Ataque + elfo.Defensa;
        }
    }

    public void AgregarObjeto(Elemento)
    {
        ElementosList.Add(Elemento);
    }

    
}