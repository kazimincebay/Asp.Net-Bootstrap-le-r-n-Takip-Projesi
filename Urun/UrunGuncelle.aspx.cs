using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities7 db = new BONUSASPDBEntities7();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var kategori = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kategori;
                DropDownList1.DataBind();



                var id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var urun = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = urun.URUNAD;
                TxtUrunMarka.Text = urun.URUNMARKA;
                DropDownList1.SelectedValue = urun.URUNKATEGORI.ToString();
                TxtUrunFiyat.Text = urun.URUNFIYAT.ToString();
                TxtUrunStok.Text = urun.URUNSTOK.ToString();
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BONUSASPDBEntities7 db= new BONUSASPDBEntities7();
            var id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var t = db.TBLURUNLER.Find(id);
            t.URUNAD = TxtUrunAd.Text;
            t.URUNMARKA = TxtUrunMarka.Text;
            t.URUNKATEGORI=byte.Parse(DropDownList1.SelectedValue.ToString());
            t.URUNFIYAT =decimal.Parse(TxtUrunFiyat.Text);
            t.URUNSTOK = short.Parse(TxtUrunStok.Text);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}