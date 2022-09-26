namespace Roleplay
{
    public class InventarioManager : IInventarioManager
    {
        public static void AgregarItem(IElemento itemToAdd, IPersonaje p)
        {
            p.Inventario.Add(itemToAdd);
        }

        public static void QuitarItem(IElemento itemToRemove, IPersonaje p)
        {
            if (!(p.Inventario.Contains(itemToRemove)))
                return;

            p.Inventario.Remove(itemToRemove);
        }

        public static void CambiarItem(IElemento viejo, IElemento nuevo, IPersonaje p)
        {
            QuitarItem(viejo, p);
            AgregarItem(nuevo, p);
        }
    }
}