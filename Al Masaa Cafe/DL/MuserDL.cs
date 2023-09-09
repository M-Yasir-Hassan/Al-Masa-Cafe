using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Al_Masaa_Cafe.BL;
using System.IO;

namespace Al_Masaa_Cafe.DL
{
    public class MuserDL
    {

        private static List<MuserBL> userList = new List<MuserBL>();
        
        
        //Getter And setters.................
        public static List<MuserBL> UserList
        {
            get => userList;
            set => userList = value;
        }

        public static void addintolist(MuserBL obj)
        {
            userList.Add(obj);
            addintofile();
        }
        public static void addintofile()
        {
            string path = "Users.txt";
            StreamWriter f = new StreamWriter(path);
           
            foreach (MuserBL i in UserList)
            {
                f.WriteLine(i.Username +"," + i.Pwd +"," +i.Role);
            }
            f.Flush();
            f.Close();
        }
        public static void loadFromFile()
        {
            string line="NA";
            string path = "Users.txt";
            StreamReader f = new StreamReader(path,true);
            while((line=f.ReadLine())!= null)
            {
                string[] splittedrecords = line.Split(',');
                string Username = splittedrecords[0];
                string Pwd = splittedrecords[1];
                string Role = splittedrecords[2];
                MuserBL obj = new MuserBL(Username, Pwd, Role);
                userList.Add(obj);
            }
            f.Close();
        }
        public static void deleteReceptionist()
        {
            int i = 0;
            int idx = 0;
            int len = UserList.Count;
            for(int z=0;z<=len;z++)
            {
                if(DelReceptionist.name == UserList[z].Username && DelReceptionist.pwd==UserList[z].Pwd)
                {
                    idx = z;
                    break;
                }
            }
                   UserList.RemoveAt(idx);
            
            addintofile();
        }
        

        public static string CheckRole(MuserBL obj)
        {
            int z = 0;
            foreach(MuserBL i in userList)
            {
                if(obj.Username == i.Username && obj.Pwd == i.Pwd)
                {
                    z = 1;
                    return i.Role;
                }
            }
            if(z==0)
            {
                return "NA";
            }
            return " ";
        }
    }
}
