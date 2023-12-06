<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="tipo.aspx.cs" Inherits="EJERCICIOEXAMEN23.tipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h1>CATALOGO DE TIPOS</h1>
    </div>
    <div class="container text-center">
        <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
            CssClass="mydatagrid" AutoGenerateColumns="true" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
            RowStyle-CssClass="rows" AllowPaging="True" />
    </div>

    <div class="container text-center">
        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Codigo</label>
            <asp:TextBox ID="tcodigo" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Descripcion</label>
                <asp:TextBox ID="tdescripcion" class="form-control" runat="server"></asp:TextBox>
                
            </div>
            <div class="mb-3">
            </div>

    <div class="container text-center">

        <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" Text="Borrar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" class="btn btn-outline-danger" Text="Modificar" OnClick="Button3_Click" />
        <asp:Button ID="Bconsulta" runat="server" class="btn btn-outline-danger" Text="Consultar" />


    </div>
</asp:Content>
