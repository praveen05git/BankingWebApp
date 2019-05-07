<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customerdetails.aspx.cs" Inherits="FinalBanking.WebForm1" %>
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
    <br />
    <center><asp:Label ID="Label1" runat="server" Text="Customer Details" Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
    
        <center>
    <table>
        <tr>
            <td>
                <asp:Label ID="custidLabel2" runat="server" Text="Customer ID" ></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbleid" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Customer SSNID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbleiid" runat="server"></asp:Label>
            </td>
                
        </tr>
        <tr>
            <td>
                <asp:Label ID="acctypeLabel2" runat="server" Text="Customer Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblename" runat="server"></asp:Label>
            </td>
                
        </tr>
        <tr>
            <td>
                <asp:Label ID="depositLabel2" runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbleage" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>

            </td>
            <td>
                <asp:Label ID="lbleadd" runat="server"></asp:Label>
            </td>
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
