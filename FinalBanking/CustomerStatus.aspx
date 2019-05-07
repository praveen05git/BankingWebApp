<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="CustomerStatus.aspx.cs" Inherits="FinalBanking.CustomerStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <center>
    <asp:Label ID="Label1" runat="server" Text="Customer Status" Font-Bold="True"></asp:Label>
        <br />
        <br />

    <asp:GridView ID="Grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:TemplateField HeaderText="Customer ID">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbleid" Text='<%#Eval("Customer_id")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Customer SSNID">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Ssnid")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Status")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Message")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Last updated">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Lastupdated")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Operations">
                <ItemTemplate>
                    <asp:Button ID="refresh" runat="server" OnClick="refresh_Click" Text="Refresh" />
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
</asp:Content>
