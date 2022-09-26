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
        public float VidaMaxima {get; set;}
        public int Daño {get; set;}
        public int Defensa {get; set;}
        public bool IsVivo {get; set;} = true;
        public List<IElemento> Inventario {get; set;}
        

        //Constructor
        public Enano(String nombre)
        {
            this.Nombre = nombre;
            this.Vida = inicialVida;
            this.VidaMaxima = inicialVida;
            this.Daño = inicialAtaque;
            this.Defensa = inicialDefensa;
            this.IsVivo = true;
            this.Inventario = new List<IElemento>();
        }
        
        public string Atacar(IPersonaje other)
        {
            if (!this.IsVivo||this.Vida==0)
            {
                return "No se puede atacar con un personaje muerto";
            }
            if (!(other.IsVivo))
            {
                return "Dejalo, ya está muerto";
            }

            if (other.Defensa < this.Daño)
            {
                other.Vida -= (this.Daño - other.Defensa);
                if (other.Vida <= 0)
                {
                    other.IsVivo = false;
                    return "0";
                }
                return other.Vida.ToString();
            }
            other.Vida--;
            return other.Vida.ToString();
        }

        // habilidad especial del Enano es un Ataque Fuerte
        // Consiste en un ataque randomizado que puede o pegar más, o pegar menos que un ataque normal
        public int UsarHabilidad(IPersonaje other)
        {
            if (!(other.IsVivo))
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return 0;
            }

            Random rand = new Random();
            if(!(this.IsVivo) || this.Vida==0)
            {
                return 0;
            }
            float Critico = (float)(rand.NextSingle() + 0.5);   //Quizás se podría redondear el num para no dejar la vida en float
            int Vida = (int)Math.Round(other.Vida, 0);
            other.Vida -= this.Daño * Critico - Defensa;
            if (other.Vida <= 0)
            {
                other.IsVivo = false;
                other.Vida = 0;
                return Vida;
            }
            float dañoHechoFloat = this.Daño * Critico - Defensa;
            int dañoHecho = (int)Math.Round(dañoHechoFloat, 0);
            return dañoHecho;

        }
    }
}
