<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqObjects._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </p>
    <p>
        Total Peliculas : <asp:TextBox ID="Total" runat="server" Width="233px"></asp:TextBox>
    </p>
    <p>
        Maximo RunTime:<asp:TextBox ID="Maximo" runat="server" Height="18px" Width="221px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Minimo RunTime:<asp:TextBox ID="Minimo" runat="server" Width="225px"></asp:TextBox>
    </p>
    <p>
        Promedio Runtime:<asp:TextBox ID="Promedio" runat="server" Width="201px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
