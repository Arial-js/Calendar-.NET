using System;
using System.Windows.Forms;
using Calendar.Utility;
using Calendar.Classes;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string Static_day { get; set; }
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
            Static_day = LblDays.Text;
            DataManagement dataManagement = new DataManagement();
            dataManagement.OpenConnection();
            LstBox.DataSource = dataManagement.ShowEvent(Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year);
            dataManagement.CloseConnection();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Static_day = LblDays.Text;
                FrmCreateEvent frmCreateEvent = new FrmCreateEvent();
                frmCreateEvent.ShowDialog();
                DataManagement dataManagement = new DataManagement();
                dataManagement.OpenConnection();
                LstBox.DataSource = dataManagement.ShowEvent(Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year);
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
                Static_day = LblDays.Text;
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
