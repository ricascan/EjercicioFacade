using EjercicioFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacade.Elementos
{
    public class Acelerador : IAcelerador
    {
        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }
    }
}
