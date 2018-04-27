using System;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EHS_Common
{
    /// <summary>
    /// Classe contendo declarações e métodos de criação e retorno de conexões com banco de dados
    /// </summary>
    /// <remarks>
    /// Author: Silva, Eric
    /// Created Date: 25 Abr 2018
    /// </remarks>
    public class ConnectionSQL
    {
        [DllImport("kernel32.dll")]
        private static extern bool ProcessIdToSessionId(uint dwProcessId, out uint pSessionId);

        #region <<<<   DECLARACOES   >>>>

        private SqlConnection objConn;

        #endregion

        #region <<<<   CONEXAO       >>>>

        /// <summary>
        /// Retorna conexão com base nas informações de conexão guardadas na classe Root
        /// </summary>
        /// <returns>Conexão (SqlConnection)</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Create Date: 25 Abr 2018
        /// </remarks>
        public SqlConnection GetConnection()
        {
            try
            {
                if (objConn == null)
                {
                    Connection objConnectionInfo = Root.ConnectionInformation;
                    objConn = this.Create_New_SqlConnection(objConnectionInfo.Login, objConnectionInfo.Password, objConnectionInfo.DataBase, objConnectionInfo.Server, objConnectionInfo.PoolingActivated, objConnectionInfo.MinConnection, objConnectionInfo.MaxConnection);
                }

                return objConn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlConnection GetConnectionSystemDataBasse(Connection objectConnection)
        {
            try
            {
                Connection objConnectionInfo = objectConnection;
                SqlConnection objNewConn = this.Create_New_SqlConnection(objConnectionInfo.Login, objConnectionInfo.Password, objConnectionInfo.DataBase, objConnectionInfo.Server, objConnectionInfo.PoolingActivated, objConnectionInfo.MinConnection, objConnectionInfo.MaxConnection);

                if (objConn == null || objConn != objNewConn)
                {
                    objConn = objNewConn;
                }

                return objConn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cria Conexão com Banco de Dados SQL Server, com base nos parâmetros informados
        /// </summary>
        /// <param name="Login">String com login do banco de dados</param>
        /// <param name="Password">String com senha do banco de dados</param>
        /// <param name="DataBase">String com nome do banco de dados</param>
        /// <param name="Server">String com nome ou ip do servidor</param>
        /// <param name="PoolingActivated">Booleano informando se ativará ou não o pooling na conexão. Valor padrão = false</param>
        /// <param name="MinConnection">Inteiro com qtde mínima de conexões. Valor padrão = 0</param>
        /// <param name="MaxConnection">Inteiro com qtde máxima de conexões. Valor padrão = 0</param>
        /// <param name="timeout">Inteiro com tempo máximo para conexão. Valor padrão = 60</param>
        /// <returns>Conexão (SqlConnection)</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public SqlConnection Create_New_SqlConnection(string Login, string Password, string DataBase, string Server, bool PoolingActivated = false, Int32 MinConnection = 0, Int32 MaxConnection = 0, Int32 timeout = 60)
        {
            try
            {
                uint intSessionID;
                string strMachineName = Environment.MachineName;
                if (ProcessIdToSessionId((uint)Process.GetCurrentProcess().Id, out intSessionID))
                {
                    strMachineName += "\\";
                    strMachineName += intSessionID.ToString();
                }

                StringBuilder stbConnection = new StringBuilder();
                stbConnection.AppendLine("workstation id=" + strMachineName + ";");
                stbConnection.AppendLine("packet size=4096;");
                stbConnection.AppendLine("user id=" + Login + ";");
                stbConnection.AppendLine("pwd=" + Password + ";");
                stbConnection.AppendLine("data source=" + Server + ";");
                stbConnection.AppendLine("persist security info=false;");
                stbConnection.AppendLine("initial catalog=" + DataBase + ";");
                stbConnection.AppendLine("timeout=" + timeout + ";");

                if (PoolingActivated)
                {
                    stbConnection.AppendLine("Min Pool Size=" + MinConnection + ";");
                    stbConnection.AppendLine("Max Pool Size=" + MaxConnection + ";");
                }
                else
                {
                    stbConnection.AppendLine("Pooling=False;");
                }

                return new SqlConnection(stbConnection.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
