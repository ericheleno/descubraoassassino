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
    public class ArmaController : ApiController
    {
        static readonly IArmaRepositorio repositorio = new ArmaRepositorio();

        public IEnumerable<armaVO> GetAllArma()
        {
            return repositorio.Listar();
        }
    }
}
