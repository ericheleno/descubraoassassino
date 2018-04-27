using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHS_ValueObject;

namespace DescubraOAssassino.Models
{
    interface IArmaRepositorio
    {
        IEnumerable<armaVO> Listar();
        armaVO Selecionar(int idArma);
        void Manter_Arma(armaVO voArma);
    }
}
