using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            BONUSASPDBEntities7 db=new BONUSASPDBEntities7();
            var silinecekdeger = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(silinecekdeger);
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}