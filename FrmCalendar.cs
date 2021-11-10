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
        public static int static_month, static_year;
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            // name of the month and year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

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

        // Previous Month
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

        // Next Month
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
    }
}
