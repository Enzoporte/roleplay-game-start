using System;

namespace Roleplay
{
    public class Elfo
    {
        // Atributos privados nombre, vida, ataque, defensa, inventario y si está vivo el personaje
        private string nombre;
        private float vida;
        private int ataque;
        private int defensa;
        private bool isVivo;
        private int inicialVida = 100;
        private int inicialAtaque = 1;
        private int inicialDefensa = 1;

        // Constructor: Solo le pasa el nombre en la creación de personaje
        // Seteamos la vida, ataque y defensa del elfo a sus variables iniciales
        // isVivo true, porque el personaje aparece vivo.
        public Elfo(String Nombre)
        {
            this.nombre = Nombre;
            this.vida = inicialVida;
            this.ataque = inicialAtaque;
            this.defensa = inicialDefensa;
            this.isVivo = true;

            /*this.objetos = Objetos[];*/
        }

        // Atributos publicos del Elfo. Acceder y Modificar sus atributos privados.
        public string Nombre {get;}
        public float Vida {get; set;}
        public int Ataque {get; set;}
        public int Defensa {get; set;}
        public bool IsVivo {get; set;}

        public void AtaqueEnano(Enano other)
        {
            if (other.isVivo) {
                other.vida -= this.Ataque;
                if (other.vida >= 0)
                {
                    other.isVivo = false;
                }
            }
        }

        public void AtaqueElfo(Elfo other)
        {
            if (other.isVivo) {
                other.vida -= this.Ataque;
                if (other.vida >= 0)
                {
                    other.isVivo = false;
                }
            }
        }

        public void AtaqueMago(Mago other)
        {
            if (other.isVivo) {
                other.vida -= this.Ataque;
                if (other.vida >= 0)
                {
                    other.isVivo = false;
                }
            }
        }


    }
}