using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EHS_Common;
using EHS_ValueObject;
using EHS_DataAccessObject;

namespace EHS_BusinessObject
{
    public class crimeBO
    {
        #region <<<< MÉTODOS PÚBLICOS >>>>

        /// <summary>
        /// Método que mantém cadastro de crimes
        /// </summary>
        /// <param name="voCrime"></param>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public void Manter_Crime(crimeVO voCrime)
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                crimeDAO daoCrime = new crimeDAO();

                daoCrime.Manter_Crime(voCrime, objTransaction);
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

        /// <summary>
        /// Método que seleciona crimes
        /// </summary>
        /// <param name="idCrime"></param>
        /// <returns>Value Object</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public crimeVO Selecionar(int idCrime)
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                crimeDAO daoCrime = new crimeDAO();

                return daoCrime.Selecionar(idCrime, objTransaction);
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

        /// <summary>
        /// Método que lista crimes
        /// </summary>
        /// <param name="voCrime"></param>
        /// <returns>Objeto DataTable</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public DataTable Listar(crimeVO voCrime)
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                crimeDAO daoCrime = new crimeDAO();

                return daoCrime.Listar(voCrime, objTransaction);
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

        /// <summary>
        /// Método que obtém crime aleatório
        /// </summary>
        /// <returns>Value Object</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public crime_aleatorioVO Obter_Crime_Aleatorio()
        {
            TransactionManager objTransaction = new TransactionManager();

            try
            {
                crimeDAO daoCrime = new crimeDAO();

                return daoCrime.Obter_Crime_Aleatorio(objTransaction);
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

        /// <summary>
        /// Método que valida teoria
        /// </summary>
        /// <param name="voCrimeTeoria"></param>
        /// <param name="voCrimeAleatorio"></param>
        /// <returns>Listagem com Resultados</returns>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public List<string> Validar_Teoria(crime_aleatorioVO voCrimeAleatorio, crime_teoriaVO voCrimeTeoria)
        {
            try
            {
                List<string> lstStrResultado = new List<string>();

                if (voCrimeTeoria.nm_suspeito != voCrimeAleatorio.nm_suspeito)
                {
                    lstStrResultado.Add("Assassino Incorreto");
                }

                if (voCrimeTeoria.nm_local != voCrimeAleatorio.nm_local)
                {
                    lstStrResultado.Add("Local Incorreto");
                }

                if (voCrimeTeoria.nm_arma != voCrimeAleatorio.nm_arma)
                {
                    lstStrResultado.Add("Arma Incorreta");
                }

                if (lstStrResultado.Count == 0)
                {
                    lstStrResultado.Add("Correto");
                }

                return lstStrResultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
