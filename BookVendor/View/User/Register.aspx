<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookVendor.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Register</h3>
    <asp:Label runat="server" Text="Username" Width="200px"></asp:Label>
    <asp:TextBox ID="Username" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Username harus diisi" ControlToValidate="Username"/>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Minimal 3 karakter" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="Username"></asp:CustomValidator>
    <br />

    <asp:Label runat="server" Text="Password" Width="200px"></asp:Label>
    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Password Harus diisi" ControlToValidate="Password"/>
    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Minimal 8 karakter" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" ControlToValidate="Password"></asp:CustomValidator>
    <br />
    
    <asp:Label runat="server" Text="Confirm Password" Width="200px"></asp:Label>
    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Confirm Password Harus diisi" ControlToValidate="ConfirmPassword"/>
    <br />
    <asp:CompareValidator ID="ComparePassword" runat="server" ErrorMessage="Password tidak sama" ControlToCompare="Password" ControlToValidate="ConfirmPassword" ForeColor="Red" /><br />

    <asp:Label runat="server" Text="Name" Width="200px"></asp:Label>
    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ErrorMessage="Nama Harus diisi" ControlToValidate="Name"/>
    <br />

    <asp:Label runat="server" Text="Gender" Width="200px"></asp:Label>
    <asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" Width="190px">
        <asp:ListItem Text="Male"/>
        <asp:ListItem Text="Female"/>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Harus pilih salah satu" ControlToValidate="Gender" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:Label runat="server" Text="Phone Number" Width="200px"></asp:Label>
    <asp:TextBox ID="PhoneNumber" runat="server" TextMode="Number" MaxLength="12"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" runat="server" ErrorMessage="Phone Number Harus diisi" ControlToValidate="PhoneNumber"/>
    <br />

    <asp:Label runat="server" Text="Adress" Width="200px"></asp:Label>
    <asp:TextBox ID="Adress" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="Red" runat="server" ErrorMessage="Adress harus diisi" ControlToValidate="Adress"/>
    <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Harus mengandung kata 'Street'" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate" ControlToValidate="Adress"></asp:CustomValidator>
    <br />
    <asp:LinkButton Class="btn btn-primary"  ID="RegisterButton1" Text="Register" runat="server" OnClick="RegisterButton1_Click" />
    <asp:Label ID="Success" Text="" ForeColor="Red" runat="server"/><br />
    <asp:RequiredFieldValidator ForeColor="Red" ID="cekuser" runat="server" ErrorMessage="" ControlToValidate="Username"></asp:RequiredFieldValidator>
    <asp:Label ForeColor="Red" Text="" ID="ceklbl" runat="server" />
</asp:Content>
