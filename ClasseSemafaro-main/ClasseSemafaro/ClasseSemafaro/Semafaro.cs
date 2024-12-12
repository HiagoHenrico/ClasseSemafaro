using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSemafaro
{
    internal class Semafaro
    {
        private byte estado;

        public Luzes()
        {
            this.estado = 0;
        }

        public void SetVerde(int rua)
        {
            estado = (byte)((int)estado | (int)(Math.Pow(2, (led - 1))));
        }

        public void SetVermelho(int rua)
        {

        }

        public void SetAmarelo(int rua)
        {

        }

        public byte GetEstado()
        {
            return this.estado;

        }

        public int GetEstado(int rua)
        {

        }
    }
}
