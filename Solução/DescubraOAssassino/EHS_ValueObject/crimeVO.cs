using System;

namespace EHS_ValueObject
{
    public class crimeVO
    {
        public int id_crime { get; set; }
        public string nm_crime { get; set; }
        public string ds_crime { get; set; }
        public bool fl_excluir { get; set; }
    }

    public class crime_aleatorioVO
    {
        public string nm_crime { get; set; }
        public string ds_crime { get; set; }
        public string nm_suspeito { get; set; }
        public string nm_local { get; set; }
        public string nm_arma { get; set; }
    }

    public class crime_teoriaVO
    {
        public string nm_crime { get; set; }
        public string nm_suspeito { get; set; }
        public string nm_local { get; set; }
        public string nm_arma { get; set; }
    }

    public class crime_validacaoVO
    {
        public crime_aleatorioVO voCrimeAleatorio { get; set; }
        public crime_teoriaVO voCrimeTeoria { get; set; }
    }
}
