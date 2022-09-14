using System;

public class Enano
{
	public void AtaqueElfo(Elfo other)
	{
        if (other.isVivo)
        {
            other.vida -= this.ataque;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    public void AtaqueMago(Mago other)
    {
        if (other.isVivo)
        {
            other.vida -= this.ataque;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    public void AtaqueEnano(Enano other)
    {
        if (other.isVivo) {
            other.vida -= this.ataque;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    public void AtaqueFuerteMago(Mago other)
    {
        if (other.isVivo)
        {
            Random rand = new Random();
            int Critico = rand.Next(0.5, 1, 5)


        other.vida -= this.ataque * Critico;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    public void AtaqueFuerteElfo(Elfo other)
    {
        if (other.isVivo)
        {
            Random rand = new Random();
            int Critico = rand.Next(0.5, 1, 5)


        other.vida -= this.ataque * Critico;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    public void AtaqueFuerteEnano(Enano other)
    {
        if (other.isVivo)
        {
            Random rand = new Random();
            int Critico = rand.Next(0.5, 1, 5)


        other.vida -= this.ataque * Critico;
            if (other.vida =< 0)
            {
                other.isVivo = false;
            }
        }
    }

    //Constructor  -->

    private string nombre;
    private int vida;
    private int ataque;
    private int defensa;
    private bool isVivo;

    public Enano(String Nombre, int Vida, int Ataque, int Defensa /* Objetos[], obj*/)
    {
        this.nombre = Nombre;
        this.vida = Vida;
        this.ataque = Ataque;
        this.defensa = Defensa;
        this.isVivo = true;

        /*this.objetos = Objetos[];*/
    }






}
