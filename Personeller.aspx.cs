using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Personeller : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            BONUSASPDBEntities7 db= new BONUSASPDBEntities7();
            Repeater1.DataSource = db.TBLPERSONEL.ToList();
            Repeater1.DataBind();
        }
    }
}