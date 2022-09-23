using System;
using System.Collections;

namespace Roleplay
{

    public class Mago : Personaje, IAtaqueHabilidad, IInventarioManager
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

        // Constructor: Solo le pasa el nombre en la creación de personaje
        // Seteamos la vida, ataque y defensa del elfo a sus variables iniciales
        // isVivo true, porque el personaje aparece vivo.
        public Mago(String nombre) : base(nombre)
        {
            this.nombre = nombre;
            this.vida = inicialVida;
            this.daño = inicialDaño;
            this.defensa = inicialDefensa;
            this.isVivo = true;
            //this.Inventario = new List<IElemento>();
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
                    Console.WriteLine($"{other.Nombre} ha muerto!");
                }
                return;
            }
            other.Vida--;
        }

        public void AgregarItem(IElemento Elemento)
        {

        }

        public void QuitarItem(IElemento Elemento)
        {

        }

        public void CambiarItem(IElemento Viejo, IElemento Nuevo)
        {

        }

        public void UsarHabilidad(Personaje other)
        {
            // Usar Hechizo del Libro de Hechizos
        }

        /* public string GetElementos()
        {
            string str = "";
            foreach (Elemento item in ElementosList)
            {
                str+=item.GetDescripcion();
            }
            return str;
        }

        public void AgregarObjeto(Elemento)
        {
            ElementosList.Add(Elemento);
        } */
    }
}
