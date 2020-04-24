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
        public string LogFilePath { set; get; }

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



/*Ako je datoteka postavljena na jednom mjestu u tekstu programa, onda ćemo uporabom loggera na drugim mjetima pisati u istu datoteku. (Uz pretpostavku da nije ponovno postavljena)*/
