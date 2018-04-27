using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EHS_Common;
using EHS_ValueObject;

namespace EHS_DataAccessObject
{
    public class crimeDAO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que mantém cadastro de crimes
        /// </summary>
        /// <param name="voCrime"></param>
        /// <param name="objTransaction"></param>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public void Manter_Crime(crimeVO voCrime, TransactionManager objTransaction)
        {
            try
            {
                voCrime.id_crime = Convert.ToInt32(SqlHelper.ExecuteScalar(objTransaction.ObjetoDeAcessoDados, CommandType.StoredProcedure, "P_MANTER_CRIME", this.Preencher_Parametro(voCrime)));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que seleciona crimes
        /// </summary>
        /// <param name="idCrime"></param>
        /// <param name="objTransaction"></param>
        /// <returns>ValueObject</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public crimeVO Selecionar(int idCrime, TransactionManager objTransaction)
        {
            try
            {
                StringBuilder stbSql = new StringBuilder();

                stbSql.Append("SELECT");
                stbSql.Append(" [id_crime]");
                stbSql.Append(" ,[nm_crime]");
                stbSql.Append(" ,[ds_crime]");
                stbSql.Append(" FROM crime");
                stbSql.Append(" WHERE [id_crime] = @id_crime");

                SqlParameter[] objParameter = new SqlParameter[1];
                objParameter[0] = DatabaseUtilities.FillParameter("@id_crime", SqlDbType.Int, idCrime);

                return this.Preencher_ValueObject(SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.Text, stbSql.ToString(), objParameter));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que lista crimes
        /// </summary>
        /// <param name="voCrime"></param>
        /// <param name="objTransaction"></param>
        /// <returns>Objeto DataTable</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public DataTable Listar(crimeVO voCrime, TransactionManager objTransaction)
        {
            try
            {
                StringBuilder stbSql = new StringBuilder();

                stbSql.Append("SELECT");
                stbSql.Append(" [id_crime]");
                stbSql.Append(" ,[nm_crime]");
                stbSql.Append(" ,[ds_crime]");
                stbSql.Append(" FROM crime");
                stbSql.Append(" WHERE (nm_crime = @nm_crime OR @nm_crime IS NULL)");

                return SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.Text, stbSql.ToString(), this.Preencher_Parametro(voCrime));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que obtém crime aleatório
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns>ValueObject</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public crime_aleatorioVO Obter_Crime_Aleatorio(TransactionManager objTransaction)
        {
            try
            {
                return this.Preencher_ValueObject_Crime_Aleatorio(SqlHelper.ExecuteDataTable(objTransaction.ObjetoDeAcessoDados, CommandType.StoredProcedure, "P_OBTER_CRIME_ALEATORIO"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region <<<< MÉTODOS PRIVADOS >>>>

        /// <summary>
        /// Método que preenche parâmetros
        /// </summary>
        /// <param name="voCrime"></param>
        /// <returns>Objeto Array de SqlParameter</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public SqlParameter[] Preencher_Parametro(crimeVO voCrime)
        {
            try
            {
                SqlParameter[] objParameter = new SqlParameter[3];

                objParameter[0] = DatabaseUtilities.FillParameter("@id_crime", SqlDbType.Int, voCrime.id_crime);
                objParameter[1] = DatabaseUtilities.FillParameter("@nm_crime", SqlDbType.VarChar, voCrime.nm_crime);
                objParameter[2] = DatabaseUtilities.FillParameter("@ds_crime", SqlDbType.VarChar, voCrime.ds_crime);

                return objParameter;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que preenche value object
        /// </summary>
        /// <param name="tableCrime"></param>
        /// <returns>ValueObject</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public crimeVO Preencher_ValueObject(DataTable tableCrime)
        {
            try
            {
                crimeVO vocrime = new crimeVO();

                foreach (DataRow dtrItem in tableCrime.Rows)
                {
                    vocrime.id_crime = Convert.ToInt32(dtrItem["id_crime"]);
                    vocrime.nm_crime = dtrItem["nm_crime"].ToString();
                    vocrime.ds_crime = dtrItem["ds_crime"].ToString();
                }

                return vocrime;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que preenche value object com crime aleatorio
        /// </summary>
        /// <param name="tableCrimeAleatorio"></param>
        /// <returns>ValueObject</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public crime_aleatorioVO Preencher_ValueObject_Crime_Aleatorio(DataTable tableCrimeAleatorio)
        {
            try
            {
                crime_aleatorioVO voCrimeAleatorio = new crime_aleatorioVO();

                foreach (DataRow dtrItem in tableCrimeAleatorio.Rows)
                {
                    voCrimeAleatorio.nm_crime = dtrItem["nm_crime"].ToString();
                    voCrimeAleatorio.ds_crime = dtrItem["ds_crime"].ToString();
                    voCrimeAleatorio.nm_suspeito = dtrItem["nm_suspeito"].ToString();
                    voCrimeAleatorio.nm_local = dtrItem["nm_local"].ToString();
                    voCrimeAleatorio.nm_arma = dtrItem["nm_arma"].ToString();
                }

                return voCrimeAleatorio;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
