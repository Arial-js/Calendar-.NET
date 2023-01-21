using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.Utility;

namespace Calendar
{
    public partial class FrmCalendar : Form
    {
        private int month, year;
        public bool FirstTimeLoad { get; set; } = true;
        public static int Static_month { get; set; }
        public static int Static_year { get; set; }
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            if (FirstTimeLoad)
            {
                DisplayDays(month, year);
                FirstTimeLoad = false;
            }
        }

        /* This is the method public that allows to show calendar on current month and year
         * @param {monthNameText} set to 0 by default
         * @Param {yearName} set to 0 by default
         * @Return VOID
         * See more for Optional Param here https://www.c-sharpcorner.com/article/make-parameter-optional-in-c-sharp/
         */
        public void DisplayDays(int monthNameText = 0, int yearName = 0)
        {
            if(monthNameText == 0 || yearName == 0)
            {
                DateTime now = DateTime.Now;
                month = now.Month;
                year = now.Year;

                // name of the month and year
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                LblMonthYear.Text = monthName + " " + year;
            }
            else
            {
                month = monthNameText;
                year = yearName;

                // name of the month and year
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthNameText);
                LblMonthYear.Text = monthName + " " + yearName;
            }

            Static_month = month;
            Static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                FlDayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; ++i)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                FlDayContainer.Controls.Add(userControlDays);
            }
            this.Show();
        }

        // Previous Month decrease the month number and show the new month
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            FlDayContainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            Static_month = month;
            Static_year = year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                FlDayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; ++i)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                FlDayContainer.Controls.Add(userControlDays);
            }
        }

        // Next Month increase the month number and show the new month
        private void BtnNext_Click(object sender, EventArgs e)
        {
            FlDayContainer.Controls.Clear();
            month++;
            if(month > 12)
            {
                month = 1;
                year++;
            }
            Static_month = month;
            Static_year = year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < daysOfTheWeek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                FlDayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; ++i)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                FlDayContainer.Controls.Add(userControlDays);
            }
        }

        // this method will send you to the FrmSummary that shows you calendar only with month
        private void LblMonthYear_Click(object sender, EventArgs e)
        {
            FrmSummary frmSummary = new FrmSummary();
            GlobalInfo.FrmSummary = frmSummary; // i save the instance of frmSummary in Globalinfo
            GlobalInfo.FrmCalendar = this;
            Hide(); //only hide because otherwise the app will close later
            frmSummary.ShowDialog();
        }
    }
}
