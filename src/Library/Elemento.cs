namespace Roleplay
{

    public class Elemento : IElemento
    {
        private string descripcion;
        private int daño;
        private int defensa;
        // private int uso; 

        public string Descripcion { set; get; }
        public int Daño { get; set; }
        public int Defensa { get; set; }

        public Elemento(string descripcion, int daño, int defensa)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}