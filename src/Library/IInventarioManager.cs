namespace Roleplay
{
    public interface IInventarioManager
    {
        void AgregarItem(IElemento itemToAdd) { }

        void QuitarItem(IElemento itemToRemove) { }

        void CambiarItem(IElemento viejo, IElemento nuevo) { }
    }
}