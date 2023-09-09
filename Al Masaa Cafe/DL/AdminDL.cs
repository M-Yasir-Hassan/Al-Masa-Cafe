using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Al_Masaa_Cafe.BL;
using System.IO;

namespace Al_Masaa_Cafe.DL
{
     public class AdminDL
    {
      public static void loadfromfile()
      {
            string line = "NA";
            string path = "adminOrders.txt";
            StreamReader f = new StreamReader(path, true);
            while((line=f.ReadLine())!=null)
            {
                string[] splittedrecords = line.Split(',');
                string name = splittedrecords[0];
                string id = splittedrecords[1];
                string product = splittedrecords[2];
                int price = int.Parse(splittedrecords[3]);
                CustomerBL data= new CustomerBL(name, id, product, price);
                AdminBL.orders.Add(data);
            }
        }
        public static void orderbyid()
        {
            int i = 0;
            int len = AdminBL.orders.Count;
            while(i<len)
            {
                if (CheckOrderByID.Id == AdminBL.orders[i].ID)
                {
                    AdminBL.ordersBYID.Add(AdminBL.orders[i]);
                }
                i++;
            }
            
        }
        public static void orderbyname()
        {
            int i = 0;
            int len = AdminBL.orders.Count;
            while (i < len)
            {
                if(OrderByName.Name1== AdminBL.orders[i].Name)
                {
                    AdminBL.ordersBYName.Add(AdminBL.orders[i]);
                }
                i++;
            }
        }
        public static void delReceptionist()
        {
            MuserDL.deleteReceptionist();


        }
    }
}
