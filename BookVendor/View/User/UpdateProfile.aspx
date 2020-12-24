<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="BookVendor.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Update Profile</h3><br />
    <asp:Label runat="server" Text="Name" Width="200px"></asp:Label>
    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Nama Harus diisi" ControlToValidate="Name"/>
    <br />

    <asp:Label runat="server" Text="Gender" Width="200px"></asp:Label>
    <asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" Width="190px">
    <asp:ListItem Text="Male"/>
    <asp:ListItem Text="Female"/>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Harus pilih salah satu" ControlToValidate="Gender" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:Label runat="server" Text="Phone Number" Width="200px"></asp:Label>
    <asp:TextBox ID="PhoneNumber" runat="server" TextMode="Number" MaxLength="12"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Phone Number Harus diisi" ControlToValidate="PhoneNumber"/>
    <br />

    <asp:Label runat="server" Text="Adress" Width="200px"></asp:Label>
    <asp:TextBox ID="Adress" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ErrorMessage="Adress harus diisi" ControlToValidate="Adress"/>
    <asp:CustomValidator ValidationGroup="update" ID="CustomValidator3" runat="server" ErrorMessage="Harus mengandung kata 'Street'" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate" ControlToValidate="Adress"></asp:CustomValidator>
    <br />
    <asp:LinkButton ValidationGroup="update" Class="btn btn-primary"  ID="UpdateButton" Text="Update" runat="server" OnClick="UpdateButton_Click"/>
    <asp:Label ID="Success" Text="Update Success" ForeColor="Red" runat="server" Visible="false"/>
</asp:Content>
