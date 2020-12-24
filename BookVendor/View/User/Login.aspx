<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookVendor.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Login</h3>
    <asp:Label runat="server" Text="Email/Username" Width="130px"></asp:Label>
    <asp:TextBox ID="LoginEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email harus diisi" ControlToValidate="LoginEmail" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:Label runat="server" Text="Password" Width="130px"></asp:Label>
    <asp:TextBox TextMode="Password" ID="LoginPassword" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password harus diisi" ControlToValidate="LoginPassword" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me"/><br />
    <asp:LinkButton class="btn btn-primary" ID="LoginButton1" runat="server" Text="Login" OnClick="LoginButton1_Click" />
    <asp:Label ForeColor="Red" Text="" ID="error" runat="server" /><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/View/User/Register.aspx">Dont have an account? Register Now</asp:HyperLink>
</asp:Content>
