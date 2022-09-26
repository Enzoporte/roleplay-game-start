using System;
using System.Collections.Generic;
using static Roleplay.InventarioManager;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup----------------------------------------------
            //Cosas
            List<Hechizo> hechizo = new List<Hechizo>();
            hechizo.Add(new Hechizo("Fuego", 1, 0));
            LibroDeHechizos l = new LibroDeHechizos(hechizo);

            //Equipo A
            IPersonaje mago = new Mago("Gonza el mago", l);
            IPersonaje elfo = new Elfo("Pablo el elfo");

            //Equipo B
            IPersonaje enano = new Enano("Enzo el enano");
            //--------------------------------------------------

            mago.Atacar(enano);

            IElemento palo = new Armas("Palo", 1);
            AgregarItem(palo, enano);

            Console.Write(enano.Vida + "\n");

            foreach (IElemento a in enano.Inventario)
            {
                Console.Write(a.Descripcion);
            }

        }
    }
}
