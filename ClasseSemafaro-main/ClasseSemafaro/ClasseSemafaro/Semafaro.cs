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

        public Semafaro()
        {
            this.estado = 0;
        }

        public Semafaro(byte estado)
        {
            this.estado = estado;
        }
      
        public void SetVerde(int semafaro)
        {
            estado = (byte)((int)estado | (int)(Math.Pow(2, (semafaro - 1))));
        }

        public void SetVermelho(int semafaro)
        {
            estado = (byte)((int)estado | (int)(Math.Pow(2, (semafaro - 1))));
        }

        public void SetAmarelo(int semafaro)
        {
            estado = (byte)((int)estado | (int)(Math.Pow(2, (semafaro - 1))));
        }

        public byte GetEstado()
        {
            return this.estado;

        }

        public bool GetSemafaro(int semafaro)
        {
            byte teste;
            teste = (byte)((int)estado & (int)(Math.Pow(2, (semafaro - 1))));
            return (teste > 0);
        }
    }
}
