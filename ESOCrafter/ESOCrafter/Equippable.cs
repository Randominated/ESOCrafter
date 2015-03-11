using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOCrafter
{
    /// <summary>
    /// Wrapper class for an Equippable type used to encapsulate variables. Provides separate data values and an array containing all.
    /// </summary>
    public class Equippable
    {
        public int? Equip_id { get; set; }
        public string Type { get; set; }
        public int Attribute_val { get; set; }
        public int Item_level { get; set; }
        public int Coin_val { get; set; }
        public string Ench_type { get; set; }
        public int Ench_val { get; set; }
        public string Trait_type { get; set; }
        public int Trait_val { get; set; }
        public int Char_type { get; set; }

        public Object []dataArray = new Object[10];

        public Equippable(Object []dataArray){
            if (dataArray.Length != this.dataArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Store(dataArray);
            }
        }

        public Equippable(int Equip_id, string Type, int Attribute_val, int Item_level, int Coin_val, string Ench_type, int Ench_val, string Trait_type, int Trait_val, int Char_type)
        {
            Store(Listify(Equip_id, Type, Attribute_val, Item_level, Coin_val, Ench_type, Ench_val, Trait_type, Trait_val, Char_type));
        }

        public Equippable(string Type, int Attribute_val, int Item_level, int Coin_val, string Ench_type, int Ench_val, string Trait_type, int Trait_val, int Char_type)
        {
            Store(Listify(null, Type, Attribute_val, Item_level, Coin_val, Ench_type, Ench_val, Trait_type, Trait_val, Char_type));
        }

        private void Store(object[] dataArray)
        {
            this.dataArray = dataArray;
            this.Equip_id = (int?)dataArray[0];
            this.Type = (string)dataArray[1];
            this.Attribute_val = (int)dataArray[2];
            this.Item_level = (int)dataArray[3];
            this.Coin_val = (int)dataArray[4];
            this.Ench_type = (string)dataArray[5];
            this.Ench_val = (int)dataArray[6];
            this.Trait_type = (string)dataArray[7];
            this.Trait_val = (int)dataArray[8];
            this.Char_type = (int)dataArray[9];
        }

        private object[] Listify(params object[] objectsToArray)
        {
            return objectsToArray;
        }

        public override string ToString()
        {
            string equipIDCheck = Equip_id.ToString();
            if (Equip_id == null)
            {
                equipIDCheck = "No Database id, item not stored!";
            }
            return "Database id is: " + equipIDCheck +
                "\nEquip type is: " + Type +
                "\nEquip has attribute of: " + Attribute_val + 
                "\nEquip level is: " + Item_level +
                "\nEquip is worth " + Coin_val + " coins" +
                "\nEquip is enchanted with: " + Ench_type +
                "\nEnchantment attribute value is: " + Ench_val +
                "\nTrait of equip is: " + Trait_type +
                "\nTrait value of equip is: " + Trait_val + 
                "\nEquip is presently in inventory of char#" + Char_type;
        }
    }
}
