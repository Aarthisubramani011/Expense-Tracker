using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ExpenseTracker
{
    public class Data
    {
        private string filePath = "student.xml";

        public List<Expenses> LoadExpenses()
        {
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                return new List<Expenses>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Expenses>));

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Expenses>)serializer.Deserialize(fs);
            }
        }

        public void SaveExpenses(List<Expenses> expenses)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Expenses>));

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, expenses);
            }
        }
    }
}

