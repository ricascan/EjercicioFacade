using EjercicioFacade.Elementos;
using EjercicioFacade.Interfaces;
using Xunit;

namespace EjercicioFacade.Test
{
    public class ClienteTest
    {
        [Fact]
        public void Test_cliente()
        {
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.PuntoMuerto();
            palancaCambios.InsertarVelocidad(3);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
        }
    }
}