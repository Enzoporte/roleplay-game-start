namespace Roleplay
{
    public class Armas : IElemento
    {

        public string Descripcion {get; set; } 
        public int Daño {get; set;} 
        public int Defensa {get; set; }

        private int MaxAtaque = 50;

        public Armas(string descripcion, int daño)
        {
            this.Descripcion = descripcion;
            if(daño>MaxAtaque)
            {
                this.Daño = MaxAtaque;
            }
            else
            {
                this.Daño = daño;
            }
            this.Defensa = 0;
            
        }
    }
}