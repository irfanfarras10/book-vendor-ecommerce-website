<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="BookVendor.View.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Change Password</h3><br />
    
    <asp:Label runat="server" Text="Old Password" Width="200px"></asp:Label>
    <asp:TextBox ID="OldPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="Change" ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Password lama harus diisi dan harus sama" ControlToValidate="OldPassword"/>
    <br />

    <asp:Label runat="server" Text="Password" Width="200px"></asp:Label>
    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="Change" ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Password Harus diisi" ControlToValidate="Password"/>
    <asp:CustomValidator ValidationGroup="Change" ID="CustomValidator2" runat="server" ErrorMessage="Minimal 5 karakter" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" ControlToValidate="Password"></asp:CustomValidator>
    <br />
    
    <asp:Label runat="server" Text="Confirm Password" Width="200px"></asp:Label>
    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="Change" ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Confirm Password Harus diisi" ControlToValidate="ConfirmPassword"/>
    <br />

    <asp:CompareValidator ValidationGroup="Change" ID="ComparePassword" runat="server" ErrorMessage="Password tidak sama" ControlToCompare="Password" ControlToValidate="ConfirmPassword" ForeColor="Red" /><br />
    <asp:LinkButton ValidationGroup="Change" Class="btn btn-primary"  ID="ChangeButton" Text="Update" runat="server" OnClick="ChangeButton_Click"/>
    <asp:Label ID="Success" Text="Change Password Success" ForeColor="Red" runat="server" Visible="false"/>
</asp:Content>
