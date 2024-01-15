<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAspProje.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Kategori Id</th>
            <th>Kategori Adı</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <td><%#Eval("KATEGORIID") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriGuncelle.Aspx?KATEGORIID="+Eval("KATEGORIID") %>' ID="HyperLink1" CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                    
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriSil.Aspx?KATEGORIID="+Eval("KATEGORIID") %>' ID="HyperLink2" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
    </table>
    <a href="KategoriEkle.Aspx" class="btn btn-info">Yeni Kategori</a>
</asp:Content>
