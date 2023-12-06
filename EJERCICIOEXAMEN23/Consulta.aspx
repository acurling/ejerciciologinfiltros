<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="EJERCICIOEXAMEN23.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h1>CONSULTAS</h1>
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

                <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Consultar" />
              
            </div>
        </div>
        </div>
</asp:Content>
