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
            if(daño > 50)
            {
                this.Daño = 50;
            }
            else
            {
                this.Daño = daño;
            }
            if(defensa > 50)
            {
                this.Defensa = 50;
            }
            else
            {
                this.Defensa = defensa;
            }
        }
    }
}