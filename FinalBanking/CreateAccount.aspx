<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="FinalBanking.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <center><asp:Label ID="Label1" runat="server" Text="Create Account" Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
    
        <center>
    <table>
        <tr>
            <td>
                <asp:Label ID="custidLabel2" runat="server" Text="Customer ID" ></asp:Label>
                <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="custidTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="acctypeLabel2" runat="server" Text="Account Type"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:DropDownList ID="acctypeDropDownList1" runat="server"><asp:ListItem>Savings</asp:ListItem>
<asp:ListItem>Current</asp:ListItem>
</asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="depositLabel2" runat="server" Text="Deposit Amount"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="depositTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="(*)fields are compulsory" ForeColor="Red"></asp:Label></td>
        </tr>
          </table>
            </center>
    <center>
            <table>
        <tr>
            <td><asp:Button ID="submitButton1" runat="server" Text="Submit" BackColor="Black" ForeColor="Yellow" OnClick="submitButton1_Click"></asp:Button></td>
            
        </tr>
  </table>
        </center>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
