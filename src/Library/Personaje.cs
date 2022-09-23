using System;

namespace Roleplay
{
    // Implementamos la clase Personaje para crear atributos y métodos compartidos por todas las razas.
    // En este caso, la vida, el nombre y el inventario son atributos comunes.

    public class Personaje
    {
// Atributos privados
        private string nombre;
        private float vida;
        private int daño;
        private int defensa;
        private bool isVivo;
        private int inicialVida;
        private int inicialDaño;
        private int inicialDefensa;
        public Elemento[] Inventario {get; set;}

// Atributos Públicos
        public string Nombre {get;}
        public float InicialVida {get;}
        public float Vida {get; set;}
        public int Daño {get; set;}
        public int Defensa {get; set;}
        public bool IsVivo {get; set;}

        public Personaje(string nombre)
        {
            this.Nombre = nombre;
        }

    }
}