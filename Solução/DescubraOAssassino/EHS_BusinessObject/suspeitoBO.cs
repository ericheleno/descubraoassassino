using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHS_Common;
using EHS_ValueObject;
using EHS_DataAccessObject;

namespace EHS_BusinessObject
{
    public class suspeitoBO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que lista suspeitos
        /// </summary>
        /// <returns>Listagem de Suspeito</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<suspeitoVO> Listar()
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                suspeitoDAO daoSuspeito = new suspeitoDAO();

                return daoSuspeito.Listar(objTransaction);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objTransaction.CloseConnection();
            }
        }

        #endregion
    }
}
