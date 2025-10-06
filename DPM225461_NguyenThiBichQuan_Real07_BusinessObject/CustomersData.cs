using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real07_BusinessObject
{
    public  class CustomersData: DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int current = 0;
        private string city;
        public CustomersData(string city)
        {
            this.city = city;

            customers.Add("Mavis Hong");
            customers.Add("Twinkle Kan");
            customers.Add("Chris Fon");
            customers.Add("Joey Law");
            customers.Add("Freeda Cheung");
        }
        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }
        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }
        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }
        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }
        public override string GetCurrentRecord()
        {
            return customers[current];
        }
        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + city);
            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}
