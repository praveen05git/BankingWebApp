<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteAccount.aspx.cs" Inherits="FinalBanking.DeleteAccount" %>
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
    
    <center><asp:Label ID="Label1" runat="server" Text="Delete Account" Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
    
        <center>
    <table>
        <tr>
            <td>
                <asp:Label ID="accidLabel2" runat="server" Text="Account ID" ></asp:Label>
                
            </td>
            <td>
                <asp:DropDownList ID="ddlid" AutoPostBack="true" OnSelectedIndexChanged="acidDropDownList1_SelectedIndexChanged" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="acctypeLabel2" runat="server" Text="Account Type"></asp:Label>
                 
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="acctypeTextBox1" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
            </center>
    <center>
            <table>
        <tr>
            <td><asp:Button ID="deleteButton1" runat="server" Text="Delete Account" BackColor="Black" ForeColor="Yellow" OnClick="deleteButton1_Click"></asp:Button></td>
            
        </tr>
  </table>
        </center>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    \<br />
    <br />

</asp:Content>
