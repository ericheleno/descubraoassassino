using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHS_ValueObject;

namespace DescubraOAssassino.Models
{
    interface ILocalRepositorio
    {
        IEnumerable<localVO> Listar();
        localVO Selecionar(int idLocal);
        void Manter_Local(localVO voLocal);
    }
}
