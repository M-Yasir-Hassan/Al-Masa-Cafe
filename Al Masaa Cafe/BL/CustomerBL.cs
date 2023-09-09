using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Al_Masaa_Cafe.BL;

namespace Al_Masaa_Cafe.BL
{
    class CustomerBL
    {
        private string name;
        private string id;
        private string product;
        private int price;

        public CustomerBL(string name,string id,string product,int price)
        {
            this.name = name;
            this.id = id;
            this.product = product;
            this.price = price;
        }

        public string ID
        {
            set => id = value;
            get => id;
        }
        public string Product
        {
            set => product = value;
            get => product;
        }
        public int Price
        {
            set => price = value;
            get => price;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
