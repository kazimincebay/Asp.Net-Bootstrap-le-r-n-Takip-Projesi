<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelGuncelle.aspx.cs" Inherits="EntityAspProje.PersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
    <div>
        <asp:TextBox ID="TxtId" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:TextBox ID="TxtAdSoyad" CssClass="form-control" runat="server" placeholder="Personel Adını ve Soyadını Girin..."></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Personel Güncelle" CssClass="btn btn-default" OnClick="Button1_Click" />
    </div>
</form>
</asp:Content>
