using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class AutoPostBackProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0) Label2.Font.Size = FontUnit.Small;
            else if (RadioButtonList1.SelectedIndex == 1) Label2.Font.Size = FontUnit.Medium;
            else if (RadioButtonList1.SelectedIndex == 2) Label2.Font.Size = FontUnit.Large;
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Font.Name = RadioButtonList2.SelectedValue;
        }

        protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList3.SelectedIndex == 0) Label2.ForeColor = System.Drawing.Color.Red;
            else if (RadioButtonList3.SelectedIndex == 1) Label2.ForeColor = System.Drawing.Color.Green;
            else if (RadioButtonList3.SelectedIndex == 2) Label2.ForeColor = System.Drawing.Color.Blue;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked) Label2.Font.Bold = true;
            else Label2.Font.Bold = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked) Label2.Font.Italic = true;
            else Label2.Font.Italic = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked) Label2.Font.Underline = true;
            else Label2.Font.Underline = false;
        }
    }
}