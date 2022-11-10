using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practicals
{
    public partial class CalenderControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // selected day in calender control 
            Label1.Text = Calendar1.SelectedDate.DayOfWeek.ToString();
            // difference between 2 calender dates 
            TimeSpan t = new DateTime(2022, 10, 24) - Calendar1.SelectedDate.Date;
            Label2.Text = "Days remaining till 24th of October : " + t.Days.ToString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            // display message in calender control 
            if (e.Day.Date.Day == 15 && e.Day.Date.Month == 8)
            {
                Label l1 = new Label();
                l1.Text = "Idenpendace Day!";
                e.Cell.Controls.Add(l1);
            }
            // display vacation in calender control 
            DateTime t = new DateTime(2022, 08, 15);
            DateTime t1 = t.AddDays(5);
            Calendar1.SelectedDates.SelectRange(t, t1);
        }
    }
}