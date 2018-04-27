using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EHS_ValueObject;

namespace DescubraOAssassino.Models
{
    interface ICrimeRepositorio
    {
        void Manter_Crime(crimeVO voCrime);
        DataTable Listar(crimeVO voCrime);
        crimeVO Selecionar(int idCrime);
        crime_aleatorioVO Obter_Crime_Aleatorio();
        IEnumerable<string> Validar_Teoria(crime_validacaoVO voCrimeValidacao);
    }
}
