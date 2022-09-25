namespace Roleplay
{
    public interface IPersonaje
    {

        string Nombre { get; set; }
        float Vida { get; set; }
        int Daño { get; set; }
        int defensa { get; set; }
        bool isVivo { get; set; }

        public void Atacar()
        {

        }

        public void UsarHabilidad()
        {

        }



    }
}