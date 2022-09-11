using System;

namespace Roleplay
{
    // Implementamos la clase Personaje para crear atributos y métodos compartidos por todas las razas.
    // En este caso, la vida, el nombre y el inventario son atributos comunes.
    // UsarHabilidad no se implementa en Personaje, pero se implementará particular para cada raza

    public class Personaje
    {
        public string Nombre;
        public int Vida;
        public Elemento[] Inventario {get; set;}

        public Personaje(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public virtual void UsarHabilidad(Personaje personajeReceptor)
        {

        }

    }
}