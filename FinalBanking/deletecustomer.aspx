<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="deletecustomer.aspx.cs" Inherits="FinalBanking.deletecustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <center><asp:Label ID="Label1" runat="server" Text="Delete Customer " Font-Bold="True" Font-Size="Large"></asp:Label></center>
    <br />
    
        <center>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" Text="Select Customer ID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlid" AutoPostBack="true" OnSelectedIndexChanged="ddlid_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text=" SSN Id" ></asp:Label>
                
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtcustssnid" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="custidLabel2" runat="server" Text="Customer Id"></asp:Label>
                 
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtcustid" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="custnameLabel2" runat="server" Text="Customer Name"></asp:Label></td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtcustname" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="ageLabel2" runat="server" Text="Age"></asp:Label>
               
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtage" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="addressLabel2" runat="server" Text="Address"></asp:Label>
                
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtaddress" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlid" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
          </table>
            </center>
    <center>
            <table>
        <tr>
            <td><asp:Button ID="delteButton1" runat="server" Text="Delete Customer" BackColor="Black" ForeColor="Yellow" OnClick="delteButton1_Click"></asp:Button></td>
            <td><asp:Button ID="cancelButton1" OnClick="cancelButton1_Click" runat="server" Text="Cancel" BackColor="Black" ForeColor="yellow"></asp:Button></td>
        </tr>
  </table>
        </center>

    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
