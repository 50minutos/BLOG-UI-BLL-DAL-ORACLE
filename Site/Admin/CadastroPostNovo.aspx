<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="CadastroPostNovo.aspx.cs" Inherits="Site.Admin.CadastroPostNovo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <h1>
        Novo post</h1>
    <p>
        Título:<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="350px"></asp:TextBox>
    </p>
    <p>
        Categorias:<asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal"
            DataSourceID="DS" DataTextField="Descricao" DataValueField="Codigo">
        </asp:CheckBoxList>
        <asp:ObjectDataSource ID="DS" runat="server" SelectMethod="Selecionar" TypeName="Site.ProxyCategoria.CategoriaClient">
        </asp:ObjectDataSource>
    </p>
    <cc1:Editor ID="Editor1" runat="server" />
    <p>
        Data de Liberação:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Privado:<br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Post privado" />
    </p>
    
    <p><asp:Button ID="Button1" runat="server" Text=":: clique aqui ::" 
            onclick="Button1Click" /></p>
</asp:Content>
