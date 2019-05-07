<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AccountSearch.aspx.cs" Inherits="FinalBanking.AccountSearch" %>
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

    <center>
        <asp:Label ID="Label2" runat="server" Text="Account Search" style="font-weight: 700"></asp:Label>
        <br />
        <br />

    <table>
        <tr>
            <td>
                <asp:Label ID="accidLabel1" runat="server" Text="Enter Account ID"></asp:Label>
                <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="accidTextBox1" OnTextChanged="accidTextBox1_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="OR"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="custidLabel2" runat="server" Text="Enter Customer ID"></asp:Label>
                <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="custidTextBox1" OnTextChanged="custidTextBox1_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="viewButton1" runat="server" Text="View" BackColor="Black" ForeColor="yellow" OnClick="viewButton1_Click"/></td>
        </tr>
    </table>
     </center>   

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
