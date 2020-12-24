<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="BookVendor.View.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>View Profile</h3>
    <asp:Label Text="Username" runat="server" Width="200px" />
    <asp:TextBox ID="Username" runat="server" ReadOnly="true" /><br />

    <asp:Label Text="Name" runat="server" Width="200px" />
    <asp:TextBox ID="Name" runat="server" ReadOnly="true" /><br />

    <asp:Label Text="Gender" runat="server" Width="200px" />
    <asp:TextBox ID="Gender" runat="server" ReadOnly="true" /><br />

    <asp:Label Text="Phone Number" runat="server" Width="200px" />
    <asp:TextBox ID="Pnumber" runat="server" ReadOnly="true" /><br />

    <asp:Label Text="Adress" runat="server" Width="200px" />
    <asp:TextBox ID="Adress" runat="server" ReadOnly="true" /><br />
    <asp:button Class="btn btn-primary" ID="Update" text="Update Profile" runat="server" OnClick="Update_Click" /> 
    <asp:button Class="btn btn-primary" ID="Change" text="Change Password" runat="server" OnClick="Change_Click" />
</asp:Content>
