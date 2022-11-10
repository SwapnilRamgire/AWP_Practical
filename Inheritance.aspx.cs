using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    class A
    {
        public int a = 10;
    }
    class B : A
    {
        public int square()
        {
            return (a * a);
        }
    }
    class C : A
    {
        public int cube()
        {
            return (a * a * a);
        }
    }
    public partial class Inheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            B obj1 = new B();
            Response.Write($"Square : {obj1.square()}<br/ >");
            C obj2 = new C();
            Response.Write($"Cube : {obj2.cube()}<br/ >");
        }
    }
}