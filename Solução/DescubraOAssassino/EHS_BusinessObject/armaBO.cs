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
    public class armaBO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que lista armas
        /// </summary>
        /// <returns>Listagem de Arma</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<armaVO> Listar()
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                armaDAO daoArma = new armaDAO();

                return daoArma.Listar(objTransaction);
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
