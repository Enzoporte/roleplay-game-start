namespace Roleplay
{
    public class Mago : Personaje
    {
        public Mago(string nombre, int vida) : base(nombre, vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Inventario.Add(BastonBasico);
            this.Inventario.Add(ArmaduraBasica);
            this.Inventario.Add(LibroBasico); //Libro de hechizos Basico (un solo hechizo? de daño)
        }

        public override void UsarHabilidad(Personaje personajeReceptor)
        {
            //Usar Hechizos
            //Si tiene Libro de Hechizos
        }
    }
}