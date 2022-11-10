using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class FunctionOverloading : System.Web.UI.Page
    {
        void area(double r)
        {
            OutputLabel.Text = "Area of circle : " + Convert.ToString(3.14 * r * r);
        }
        void area(int l, int b)
        {
            OutputLabel.Text = "Area of rectangle : " + Convert.ToString(l * b);
        }
        void area(int s)
        {
            OutputLabel.Text = "Area of square : " + Convert.ToString(s*s);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Circle_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(TextBox1.Text);
            area(radius);
        }

        protected void Rectangle_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(TextBox1.Text);
            int breadth = Convert.ToInt32(TextBox2.Text);
            area(len, breadth);
        }

        protected void Square_Click(object sender, EventArgs e)
        {
            int side = Convert.ToInt32(TextBox1.Text);
            area(side);
        }
    }
}