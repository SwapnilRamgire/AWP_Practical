<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunctionOverloading.aspx.cs" Inherits="Practicals.FunctionOverloading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Circle" runat="server" Text="Circle" OnClick="Circle_Click" />
            <asp:Button ID="Rectangle" runat="server" Text="Retangle" OnClick="Rectangle_Click" />
            <asp:Button ID="Square" runat="server" Text="Square" OnClick="Square_Click" /><br />
            <asp:Label ID="OutputLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
