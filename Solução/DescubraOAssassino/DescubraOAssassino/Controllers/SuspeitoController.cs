using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DescubraOAssassino.Models;
using EHS_ValueObject;

namespace DescubraOAssassino.Controllers
{
    public class SuspeitoController : ApiController
    {
        static readonly ISuspeitoRepositorio repositorio = new SuspeitoRepositorio();

        public IEnumerable<suspeitoVO> GetAllSuspeito()
        {
            return repositorio.Listar();
        }
    }
}
