using Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms.Site.EntityFramework
{
    public partial class EF_Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteService service = new ClienteService();
            var lista = service.Listar();

            gvListaClientesEF.DataSource = lista;
            gvListaClientesEF.DataBind();
        }

        protected void gvListaClientesEF_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int codigo = Convert.ToInt32(e.CommandArgument.ToString());

                Response.Redirect("EF_Cadastrar.aspx?ID=" + codigo);
            }
            if (e.CommandName == "Deletar")
            {
                int codigo = Convert.ToInt32(e.CommandArgument.ToString());
                ClienteService srv = new ClienteService();
                srv.Deletar(codigo);
            }
        }   
    }
}