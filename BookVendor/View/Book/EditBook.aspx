<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="BookVendor.View.EditBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Modify Book</h3>
    <asp:label text="BookID" runat="server" width="200px" />
    <asp:textbox ID="InsertId" runat="server" ReadOnly="True"></asp:textbox>
    <br />

    <asp:Label Text="Name" runat="server" width="200px"/>
    <asp:TextBox ID="Name" runat="server" />
    <asp:RequiredFieldValidator ForeColor="Red" ValidationGroup="Update" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nama harus diisi" ControlToValidate="Name"></asp:RequiredFieldValidator>
    <br />

    <asp:Label Text="Genre" runat="server" width="200px"/>
    <asp:DropDownList DataTextField="GenreName" DataValueField="GenreID" ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ForeColor="Red" ValidationGroup="Update" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Genre harus dipilih" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
    <br />

    <asp:Label Text="Description" runat="server" width="200px"/>
    <asp:TextBox ID="Description" runat="server" />
    <asp:RequiredFieldValidator ValidationGroup="Update" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Description harus diisi" ControlToValidate="Description"></asp:RequiredFieldValidator>
    <asp:CustomValidator ForeColor="Red" ValidationGroup="Update" ID="CustomValidator1" runat="server" ErrorMessage="Harus lebih dari 10 karakter" ControlToValidate="Description" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />

    <asp:Label Text="Stock" runat="server" width="200px" />
    <asp:TextBox ID="Stock" runat="server" TextMode="Number" />
    <asp:RequiredFieldValidator ValidationGroup="Update" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Stock harus diisi" ControlToValidate="Stock"></asp:RequiredFieldValidator>
    <asp:RangeValidator type="Integer" ValidationGroup="Update" ForeColor="Red" ID="RangeValidator1" runat="server" ErrorMessage="Harus lebih dari 0" MinimumValue="1" MaximumValue="100000000" ControlToValidate="Stock"></asp:RangeValidator>
    <br />

    <asp:Label Text="Price" runat="server" width="200px"/>
    <asp:TextBox ID="Price" runat="server" TextMode="Number" />
    <asp:RequiredFieldValidator ForeColor="Red" ValidationGroup="Update" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Price harus diisi" ControlToValidate="Price"></asp:RequiredFieldValidator>
    <asp:RangeValidator type="Integer" ValidationGroup="Update" ForeColor="Red" ID="RangeValidator2" runat="server" ErrorMessage="Harus lebih dari 0" MinimumValue="1" MaximumValue="100000000" ControlToValidate="Price"></asp:RangeValidator>
    <br />

    <asp:Button Class="btn btn-primary" ValidationGroup="Update" Text="Update" runat="server" ID="Update" OnClick="Insert_Click"/>
    <asp:Label ID="Success" Text="" runat="server" ForeColor="Red" />
</asp:Content>
