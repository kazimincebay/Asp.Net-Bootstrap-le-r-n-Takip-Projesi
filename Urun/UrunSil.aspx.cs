using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BONUSASPDBEntities7 db = new BONUSASPDBEntities7();
            var id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun=db.TBLURUNLER.Find(id);
            urun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}