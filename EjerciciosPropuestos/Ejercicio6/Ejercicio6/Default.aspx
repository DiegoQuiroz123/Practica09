<%@ Page Title="Farmacia Lupe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>PORFAVOR INGRESE EL CODIGO DE LA VENTA A BUSCAR </p><asp:TextBox id="idVenta" runat="server" ></asp:TextBox>
    <br />
    <asp:button id="botonVenta" runat="server" Text="Buscar" OnClick="ClickBuscar"/>
    <br />
    <asp:Label ID ="labelPro" runat="server"></asp:Label>
    <h1 align="center" >PRODUCTOS</h1>
    <p style="margin-left: 160px">
    <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    <br />
    </p>
    <h1 align="center">VENTAS</h1>
    <p align="center">
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
    </p>
    <p align="center">&nbsp;</p>
    <br />
</asp:Content>
