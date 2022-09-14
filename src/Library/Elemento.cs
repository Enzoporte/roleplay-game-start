namespace Roleplay{

    public class Elemento
    {
        private string descripcion;
        private int ataque;
        private int defensa;
        // private int uso; 
        
        public string Descripcion {get;}
        public int Ataque {get;}
        public int Defensa {get;}

        public Elemento(string descripcion, int ataque, int defensa)
        {
            this.Descripcion = descripcion;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}