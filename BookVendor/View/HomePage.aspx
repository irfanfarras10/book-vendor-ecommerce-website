<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookVendor.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button Class="btn btn-primary" ID="vbook" Text="View Books" runat="server" OnClick="vbook_Click" />
    <asp:Button Class="btn btn-primary" ID="vprofile" Text="View Profile" runat="server" OnClick="vprofile_Click" />
    <asp:Button Class="btn btn-primary" ID="vcart" Text="View Cart" runat="server" OnClick="vcart_Click" />
    <asp:Button Class="btn btn-primary" ID="vtrans" Text="View Transaction History" runat="server" OnClick="vtrans_Click" />
    <asp:Button Class="btn btn-primary" ID="ibook" Text="Insert Books" runat="server" OnClick="ibook_Click" />
    <asp:Button Class="btn btn-primary" ID="vuser" Text="View User" runat="server" OnClick="vuser_Click" />
    <asp:Button Class="btn btn-primary" ID="vgenre" Text="View Genre" runat="server" OnClick="vgenre_Click" />
    <asp:Button Class="btn btn-primary" ID="igenre" Text="Insert Genre" runat="server" OnClick="igenre_Click" />
    <asp:Button Class="btn btn-primary" ID="vreport" Text="View Transaction Report" runat="server" OnClick="vreport_Click" />
    <br /><br />

   <h3>Random Books</h3>
   <asp:DataList ID="DataList" runat="server" RepeatColumns="5" CellPadding="2" OnItemCommand="DataList_ItemCommand" OnItemDataBound="DataList_ItemDataBound">
        <ItemTemplate>
            <table>
                <tr>
                    <div class="card">
                    <td>
                        <h6><%#"Book Name: "+Eval("Name") %></h6>   
                    </td>
                    </div>
                </tr>
                <tr>
                    <div class="card">
                    <td>
                    <h6><%#"Genre: "+Eval("Genre.GenreName") %></h6>
                    </td>
                    </div>
                </tr>
                <tr>
                    <div class="card">
                     <td>
                    <h6><%#"Description: "+Eval("Description") %></h6>
                    </td>
                    </div>
                </tr>
                 <tr>
                     <div class="card">
                     <td>
                    <h6><%#"Stock: "+Eval("Stock") %></h6>
                    </td>
                    </div>
                </tr>
                <tr>
                    <div class="card">
                    <td>
                    <h6><%#"Price: "+Eval("Price") %></h6>
                    </td>
                    </div>
                </tr>
                <tr>
                    <div class="card">
                    <td>
                    <h6>
                        <asp:LinkButton class="btn btn-primary" ID="add" Text="Add to Cart" runat="server" CommandName="buy" CommandArgument='<%#Eval("BookID") %>'/>
                    </h6>
                    </td>
                    </div>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
