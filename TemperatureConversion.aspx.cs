using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class TemperatureConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(tempInput.Text);
            OutputLable.Text = Convert.ToString("Celcius : " + (float)(temp - 32) * 0.5556);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            float temp = Convert.ToInt32(tempInput.Text);
            OutputLable.Text = Convert.ToString("Fahrenheit : " + (float) (temp *1.8 + 32));
        }
    }
}