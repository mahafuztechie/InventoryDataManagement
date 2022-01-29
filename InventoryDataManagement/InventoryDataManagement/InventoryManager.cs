using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryDataManagement
{
    internal class InventoryManager
    {
        public void InventoryDataReport(string file)
        {
            double totalValue = 0;
            //checking if json file exists
            if(File.Exists(file))
            {
                //Reading all data from json file & storing it in a variable
                var json = File.ReadAllText(file);
                //mapping json objects into list of Inventory objects
                var items = JsonConvert.DeserializeObject<List<InventoryPortfolio>>(json);
                Console.WriteLine("Inventory Management Data Report :");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Name\tWeight\tPrice_Per_KG\tAmount");
                Console.WriteLine("");
                //traversing each item from list of  items & print the data
                foreach (var item in items)
                {
                    totalValue = totalValue + (item.Weight * item.PricePerKg);
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                }
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("the total amount is : \t\t" +totalValue);
            }
            else
            {
                Console.WriteLine("json file does not exist");
            }
           

        }
    }
}
