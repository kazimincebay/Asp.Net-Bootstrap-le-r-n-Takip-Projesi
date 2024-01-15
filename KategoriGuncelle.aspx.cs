using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities7 db = new BONUSASPDBEntities7();
        protected void Page_Load(object sender, EventArgs e)
        {   if (!IsPostBack)
            {
                int guncellenecekId = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtId.Text = guncellenecekId.ToString();
                var kategoriAd = db.TBLKATEGORI.Find(guncellenecekId);
                TxtAd.Text = kategoriAd.KATEGORIAD;
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int guncellenecekId = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var kategori = db.TBLKATEGORI.Find(guncellenecekId);
            kategori.KATEGORIAD = TxtAd.Text.ToString();
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}