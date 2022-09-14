using System;
namespace Roleplay
{

    public class Enano
    {
        // Propiedades Comunes de los tipos de personajes. Cambian los valores de Defensa y Vida
        // por ser enanos. Son más duritos

        private string nombre;
        private float vida;
        private int ataque;
        private int defensa;
        private bool isVivo;
        private int inicialVida = 300;
        private int inicialAtaque = 1;
        private int inicialDefensa = 5;

        //Constructor como el de Elfo. 
        public Enano(String Nombre)
        {
            this.nombre = Nombre;
            this.vida = inicialVida;
            this.ataque = inicialAtaque;
            this.defensa = inicialDefensa;
            this.isVivo = true;

            /*this.objetos = Objetos[];*/
        }

        // Atributos publicos para acceder y poder modificar los atributos privados del Enano
        public string Nombre {get;}
        public float Vida {get; set;}
        public int Ataque {get;}
        public int Defensa {get;}
        public bool IsVivo {get; set;}

        // Ataques a distintas clases del Enano al resto
        public void AtaqueElfo(Elfo other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }

        public void AtaqueMago(Mago other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }

        public void AtaqueEnano(Enano other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            other.Vida -= this.ataque;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }


        // AtaqueFuerte es una habilidad especial del Enano
        // Consiste en un ataque randomizado que puede o pegar más, o pegar menos que un ataque normal
        public void AtaqueFuerteMago(Mago other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }

        public void AtaqueFuerteElfo(Elfo other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }

        public void AtaqueFuerteEnano(Enano other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);
            other.Vida -= this.ataque * Critico;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }
        }
    }
}
