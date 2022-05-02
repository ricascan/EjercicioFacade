using EjercicioFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacade.Elementos
{
    public class Embrague : IEmbrague
    {
        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }
    }
}
