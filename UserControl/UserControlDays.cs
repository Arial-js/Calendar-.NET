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
using Calendar.Classes;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day; // this is your get/set for the days remember static_day = LblDays.Text in all method
        public UserControlDays()
        {
            InitializeComponent(); 
        }

        /* This method public allows to set the days in the cells
         * @Param {int numDay)
         * @Return VOID
         */
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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                static_day = LblDays.Text;
                FrmCreateEvent frmCreateEvent = new FrmCreateEvent();
                frmCreateEvent.ShowDialog();
                DataManagement dataManagement = new DataManagement();
                dataManagement.OpenConnection();
                LstBox.DataSource = dataManagement.ShowEvent(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
                dataManagement.CloseConnection();
            } 
            catch(Exception ex)
            {
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }

        private void BtnListEvent_Click(object sender, EventArgs e)
        {
            try
            {
                static_day = LblDays.Text;
                FrmListEvents frmListEvents = new FrmListEvents();
                frmListEvents.ShowDialog();
            } 
            catch (Exception ex)
            {
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }
    }
}
