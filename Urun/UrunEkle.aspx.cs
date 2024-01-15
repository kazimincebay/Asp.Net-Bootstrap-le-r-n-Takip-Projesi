using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunEkle : System.Web.UI.Page
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
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLURUNLER t = new TBLURUNLER();
            t.URUNAD = TxtUrunAd.Text;
            t.URUNMARKA = TxtUrunMarka.Text;
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue);
            t.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            t.URUNSTOK = short.Parse(TxtUrunStok.Text);
            db.TBLURUNLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");

        }
    }
}