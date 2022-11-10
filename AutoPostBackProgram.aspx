<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutoPostBackProgram.aspx.cs" Inherits="Practicals.AutoPostBackProgram" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div> 
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"> 
                <asp:ListItem Value="400701">Ghansoli</asp:ListItem> 
                <asp:ListItem Value="400709">Vashi</asp:ListItem> 
                <asp:ListItem Value="400614">CBD Belapur</asp:ListItem> 
                <asp:ListItem Value="400706">Nerul</asp:ListItem> 
            </asp:DropDownList> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
            <br /> 
            <asp:Label ID="Label2" runat="server" Text="TestText"></asp:Label> 
            <br /> 
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"> 
                <asp:ListItem>Small</asp:ListItem> 
                <asp:ListItem>Medium</asp:ListItem> 
                <asp:ListItem>Large</asp:ListItem> 
            </asp:RadioButtonList> 
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged"> 
                <asp:ListItem>Times New Roman</asp:ListItem> 
                <asp:ListItem>Arial</asp:ListItem> 
                <asp:ListItem>Jokerman</asp:ListItem> 
                <asp:ListItem>Sans-serif</asp:ListItem> 
            </asp:RadioButtonList> 
            <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged"> 
                <asp:ListItem>Red</asp:ListItem> 
                <asp:ListItem>Green</asp:ListItem> 
                <asp:ListItem>Blue</asp:ListItem> 
            </asp:RadioButtonList> 
            <asp:CheckBox AutoPostBack="true" ID="CheckBox1" runat="server" Text="Bold" OnCheckedChanged="CheckBox1_CheckedChanged" /> 
            <asp:CheckBox AutoPostBack="true" ID="CheckBox2" runat="server" Text="Italic" OnCheckedChanged="CheckBox2_CheckedChanged" /> 
            <asp:CheckBox AutoPostBack="true" ID="CheckBox3" runat="server" Text="Underline" OnCheckedChanged="CheckBox3_CheckedChanged" /> 
        </div> 
    </form>
</body>
</html>
