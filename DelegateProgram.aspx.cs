using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public delegate string del1();
    public partial class DelegateProgram : System.Web.UI.Page
    {
        public string show()
        {
            return ("Show method<br />");
        }
        public string disp()
        {
            return ("Disp method<br />");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            del1 d1 = new del1(show);
            del1 d2 = new del1(disp);
            del1 d3 = new del1(show);

            Response.Write(d1());
            Response.Write(d2());
            Response.Write(d3());
        }
    }
}