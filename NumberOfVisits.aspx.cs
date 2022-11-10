using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class NumberOfVisits : System.Web.UI.Page
    {
        int visitCount;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                visitCount = Convert.ToInt32(Application["visits"]) + 1;
                Label1.Text = "Total number of visits : " + visitCount.ToString();
                Application["visits"] = visitCount;
            }

        }
    }
}