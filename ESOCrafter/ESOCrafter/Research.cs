using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOCrafter
{
    /// <summary>
    /// Wrapper class for a Research type used to encapsulate variables. Provides separate data values and an array containing all.
    /// </summary>
    class Research
    {
        public int? Res_id { get; set; }
        public string Trait { get; set; }
        public int Bench_type { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }
        public int Init_equip_id { get; set; }
        public int Char_id { get; set; }

        public Object []dataArray = new Object[7];

        public Research(Object []dataArray)
        {
            if (dataArray.Length != this.dataArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Store(dataArray);
            }
        }

        public Research(int Res_id, string Trait, int Bench_type, DateTime Time_start, DateTime Time_end, int Init_equip_id, int Char_id)
        {
            Store(Listify(Res_id, Trait, Bench_type, Time_start, Time_end, Init_equip_id, Char_id));
        }

        public Research(string Trait, int Bench_type, DateTime Time_start, DateTime Time_end, int Init_equip_id, int Char_id)
        {
            Store(Listify(null, Trait, Bench_type, Time_start, Time_end, Init_equip_id, Char_id));
        }

        private void Store(object[] dataArray)
        {
            this.dataArray = dataArray;
            this.Res_id = (int?)dataArray[0];
            this.Trait = (string)dataArray[1];
            this.Bench_type = (int)dataArray[2];
            this.Time_start = (DateTime)dataArray[3];
            this.Time_end = (DateTime)dataArray[4];
            this.Init_equip_id = (int)dataArray[5];
            this.Char_id = (int)dataArray[6];
        }

        private object[] Listify(params object[] objectsToArray)
        {
            return objectsToArray;
        }

        public override string ToString()
        {
            string equipIDCheck = Res_id.ToString();
            if (Res_id == null)
            {
                equipIDCheck = "No Database id, item not stored!";
            }
            return "Researches DB id is: " + equipIDCheck +
                "\nTrait of research is: " + Trait +
                "\nResearch is done at bench type: " + Bench_type +
                "\nResearch start time is: " + Time_start +
                "\nResearch end time is:" + Time_end +
                "\nResearch initiated from item ID: " + Init_equip_id + 
                "\nReseach done for character ID: " + Char_id;
        }
    }
}
