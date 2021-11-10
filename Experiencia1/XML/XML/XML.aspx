<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XML.aspx.cs" Inherits="XML.XML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="nuevoEstilo1">
            <asp:Button ID="cmdCreateXml" runat="server" OnClick="cmdCreateXml_Click" Text="Crear XML" Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdReadXml" runat="server" Text=" Leer XML (Como texto)" Width="193px" OnClick="cmdReadXml_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cdmReadXmlAsObjects" runat="server" Text="Leer XML ( Como objeto ) " Width="223px" OnClick="cdmReadXmlAsObjects_Click" />
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

