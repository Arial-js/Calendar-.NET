using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Classes
{
    static class LogFile
    {
        public static bool WriteLog(string strMessage)
        {
            try
            {
                using (FileStream fileStream = new FileStream(string.Format("{0}\\{1}", Environment.CurrentDirectory, "Calendar.log"), FileMode.Append, FileAccess.Write))
                using(StreamWriter streamWriter = new StreamWriter(fileStream))
                {                  
                    streamWriter.WriteLine(strMessage);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
