using System;
namespace Roleplay
{
    public class InventarioManager
    {
        public Elemento[] PersonajeInventario;

        public static void AgregarElemento(Object personaje, Elemento elemento)
        {
            personaje.Inventario.Add(elemento);
        }
        public static void QuitarElemento(Object personaje, Elemento elemento)
        {
            personaje.Inventario.Remove(elemento);
        }
        public static void CambiarElemento(Object personaje, Elemento elementoViejo, Elemento elementoNuevo)
        {
            personaje.Inventario.Remove(elementoViejo);
            personaje.Inventario.Add(elementoNuevo);
        }
    }
}