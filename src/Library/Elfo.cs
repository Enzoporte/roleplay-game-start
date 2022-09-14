using System;

namespace Roleplay
{
    public class Elfo
    {
        private string nombre;
        private float vida;
        private int ataque;
        private int defensa;
        private bool isVivo;

        public Elfo(String Nombre)
        {
            this.nombre = Nombre;
            this.vida = 100;
            this.ataque = 1;
            this.defensa = 1;
            this.isVivo = true;

            /*this.objetos = Objetos[];*/
        }
        public string Nombre {get;}
        public float Vida {get; set;}
        public int Ataque {get;}
        public int Defensa {get;}
        public bool IsVivo {get; set;}

        // public void AtaqueEnano(Enano Object)
        // {
        //     if Object.isVivo()
        //     {

        //     }
        // }

        // public void AtaqueElfo(Enano Object)
        // {
        //     if Object.isVivo()
        //     {

        //     }
        // }
    }
}