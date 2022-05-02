using EjercicioFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacade.Elementos
{
    public class PalancaCambios : IPalancaCambios
    {
        private int _velocidadActual;
        public int GetVelocidadActual()
        {
            return _velocidadActual;
        }

        public void InsertarVelocidad(int velocidad)
        {
            Console.WriteLine("Introduciendo marcha " + velocidad);
            this._velocidadActual = velocidad;
        }

        public void PuntoMuerto()
        {
            Console.WriteLine("Sacando velocidad " + this._velocidadActual);
            this._velocidadActual = 0;
        }
    }
}
