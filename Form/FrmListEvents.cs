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
    public partial class FrmListEvents : Form
    {
        public FrmListEvents()
        {
            InitializeComponent();
        }

        private void FrmListEvents_Load(object sender, EventArgs e)
        {
            DataManagement dataManagement = new DataManagement();
            dataManagement.OpenConnection();
            DgListEvents.DataSource = dataManagement.ShowListEvents(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
            dataManagement.CloseConnection();
        }
    }
}
