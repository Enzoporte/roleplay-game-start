namespace Roleplay
{
    public class Armas : IElemento
    {
        public string Descripcion { get; set; }
        public int Daño { get; set; }
        public int Defensa { get; set; }
        public Armas(string descripcion, int daño)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
            this.Defensa = 0;
        }
    }
}