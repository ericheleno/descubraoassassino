using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EHS_Common
{
    public static class DatabaseUtilities
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que preenche parâmetros
        /// </summary>
        /// <param name="parameterName">Nome do Parâmetro</param>
        /// <param name="parameterType">Tipo do Parâmetro</param>
        /// <param name="parameterValue">Valor do Parâmetro</param>
        /// <param name="validateZeros">Se True, substituir zero por DBNull.Value</param>
        /// <returns>Objeto SqlParameter preenchido</returns>
        /// <remarks>
        /// Created By: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static SqlParameter FillParameter(string parameterName, SqlDbType parameterType, object parameterValue = null, bool validateZeros = false)
        {
            try
            {
                SqlParameter objParametro = null;

                objParametro = new SqlParameter(parameterName, parameterType);

                if (parameterValue == null ||
                    (parameterValue.GetType() == typeof(string) && (parameterValue.ToString().Trim() == string.Empty || (validateZeros && parameterValue.ToString().Trim() == "0"))) ||
                    (parameterValue.GetType() == typeof(int) && validateZeros && Convert.ToInt32(parameterValue) == 0) ||
                    (parameterValue.GetType() == typeof(decimal) && validateZeros && Convert.ToInt32(parameterValue) == 0) ||
                    (parameterValue.GetType() == typeof(DateTime) && (Convert.ToDateTime(parameterValue) == new DateTime(0001, 01, 01) || Convert.ToDateTime(parameterValue) == new DateTime(1900, 01, 01))))
                {
                    objParametro.Value = DBNull.Value;
                }
                else
                {
                    objParametro.Value = parameterValue;
                }

                return objParametro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que obtém data do servidor
        /// </summary>
        /// <param name="dataAndHour">Se True, retorna data e hora, se False retorno somente data</param>
        /// <returns>Data do Servidor</returns>
        /// <remarks>
        /// Created By: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static DateTime GetServerDate(bool dataAndHour = false)
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                return GetServerDate(dataAndHour, objTransaction);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (objTransaction != null)
                {
                    objTransaction.CloseConnection();
                }
            }
        }


        #endregion

        #region <<<< MÉTODOS PRIVADOS >>>>

        /// <summary>
        /// Método que obtém data do servidor
        /// </summary>
        /// <param name="completeDate">Se True, retorna data e hora, se False retorno somente data</param>
        /// <param name="objTransaction">Objeto de Transação</param>
        /// <returns>Data do Servidor</returns>
        /// <remarks>
        /// Created By: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        private static DateTime GetServerDate(bool completeDate, TransactionManager objTransaction)
        {
            try
            {
                string strSql = null;

                if (completeDate)
                {
                    strSql = "SELECT GetDate() AS Data";
                }
                else
                {
                    strSql = "SELECT CONVERT(DATETIME, CONVERT(VARCHAR, GetDate(), 111), 120) AS Data";
                }

                return Convert.ToDateTime(SqlHelper.ExecuteScalar(objTransaction.ObjetoDeAcessoDados, CommandType.Text, strSql));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
