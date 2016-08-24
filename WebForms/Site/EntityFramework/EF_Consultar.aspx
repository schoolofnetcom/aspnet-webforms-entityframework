<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EF_Consultar.aspx.cs" Inherits="WebForms.Site.EntityFramework.EF_Consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Página com Entity Framework</h1>

    <asp:Button ID="btnPesquisar" CssClass="btn" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />

    <asp:GridView ID="gvListaClientesEF" CssClass="table table-hover table-striped" 
        AutoGenerateColumns="false" runat="server" OnRowCommand="gvListaClientesEF_RowCommand">
        <Columns>
            <asp:BoundField DataField="CPF" HeaderText="CPF" />
            <asp:BoundField DataField="NOME" HeaderText="Nome" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEditar" runat="server" 
                        Text="Editar"
                        CommandName="Editar"
                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>'>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkExcluir" runat="server" 
                        Text="Excluir"
                        CommandName="Deletar"
                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>'>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
