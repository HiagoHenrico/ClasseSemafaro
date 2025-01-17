using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace ClasseSemafaro
{
    internal class Paralela
    {
        public class Paralela1
        {
            [DllImport("Inpout32.dll", EntryPoint = "Out32")]
            public static extern void Escrever(int endereco, byte valor);
        }
    }
    
}
