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
    public class suspeitoDAO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que lista suspeito
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns>Listagem de Suspeito</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<suspeitoVO> Listar(TransactionManager objTransaction)
        {
            try
            {
                StringBuilder stbSql = new StringBuilder();

                stbSql.Append("SELECT");
                stbSql.Append(" [id_suspeito]");
                stbSql.Append(" ,[nm_suspeito]");
                stbSql.Append(" FROM suspeito");

                DataTable dttSuspeito = SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.Text, stbSql.ToString());

                List<suspeitoVO> listVoSuspeito = new List<suspeitoVO>();

                foreach (DataRow dtrItem in dttSuspeito.Rows)
                {
                    listVoSuspeito.Add(this.Preencher_ValueObject(dtrItem));
                }

                return listVoSuspeito;
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
        public suspeitoVO Preencher_ValueObject(DataRow rowSuspeito)
        {
            try
            {
                suspeitoVO vosuspeito = new suspeitoVO();

                vosuspeito.id_suspeito = Convert.ToInt32(rowSuspeito["id_suspeito"]);
                vosuspeito.nm_suspeito = rowSuspeito["nm_suspeito"].ToString();

                return vosuspeito;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
