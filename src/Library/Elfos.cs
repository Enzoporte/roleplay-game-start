namespace Rolplay
{
    public class Elfos
    {
        public string Nombre;
        public int Vida;
        public int Ataque;
        public int Defensa;
        // public Elemento[];

        public Elfos(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 100;
            this.Ataque = 0;
            this.Defensa = 0;
        }

        public void AtaqueEnano(Enano other)
        {
            if (other.isVivo) {
                other.vida -= this.ataque;
                if (other.vida =< 0)
                {
                    other.isVivo = false;
                }
            }
        }

        public void AtaqueElfo(Elfo other)
        {
            if (other.isVivo) {
                other.vida -= this.ataque;
                if (other.vida =< 0)
                {
                    other.isVivo = false;
                }
            }
        }

        public void AtaqueMago(Mago other)
        {
            if (other.isVivo) {
                other.vida -= this.ataque;
                if (other.vida =< 0)
                {
                    other.isVivo = false;
                }
            }
        }

        
    }
}