using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Classes
{
    class LogFile
    {
        public static bool WriteLog(string strMessage)
        {
            try
            {
                FileStream fileStream = new FileStream(string.Format("{0}\\{1}", Environment.CurrentDirectory, "Calendar.log"), FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(strMessage);
                streamWriter.Close();
                fileStream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
