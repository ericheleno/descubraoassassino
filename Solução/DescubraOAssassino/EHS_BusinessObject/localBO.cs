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
    public class localBO
    {
        /// <summary>
        /// Método que lista locais
        /// </summary>
        /// <returns>Listagem de Local</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<localVO> Listar()
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                localDAO daoLocal = new localDAO();

                return daoLocal.Listar(objTransaction);
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
    }
}
