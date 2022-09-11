namespace Roleplay
{
    public class Elfo : Personaje
    {
        public Elfo(string nombre, int vida) : base(nombre, vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Inventario.Add(MartilloBasico);
            this.Inventario.Add(EscudoBasico);
            this.Inventario.Add(ArmaduraBasica);
        }

        public override void UsarHabilidad(Personaje personajeReceptor)
        {
            //Curar
        }
    }
}