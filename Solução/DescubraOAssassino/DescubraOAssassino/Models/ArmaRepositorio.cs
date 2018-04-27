using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EHS_ValueObject;
using EHS_BusinessObject;

namespace DescubraOAssassino.Models
{
    public class ArmaRepositorio: IArmaRepositorio
    {
        public IEnumerable<armaVO> Listar()
        {
            armaBO boArma = new armaBO();

            return boArma.Listar();
        }

        public armaVO Selecionar(int idArma)
        {
            return new armaVO();
        }

        public void Manter_Arma(armaVO voArma)
        {

        }
    }
}