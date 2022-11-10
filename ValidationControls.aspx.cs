using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class ValidationControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) Label1.Text = "Data submitted.";
            else Label1.Text = "";
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string input = args.Value.ToString();
            int len = input.Length;
            if (len == 10) args.IsValid = true;
            else args.IsValid = false;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Label1.Text = "";
        }
    }
}