using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS_Common
{
    /// <summary>
    /// Classe age como uma coletânea de propriedades, variáveis e métodos públicos.
    /// Esses valores são preenchidos na abertura do sistema e ficam disponíveis para consumo em praticamente qualquer classe. 
    /// </summary>
    /// <remarks>
    /// Created by: Silva, Eric
    /// Created Date: 25 Abr 2018
    /// </remarks>
    public class Root
    {
        public static Connection ConnectionInformation { get; set; }

        public static int UserID { get; set; }
    }
}
