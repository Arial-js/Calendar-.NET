﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Calendar.Utility
{
    public static class GlobalInfo
    {
        public static SQLiteConnection SQLiteConnection { get; set; }
        public static FrmCalendar FrmCalendar { get; set; }
        public static FrmSummary FrmSummary { get; set; }
    }
}
