<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="EntityAspProje.Satis.SatisEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        Ürün Seçin
    <div>
        <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>
    <br />
        Müşeri Seçin
    <div>
        <asp:DropDownList CssClass="form-control" ID="DropDownList2" runat="server"></asp:DropDownList>
    </div>
    <br />
        Personel Seçin
    <div>
        <asp:DropDownList CssClass="form-control" ID="DropDownList3" runat="server"></asp:DropDownList>
    </div>
    <br />
        Fiyat Girin
    <div>
        <asp:TextBox ID="TxtUrunFiyat" CssClass="form-control" runat="server" placeholder="Ürün Fiyatını Girin..."></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Satış Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </div>
</form>
</asp:Content>
