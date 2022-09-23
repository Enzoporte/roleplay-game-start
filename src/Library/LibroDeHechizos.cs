namespace Roleplay
{
    public class LibroDeHechizos : Elemento
    {
        private string descripcion;
        private int ataque;
        private int defensa;
        private Hechizo[] hechizos;

        public LibroDeHechizos(string descripcion, int ataque, int defensa) : base(descripcion, ataque, defensa)
        {
            this.descripcion = descripcion;
            this.ataque = ataque;
            this.defensa = defensa;
        }
        public Hechizo[] Hechizos {get; set;}
        

    }
}