<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="TransferMoney.aspx.cs" Inherits="FinalBanking.TransferMoney" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 285px;
            background-image: url('images/bank%20baner.jpg');
        }
        .auto-style2 {
            width: 642px;
        }
        .auto-style3 {
            width: 642px;
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <center><asp:Label ID="Label1" runat="server" Text="Transfer Money" style="font-weight: 700"></asp:Label>
        <br />
        <br />
        <table align="center">
            <tr>
                <td >Source Account ID</td>
                <td>
                    <asp:TextBox ID="txtsid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;Target Account ID</td>
                <td>
                    <asp:TextBox ID="txttid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Target Account Type</td>
                <td>
                    <asp:DropDownList ID="ddltype" runat="server">
                        <asp:ListItem>Savings</asp:ListItem>
                        <asp:ListItem>Current</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Transfer Amount</td>
                <td>
                    <asp:TextBox ID="txtamt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <br />
                <br />
                <td>
                    <asp:Button ID="ButtonTransfer" runat="server" BackColor="Black" ForeColor="Yellow" Text="Transfer" OnClick="ButtonTransfer_Click" />
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
