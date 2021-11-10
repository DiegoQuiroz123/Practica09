<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="XML.Index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .nuevoEstilo1 {
            background-color: #00CC99;
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="nuevoEstilo1">
            <asp:Button ID="cmdCreateXml" runat="server" OnClick="cmdCreateXml_Click" Text="Crear XML" Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdReadXml" runat="server" Text=" Leer XML (Como texto)" Width="193px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cdmReadXmlAsObjects" runat="server" Text="Leer XML ( Como objeto ) " Width="223px" />
            <br />
            <br />
            <asp:Label ID="lblXml" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gridResults" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
