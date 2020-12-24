<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="BookVendor.View.UpdateBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>View Book</h3><br />
    <asp:TextBox ID="Search" runat="server" placeholder="Search Book" Width="200px" Height="30px"/>
    <asp:Button ID="Searchbtn" Class="btn btn-primary" Text="Search" runat="server" OnClick="Searchbtn_Click" />
    <asp:Button ID="Clearbtn" Class="btn btn-primary" Text="Clear Filter" runat="server" OnClick="Clearbtn_Click"/><br />
    <asp:Label ID="empty" Text="" runat="server" ForeColor="Red"/><br />
    <asp:Button Class="btn btn-primary" Text="Add Book" OnClick="AddBook" runat="server" />
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="Grid1" runat="server" onrowcommand="Grid1_RowCommand" OnRowDeleting="Grid1_RowDeleting" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Book ID">
                        <ItemTemplate>
                            <asp:Label ID="BookID" Text='<%#Eval("BookID")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Book Name">
                        <ItemTemplate>
                            <asp:Label ID="BookName" Text='<%#Eval("Name")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Genre">
                        <ItemTemplate>
                            <asp:Label ID="Genre" Text='<%#Eval("Genre.GenreName")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:Label ID="Description" Text='<%#Eval("Description")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Stock">
                        <ItemTemplate>
                            <asp:Label ID="Stock" Text='<%#Eval("Stock")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="Price" Text='<%#Eval("Price")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary"  Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("BookID") %>'  runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary"  Text="Delete" CommandName="Delete"  runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>  
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
