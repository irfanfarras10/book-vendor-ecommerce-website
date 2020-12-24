<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="BookVendor.View.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>View User</h3>
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="false" onrowcommand="CustomersGridView_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Username">
                        <ItemTemplate>
                            <asp:Label ID="Usename" Text='<%#Eval("Username")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="Name" Text='<%#Eval("Name")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Role">
                        <ItemTemplate>
                            <asp:Label ID="Role" Text='<%#Eval("Role.RoleName")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="Gender" Text='<%#Eval("Gender")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Phone Number">
                        <ItemTemplate>
                            <asp:Label ID="Pnumber" Text='<%#Eval("PhoneNumber")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Adress">
                        <ItemTemplate>
                            <asp:Label ID="Adress" Text='<%#Eval("Adress")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Banned">
                        <ItemTemplate>
                            <asp:Label ID="Banned" Text='<%#Eval("Banned").ToString() == "1" ? "Banned" : "Not Banned"%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary" ID="Delete" CommandArgument='<%# Eval("UserID") %>'  Text='Delete' CommandName="DeleteUser"  runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ban">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary" ID="Ban" CommandName="Ban" CommandArgument='<%# Eval("UserID") %>' Text='<%#Eval("Banned").ToString() == "1" ? "Unbanned" : "Banned"%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Promote">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary" ID="PromoteButton" CommandName="Promote" CommandArgument='<%# Eval("UserID") %>' Text="Promote" runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>  
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
