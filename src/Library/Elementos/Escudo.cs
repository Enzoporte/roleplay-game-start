namespace Roleplay
{
    public class Escudo : IElemento
    {
        public string Descripcion {get; set; } 
        public int Daño {get; set;} 
        public int Defensa {get; set; }

        public Escudo(string descripcion, int  daño, int defensa)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}