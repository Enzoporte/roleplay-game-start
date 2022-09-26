namespace Roleplay
{
    public class Armadura
    {
        string Descripcion {get; set; } 
        int Defensa {get; set; }

        public Armadura (string descripcion, int defensa)
        {
            this.Descripcion = descripcion;
            this.Defensa = defensa;
        }
    }
}