<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="CadastroCategoria.aspx.cs" Inherits="Site.Admin.CadastroCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Cadastro de categorias</h1>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        CellPadding="4" DataKeyNames="Codigo,Descricao" DataSourceID="DS" ForeColor="#333333"
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
            <asp:TemplateField HeaderText="DataExclusao" SortExpression="DataExclusao">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DataExclusao") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DataExclusao")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="DS" runat="server" DataObjectTypeName="Site.ProxyCategoria.Categoria"
        DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="Selecionar" TypeName="Site.ProxyCategoria.CategoriaClient"
        UpdateMethod="Alterar">
        <UpdateParameters>
            <asp:Parameter Name="Codigo" Type="Int32" />
            <asp:Parameter Name="DataExclusao" Type="Datetime" />
            <asp:Parameter Name="Descricao" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4"
        DataSourceID="DS" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px"
        Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
        <EditRowStyle BackColor="#2461BF" />
        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
    </asp:DetailsView>
</asp:Content>
