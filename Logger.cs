using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Logger
    {
        private static Logger instance;
        private string LogFilePath;

        private Logger()
        {
            this.LogFilePath = "Log.txt";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.LogFilePath, true))
            {
                writer.WriteLine(data);
            }
        }
    }
}
