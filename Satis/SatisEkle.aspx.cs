using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        BONUSASPDBEntities7 db = new BONUSASPDBEntities7();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var urunler = (from x in db.TBLURUNLER
                               select new
                               {
                                   x.URUNAD,
                                   x.URUNID
                               }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urunler;
                DropDownList1.DataBind();

                var musteriler = (from x in db.TBLMUSTERI
                                  select new
                                  {
                                      x.MUSTERIID,
                                      MUSTERIADSOYAD = x.MUSTERIAD + " " + x.MUSTERISOYAD
                                  }).ToList();
                DropDownList2.DataTextField = "MUSTERIADSOYAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = musteriler;
                DropDownList2.DataBind();

                var personeller = (from x in db.TBLPERSONEL
                                   select new
                                   {
                                       x.PERSONELID,
                                       x.PERSONELADSOYAD
                                   }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = personeller;
                DropDownList3.DataBind();

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLSATIS t = new TBLSATIS();
            t.URUN = Convert.ToInt32(DropDownList1.SelectedValue);
            t.MUSTERİ = Convert.ToInt32(DropDownList2.SelectedValue);
            t.PERSONEL =  byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT=decimal.Parse(TxtUrunFiyat.Text);
            db.TBLSATIS.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.Aspx");


        }
    }
}