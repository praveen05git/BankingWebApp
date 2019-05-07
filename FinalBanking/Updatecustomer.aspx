<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Updatecustomer.aspx.cs" Inherits="FinalBanking.Updatecustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    <br />
    <br />
    <center><asp:Label ID="Label1" runat="server" Text="Update Customer" Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
   
        <center>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" Text="Select Customer ID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlid_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="Customer SSN ID" ></asp:Label>
                
            </td>
            <td>
                <asp:Label ID="lblessnid" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="Customer ID"></asp:Label>
                 
            </td>
            <td>
                <asp:Label ID="lbleid" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="Old Customer Name"></asp:Label>
              
            </td>
            <td>
                <asp:Label ID="lblename" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="newcustnameLabel2" runat="server" Text="New Customer Name"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="newcustnameTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="oldaddressLabel2" runat="server" Text="Old Address"></asp:Label>
             
            </td>
            <td>
                <asp:Label ID="lbleaddress" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="newaddressLabel2" runat="server" Text="New Address"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="newaddressTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td><asp:Label runat="server" Text="Old Age"></asp:Label></td>
            <td><asp:Label ID="lbleage" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="newageLabel3" runat="server" Text="New Age"></asp:Label>
                <sup style="color:red"></sup>
                </td>
        <td><asp:TextBox ID="newageTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            
            <td><asp:Label ID="Label2" runat="server" Text="(*)fields are compulsory" ForeColor="Red"></asp:Label></td>
        </tr>
          </table>
            </center>
    <center>
            <table>
        <tr>
            <td></td>
            <td><asp:Button ID="updateButton1" runat="server" Text="Update" BackColor="Black" ForeColor="yellow" OnClick="updateButton1_Click"></asp:Button></td>
        </tr>
  </table>
        </center>

    <br />

</asp:Content>
