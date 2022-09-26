namespace Roleplay
{
    public class Armadura : IElemento
    {
        public string Descripcion {get; set; } 
        public int Daño {get; set;} 
        public int Defensa {get; set; }

        public Armadura (string descripcion, int defensa)
        {
            this.Descripcion = descripcion;
            this.Daño = 0;
            this.Defensa = defensa;
        }
    }
}