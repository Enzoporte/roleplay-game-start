namespace Roleplay
{
    public class Armas
    {
        string Descripcion {get; set; }
        int Daño {get; set; }
        int Defensa {get;set;}
        public Armas(string descripcion, int daño)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
        }
    }
}