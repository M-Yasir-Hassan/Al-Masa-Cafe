using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Al_Masaa_Cafe.BL;

namespace Al_Masaa_Cafe.DL
{
    public class CustomerDL
    {
        private static string[] products = new string[20];
        private static int[] prices = new int[20];
        private static List<CustomerBL> orders = new List<CustomerBL>();
        private static List<CustomerBL> specificOrder = new List<CustomerBL>();

        internal static List<CustomerBL> Orders
        {
            get => orders;
            set => orders = value;
        }
        internal static List<CustomerBL> SpecificOrder
        {
            get => specificOrder;
            set => specificOrder = value;
        }

        public static string[] Products
        {
            get => products;
            set => products = value;
        }
        public static int[] Prices
        {
            get => prices;
            set => prices = value;
        }

        public static void loadfromfile()
        {
            int i = 0;
            string line = "NA";
            string path = "prices.txt";
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = f.ReadLine()) != null)
                {
                    string[] splittedrecords = line.Split(',');
                    Products[i] = splittedrecords[0];
                    Prices[i] = int.Parse(splittedrecords[1]);
                    i++;
                }
            }
            f.Close();
        }
        public static void storeintofile()
        {
            string path = "adminOrders.txt";
            StreamWriter f = new StreamWriter(path,true);
            int i=orders.Count;
            for(int z=0 ; z<i ; z++)
            {
                f.WriteLine(Orders[z].Name + ',' + Orders[z].ID + ',' + Orders[z].Product + ',' + Orders[z].Price);
            }
            f.Flush();
            f.Close();
        }
    }
}
