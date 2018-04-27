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
    public class LocalController : ApiController
    {
        static readonly ILocalRepositorio repositorio = new LocalRepositorio();

        public IEnumerable<localVO> GetAllLocal()
        {
            return repositorio.Listar();
        }
    }
}
