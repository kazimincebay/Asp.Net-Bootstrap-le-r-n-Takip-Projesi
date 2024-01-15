using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BONUSASPDBEntities7 db=new BONUSASPDBEntities7();
            var personelId = Convert.ToInt32(Request.QueryString["PERSONELID"]);
            var t = db.TBLPERSONEL.Find(personelId);
            db.TBLPERSONEL.Remove(t);
            db.SaveChanges();
            Response.Redirect("Personeller.Aspx");
        }
    }
}