<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="viewbystartandenddate.aspx.cs" Inherits="FinalBanking.viewbystartandenddate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <center>
       <asp:Label ID="Label1" runat="server" Text="Account Statement" Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <br />
   </center>
    <center>
     <table>
         <tr>
             <td>
                 <asp:Label ID="accidLabel2" runat="server" Text="Account ID"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtaccid" Enabled="false" runat="server"></asp:TextBox>
                 
             </td>
             
         </tr>
         <tr>
            <td> <asp:Label ID="startdateLabel2" runat="server" Text="Start Date"></asp:Label></td>
             <td>
                 <asp:TextBox ID="startdateTextBox1" runat="server" TextMode="Date"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ControlToValidate="startdateTextBox1" ErrorMessage="This field cannot be empty"></asp:RequiredFieldValidator>
                 
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="enddateLabel2" runat="server" Text="End Date"></asp:Label>

             </td>
             <td>
                 <asp:TextBox ID="enddateTextBox1" runat="server" TextMode="Date"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ForeColor="Red" ControlToValidate="enddateTextBox1" ErrorMessage="This field cannot be empty"></asp:RequiredFieldValidator>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ErrorMessage="Enter valid date" ControlToCompare="startdateTextBox1" ControlToValidate="enddateTextBox1" Operator="GreaterThan"></asp:CompareValidator>
             </td>
         </tr>
         <tr>
             <td><asp:Label ID="Label2" runat="server" Text="(*)fields are mandatory" ForeColor="Red"></asp:Label></td>
         </tr>
         <tr>
             <td></td>
             <td><asp:Button ID="submitButton1" runat="server" Text="Submit" OnClick="submitButton1_Click"></asp:Button></td>
         </tr>
     </table>
        <br />
        <br />
        <asp:GridView ID="Grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
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
        </asp:GridView>

        </center>
    <br />
    </asp:Content>
