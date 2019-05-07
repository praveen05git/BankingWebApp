<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CutomerSearch.aspx.cs" Inherits="FinalBanking.CutomerSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <center>
        <asp:Label ID="Label2" runat="server" Text="Customer Search" style="font-weight: 700"></asp:Label>
        <br />
        <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="ssnidLabel1" runat="server" Text="Enter SSN ID"></asp:Label>
                <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="ssnidTextBox1" OnTextChanged="ssnidTextBox1_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox></td>
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
