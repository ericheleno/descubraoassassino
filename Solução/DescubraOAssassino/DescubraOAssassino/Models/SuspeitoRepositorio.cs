using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EHS_ValueObject;
using EHS_BusinessObject;

namespace DescubraOAssassino.Models
{
    public class SuspeitoRepositorio: ISuspeitoRepositorio
    {
        public IEnumerable<suspeitoVO> Listar()
        {
            suspeitoBO boSuspeito = new suspeitoBO();

            return boSuspeito.Listar();
        }

        public suspeitoVO Selecionar(int idSuspeito)
        {
            return new suspeitoVO();
        }

        public void Manter_Suspeito(suspeitoVO voSuspeito)
        {

        }
    }
}