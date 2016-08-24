using Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms.Site.EntityFramework
{
    public partial class EF_Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int codigo = Convert.ToInt32(Request.QueryString["ID"]);
                    CarregarFormulario(codigo);
                }
            }
        }

        private void CarregarFormulario(int codigo)
        {
            ClienteService srv = new ClienteService();
            var cliente = srv.Obter(codigo);

            if (cliente != null)
            {
                txtCPF.Text = cliente.CPF;
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtEndreco.Text = cliente.Endereco;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Domain.Entities.Cliente cli = new Domain.Entities.Cliente();

            if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                cli.ID = Convert.ToInt32(Request.QueryString["ID"]);
            }

            cli.CPF = txtCPF.Text;
            cli.Nome = txtNome.Text;
            cli.Telefone = txtTelefone.Text;
            cli.Endereco = txtEndreco.Text;

            ClienteService srv = new ClienteService();
            srv.Salvar(cli);
        }
    }
}