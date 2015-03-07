using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOCrafter
{
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

        public Object []v = new Object[10];

        public Equippable(Object []v){
            if (v.Length != this.v.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Store(v);
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

        private void Store(object[] v)
        {
            this.v = v;
            this.Equip_id = (int?)v[0];
            this.Type = (string)v[1];
            this.Attribute_val = (int)v[2];
            this.Item_level = (int)v[3];
            this.Coin_val = (int)v[4];
            this.Ench_type = (string)v[5];
            this.Ench_val = (int)v[6];
            this.Trait_type = (string)v[7];
            this.Trait_val = (int)v[8];
            this.Char_type = (int)v[9];
        }

        private object[] Listify(params object[] v)
        {
            return v;
        }

        public override string ToString()
        {
            return "Database id is: " + Equip_id +
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
