using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Juego_Final.Modelos
{
    internal abstract class Personajes
    {
        public abstract string Nombre { get; set; }
        public abstract int vida { get; set; }
        //public Image avatar { get; set; }


        public abstract void atacar(ProgressBar barraVida);
        public void defender()
        {

        }
      
    }
}
