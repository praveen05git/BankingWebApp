<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="FinalBanking.CreateCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <center><asp:Label ID="Label1" runat="server" Text="Create Customer Screen" Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
   
        <center>
    <table>
        <tr>
            <td>
                <asp:Label ID="custssnidLabel2" runat="server" Text="Customer SSN ID" ></asp:Label>
                <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="custssnidTextBox1" ClientIDMode="Static" runat="server"></asp:TextBox>
            </td>
            <td>    
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="valid" runat="server" ControlToValidate="custssnidTextBox1" ErrorMessage="This field cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="numerr" ClientIDMode="Static" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="custnameLabel2" runat="server" Text="Customer Name"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="custnameTextBox1" ClientIDMode="Static" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="valid" runat="server" ControlToValidate="custnameTextBox1" ErrorMessage="This field cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="namerr" ClientIDMode="Static" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="ageLabel2" runat="server" Text="Age"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="ageTextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="valid" runat="server" ControlToValidate="ageTextBox1" ErrorMessage="This field cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="addressLabel2" runat="server" Text="Address"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:TextBox ID="addresTextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="valid" runat="server" ControlToValidate="addresTextBox1" ErrorMessage="This field cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="stateLabel2" runat="server" Text="State"></asp:Label>
                 <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:DropDownList ID="ddlstate" ValidationGroup="valid" OnSelectedIndexChanged="stateDropDownList1_SelectedIndexChanged" AutoPostBack="true" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>TamilNadu</asp:ListItem>
                    <asp:ListItem>Kerala</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="valid" runat="server" ControlToValidate="ddlstate" ErrorMessage="This field cannot be empty" ForeColor="Red" InitialValue="Select"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                         <asp:Label ID="cityLabel2" runat="server" Text="City"></asp:Label>
                         <sup style="color:red">*</sup>
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                <asp:DropDownList ID="ddlcity" ValidationGroup="valid" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                </asp:DropDownList>
                        </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlstate" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="valid" runat="server" ControlToValidate="ddlcity" ErrorMessage="This field cannot be empty" ForeColor="Red" InitialValue="Select"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="(*)fields are compulsory" ForeColor="Red"></asp:Label></td>
        </tr>
          </table>
            </center>
    <center>
            <table>
        <tr>
            <td><asp:Button ID="submitButton1" runat="server" OnClientClick="return validate()" ValidationGroup="valid" Text="Submit" BackColor="Black" ForeColor="Yellow" OnClick="submitButton1_Click"></asp:Button></td>
            <td><asp:Button ID="resetButton1" runat="server" OnClick="resetButton1_Click" Text="Reset" BackColor="Black" ForeColor="yellow"></asp:Button></td>
        </tr>
  </table>
            <br />
            <br />
            <br />
            <br />
        </center>
    
</asp:Content>
