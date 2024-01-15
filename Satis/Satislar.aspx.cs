using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje.Satis
{
    public partial class Satislar : System.Web.UI.Page
    {BONUSASPDBEntities7 db=new BONUSASPDBEntities7();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler=(from x in db.TBLSATIS select new
            {
               x.SATISID,x.TBLURUNLER.URUNAD,x.TBLPERSONEL.PERSONELADSOYAD,MUSTERIADSOYAD=x.TBLMUSTERI.MUSTERIAD+" "+x.TBLMUSTERI.MUSTERISOYAD,x.FIYAT
            }).ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}