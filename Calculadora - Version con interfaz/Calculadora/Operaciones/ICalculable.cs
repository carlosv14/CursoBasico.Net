using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public interface ICalculable
    {
        void ImprimirOpciones();
        double Calcular(int opcion);
    }
}
