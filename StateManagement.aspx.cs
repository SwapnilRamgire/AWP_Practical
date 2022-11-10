using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class StateManagement : System.Web.UI.Page
    {
        int x = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Application["temp"] != null)
            {
                x = Convert.ToInt32(Application["temp"]) + 1;
            }
            TextBox1.Text = x.ToString();
            Application["temp"] = x;
        }
    }
}