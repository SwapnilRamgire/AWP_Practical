using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    interface I1
    {
        string show();
    }
    interface I2
    {
        string show();
    }
    class DemoInterface : I1, I2
    {
        string I1.show()
        {
            return ("Show method of interface I1<br />");
        }
        string I2.show()
        {
            return ("Show method of interface I2<br />");
        }
    }
    public partial class InterfaceProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I1 iObj1 = new DemoInterface();
            I2 iObj2 = new DemoInterface();
            Response.Write(iObj1.show());
            Response.Write(iObj2.show());
        }
    }
}