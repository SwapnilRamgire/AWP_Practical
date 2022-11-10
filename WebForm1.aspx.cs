using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = "Hola Amigos!";
            Response.Write("Trim Function : " + s.Trim() + "<br/>");
            Response.Write("SubString Function : " + s.Substring(0, 4) + "<br/>");
            Response.Write("UpperCase Function : " + s.ToUpper() + "<br/>");
            Response.Write("LowerCase Function : " + s.ToLower() + "<br/>");
            Response.Write("Replace Function : " + s.Replace("Hola", "Hello") + "<br/>");
            Response.Write("PadLeft Function : " + s.PadLeft(20, 'w') + "<br/>");
            Response.Write("Insert Function : " + s.Insert(3, "11111") + "<br/>");
            Response.Write("EndWith Function : " + s.EndsWith("Amigos!") + "<br/>");
            Response.Write("IndexOf Function : " + s.IndexOf("+") + "<br/>");
            string[] s1 = s.Split(' ');
            foreach (string s2 in s1) 
            { 
                Response.Write("<br/>" + s2);
            }
            string s3 = String.Join("", s1); 
            Response.Write(s3);
        }
    }
}