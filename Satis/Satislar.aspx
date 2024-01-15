<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="EntityAspProje.Satis.Satislar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Satış Id</th>
            <th>Ürün</th>
            <th>Personel</th>
            <th>Müşteri</th>
            <th>Fiyat</th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SATISID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("PERSONELADSOYAD") %></td>
                    <td><%#Eval("MUSTERIADSOYAD") %></td>
                    <td><%#Eval("FIYAT") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="Satis/SatisEkle.Aspx" class="btn btn-primary">Yeni Satış Ekle</a>
</asp:Content>
