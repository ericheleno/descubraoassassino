using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS_Common
{
    public class Connection
    {
        #region <<<< PROPRIEDADES >>>>

        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }
        public bool PoolingActivated { get; set; }
        public int MinConnection { get; set; }
        public int MaxConnection { get; set; }

        #endregion
    }
}
