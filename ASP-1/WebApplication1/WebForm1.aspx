<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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
                   <td><asp:TextBox Id="customerId" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Customer Name</td>
                   <td><asp:TextBox ID="customerName" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Address </td>
                   <td><asp:TextBox ID="address" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Phone No</td>
                   <td><asp:Textbox ID="phoneNo" runat="server"></asp:Textbox></td>
               
               </tr>
               <tr>
                   <td>Mail Id</td>
                   <td><asp:TextBox ID="mailId" runat="server"></asp:TextBox></td>
               
               </tr>
               <tr>
                   
                   <td><asp:button ID="add" runat="server" Text="Add"></asp:button></td>
               
                
                   
                   <td><asp:button ID="save" runat="server" Text="Save" OnClick="Save_Click"></asp:button></td>
               
            </tr>
             
           </table>
        </div>
    </form>
</body>
</html>
