﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAspProje.Urun.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Ürün Id</th>
            <th>Ürün Adı</th>
            <th>Ürün Markası</th>
            <th>Ürün Kategorisi</th>
            <th>Ürün Fiyatı</th>
            <th>Ürün Stoğu</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("URUNMARKA") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><%#Eval("URUNFIYAT") %></td>
                    <td><%#Eval("URUNSTOK") %></td>
                    <td><asp:HyperLink CssClass="btn btn-warning" NavigateUrl='<%#"~/Urun/UrunGuncelle.Aspx?URUNID="+Eval("URUNID")%>' ID="HyperLink1" runat="server">Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink CssClass="btn btn-danger" NavigateUrl='<%#"~/Urun/UrunSil.Aspx?URUNID="+Eval("URUNID")%>' ID="HyperLink2" runat="server">Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="UrunEkle.Aspx" class="btn btn-primary">Yeni Ürün Ekle</a>
</asp:Content>
