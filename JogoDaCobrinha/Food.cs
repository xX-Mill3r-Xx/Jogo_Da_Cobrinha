using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobrinha
{
    class Food
    {
        public Point Location { get; private set; }
        public void CreateFood()
        {
            Random rdn = new Random();
            Location = new Point(rdn.Next(0, 27), rdn.Next(0,27));
        }
    }
}
