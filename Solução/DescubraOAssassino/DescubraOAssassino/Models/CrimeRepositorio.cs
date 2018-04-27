using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EHS_ValueObject;
using EHS_BusinessObject;

namespace DescubraOAssassino.Models
{
    public class CrimeRepositorio: ICrimeRepositorio
    {
        public void Manter_Crime(crimeVO voCrime)
        {
            crimeBO boCrime = new crimeBO();

            boCrime.Manter_Crime(voCrime);
        }

        public DataTable Listar(crimeVO voCrime)
        {
            crimeBO boCrime = new crimeBO();

            return boCrime.Listar(voCrime);
        }

        public crimeVO Selecionar(int idCrime)
        {
            crimeBO boCrime = new crimeBO();

            return boCrime.Selecionar(idCrime);
        }

        public crime_aleatorioVO Obter_Crime_Aleatorio()
        {
            crimeBO boCrime = new crimeBO();

            return boCrime.Obter_Crime_Aleatorio();
        }

        public IEnumerable<string> Validar_Teoria(crime_validacaoVO voCrimeValidacao)
        {
            crimeBO boCrime = new crimeBO();

            return boCrime.Validar_Teoria(voCrimeValidacao.voCrimeAleatorio, voCrimeValidacao.voCrimeTeoria);
        }
    }
}