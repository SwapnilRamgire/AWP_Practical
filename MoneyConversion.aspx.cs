using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class MoneyConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rupee = Convert.ToInt32(rupeeInput.Text);
            OutputLable.Text = Convert.ToString("Dollars : " + (float) rupee / 78);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int rupee = Convert.ToInt32(rupeeInput.Text);
            OutputLable.Text = Convert.ToString("Yen : " + (float)rupee * 1.71);
        }
    }
}