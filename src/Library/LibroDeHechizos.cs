using System;
using System.Collections.Generic;

namespace Roleplay
{
    public class LibroDeHechizos
    {

        private List<Hechizo> hechizos;
        private Hechizo currentHechizo;

        public List<Hechizo> Hechizos {get; set;}
        public Hechizo CurrentHechizo {get;}

        public LibroDeHechizos(List<Hechizo> hechizos)
        {
            this.Hechizos = hechizos;
        }

        public void SeleccionarHechizo(Hechizo hechizo)
        {
            if (Hechizos.Contains(hechizo))
            {
                this.currentHechizo = hechizo;
            }
            Console.WriteLine("Hechizo no está en el Libro");
        }
        

    }
}