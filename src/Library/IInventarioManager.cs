namespace Roleplay
{
    public interface IInventarioManager
    {
        void AgregarItem(IElemento itemToAdd, IPersonaje personaje) { }

        void QuitarItem(IElemento itemToRemove, IPersonaje personaje) { }

        void CambiarItem(IElemento viejo, IElemento nuevo, IPersonaje personaje) { }
    }
}