<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="EntityAspProje.Personeller" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Personel Id</th>
            <th>Personel Ad Soyad</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("PERSONELID") %></td>
                    <td><%# Eval("PERSONELADSOYAD") %></td>
                    <td><asp:HyperLink ID="HyperLink1" CssClass="btn btn-warning" NavigateUrl='<%#"~/PersonelGuncelle.Aspx?PERSONELID="+Eval("PERSONELID")%>' runat="server">Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" CssClass="btn btn-danger" NavigateUrl='<%#"~/PersonelSil.Aspx?PERSONELID="+Eval("PERSONELID")%>' runat="server">Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="PersonelEkle.Aspx" class="btn btn-primary">Yeni Personel Ekle</a>
</asp:Content>
