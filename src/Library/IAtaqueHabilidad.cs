namespace Roleplay
{
    public interface IAtaqueHabilidad
    {
        string Atacar(IPersonaje personaje);
        int UsarHabilidad(IPersonaje personaje);

    }
}