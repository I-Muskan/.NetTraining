<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="customerData" runat="server">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer Id" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="PhoneNo" HeaderText="Phone No" />
                    <asp:BoundField DataField="EmailId" HeaderText="Mail Id" />
                   
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
