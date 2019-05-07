<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AccountStatus.aspx.cs" Inherits="FinalBanking.AccountStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <center>
        <asp:Label ID="Label1" runat="server" Text="Account Status" Font-Bold="True"></asp:Label>
        <br />
        <br />
    <asp:GridView ID="Grid" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:TemplateField HeaderText="Customer Id">
                <ItemTemplate>
                    <asp:Label ID="custidLabel1" runat="server" Text='<%#Eval("Customer_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Account Id">
                <ItemTemplate>
                    <asp:Label ID="accidLabel1" runat="server" Text='<%#Eval("Account_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Account type">
                <ItemTemplate>
                    <asp:Label ID="acctypeLabel1" runat="server" Text='<%#Eval("Account_type") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Account Status">
                <ItemTemplate>
                    <asp:Label ID="statusLabel2" runat="server" Text='<%#Eval("Status") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:Label ID="messageLabel1" runat="server" Text='<%#Eval("Message") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Last Updated">
                <ItemTemplate>
                    <asp:Label ID="createddateLabel1" runat="server" Text='<%#Eval("Created_date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Operation">
                <ItemTemplate>
                    <asp:Button ID="refreshLinkButton1" runat="server" Text="Refresh" OnClick="refreshLinkButton1_Click"></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
        </center>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
