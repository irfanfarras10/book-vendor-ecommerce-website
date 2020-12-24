<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="BookVendor.View.Transaction1.ViewTransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction</h1><br />
    <%
        foreach (var header in trans)
        {
    %>
    <h4 style="color:blue">Date: <%= header.Date %></h4>
     <table>
          <tr>
              <th style="width:200px;">Book Name</th>
              <th style="width:200px;">Quantity</th>
              <th style="width:300px;">Price</th>
               <th style="width:200px;">Sub Total</th>
          </tr>
         <% foreach (var item in header.DetailTransactions){  %>
         <tr>
            <td><h5><%= item.Book.Name %></h5></td>
            <td><h5><%= item.Quantity%></h5></td>
            <td><h5><%= item.Book.Price%></h5></td>
            <td><h5><%= item.Book.Price*item.Quantity %></h5></td>
        </tr>
         <% } %>
    </table>
    <h4>Total Harga: <%= header.DetailTransactions.Sum(item => item.Book.Price*item.Quantity) %></h4>
    <hr style="height:3px;background-color:deepskyblue;"/>
    <%
        }
    %>
     
</asp:Content>
