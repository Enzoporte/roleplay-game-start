namespace Roleplay
{
    public class Enano : Personaje
    {
        public Enano(string nombre, int vida) : base(nombre, vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Inventario.Add(HachaBasica); //implementar Elemento, (nombre, daño, defensa). Hacha es dos manos, + daño
            this.Inventario.Add(ArmaduraMedia);
        }

        public override void UsarHabilidad(Personaje personajeReceptor)
        {
            //Ataque Fuerte
        }
    }
}