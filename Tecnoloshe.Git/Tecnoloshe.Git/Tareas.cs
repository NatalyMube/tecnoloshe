using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnoloshe.Git
{
    public class Tareas
    {
        long numero = 0;
        public long num()
        {
            for (long i=0;i <= 1000000; i++)
            {
                numero += i;
            }
            return numero;
        }
    }
}
