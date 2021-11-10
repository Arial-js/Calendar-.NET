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
    public partial class UserControlMonth : UserControl
    {
        public UserControlMonth()
        {
            InitializeComponent();
        }
        // this function allow you to set the name of the Label of the month when you displayMonth() on FrmSummary
        public void Month(int numMonth)
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth);
            LblMonth.Text = monthName;
            LblMonthNumber.Text = numMonth.ToString();
        }
        // this funcion on lick will send you on calendar on the month that you clicked
        private void UserControlMonth_Click(object sender, EventArgs e)
        {
            FrmCalendar frmCalendar = new FrmCalendar();
            frmCalendar.DisplayDays(int.Parse(LblMonthNumber.Text), FrmCalendar.static_year);
        }
    }
}
