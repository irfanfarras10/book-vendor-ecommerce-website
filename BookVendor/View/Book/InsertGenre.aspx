﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertGenre.aspx.cs" Inherits="BookVendor.View.InsertGenre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Insert Genre</h3>
    <asp:Label Text="Name" runat="server" width="200px"/>
    <asp:TextBox ID="Name" runat="server" />
    <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nama harus diisi" ControlToValidate="Name" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:CustomValidator ValidationGroup="Insert" ID="CustomValidator1" runat="server" ErrorMessage="Harus lebih dari 3 karakter" ControlToValidate="Name" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />

    <asp:Label Text="Description" runat="server" width="200px"/>
    <asp:TextBox ID="Description" runat="server" />
    <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Description harus diisi" ControlToValidate="Description" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:CustomValidator ValidationGroup="Insert" ID="CustomValidator2" runat="server" ErrorMessage="Harus lebih dari 10 karakter" ControlToValidate="Description" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
    <br />

    <asp:Button Class="btn btn-primary" ValidationGroup="Insert" Text="Insert" runat="server" ID="Insert" OnClick="Insert_Click"/>
    <asp:Label ID="Success" Text="" runat="server"  ForeColor="Red"/>
</asp:Content>
