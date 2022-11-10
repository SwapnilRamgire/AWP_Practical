using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var num = TextBox1.Text;
            for(int i=1; i<=4; i++)
            {
                for(int j = 0;j<4; j++)
                {
                    if (i % 2 == 0)
                        Response.Write(num);
                    else
                        Response.Write($"{num} ");
                }
                Response.Write("<br/>");
            }
        }
    }
}