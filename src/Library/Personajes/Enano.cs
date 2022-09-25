using System;
using System.Collections.Generic;

namespace Roleplay
{

    public class Enano : IPersonaje, IAtaqueHabilidad
    {
        // Propiedades Comunes de los tipos de personajes. Cambian los valores de Defensa y Vida
        // por ser enanos. Son más duritos

        private int inicialVida = 300;
        private int inicialAtaque = 10;
        private int inicialDefensa = 5;

        public string Nombre {get;}
        public float Vida {get; set;}
        public int Daño {get; set;}
        public int Defensa {get; set;}
        public bool IsVivo {get; set;}
        public List<IElemento> Inventario {get; set;}
        

        //Constructor
        public Enano(String nombre)
        {
            this.Nombre = nombre;
            this.Vida = inicialVida;
            this.Daño = inicialAtaque;
            this.Defensa = inicialDefensa;
            this.IsVivo = true;
            this.Inventario = new List<IElemento>();
        }
        
        public void Atacar(IPersonaje other)
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
        public void UsarHabilidad(IPersonaje other)
        {
            if (!(other.IsVivo))
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }

            Random rand = new Random();
            float Critico = (float)(rand.NextSingle() + 0.5);   //Quizás se podría redondear el num para no dejar la vida en float
            other.Vida -= this.Daño * Critico - Defensa;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
            }

        }
    }
}
