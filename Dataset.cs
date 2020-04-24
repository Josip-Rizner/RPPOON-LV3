using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Dataset : Prototype
    {
        private List<List<string>> data; 
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public Prototype Clone()
        {
            Dataset newDataSet = new Dataset();
            newDataSet.data = this.data;
            return (Prototype)newDataSet;
        }
    }
}


/* Bilo je potrebno duboko kopiranje, zato što bismo inače imali  
  samo kopiju reference što radi plitko kopiranje. Tako bi oba objekta (original i kopija) 
  imali referencu na istu listu. Promjena na jednom od objekata */
