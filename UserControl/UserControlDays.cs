using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.Utility;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent(); 
        }

        public void Days(int numDay)
        {
            LblDays.Text = numDay + "";
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            static_day = LblDays.Text;
            DataManagement dataManagement = new DataManagement();
            dataManagement.OpenConnection();
            LstBox.DataSource = dataManagement.ShowEvent(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
            dataManagement.CloseConnection();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = LblDays.Text;
            DataManagement dataManagement = new DataManagement();
            dataManagement.OpenConnection();
            LstBox.DataSource = dataManagement.ShowEvent(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
            FrmCreateEvent frmCreateEvent = new FrmCreateEvent();
            frmCreateEvent.ShowDialog();
            dataManagement.CloseConnection();
        }
    }
}
