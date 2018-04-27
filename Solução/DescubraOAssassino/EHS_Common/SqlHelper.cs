using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace EHS_Common
{
    public sealed class SqlHelper : SqlHelperPai
    {


        const Int32 TimeOutSQLHelper = 300;
        #region "   Private Utility Methods & Constructors   "

        private SqlHelper()
            : base()
        {
        }

        #endregion

        #region "   ExecuteDataSet   -  Transaction   "

        /// <summary>
        /// Executa o comando e retorna um DataSet preenchido com os dados
        /// </summary>
        /// <param name="ObjectDataAccess">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <returns>DataSet preenchido com os dados</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static DataSet ExecuteDataSet(object ObjectDataAccess, CommandType commandType, string commandText)
        {
            try
            {
                if (ObjectDataAccess is SqlConnection)
                {
                    return SqlHelperPai.ExecuteDataSet((SqlConnection)ObjectDataAccess, commandType, commandText);
                }

                if (ObjectDataAccess is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteDataSet((SqlTransaction)ObjectDataAccess, commandType, commandText);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Executa o comando e retorna um DataSet preenchido com os dados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <param name="commandParameters">Parametros do comando</param>
        /// <returns>DataSet preenchido com os dados</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static DataSet ExecuteDataSet(object ObjetoAcessoDados, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteDataSet((SqlConnection)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteDataSet((SqlTransaction)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "   ExecuteDataTable -  Transaction   "

        /// <summary>
        /// Executa o comando e retorna um DataTable preenchido com os dados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <returns>DataTable preenchido com os dados</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static DataTable ExecuteDataTable(object ObjetoAcessoDados, CommandType commandType, string commandText)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteDataTable((SqlConnection)ObjetoAcessoDados, commandType, commandText);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteDataTable((SqlTransaction)ObjetoAcessoDados, commandType, commandText);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Executa o comando e retorna um DataTable preenchido com os dados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <param name="commandParameters">Parametros do comando</param>
        /// <returns>DataTable preenchido com os dados</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static DataTable ExecuteDataTable(object ObjetoAcessoDados, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            // create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = TimeOutSQLHelper;

            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteDataTable((SqlConnection)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteDataTable((SqlTransaction)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "   ExecuteNonQuery  -  Transaction   "

        /// <summary>
        /// Executa o comando e retorna o número de linhas afetadas
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <returns>Número de linhas afetadas</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static int ExecuteNonQuery(object ObjetoAcessoDados, CommandType commandType, string commandText)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteNonQuery((SqlConnection)ObjetoAcessoDados, commandType, commandText);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteNonQuery((SqlTransaction)ObjetoAcessoDados, commandType, commandText);
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Executa o comando e retorna o número de linhas afetadas
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <param name="commandParameters">Parametros do comando</param>
        /// <returns>Número de linhas afetadas</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static int ExecuteNonQuery(object ObjetoAcessoDados, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteNonQuery((SqlConnection)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteNonQuery((SqlTransaction)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "   ExecuteReader    -  Transaction   "

        /// <summary>
        /// Executa o comando e retorna um DataReader preenchido com os dados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <returns>Número de linhas afetadas</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static SqlDataReader ExecuteReader(object ObjetoAcessoDados, CommandType commandType, string commandText)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteReader((SqlConnection)ObjetoAcessoDados, commandType, commandText);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteReader((SqlTransaction)ObjetoAcessoDados, commandType, commandText);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Executa o comando e retorna um DataReader preenchido com os dados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <param name="commandParameters">Parametros do comando</param>
        /// <returns>Número de linhas afetadas</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static SqlDataReader ExecuteReader(object ObjetoAcessoDados, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteReader((SqlConnection)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteReader((SqlTransaction)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "   ExecuteScalar    -  Transaction   "

        /// <summary>
        /// Executa o comando e retorna um objeto que contém o valor do conjunto de resultados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <returns>Um objeto que contém o valor do conjunto de resultados 1x1 gerado pelo comando</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static object ExecuteScalar(object ObjetoAcessoDados, CommandType commandType, string commandText)
        {
            try
            {
                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteScalar((SqlConnection)ObjetoAcessoDados, commandType, commandText);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteScalar((SqlTransaction)ObjetoAcessoDados, commandType, commandText);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Executa o comando e retorna um objeto que contém o valor do conjunto de resultados
        /// </summary>
        /// <param name="ObjetoAcessoDados">Objeto de Transação ou ConnectionString</param>
        /// <param name="commandType">Tipo de comando</param>
        /// <param name="commandText">Comando a ser executado</param>
        /// <param name="commandParameters">Parametro do comando</param>
        /// <returns>Um objeto que contém o valor do conjunto de resultados 1x1 gerado pelo comando</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 25 Abr 2018
        /// </remarks>
        public static object ExecuteScalar(object ObjetoAcessoDados, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            try
            {

                if (ObjetoAcessoDados is SqlConnection)
                {
                    return SqlHelperPai.ExecuteScalar((SqlConnection)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                if (ObjetoAcessoDados is SqlTransaction)
                {
                    return SqlHelperPai.ExecuteScalar((SqlTransaction)ObjetoAcessoDados, commandType, commandText, commandParameters);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

    }


    public abstract class SqlHelperPai
    {


        const Int32 TimeOutSQLHelper = 900;
        #region "   Private Utility Methods & Constructors   "

        public SqlHelperPai()
        {
        }

        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            SqlParameter p = null;
            foreach (SqlParameter p_loopVariable in commandParameters)
            {
                p = p_loopVariable;
                // check for derived output value with no value assigned
                if (p.Direction == ParameterDirection.InputOutput & p.Value == null)
                {
                    p.Value = null;
                }
                command.Parameters.Add(p);
            }
        }

        private static void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
        {
            short i = 0;
            short j = 0;

            if ((commandParameters == null) & (parameterValues == null))
            {
                // do nothing if we get no data
                return;
            }

            // we must have the same number of values as we pave parameters to put them in
            if (commandParameters.Length != parameterValues.Length)
            {
                throw new ArgumentException("Parameter count does not match Parameter Value count.");
            }

            // value array
            j = Convert.ToInt16(commandParameters.Length - 1);
            for (i = 0; i <= j; i++)
            {
                commandParameters[i].Value = parameterValues[i];
            }

        }

        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            // if the provided connection is not open, we will open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // associate the connection with the command
            command.Connection = connection;

            // set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;

            // if we were provided a transaction, assign it.
            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            // set the command type
            command.CommandType = commandType;

            // attach the command parameters if they are provided
            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }

            return;
        }

        #endregion

        #region "   ExecuteNonQuery   "

        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connectionString, commandType, commandText, (SqlParameter[])null);
        }

        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();

                return ExecuteNonQuery(cn, commandType, commandText, commandParameters);
            }
            finally
            {
                cn.Dispose();
            }
        }

        public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            // if we receive parameter values, we need to figure out where they go
            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                // pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)

                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                // assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues);

                // call the overload that takes an array of SqlParameters
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, commandParameters);
                // otherwise we can just call the SP without params
            }
            else
            {
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
            }
        }

        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connection, commandType, commandText, (SqlParameter[])null);

        }

        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();
            int retval = 0;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return retval;

        }

        public static int ExecuteNonQuery(SqlConnection connection, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
            }

        }

        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(transaction, commandType, commandText, (SqlParameter[])null);
        }

        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            int retval = 0;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return retval;

        }

        public static int ExecuteNonQuery(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion

        #region "   ExecuteDataSet    "

        public static DataSet ExecuteDataSet(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteDataSet(connectionString, commandType, commandText, (SqlParameter[])null);
        }

        public static DataSet ExecuteDataSet(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();

                return ExecuteDataSet(cn, commandType, commandText, commandParameters);
            }
            finally
            {
                cn.Dispose();
            }
        }

        public static DataSet ExecuteDataSet(string connectionString, string spName, params object[] parameterValues)
        {

            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteDataSet(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteDataSet(connectionString, CommandType.StoredProcedure, spName);
            }
        }

        public static DataSet ExecuteDataSet(SqlConnection connection, CommandType commandType, string commandText)
        {

            return ExecuteDataSet(connection, commandType, commandText, (SqlParameter[])null);
        }

        public static DataSet ExecuteDataSet(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            da = new SqlDataAdapter(cmd);

            ds.EnforceConstraints = false;

            da.Fill(ds);

            cmd.Parameters.Clear();

            ds.EnforceConstraints = true;

            return ds;

        }

        public static DataSet ExecuteDataSet(SqlConnection connection, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteDataSet(connection, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteDataSet(connection, CommandType.StoredProcedure, spName);
            }

        }

        public static DataSet ExecuteDataSet(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteDataSet(transaction, commandType, commandText, (SqlParameter[])null);
        }

        public static DataSet ExecuteDataSet(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            da = new SqlDataAdapter(cmd);

            ds.EnforceConstraints = false;

            da.Fill(ds);

            cmd.Parameters.Clear();

            ds.EnforceConstraints = true;

            return ds;
        }

        public static DataSet ExecuteDataSet(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteDataSet(transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteDataSet(transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion

        #region "   ExecuteReader     "

        private enum SqlConnectionOwnership
        {
            Internal,
            External
        }

        private static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, SqlConnectionOwnership connectionOwnership)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);

            if (connectionOwnership == SqlConnectionOwnership.External)
            {
                dr = cmd.ExecuteReader();
            }
            else
            {
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

            cmd.Parameters.Clear();

            return dr;
        }

        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteReader(connectionString, commandType, commandText, (SqlParameter[])null);
        }

        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            try
            {
                return ExecuteReader(cn, (SqlTransaction)null, commandType, commandText, commandParameters, SqlConnectionOwnership.Internal);
            }
            catch
            {
                cn.Dispose();
                return null;
            }
        }

        public static SqlDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText)
        {

            return ExecuteReader(connection, commandType, commandText, (SqlParameter[])null);

        }

        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteReader(connection, (SqlTransaction)null, commandType, commandText, commandParameters, SqlConnectionOwnership.External);

        }

        public static SqlDataReader ExecuteReader(SqlConnection connection, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteReader(connection, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteReader(connection, CommandType.StoredProcedure, spName);
            }

        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteReader(transaction, commandType, commandText, (SqlParameter[])null);
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, SqlConnectionOwnership.External);
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteReader(transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteReader(transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion

        #region "   ExecuteScalar     "

        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connectionString, commandType, commandText, (SqlParameter[])null);
        }

        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();

                return ExecuteScalar(cn, commandType, commandText, commandParameters);
            }
            finally
            {
                cn.Dispose();
            }
        }

        public static object ExecuteScalar(string connectionString, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
            }
        }

        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connection, commandType, commandText, (SqlParameter[])null);
        }

        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            object retval = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            retval = cmd.ExecuteScalar();

            cmd.Parameters.Clear();

            return retval;

        }

        public static object ExecuteScalar(SqlConnection connection, string spName, params object[] parameterValues)
        {

            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteScalar(connection, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteScalar(connection, CommandType.StoredProcedure, spName);
            }

        }

        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteScalar(transaction, commandType, commandText, (SqlParameter[])null);
        }

        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            object retval = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            retval = cmd.ExecuteScalar();

            cmd.Parameters.Clear();

            return retval;

        }

        public static object ExecuteScalar(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteScalar(transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion

        #region "   ExecuteXmlReader  "

        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteXmlReader(connection, commandType, commandText, (SqlParameter[])null);
        }

        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            XmlReader retval = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            retval = cmd.ExecuteXmlReader();

            cmd.Parameters.Clear();

            return retval;


        }

        public static XmlReader ExecuteXmlReader(SqlConnection connection, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName);
            }
        }

        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteXmlReader(transaction, commandType, commandText, (SqlParameter[])null);
        }

        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            XmlReader retval = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            retval = cmd.ExecuteXmlReader();

            cmd.Parameters.Clear();

            return retval;

        }

        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            if ((parameterValues != null) & parameterValues.Length > 0)
            {
                commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                AssignParameterValues(commandParameters, parameterValues);

                return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion

        #region "   ExecuteDataTable  "

        public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText)
        {
            try
            {
                return ExecuteDataTable(connectionString, commandType, commandText, (SqlParameter[])null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();

                return ExecuteDataTable(cn, commandType, commandText, commandParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Dispose();
            }
        }

        public static DataTable ExecuteDataTable(string connectionString, string spName, params object[] parameterValues)
        {

            SqlParameter[] commandParameters = null;

            try
            {
                if ((parameterValues != null) & parameterValues.Length > 0)
                {
                    commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                    AssignParameterValues(commandParameters, parameterValues);

                    return ExecuteDataTable(connectionString, CommandType.StoredProcedure, spName, commandParameters);
                }
                else
                {
                    return ExecuteDataTable(connectionString, CommandType.StoredProcedure, spName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection connection, CommandType commandType, string commandText)
        {

            try
            {
                return ExecuteDataTable(connection, commandType, commandText, (SqlParameter[])null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = null;

            cmd.CommandTimeout = TimeOutSQLHelper;

            try
            {
                PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

                da = new SqlDataAdapter(cmd);

                dt.BeginLoadData();
                da.Fill(dt);
                dt.EndLoadData();

                cmd.Parameters.Clear();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection connection, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            try
            {
                if ((parameterValues != null) & parameterValues.Length > 0)
                {
                    commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);

                    AssignParameterValues(commandParameters, parameterValues);

                    return ExecuteDataTable(connection, CommandType.StoredProcedure, spName, commandParameters);
                }
                else
                {
                    return ExecuteDataTable(connection, CommandType.StoredProcedure, spName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            try
            {
                return ExecuteDataTable(transaction, commandType, commandText, (SqlParameter[])null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = null;

            cmd.CommandTimeout = TimeOutSQLHelper;


            try
            {
                PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

                da = new SqlDataAdapter(cmd);

                dt.BeginLoadData();
                da.Fill(dt);
                dt.EndLoadData();

                cmd.Parameters.Clear();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExecuteDataTable(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            SqlParameter[] commandParameters = null;

            try
            {
                if ((parameterValues != null) & parameterValues.Length > 0)
                {
                    commandParameters = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName);

                    AssignParameterValues(commandParameters, parameterValues);

                    return ExecuteDataTable(transaction, CommandType.StoredProcedure, spName, commandParameters);
                }
                else
                {
                    return ExecuteDataTable(transaction, CommandType.StoredProcedure, spName);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }


    public abstract class SqlHelperParameterCache
    {
        const Int32 TimeOutSQLHelper = 120;
        #region "   Private Methods, Variables And Constructors   "


        private SqlHelperParameterCache()
        {
        }


        private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());

        private static SqlParameter[] DiscoverSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter, params object[] parameterValues)
        {

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(spName, cn);
            SqlParameter[] discoveredParameters = null;

            try
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);
                if (!includeReturnValueParameter)
                {
                    cmd.Parameters.RemoveAt(0);
                }

                discoveredParameters = new SqlParameter[cmd.Parameters.Count];
                cmd.Parameters.CopyTo(discoveredParameters, 0);
            }
            finally
            {
                cmd.Dispose();
                cn.Dispose();

            }

            return discoveredParameters;

        }

        private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
        {

            short i = 0;
            short j = Convert.ToInt16(originalParameters.Length - 1);
            SqlParameter[] clonedParameters = new SqlParameter[j + 1];

            for (i = 0; i <= j; i++)
            {
                clonedParameters[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
            }

            return clonedParameters;
        }



        #endregion

        #region "   Caching Functions   "

        public static void CacheParameterSet(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            string hashKey = connectionString + ":" + commandText;

            paramCache[hashKey] = commandParameters;
        }

        public static SqlParameter[] GetCachedParameterSet(string connectionString, string commandText)
        {
            string hashKey = connectionString + ":" + commandText;
            SqlParameter[] cachedParameters = (SqlParameter[])paramCache[hashKey];

            if (cachedParameters == null)
            {
                return null;
            }
            else
            {
                return CloneParameters(cachedParameters);
            }
        }

        #endregion

        #region "   Parameter Discovery Functions   "

        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
        {
            return GetSpParameterSet(connectionString, spName, false);
        }

        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {

            SqlParameter[] cachedParameters = null;
            string hashKey = null;

            hashKey = connectionString + ":" + spName + (includeReturnValueParameter == true ? ":include ReturnValue Parameter" : String.Empty);

            cachedParameters = (SqlParameter[])paramCache[hashKey];

            if (cachedParameters == null)
            {
                paramCache[hashKey] = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter);
                cachedParameters = (SqlParameter[])paramCache[hashKey];

            }

            return CloneParameters(cachedParameters);

        }

        #endregion
    }
}
