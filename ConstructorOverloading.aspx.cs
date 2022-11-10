using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class ConstructorOverloading : System.Web.UI.Page
    {
        int x;
        public ConstructorOverloading()
        {
            x = 50;
        }
        public ConstructorOverloading(int y)
        {
            x = y;
        }
        public ConstructorOverloading(ConstructorOverloading obj)
        {
            x = obj.x;
        }
        public int getX()
        {
            return x;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ConstructorOverloading obj1 = new ConstructorOverloading();
            Response.Write(obj1.getX() + "<br />");
            ConstructorOverloading obj2 = new ConstructorOverloading(15);
            Response.Write(obj2.getX() + "<br />");
            ConstructorOverloading obj3 = new ConstructorOverloading(obj2);
            Response.Write(obj2.getX() + "<br />");
        }
    }
}