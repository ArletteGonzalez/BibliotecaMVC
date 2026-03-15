<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarLibros.aspx.cs" Inherits="BibliotecaMVC.Views.ConsultarLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
<h2>Consultar Libros</h2>
<asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>

<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>

    
    <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="false"
OnRowCommand="gvLibros_RowCommand">

    <Columns>

        <asp:BoundField DataField="Codigo" HeaderText="Código" />
        <asp:BoundField DataField="Titulo" HeaderText="Título" />
        <asp:BoundField DataField="Autor" HeaderText="Autor" />
        <asp:BoundField DataField="FechaPublicacion" HeaderText="Fecha" />

        <asp:TemplateField HeaderText="Detalle">
            <ItemTemplate>
                <asp:Button 
                    ID="btnDetalle"
                    runat="server"
                    Text="Ver Detalle"
                    CommandName="Detalle"
                    CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Eliminar">
            <ItemTemplate>
                <asp:Button 
                    ID="btnEliminar"
                    runat="server"
                    Text="Eliminar"
                    CommandName="Eliminar"
                    CommandArgument="<%# Container.DataItemIndex %>"
                    OnClientClick="return confirm('¿Desea eliminar este libro?');" />
            </ItemTemplate>
        </asp:TemplateField>

    </Columns>

</asp:GridView>
</asp:Content>
