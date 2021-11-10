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

namespace Calendar
{
    public partial class FrmCalendar : Form
    {
        private int month, year;
        public static int static_month, static_year; // see DisplayDays() method
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            //TODO sistemare il fatto che quando faccio il load dal Summary si loada sia il displaydays(param param) che questo sotto.
            DisplayDays();
        }
        // this funcion display the calendar.
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            static_month = month; // here you set the static month to the actual month
            static_year = year;   // here you set the static year to the actual year

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            for(int i=1; i< daysOfTheWeek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                FlDayContainer.Controls.Add(userControlBlank);
            }

            for(int i = 1; i<= days; ++i)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                FlDayContainer.Controls.Add(userControlDays);
            }

        }
        // this is the method public that allow to show calendar on current month and year when click Summary -> see FrmSummary.cs
        public void DisplayDays(int monthNameText, int yearName)
        {
            month = monthNameText;
            year = yearName;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthNameText);
            LblMonthYear.Text = monthName + " " + yearName;

            static_month = month;
            static_year = year;

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
            static_month = month;
            static_year = year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            DateTime now = DateTime.Now;
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
            static_month = month;
            static_year = year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            DateTime now = DateTime.Now;
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
            this.Hide();
            frmSummary.ShowDialog();
            this.Close();
        }
    }
}
