<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalBanking.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="Black" Font-Size="Large" ForeColor="White" Height="62px" >
        <br />
        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
           
    </asp:Panel>
   &nbsp;<asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="New Item" Value="New Item">
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item">
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item">
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
    </asp:Menu>
   <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <center><table>

        <tr>
            <td>
                 <asp:Label runat="server" Text="UserName"></asp:Label></td>
            <td>
                <asp:TextBox ID="username" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ForeColor="Red" ErrorMessage="Enter username"></asp:RequiredFieldValidator>
               
            </td>
        </tr>
        <tr>
             <td class="auto-style1">
                <asp:Label runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ForeColor="Red" ErrorMessage="Enter password"></asp:RequiredFieldValidator>
             
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="login" OnClick="login_Click" runat="server" Text="Login" BackColor="Black" ForeColor="Yellow" /></td>
        </tr>
    </table></center>
    <br />
    <br />
    <br />
       <br />
    <br />
    <br />
    <br />
    <br /> 
</asp:Content>
