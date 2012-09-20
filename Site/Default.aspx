<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Site.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="DS">
        <ItemTemplate>
            <div class="Post">
                <h1><%# DataBinder.Eval(Container.DataItem, "Titulo")%></h1>
                <p class="PostDataInclusao"><strong>Data:</strong> <%# DataBinder.Eval(Container.DataItem, "DataInclusao","{0:dd:MM:yyyy}")%></p>
                <p class="PostCategorias"><strong>Categorias:</strong> <%# Listar(DataBinder.Eval(Container.DataItem, "Categorias"))%></p>
                <p class="PostConteudo"><%# DataBinder.Eval(Container.DataItem, "Conteudo")%></p>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource ID="DS" runat="server" SelectMethod="Selecionar" TypeName="Site.ProxyPost.PostClient">
    </asp:ObjectDataSource>
</asp:Content>
