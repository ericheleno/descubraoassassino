using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHS_ValueObject;

namespace DescubraOAssassino.Models
{
    interface ISuspeitoRepositorio
    {
        IEnumerable<suspeitoVO> Listar();
        suspeitoVO Selecionar(int idSuspeito);
        void Manter_Suspeito(suspeitoVO voSuspeito);
    }
}
