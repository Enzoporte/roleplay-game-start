using System.Collections.Generic;
namespace Roleplay
{
    public interface IPersonaje
    {

        string Nombre { get; }
        float Vida { get; set; }
        float VidaMaxima { get; set; }
        int Daño { get; set; }
        int Defensa { get; set; }
        bool IsVivo { get; set; }

        List<IElemento> Inventario { get; set; }

        public void Atacar(IPersonaje p) { }
    }
}