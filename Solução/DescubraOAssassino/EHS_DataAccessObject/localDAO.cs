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
    public class localDAO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que lista locais
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns>Listagem de Local</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<localVO> Listar(TransactionManager objTransaction)
        {
            try
            {
                StringBuilder stbSql = new StringBuilder();

                stbSql.Append("SELECT");
                stbSql.Append(" [id_local]");
                stbSql.Append(" ,[nm_local]");
                stbSql.Append(" FROM local");

                DataTable dttLocal = SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.Text, stbSql.ToString());

                List<localVO> listVoLocal = new List<localVO>();

                foreach (DataRow dtrItem in dttLocal.Rows)
                {
                    listVoLocal.Add(this.Preencher_ValueObject(dtrItem));
                }

                return listVoLocal;
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
        /// <param name="rowSuspeito"></param>
        /// <returns>Value Object</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public localVO Preencher_ValueObject(DataRow rowSuspeito)
        {
            try
            {
                localVO voLocal = new localVO();

                voLocal.id_local = Convert.ToInt32(rowSuspeito["id_local"]);
                voLocal.nm_local= rowSuspeito["nm_local"].ToString();

                return voLocal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
