<%@ Page Theme="Theme1" Language="C#" AutoEventWireup="true" CodeBehind="Beautification.aspx.cs" Inherits="Practicals.Beautification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div> 
            <div class="inputCont"> 
            <asp:Label ID="Label1" SkinID="lsk1" runat="server" Text="Login"></asp:Label> 
            <asp:TextBox ID="TextBox1" runat="server" CssClass="inputBox"></asp:TextBox> 
            <asp:TextBox ID="TextBox2" runat="server" CssClass="inputBox" TextMode="Password"></asp:TextBox> 
            <asp:Button ID="Button1" runat="server" CssClass="loginBtn" Text="Login"/> 
            </div> 
        </div> 
    </form>
</body>
</html>
