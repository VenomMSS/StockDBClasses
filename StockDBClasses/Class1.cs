using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDBClasses
{
    public class Item
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Unit { get; set; }
        public String PartNumber { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public String Currency { get; set; }
        public bool Status { get; set; }
        public int typeFK { get; set; }
        public int locFK { get; set; }
        public int supFK { get; set; }
        public override string ToString()
        {
            return Name + "," + Description + "," + Unit + "," + Amount + "," + Price + "," + Currency + "," + Status;
        }
        
    }

    public class Location
    {

        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int groupFK { get; set; }
        public override string ToString()
        {
            return Name + "," + Type ;
        }
    }

    public class ItemType
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int typeGroupFK { get; set; }
        public override string ToString()
        {
            return Name + "," + typeGroupFK;
        }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Website { get; set; }
        public String Email { get; set; }
        public String phone { get; set; }
        public override string ToString()
        {
            return Name + "," + Address + "," + Website + "," + Email + "," + phone;
        }
    }

    public class Order
    { 
        public int ID { get; set; }
        public  DateTime DateOrdered { get; set; }
        public String OrderNumber { get; set; } 
        public int SupplierFK { get; set; }
        public List<Item> Itemsordered { get; set; }
        public DateTime DatedReceived { get; set; }
        public Double TotalPaid { get; set; }
        public override string ToString()
        {
            return OrderNumber + "," + SupplierFK + "," + DateOrdered.ToShortDateString() ;
        }
    }
}
