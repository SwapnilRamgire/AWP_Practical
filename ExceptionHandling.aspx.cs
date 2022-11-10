using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class ExceptionHandling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            try
            {
                int res =  num1 / num2;
                Response.Write($"Division : {res}<br/>");
            }
            catch (DivideByZeroException)
            {
                Response.Write("Division by 0 exception.<br/>");
            }
            finally
            {
                Response.Write("Finally block always executes");
            }
        }
    }
}