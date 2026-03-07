using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Juego_Final.Modelos
{
    internal class Villano : Personajes
    {
        public override string Nombre { get; set; }
        public override int vida { get; set; }

        //public override Image avatar { get; set; }

        public override void atacar(ProgressBar barraVida)
        {
            barraVida.Value -= 10; //se decrementa la vida del heroe cada vez que el villano ataca
        }

        public void regenerarse(ProgressBar pgbVillanovida)
        {
            pgbVillanovida.Value += 10; //se incrementa la voda cada cierto tiempo 
        }
    }
}
