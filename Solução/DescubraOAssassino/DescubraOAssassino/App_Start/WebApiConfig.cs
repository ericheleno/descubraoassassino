using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using EHS_Common;

namespace DescubraOAssassino
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional}
            );

            Root.ConnectionInformation = Obter_Conexao();

            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);
        }

        /// <summary>
        /// Método que obtém informações de conexão com banco de dados
        /// </summary>
        /// <returns>ValueObjects "Conexao"</returns>
        /// <remarks>
        /// Created by: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        public static Connection Obter_Conexao()
        {
            try
            {
                Connection objConn = new Connection();

                objConn.Server = ConfigurationManager.AppSettings["Server"].ToString();
                objConn.DataBase = ConfigurationManager.AppSettings["DataBase"].ToString();
                objConn.Login = ConfigurationManager.AppSettings["User"].ToString();
                objConn.Password = ConfigurationManager.AppSettings["Password"].ToString();

                return objConn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
