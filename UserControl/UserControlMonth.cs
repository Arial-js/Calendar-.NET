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
    public partial class UserControlMonth : UserControl
    {
        public UserControlMonth()
        {
            InitializeComponent();
        }
        /* This method allow you to set the name of the LblMonth when you displayMonth() on FrmSummary
         * @Param {numMonth)
         * @Return VOID
         */
        public void Month(int numMonth)
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth);
            LblMonth.Text = monthName;
            LblMonthNumber.Text = numMonth.ToString();
        }

        /*This method able to get the year frm the FrmSummary's year 
         * @Param {yearName}
         * @Return VOID
         */
        public void Year(int yearName)
        {
            LblYear.Text = yearName.ToString(); 
        }

        // this method -click will send you on calendar on the window-month that you clicked
        private void UserControlMonth_Click(object sender, EventArgs e)
        {
            FrmCalendar frmCalendar = new FrmCalendar
            {
                FirstTimeLoad = false // so the load will be once
            };
            frmCalendar.DisplayDays(int.Parse(LblMonthNumber.Text), int.Parse(LblYear.Text));
            GlobalInfo.FrmSummary.Close();
        }
        // this method -click will send you on calendar on the month that you clicked
        private void LblMonth_Click(object sender, EventArgs e)
        {
            FrmCalendar frmCalendar = new FrmCalendar
            {
                FirstTimeLoad = false
            };
            frmCalendar.DisplayDays(int.Parse(LblMonthNumber.Text), int.Parse(LblYear.Text));
            GlobalInfo.FrmSummary.Close();
        }
    }
}
