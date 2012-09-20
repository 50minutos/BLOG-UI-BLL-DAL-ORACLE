<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="Site.Admin.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Login</h1>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <p>
                Nome:<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                Senha:<br />
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" onclick="Button1Click" Text="Entrar" />
            </p>
        </asp:View>
        <asp:View ID="View2" runat="server">
           <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/CadastroUsuario.aspx">Usuários</asp:HyperLink></p>
           <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/CadastroCategoria.aspx">Categorias</asp:HyperLink></p>
           <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/CadastroPostNovo.aspx">Escrever um post</asp:HyperLink></p>
        </asp:View>
    </asp:MultiView>
</asp:Content>

