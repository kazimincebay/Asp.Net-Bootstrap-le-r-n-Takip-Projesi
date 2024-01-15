<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="EntityAspProje.Urun.UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TxtUrunAd" CssClass="form-control" runat="server" placeholder="Ürün Adını Girin..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TxtUrunMarka" CssClass="form-control" runat="server" placeholder="Ürün Markasını Girin..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TxtUrunFiyat" CssClass="form-control" runat="server" placeholder="Ürün Fiyatını Girin..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TxtUrunStok" CssClass="form-control" runat="server" placeholder="Ürün Stoğu Girin..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
