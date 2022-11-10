using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Practicals
{
    public partial class XMLtoDropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("XMLFile2.xml"));
                DropDownList1.DataSource = ds;
                DropDownList1.DataValueField = "empId";
                DropDownList1.DataTextField = "empName";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}