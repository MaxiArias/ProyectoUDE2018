using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public class FabricaFachadas
    {
        public IFachadaWin CrearFachadaWin { get { return new Fachada(); } }

        public IFachadaWeb CrearFachadaWeb { get { return new Fachada(); } }
    }
}
