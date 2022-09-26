using System;
using System.Collections.Generic;
using System.Collections;

namespace Roleplay
{

    public class Mago : IPersonaje, IAtaqueHabilidad, IInventarioManager
    {
        // Atributos privados nombre, vida, ataque, defensa, inventario y si está vivo el personaje
        // Propiedades Comunes de los tipos de personajes. Cambian los valores de Defensa y Vida
        // por ser enanos. Son más duritos

        private int inicialVida = 300;
        private int inicialAtaque = 10;
        private int inicialDefensa = 5;

        public string Nombre { get; }
        public LibroDeHechizos LibroDeHechizos { get; set; }
        public float Vida { get; set; }
        public float VidaMaxima { get; set; }
        public int Daño { get; set; }
        public int Defensa { get; set; }
        public bool IsVivo { get; set; }
        public List<IElemento> Inventario { get; set; }

        // Constructor: Le pasa el nombre en la creación de personaje y un Libro (se podría cambiar, porque no es muy reutilizable hacer esto)
        // Seteamos la vida, ataque y defensa del Mago a sus variables iniciales + el hechizo
        // isVivo true, porque el personaje aparece vivo.
        public Mago(String nombre, LibroDeHechizos libroDeHechizos)
        {
            this.Nombre = nombre;
            this.LibroDeHechizos = libroDeHechizos;
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
                    Console.WriteLine($"{other.Nombre} ha muerto!");
                }
                return;
            }
            other.Vida--;
        }

        public void UsarHabilidad(IPersonaje other)
        {
            if (!(other.IsVivo))
            {
                Console.WriteLine("Dejalo, ya está muerto");
                return;
            }
            if (other.Defensa < this.LibroDeHechizos.CurrentHechizo.Daño)
            {
                other.Vida -= (this.LibroDeHechizos.CurrentHechizo.Daño - other.Defensa);
                if (other.Vida <= 0)
                {
                    other.IsVivo = false;
                    Console.WriteLine($"{other.Nombre} ha muerto!");
                }
                return;
            }
            other.Vida--;
        }


    }
}
