<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="BookVendor.View.Transaction1.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Cart</h1><br />
    <asp:Button Class="btn btn-primary" Text="Check Out" ID="cekout" runat="server" OnClick="cekout_Click" />
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="Grid1" runat="server" OnRowCommand="Grid1_RowCommand" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Book Name" ControlStyle-Width="300">
                        <ItemTemplate>
                            <asp:Label ID="Name" Text='<%#Eval("Book.Name")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price"  ControlStyle-Width="200">
                        <ItemTemplate>
                            <asp:Label ID="Price" Text='<%#"Rp"+Eval("Book.Price")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantity"  ControlStyle-Width="200">
                        <ItemTemplate>
                            <asp:Label ID="Quantity" Text='<%#Eval("Quantity")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Subtotal"  ControlStyle-Width="200">
                        <ItemTemplate>
                            <asp:Label ID="Subtotal" Text='<%#Convert.ToInt32(Eval("Quantity"))*Convert.ToInt32(Eval("Book.Price")) %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton Class="btn btn-primary"  Text="Delete" CommandName="DeleteItem" CommandArgument='<%#Eval("Book.BookID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>  
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:Label Text="" ForeColor="blue" ID="total" runat="server" Font-Bold="True" Font-Size="20" />
</asp:Content>
