using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*
            DateTime firstDate = oneCalendar.SelectedDate;
            DateTime secondDate = twoCalendar.SelectedDate;

            TimeSpan myTime = firstDate.Subtract(secondDate).TotalDays;
            resultLabel.Text = myTime.ToString();
            */

            /*
            string result = oneCalendar.SelectedDate.Subtract(twoCalendar.SelectedDate).TotalDays.ToString();

            if (int.Parse(result) > 0)
            {
                resultLabel.Text = result.ToString();
            }
            else
            {
                int negativeResult = int.Parse(result) * -1;
                resultLabel.Text = negativeResult.ToString();
            }
            */

            if (oneCalendar.SelectedDate > twoCalendar.SelectedDate)
            {
                resultLabel.Text = oneCalendar.SelectedDate.Subtract(twoCalendar.SelectedDate).TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = twoCalendar.SelectedDate.Subtract(oneCalendar.SelectedDate).TotalDays.ToString();
            }
        }
    }
}