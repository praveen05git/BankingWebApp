<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DepositMoney.aspx.cs" Inherits="FinalBanking.DepositMoney" %>
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
               <asp:Label ID="Label1" runat="server" Text="Deposit Money" style="font-weight: 700"></asp:Label>
               <br />
               <br />
    
    
            <table   class="auto-style2">
            <tr>
                <td >Customer ID</td>
                <td >
                    <asp:DropDownList ID="ddlid" OnSelectedIndexChanged="ddlid_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td >Account ID</td>
                <td >
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddlaccid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="accid_SelectedIndexChanged">
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
                <td >Account Type</td>
                <td >
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lbleacctype" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlaccid" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>Balance</td>
                <td >
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblebalance" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlaccid" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td >Deposit Amount</td>
                <td >
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter digits only" ForeColor="Red" ValidationExpression="\d{1,10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td ></td>
                <td>
                    <asp:Button ID="ButtonSub1" runat="server" BackColor="Black" ForeColor="Yellow" Text="Submit" Width="99px" OnClick="ButtonSub1_Click" style="height: 26px" />
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
