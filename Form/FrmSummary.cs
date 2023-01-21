using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FrmSummary : Form
    {
        private int year;
        public FrmSummary()
        {
            InitializeComponent();
        }

        private void FrmSummary_Load(object sender, EventArgs e)
        {
            DisplayMonth();
        }

        // this method display the calendar in month-only mode
        private void DisplayMonth()
        {
            year = FrmCalendar.Static_year;

            LblYear.Text = year.ToString();

            for (int i = 1; i <= 12; ++i)
            {
                UserControlMonth userControlMonth = new UserControlMonth();
                userControlMonth.Month(i);
                userControlMonth.Year(int.Parse(LblYear.Text));
                FlMonthContainer.Controls.Add(userControlMonth);
            }
        }

        // this method allow you to go in previous year's months
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            FlMonthContainer.Controls.Clear();
            year--;

            LblYear.Text = year.ToString();

            for (int i = 1; i <= 12; ++i)
            {
                UserControlMonth userControlMonth = new UserControlMonth();
                userControlMonth.Month(i);
                userControlMonth.Year(int.Parse(LblYear.Text));
                FlMonthContainer.Controls.Add(userControlMonth);
            }
        }

        // this method allow you to go in next year's months
        private void BtnNext_Click(object sender, EventArgs e)
        {
            FlMonthContainer.Controls.Clear();
            year++;

            LblYear.Text = year.ToString();

            for (int i = 1; i <= 12; ++i)
            {
                UserControlMonth userControlMonth = new UserControlMonth();
                userControlMonth.Month(i);
                userControlMonth.Year(int.Parse(LblYear.Text));
                FlMonthContainer.Controls.Add(userControlMonth);
            }
        }
    }
}
