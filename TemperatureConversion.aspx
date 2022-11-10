<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemperatureConversion.aspx.cs" Inherits="Practicals.TemperatureConversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tempInput" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Celcius" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Fahrenheit" OnClick="Button2_Click" />
            <asp:Label ID="OutputLable" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
