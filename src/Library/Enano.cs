using System;
namespace Roleplay
{

    public class Enano : Personaje, IAtaqueHabilidad
    {
        // Propiedades Comunes de los tipos de personajes. Cambian los valores de Defensa y Vida
        // por ser enanos. Son más duritos

        private string nombre;
        private float vida;
        private int ataque;
        private int defensa;
        private bool isVivo;
        private int inicialVida = 300;
        private int inicialAtaque = 10;
        private int inicialDefensa = 5;

        //Constructor como el de Elfo. 
        public Enano(String nombre) : base(nombre)
        {
            this.nombre = nombre;
            this.vida = inicialVida;
            this.ataque = inicialAtaque;
            this.defensa = inicialDefensa;
            this.isVivo = true;
        }
        
        public void Atacar(Personaje other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            if (other.Defensa < this.Daño) 
            {
                other.Vida -= (this.Daño - other.Defensa);
                if (other.Vida <= 0)
                {
                    other.IsVivo = false;
                }
                Console.WriteLine($"{other.Nombre} ha muerto!");
                return;
            }
            other.Vida--;
        }

        // habilidad especial del Enano es un Ataque Fuerte
        // Consiste en un ataque randomizado que puede o pegar más, o pegar menos que un ataque normal
        public void UsarHabilidad(Personaje other)
        {
            if (!(other.IsVivo)) 
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);   //Quizás se podría redondear el num para no dejar la vida en float
            other.Vida -= this.ataque * Critico - defensa;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }

        }
    }
}
