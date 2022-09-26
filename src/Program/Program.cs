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
            IPersonaje magoA = new Mago("Gonza el mago", l);
            IPersonaje elfoA = new Elfo("Pablo el elfo");

            //Equipo B
            IPersonaje enanoB = new Enano("Enzo el enano");
            //--------------------------------------------------

            magoA.Atacar(enanoB);

            IElemento palo = new Armas("Palo", 1);
            AgregarItem(palo, enanoB);

            Console.Write(enanoB.Vida + "\n");

            foreach (IElemento a in enanoB.Inventario)
            {
                Console.Write(a.Descripcion + "\n");
            }

            magoA.UsarHabilidad(enanoB);
            Console.Write(enanoB.Vida + "\n");
        }
    }
}
