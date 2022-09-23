using System;

namespace Roleplay
{
    public class Elfo : Personaje, IAtaqueHabilidad
    {
        // Atributos privados nombre, vida, ataque, defensa, inventario y si está vivo el personaje
        private string nombre;
        private float vida;
        private int daño;
        private int defensa;
        private bool isVivo;
        private int inicialVida = 100; //También su vida Máxima inicial. Se podría crear otro atributo para vida máxima y que pueda subir
        private int inicialDaño = 1;
        private int inicialDefensa = 1;
        private int poderCuracion = 10;

        // Constructor: Solo le pasa el nombre en la creación de personaje
        // Seteamos la vida, ataque y defensa del elfo a sus variables iniciales
        // isVivo true, porque el personaje aparece vivo.
        public Elfo(String nombre) : base(nombre)
        {
            this.nombre = nombre;
            this.vida = inicialVida;
            this.daño = inicialDaño;
            this.defensa = inicialDefensa;
            this.isVivo = true;
            // Inventario
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
        
        public void UsarHabilidad(Personaje other)
        {
            // --- Curar ---
           if (!(other.IsVivo))
           {
                Console.WriteLine($"{other.Nombre} está muerto, no puedes curarlo.");
                return;
           }

           if (other.Vida >= other.InicialVida)
           {
                Console.WriteLine($"{other.Nombre} ya tiene su vida al máximo");
                return;
           }

           other.Vida += poderCuracion;
           if (other.Vida > other.InicialVida)
           {
                other.Vida = InicialVida;
           }

        }
    }
}