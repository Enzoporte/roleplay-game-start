using System;
namespace Roleplay{

    public class Enano
    {
        //Constructor  -->

        private string nombre;
        private float vida;
        private int ataque;
        private int defensa;
        private bool isVivo;

        public Enano(String Nombre)
        {
            this.nombre = Nombre;
            this.vida = Vida;
            this.ataque = Ataque;
            this.defensa = Defensa;
            this.isVivo = true;

            /*this.objetos = Objetos[];*/
        }
        public string Nombre {get;}
        public float Vida {get; set;}
        public int Ataque {get;}
        public int Defensa {get;}
        public bool IsVivo {get; set;}

        public void AtaqueElfo(Elfo other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }

        public void AtaqueMago(Mago other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }

        public void AtaqueEnano(Enano other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }

        public void AtaqueFuerteMago(Mago other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }

        public void AtaqueFuerteElfo(Elfo other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }

        public void AtaqueFuerteEnano(Enano other)
        {
            if (!(other.isVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.isVivo = false;
            }
        }
    }
}
