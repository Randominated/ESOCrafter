using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOCrafter
{
    /// <summary>
    /// A Metadata class for persistent storing of data not in the database, ie. pertaining not the data but the application in general.
    /// </summary>
    [Serializable()]
    class Metadata
    {
        public List<String> FilePathList { get; private set; }

        public Metadata()
        {
            FilePathList = new List<string>();
            //TODO might need more code in here. Add as needed.
        }

        public void AddElement(string element)
        {
            FilePathList.Add(element);
        }
        public void ClearList()
        {
            FilePathList = new List<string>();
        }
    }
}
