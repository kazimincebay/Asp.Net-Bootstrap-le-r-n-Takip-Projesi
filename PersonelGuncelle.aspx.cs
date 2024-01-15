using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities7 db=new BONUSASPDBEntities7();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var personelId =Convert.ToInt32(Request.QueryString["PERSONELID"]);
                TxtId.Text = personelId.ToString();
                var t= db.TBLPERSONEL.Find(personelId);
                TxtAdSoyad.Text = t.PERSONELADSOYAD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var personelId = Convert.ToInt32(Request.QueryString["PERSONELID"]);
            var t = db.TBLPERSONEL.Find(personelId);
            t.PERSONELADSOYAD = TxtAdSoyad.Text.ToString();
            db.SaveChanges();
            Response.Redirect("Personeller.Aspx");
        }
    }
}