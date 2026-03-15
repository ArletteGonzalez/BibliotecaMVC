<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarLibro.aspx.cs" Inherits="BibliotecaMVC.Views.RegistrarLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<h2>Registrar Libro</h2>

Código:
<asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
<br /><br />

Título:
<asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
<br /><br />

<asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
<br /><br />

<asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
<br /><br />

<asp:Button ID="btnGuardar" runat="server" Text="Guardar Libro" OnClick="btnGuardar_Click"/>
<br /><br />

<asp:Label ID="lblMensaje" runat="server"></asp:Label>
