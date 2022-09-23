namespace Roleplay{

    public class Hechizo
    {
        private string descripcion;
        private int ataque;
        private int defensa;
        
        public string Descripcion {get;}
        public int Ataque {get;}
        public int Defensa {get;}

        public Hechizo(string descripcion, int ataque, int defensa)
        {
            this.Descripcion = descripcion;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}