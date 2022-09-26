namespace Roleplay
{
    public class Escudo
    {
        string Descripcion { get; set; }
        int Daño { get; set; }
        int Defensa { get; set; }

        public Escudo(string descripcion, int  daño, int defensa)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}