using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EHS_Common;
using EHS_ValueObject;

namespace EHS_DataAccessObject
{
    public class armaDAO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que lista armas
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns>Listagem de Arma</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<armaVO> Listar(TransactionManager objTransaction)
        {
            try
            {
                StringBuilder stbSql = new StringBuilder();

                stbSql.Append("SELECT");
                stbSql.Append(" [id_arma]");
                stbSql.Append(" ,[nm_arma]");
                stbSql.Append(" FROM arma");

                DataTable dttArma = SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.Text, stbSql.ToString());

                List<armaVO> listVoArma = new List<armaVO>();

                foreach (DataRow dtrItem in dttArma.Rows)
                {
                    listVoArma.Add(this.Preencher_ValueObject(dtrItem));
                }

                return listVoArma;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region <<<< MÉTODOS PRIVADOS >>>>

        /// <summary>
        /// Método que preenche value object
        /// </summary>
        /// <param name="rowArma"></param>
        /// <returns>Value Object</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public armaVO Preencher_ValueObject(DataRow rowArma)
        {
            try
            {
                armaVO voArma = new armaVO();

                voArma.id_arma = Convert.ToInt32(rowArma["id_arma"]);
                voArma.nm_arma = rowArma["nm_arma"].ToString();

                return voArma;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
