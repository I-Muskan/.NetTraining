<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="selectColor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" ID="ListBox1" SelectionMode="Multiple" width="150px">
            <asp:ListItem>Red</asp:ListItem>
             <asp:ListItem>Green</asp:ListItem>
             <asp:ListItem>Blue</asp:ListItem>
              <asp:ListItem>Yellow</asp:ListItem>
               <asp:ListItem>Orange</asp:ListItem>
             </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>
