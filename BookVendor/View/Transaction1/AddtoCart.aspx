<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddtoCart.aspx.cs" Inherits="BookVendor.View.Transaction1.AddtoCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add to Cart</h1>
     <asp:DataList ID="DataList" runat="server" RepeatColumns="5" CellPadding="2" OnItemCommand="DataList_ItemCommand">
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
                    <h6>Stock: <asp:Label runat="server" ID="stock" Text='<%#Eval("Stock")%>'/></h6>
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
                       <asp:TextBox ID="qty" runat="server" Width="100px" Text="" TextMode="Number"></asp:TextBox>
                        <asp:LinkButton class="btn btn-primary" ID="add" Text="Add to Cart" runat="server" CommandName="buy" CommandArgument='<%#Eval("BookID") %>'/>
                        <asp:Label ID="validator" ForeColor="Red" Text="" runat="server" />
                    </h6>
                    </td>
                    </div>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
