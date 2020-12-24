<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateGenre.aspx.cs" Inherits="BookVendor.View.UpdateGenre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button Class="btn btn-primary" Text="Add Genre" OnClick="AddGenre" runat="server" />
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="Grid1" runat="server" onrowcommand="Grid1_RowCommand" OnRowDeleting="Grid1_RowDeleting" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="GenreID">
                        <ItemTemplate>
                            <asp:Label ID="GenreID" Text='<%#Eval("GenreID")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Genre Name">
                        <ItemTemplate>
                            <asp:Label ID="GenreName" Text='<%#Eval("GenreName")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Genre Description">
                        <ItemTemplate>
                            <asp:Label ID="GenreDescription" Text='<%#Eval("Description")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary"  Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("GenreID") %>'  runat="server" />
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

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label Text="" ForeColor="Red" ID="cek1" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
