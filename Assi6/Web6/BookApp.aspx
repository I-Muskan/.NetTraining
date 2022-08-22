<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookForm.aspx.cs" Inherits="Web6.BookForm" %>

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
                   <td>Book Id </td>
                   <td><asp:TextBox Id="txtBookId" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Book Name</td>
                   <td><asp:TextBox ID="txtBookName" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Author</td>
                   <td><asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox></td>
               
               </tr>
                <tr>
                   <td>Publisher</td>
                   <td><asp:Textbox ID="txtPublisher" runat="server"></asp:Textbox></td>
               
               </tr>
               <tr>
                   <td>Price</td>
                   <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
               
               </tr>
               <tr>
                   
                  <td><asp:button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"></asp:button></td>
               
                
                   
                   <td><asp:button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"></asp:button></td>
                   <td><asp:button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"></asp:button></td>
                   <td><asp:button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click"></asp:button></td>
               
               
               
            </tr>
             
           </table>
             <asp:GridView ID="GridView1" runat="server">

             </asp:GridView>


        </div>
    </form>
</body>
</html>
