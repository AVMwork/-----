using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsApp1
{
    static class databaseservis
    {
        public static database dbContext;
        
        static databaseservis() { Load(); }
        public static void Save() 
        { 
            File.WriteAllText(@"C:\Temp\spisok.json", System.Text.Json.JsonSerializer.Serialize(dbContext)); 
        }
        public static void Load()
        {
            if (File.Exists(@"C:\Temp\spisok.json") == true)
            {
                string s = File.ReadAllText(@"C:\Temp\spisok.json");
                dbContext = System.Text.Json.JsonSerializer.Deserialize<database>(s);
                
            }
            else
            {
                dbContext = new database();
               
            }
        
        }
        

    }
}
