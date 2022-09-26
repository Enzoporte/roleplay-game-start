namespace Roleplay
{
    public interface IPersonaje
    {

        string Nombre { get; }
        float Vida { get; set; }
        float VidaMaxima { get; set; }
        int Daño { get; set; }
        int Defensa { get; set; }
        bool IsVivo { get; set; }

    }
}