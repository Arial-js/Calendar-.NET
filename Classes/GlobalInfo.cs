using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Calendar.Utility
{
    public static class GlobalInfo
    {
        public static SQLiteConnection SQLiteConnection;

        public static FrmCalendar FrmCalendar;
        // I save the instance of FrmSummary because i will need it on UserControlMonth
        public static FrmSummary frmSummary;
    }
}
