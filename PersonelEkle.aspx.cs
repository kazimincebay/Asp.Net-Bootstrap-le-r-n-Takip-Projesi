using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BONUSASPDBEntities7 db=new BONUSASPDBEntities7();
            TBLPERSONEL t = new TBLPERSONEL();
            t.PERSONELADSOYAD = TextBox1.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            Response.Redirect("Personeller.Aspx");

        }
    }
}