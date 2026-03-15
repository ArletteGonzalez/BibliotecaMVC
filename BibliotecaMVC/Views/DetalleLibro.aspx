<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleLibro.aspx.cs" Inherits="BibliotecaMVC.Views.DetalleLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle del Libro</h2>

Código:
<asp:Label ID="lblCodigo" runat="server"></asp:Label>
<br /><br />

Título:
<asp:Label ID="lblTitulo" runat="server"></asp:Label>
<br /><br />

Autor:
<asp:Label ID="lblAutor" runat="server"></asp:Label>
<br /><br />

Fecha:
<asp:Label ID="lblFecha" runat="server"></asp:Label>
<br /><br />

<asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>
