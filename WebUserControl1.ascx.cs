using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan t1 = new DateTime(2022, 10, 24) - Calendar1.SelectedDate.Date;
            Label1.Text = "Days remaining till 24th of October : " + t1.Days.ToString();
        }
    }
}