using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lapìceras
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(string color)
        { 
            if(color=="blue")
            {
                this._color = ConsoleColor.Blue;
                this._tinta = 100;
            }
            if(color=="red")
            {
                this._color = ConsoleColor.Red;
                this._tinta = 50;
            }
        }

        public bool Pintar(int cantidad)
        {
            this._tinta = this._tinta - cantidad;
            return true;   
        }

        public void Recargar()
        {
            this._tinta = 100;
        }
    }
}
