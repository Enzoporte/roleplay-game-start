using System;
using System.Collections.Generic;

namespace Roleplay
{
    public class Elfo : IPersonaje, IAtaqueHabilidad
    {
        // Atributos privados nombre, vida, ataque, defensa, inventario y si está vivo el personaje
        // Propiedades Comunes de los tipos de personajes. Cambian los valores de Defensa y Vida
        // por ser enanos. Son más duritos

        private int inicialVida = 300;
        private int inicialAtaque = 10;
        private int inicialDefensa = 5;
        private int poderCuracion = 10;

        public string Nombre {get;}
        public float Vida {get; set;}
        public float VidaMaxima {get; set;}
        public int Daño {get; set;}
        public int Defensa {get; set;}
        public bool IsVivo {get; set;}
        public List<IElemento> Inventario { get; set; }


        // Constructor: Solo le pasa el nombre en la creación de personaje
        // Seteamos la vida, ataque y defensa del elfo a sus variables iniciales
        // isVivo true, porque el personaje aparece vivo.
        public Elfo(String nombre)
        {
            this.Nombre = nombre;
            this.Vida = inicialVida;
            this.VidaMaxima = inicialVida;
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
        
        public void UsarHabilidad(IPersonaje other)
        {
            // --- Curar ---
           if (!(other.IsVivo))
           {
                Console.WriteLine($"{other.Nombre} está muerto, no puedes curarlo.");
                return;
           }

           if (other.Vida >= other.VidaMaxima)
           {
                Console.WriteLine($"{other.Nombre} ya tiene su vida al máximo");
                return;
           }

           other.Vida += poderCuracion;
           if (other.Vida > other.VidaMaxima)
           {
                other.Vida = VidaMaxima;
           }

        }
    }
}