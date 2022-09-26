using System;
using static Roleplay.InventarioManager;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equipo A
            IPersonaje mago = new Mago("Gonza el mago");
            IPersonaje elfo = new Elfo("Pablo el elfo");

            //Equipo B
            IPersonaje enano = new Enano("Enzo el enano");

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
