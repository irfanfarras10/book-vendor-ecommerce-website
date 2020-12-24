<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewBook.aspx.cs" Inherits="BookVendor.View.ViewBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>View Books</h3><br />
    <asp:TextBox ID="Search" runat="server" placeholder="Search Book" Width="200px" Height="30px"/>
    <asp:Button ID="Searchbtn" Class="btn btn-primary" Text="Search" runat="server" OnClick="Searchbtn_Click" />
    <asp:Button ID="Clearbtn" Class="btn btn-primary" Text="Clear Filter" runat="server" OnClick="Clearbtn_Click"/><br />
    <asp:Label ID="empty" Text="" runat="server" ForeColor="Red"/>
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
