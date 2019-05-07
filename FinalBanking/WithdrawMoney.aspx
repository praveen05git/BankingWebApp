<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WithdrawMoney.aspx.cs" Inherits="FinalBanking.WithdrawMoney" %>
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
       <asp:Label ID="Label1" runat="server" Text="Withdraw Money" style="font-weight: 700"></asp:Label><br />
        <br />
   </center>
    <center>
    <table>
        <tr>
            <td><asp:Label ID="custidLabel2" runat="server" Text="Customer ID"></asp:Label></td>
            <td><asp:DropDownList ID="ddlid" AutoPostBack="true" OnSelectedIndexChanged="ddlid_SelectedIndexChanged" runat="server"></asp:DropDownList></td>
            </tr>
        <tr>
            <td><asp:Label ID="accidLabel2" runat="server" Text="Account ID"></asp:Label></td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlaccid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlaccid_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                        </asp:DropDownList>
                    </ContentTemplate>
                    <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                        </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="acctypeLabel2" runat="server" Text="Account Type"></asp:Label>
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="lbleacctype" runat="server" Text=""></asp:Label>
                    </ContentTemplate>
                    <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlaccid" EventName="SelectedIndexChanged" />
                        </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="balanceLabel2" runat="server" Text="Balance"></asp:Label></td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="lblebalance" runat="server" Text=""></asp:Label>
                    </ContentTemplate>
                     <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlaccid" EventName="SelectedIndexChanged" />
                        </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="withdrawamntLabel2" runat="server" Text="Withdraw Amount"></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter digits only" ForeColor="Red" ValidationExpression="\d{1,10}" ControlToValidate="TextBox1"></asp:RegularExpressionValidator>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="submitButton1" runat="server" Text="Submit" OnClick="submitButton1_Click" BackColor="Black" ForeColor="Yellow"></asp:Button></td>
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
