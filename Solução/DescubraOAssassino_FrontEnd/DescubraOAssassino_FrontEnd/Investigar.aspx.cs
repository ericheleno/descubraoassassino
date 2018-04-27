using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using EHS_ValueObject;

namespace DescubraOAssassino_FrontEnd
{
    public partial class Contact : Page
    {
        #region <<<< DECLARAÇÕES      >>>>

        protected crime_aleatorioVO voCrimeAleatorio
        {
            get { return (crime_aleatorioVO)this.Session["voCrimeAleatorio"] ?? new crime_aleatorioVO(); }
            set { this.Session["voCrimeAleatorio"] = value; }
        }

        private string strUri;

        #endregion

        #region <<<< EVENTOS          >>>>

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    this.Preencher_Combo();

                    // Buscar Crime Aleatório

                    this.Obter_Crime_Aleatorio();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnValidarTeoria_Click(object sender, EventArgs e)
        {
            this.Validar_Teoria();
        }

        protected void btnNovaInvestigacao_Click(object sender, EventArgs e)
        {
            this.Obter_Crime_Aleatorio();
        }

        #endregion

        #region <<<< MÉTODOS PRIVADOS >>>>

        /// <summary>
        /// Método que preenche combo
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        private async void Preencher_Combo()
        {
            // Suspeito

            strUri = System.Configuration.ConfigurationManager.AppSettings["EnderecoWebApi"].ToString() + "Suspeito";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(strUri))
                {
                    this.ddlSuspeito.DataSource = JsonConvert.DeserializeObject<suspeitoVO[]>(await response.Content.ReadAsStringAsync());
                    this.ddlSuspeito.DataTextField = "nm_suspeito";
                    this.ddlSuspeito.DataValueField = "id_suspeito";
                    this.ddlSuspeito.DataBind();
                }
            }

            // Local

            strUri = System.Configuration.ConfigurationManager.AppSettings["EnderecoWebApi"].ToString() + "Local";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(strUri))
                {
                    this.ddlLocal.DataSource = JsonConvert.DeserializeObject<localVO[]>(await response.Content.ReadAsStringAsync());
                    this.ddlLocal.DataTextField = "nm_local";
                    this.ddlLocal.DataValueField = "id_local";
                    this.ddlLocal.DataBind();
                }
            }

            // Arma

            strUri = System.Configuration.ConfigurationManager.AppSettings["EnderecoWebApi"].ToString() + "Arma";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(strUri))
                {
                    this.ddlArma.DataSource = JsonConvert.DeserializeObject<armaVO[]>(await response.Content.ReadAsStringAsync());
                    this.ddlArma.DataTextField = "nm_arma";
                    this.ddlArma.DataValueField = "id_arma";
                    this.ddlArma.DataBind();
                }
            }
        }

        /// <summary>
        /// Método que obtém crime aleatório
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        private async void Obter_Crime_Aleatorio()
        {
            strUri = System.Configuration.ConfigurationManager.AppSettings["EnderecoWebApi"].ToString() + "CrimeAleatorio";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(strUri))
                {
                    voCrimeAleatorio = JsonConvert.DeserializeObject<crime_aleatorioVO>(await response.Content.ReadAsStringAsync());

                    this.lblCrime.Text = voCrimeAleatorio.nm_crime + " (" + voCrimeAleatorio.ds_crime + ")";

                    this.lblResultado.Text = string.Empty;

                    this.btnNovaInvestigacao.Visible = false;

                    this.btnValidarTeoria.Visible = true;
                }
            }
        }

        /// <summary>
        /// Método que valida teoria
        /// </summary>
        /// <remarks>
        /// Author: Silva, Eric
        /// Created Date: 26 Abr 2018
        /// </remarks>
        private async void Validar_Teoria()
        {
            try
            {
                strUri = System.Configuration.ConfigurationManager.AppSettings["EnderecoWebApi"].ToString() + "ValidarTeoria";
                strUri += "/" + this.voCrimeAleatorio.nm_suspeito;
                strUri += "/" + this.voCrimeAleatorio.nm_local;
                strUri += "/" + this.voCrimeAleatorio.nm_arma;
                strUri += "/" + this.ddlSuspeito.SelectedItem.Text;
                strUri += "/" + this.ddlLocal.SelectedItem.Text;
                strUri += "/" + this.ddlArma.SelectedItem.Text;

                string[] strArrResultado;

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(strUri))
                    {
                        strArrResultado = JsonConvert.DeserializeObject<string[]>(await response.Content.ReadAsStringAsync());

                        if (strArrResultado.Length == 1 && strArrResultado[0] == "Correto")
                        {
                            this.lblResultado.Text = "Parabéns! Você Solucionou o Caso!";

                            this.btnValidarTeoria.Visible = false;

                            this.btnNovaInvestigacao.Visible = true;

                            this.lblResultado.ForeColor = System.Drawing.Color.Navy;
                        }
                        else
                        {
                            string strResultado = string.Empty;

                            foreach (string strItem in strArrResultado)
                            {
                                strResultado = strResultado.Length > 0 ? strResultado + " | " : string.Empty;

                                strResultado += strItem;
                            }

                            this.lblResultado.Text = strResultado;

                            this.lblResultado.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}