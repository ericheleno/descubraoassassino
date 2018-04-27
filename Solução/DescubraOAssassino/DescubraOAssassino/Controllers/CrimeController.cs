using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using DescubraOAssassino.Models;
using EHS_ValueObject;

namespace DescubraOAssassino.Controllers
{
    public class CrimeController : ApiController
    {
        static readonly ICrimeRepositorio repositorio = new CrimeRepositorio();

        public void PutCrime(crimeVO voCrime)
        {
            repositorio.Manter_Crime(voCrime);
        }

        [HttpGet]
        [Route("api/Crime/{voCrime}")]
        public DataTable GetAllCrime(crimeVO voCrime)
        {
            if (voCrime == null)
            {
                voCrime = new crimeVO();
            }

            return repositorio.Listar(voCrime);
        }

        public crimeVO GetCrime(int id)
        {
            return repositorio.Selecionar(id);
        }

        [HttpGet]
        [Route("api/CrimeAleatorio")]
        public crime_aleatorioVO GetCrimeAleatorio()
        {
            return repositorio.Obter_Crime_Aleatorio();
        }

        [HttpGet]
        [Route("api/ValidarTeoria/{nomeSuspeitoSelecionado}/{nomeLocalSelecionado}/{nomeArmaSelecionada}/{nomeSuspeitoTeoria}/{nomeLocalTeoria}/{nomeArmaTeoria}")]
        public IEnumerable<string> PostValidarTeoria(string nomeSuspeitoSelecionado, string nomeLocalSelecionado, string nomeArmaSelecionada, string nomeSuspeitoTeoria, string nomeLocalTeoria, string nomeArmaTeoria)
        {
            crime_aleatorioVO voCrimeAleatorio = new crime_aleatorioVO();

            voCrimeAleatorio.nm_suspeito = nomeSuspeitoSelecionado;
            voCrimeAleatorio.nm_local = nomeLocalSelecionado;
            voCrimeAleatorio.nm_arma = nomeArmaSelecionada;

            crime_teoriaVO voCrimeTeoria = new crime_teoriaVO();

            voCrimeTeoria.nm_suspeito = nomeSuspeitoTeoria;
            voCrimeTeoria.nm_local = nomeLocalTeoria;
            voCrimeTeoria.nm_arma = nomeArmaTeoria;

            crime_validacaoVO voCrimeValidacao = new crime_validacaoVO();

            voCrimeValidacao.voCrimeAleatorio = voCrimeAleatorio;
            voCrimeValidacao.voCrimeTeoria = voCrimeTeoria;

            return repositorio.Validar_Teoria(voCrimeValidacao);
        }
    }
}
