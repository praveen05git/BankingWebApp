<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Viewbynooftransaction.aspx.cs" Inherits="FinalBanking.Viewbynooftransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><asp:Label ID="Label1" runat="server" Text="Account Statement" style="font-weight: 700"></asp:Label>
        <br />
        <br />
        <table align="center">
            <tr>
                <td >Account ID</td>
                <td>
                    <asp:TextBox ID="TextAccId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="valid" ForeColor="Red" ControlToValidate="TextAccId" ErrorMessage="Please Enter Account ID!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label runat="server" Text="Select"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="selection" ValidationGroup="valid" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Number of Transactions</asp:ListItem>
                        <asp:ListItem Value="2">Start-End Date</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="valid" ForeColor="Red" ControlToValidate="selection" ErrorMessage="Please select any one!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>No of Transactions</td>
                <td>
                    <asp:DropDownList ID="DDLTransaction" ValidationGroup="valid" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="DDLTransaction" ForeColor="Red" ValidationGroup="valid" ErrorMessage="Please sekect any one!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td><br />
                <br />

                <br />

                <td>
                    <asp:Button ID="ButtonSubmit" runat="server" BackColor="Black" Text="Submit" Width="88px" ValidationGroup="valid" OnClick="ButtonSubmit_Click" ForeColor="Yellow" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </center>
    <br />
&nbsp;&nbsp;&nbsp;
  <center>  <asp:GridView ID="Grid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="Grid_SelectedIndexChanged" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
      <AlternatingRowStyle BackColor="#F7F7F7" />
      <Columns>
          <asp:TemplateField HeaderText="Transaction ID">
              <ItemTemplate>
                  <asp:Label runat="server"  Text='<%#Eval("Transaction_id") %>'></asp:Label>
              </ItemTemplate>
          </asp:TemplateField>

           <asp:TemplateField HeaderText="Transaction Date">
              <ItemTemplate>
                  <asp:Label runat="server"  Text='<%#Eval("Transaction_date") %>'></asp:Label>
              </ItemTemplate>
          </asp:TemplateField>

           <asp:TemplateField HeaderText="Amount">
              <ItemTemplate>
                  <asp:Label runat="server"  Text='<%#Eval("Amount") %>'></asp:Label>
              </ItemTemplate>
          </asp:TemplateField>

           <asp:TemplateField HeaderText="Description">
              <ItemTemplate>
                  <asp:Label runat="server"  Text='<%#Eval("Description") %>'></asp:Label>
              </ItemTemplate>
          </asp:TemplateField>

           <asp:TemplateField HeaderText="Balance">
              <ItemTemplate>
                  <asp:Label runat="server"  Text='<%#Eval("Balance") %>'></asp:Label>
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
            </asp:GridView></center>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
