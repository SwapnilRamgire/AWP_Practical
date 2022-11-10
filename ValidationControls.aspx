<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="Practicals.ValidationControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div> 
            <asp:Label ID="Label2" runat="server" Text="Enter UserName"></asp:Label> 
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 54px" ></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter User ID" ControlToValidate="TextBox1"></asp:RequiredFieldValidator> 
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Username should be less than 25 Characters" ControlToValidate="TextBox1" ValidationExpression="\D{1,25}"></asp:RegularExpressionValidator><br /> 
             
            <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label> 
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 124px"></asp:TextBox> 
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox6" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator><br /> 
 
            <asp:Label ID="Label3" runat="server" Text="Enter Password"></asp:Label> 
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 60px" TextMode="Password" ></asp:TextBox> 
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Password should contain characters and digits, minimum lenght : 8" ControlToValidate="TextBox2" ValidationExpression="[a-zA-Z]\w*\d+\w*"></asp:RegularExpressionValidator><br /> 
            <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label> 
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 42px" TextMode="Password"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password didn't matched." ControlToValidate="TextBox3" ControlToCompare="TextBox2"></asp:CompareValidator><br /> 
 
            <asp:Label ID="Label5" runat="server" Text="Age"></asp:Label> 
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 132px"></asp:TextBox> 
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be inbetween 18-50" ControlToValidate="TextBox4" Type="Integer" MinimumValue="18" MaximumValue="50"></asp:RangeValidator><br /> 
 
            <asp:Label ID="Label6" runat="server" Text="Mobile Number"></asp:Label> 
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 59px"></asp:TextBox> 
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Enter valid phone no." ControlToValidate="TextBox5" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator><br /> 
             
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> 
            <asp:Button ID="Button2" runat="server" Text="Clear" style="margin-left: 28px" OnClick="Button2_Click"/><br/> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
        </div> 
    </form>
</body>
</html>
