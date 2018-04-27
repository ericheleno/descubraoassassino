using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EHS_Common
{
    /// <summary>
    /// Classe com Transações do Banco de Dados
    /// </summary>
    /// <remarks>
    /// Author: Silva, Eric
    /// Created Date: 25 Abr 2018
    /// </remarks>
    public class TransactionManager
    {
        #region <<<<   DECLARAÇÕES        >>>>

        private SqlTransaction objOpenTransaction;
        private SqlTransaction objTransaction;

        private ConnectionSQL objConexao = new ConnectionSQL();

        #endregion

        #region <<<<   MÉTODOS PÚBLICOS   >>>>

        /// <summary>
        /// Abre transação com banco de dados
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public TransactionManager(Connection connectionInformation = null)
        {
            try
            {
                Init(connectionInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TransactionManager(SqlTransaction OpenTransaction, Connection connectionInformation = null)
        {
            try
            {
                objOpenTransaction = OpenTransaction;

                if (objOpenTransaction == null)
                {
                    Init(connectionInformation);
                }
                else
                {
                    objTransaction = objOpenTransaction;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Aceita e finaliza operações realizadas no banco de dados
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public void Commit()
        {
            try
            {
                SqlConnection cnnTmp = objTransaction.Connection;

                if ((objTransaction != null))
                {
                    try
                    {
                        objTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        objTransaction = null;

                        if (cnnTmp.State == ConnectionState.Open)
                        {
                            cnnTmp.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Desfaz operações realizadas no banco de dados
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public void RollBack()
        {
            try
            {
                SqlConnection cnnTmp = objTransaction.Connection;

                if ((objTransaction != null))
                {
                    try
                    {
                        objTransaction.Rollback();
                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                    finally
                    {
                        objTransaction = null;

                        if (cnnTmp.State == ConnectionState.Open)
                        {
                            cnnTmp.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Prepara transação com banco de dados
        /// </summary>
        /// <param name="Isolation">IsolationLevel. Valor Padrão = IsolationLevel.Unspecified</param>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public void BeginTransaction(IsolationLevel Isolation = IsolationLevel.Unspecified)
        {
            try
            {
                if (objTransaction == null)
                {
                    if (Isolation != IsolationLevel.Unspecified)
                    {
                        objTransaction = objConexao.GetConnection().BeginTransaction(Isolation);
                    }
                    else
                    {
                        objTransaction = objConexao.GetConnection().BeginTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fecha transação com banco de dados
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public void CloseConnection()
        {
            try
            {
                SqlConnection objConnTemp = null;

                objConnTemp = objConexao.GetConnection();

                if (!(objConnTemp.State == ConnectionState.Closed))
                {
                    objConnTemp.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region <<<<   MÉTODOS PRIVADOS   >>>>

        /// <summary>
        /// Inicia abertura de conexão com banco de dados
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        private void Init(Connection connectionInformation = null)
        {
            try
            {
                if (connectionInformation == null)
                {
                    objConexao.GetConnection().Open();
                }
                else
                {
                    objConexao.GetConnectionSystemDataBasse(connectionInformation).Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region <<<<   PROPRIEDADES       >>>>

        public object ObjetoDeAcessoDados
        {
            get
            {
                if (objTransaction == null)
                {
                    return objConexao.GetConnection();
                }
                else
                {
                    return objTransaction;
                }
            }
        }

        #endregion
    }
}
