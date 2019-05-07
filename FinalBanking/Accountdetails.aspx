<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Accountdetails.aspx.cs" Inherits="FinalBanking.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <center>
        <asp:Label ID="Label1" runat="server" Text="Account Details" Font-Bold="True"></asp:Label><br />
        <br />
     <table>
        <tr>
            <td>
                <asp:Label ID="accidLabel1" runat="server" Text="Account id"></asp:Label></td>
            <td>
                <asp:DropDownList ID="accid" OnSelectedIndexChanged="accid_SelectedIndexChanged" AutoPostBack="True" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
           <td>
               <asp:Label ID="custidLabel1" runat="server" Text="Customer Id"></asp:Label></td>
            <td>
                <asp:TextBox ID="custidTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="acctypeLabel1" runat="server" Text="Account Type"></asp:Label></td>
            <td>
                <asp:TextBox ID="acctypeTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="statusLabel1" runat="server" Text="Status"></asp:Label></td>
            <td>
                <asp:TextBox ID="statusTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="messageLabel1" runat="server" Text="Message"></asp:Label></td>
            <td>
                <asp:TextBox ID="messageTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lastupdatedLabel1" runat="server" Text="LastUpdated"></asp:Label></td>
            <td>
                <asp:TextBox ID="lastupdatedTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="depositamtLabel1" runat="server" Text="Deposit Amount"></asp:Label></td>
            <td>
                <asp:TextBox ID="depositamtTextBox1" Enabled="false" runat="server"></asp:TextBox></td>
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
