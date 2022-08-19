<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="App1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table>
               <tr>
                   <td>Customer Id </td>
                   <td><asp:Textbox ID="customerId" runat="server"></asp:Textbox></td>
               
               </tr>
                <tr>
                   <td>Customer Name</td>
                   <td><asp:Textbox ID="customerName" runat="server"></asp:Textbox></td>
               
               </tr>
                <tr>
                   <td>Address </td>
                   <td><asp:Textbox ID="address" runat="server"></asp:Textbox></td>
               
               </tr>
                <tr>
                   <td>Phone No</td>
                   <td><asp:Textbox ID="phoneNo" runat="server"></asp:Textbox></td>
               
               </tr>
               <tr>
                   <td>Mail Id</td>
                   <td><asp:Textbox ID="mailId" runat="server"></asp:Textbox></td>
               
               </tr>
               <tr>
                   
                   <td><asp:button ID="add" runat="server" Text="Add"></asp:button></td>
               
                  <%-- <a href="WebForm1.aspx">WebForm1.aspx</a>--%>
                   
                   <td><asp:button ID="save" runat="server" Text="Save" OnClick="save_Click"></asp:button></td>
               
            </tr>
             
           </table>
        </div>
    </form>
</body>
</html>
