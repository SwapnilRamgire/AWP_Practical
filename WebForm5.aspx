<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Practicals.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter number : <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
