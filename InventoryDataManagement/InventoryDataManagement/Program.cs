// See https://aka.ms/new-console-template for more information
using InventoryDataManagement;

//path to json file
const string INVENTORY_JSON = @"C:\Users\dell\source\repos\InventoryDataManagement\InventoryDataManagement\InventoryDataManagement\InventoryDataManagement\Inventory.json"; 
InventoryManager inventory = new InventoryManager();
inventory.InventoryDataReport(INVENTORY_JSON);
