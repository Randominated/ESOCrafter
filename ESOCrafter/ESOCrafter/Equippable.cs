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

    //TODO: Make a wrapper class to be extended with common methods for all wrapper classes, for cleaner code!

    public class Equippable
    {
        public int? Equip_id { get; set; }
        public string Equip_q { get; set; }
        public string Equip_type { get; set; }
        public int Attribute_val { get; set; }
        public int Item_level { get; set; }
        public int Coin_val { get; set; }
        public string Ench_type { get; set; }
        public int Ench_val { get; set; }
        public string Trait_type { get; set; }
        public int Char_id { get; set; }

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

        public Equippable(int Equip_id, string Equip_q, string Equip_type, int Attribute_val, int Item_level, int Coin_val, string Ench_type, int Ench_val, string Trait_type, int Char_id)
        {
            Store(Listify(Equip_id, Equip_q, Equip_type, Attribute_val, Item_level, Coin_val, Ench_type, Ench_val, Trait_type, Char_id));
        }

        public Equippable(string Equip_q, string Equip_type, int Attribute_val, int Item_level, int Coin_val, string Ench_type, int Ench_val, string Trait_type, int Char_id)
        {
            Store(Listify(null, Equip_q, Equip_type, Attribute_val, Item_level, Coin_val, Ench_type, Ench_val, Trait_type, Char_id));
        }

        private void Store(object[] dataArray)
        {
            this.dataArray = dataArray;
            this.Equip_id = (int?)dataArray[0];
            this.Equip_q = (string)dataArray[1];
            this.Equip_type = (string)dataArray[2];
            this.Attribute_val = (int)dataArray[3];
            this.Item_level = (int)dataArray[4];
            this.Coin_val = (int)dataArray[5];
            this.Ench_type = (string)dataArray[6];
            this.Ench_val = (int)dataArray[7];
            this.Trait_type = (string)dataArray[8];
            this.Char_id = (int)dataArray[9];
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
            return "Equips DB id is: " + equipIDCheck +
                "\nEquip is of " + Equip_q + " quality " +
                "\nEquip type is: " + Equip_type +
                "\nEquip has attribute of: " + Attribute_val + 
                "\nEquip level is: " + Item_level +
                "\nEquip is worth " + Coin_val + " coins" +
                "\nEquip is enchanted with: " + Ench_type +
                "\nEnchantment attribute value is: " + Ench_val +
                "\nTrait of equip is: " + Trait_type +
                "\nEquip is presently in inventory of char_id: " + Char_id;
        }
    }
}
