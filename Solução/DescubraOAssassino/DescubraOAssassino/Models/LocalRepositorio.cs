using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EHS_ValueObject;
using EHS_BusinessObject;

namespace DescubraOAssassino.Models
{
    public class LocalRepositorio:ILocalRepositorio
    {
        public IEnumerable<localVO> Listar()
        {
            localBO boLocal = new localBO();

            return boLocal.Listar();
        }

        public localVO Selecionar(int idLocal)
        {
            return new localVO();
        }

        public void Manter_Local(localVO voLocal)
        {

        }
    }
}