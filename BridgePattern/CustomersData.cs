using System;
using System.Collections.Generic;

namespace BridgePattern
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class CustomersData : IDataObject<string>
    {
        /// <summary>
        /// Gets or sets city 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// A collection of customers
        /// </summary>
        private List<string> _customers;

        /// <summary>
        /// the internal record index
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomersData()
        {
            // Simulate loading from database
            _customers = new List<string>
            {
                "Bob Jones",
                "Frank Jackson",
                "Johnny B. Good",
                "Fred Smith"
            };
        }

        /// <summary>
        /// Advance to the next record
        /// </summary>
        public void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        /// <summary>
        /// Go back one record
        /// </summary>
        public void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="customer">customer name</param>
        public void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        /// <summary>
        /// Delete a record
        /// </summary>
        /// <param name="customer">customer name</param>
        public void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        /// <summary>
        /// Get the current record
        /// </summary>
        /// <returns>the current record</returns>
        public string GetCurrentRecord()
        {
            return _customers[_current];
        }

        /// <summary>
        /// Shows the current record
        /// </summary>
        public void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }

        /// <summary>
        /// Show all records
        /// </summary>
        public void ShowAllRecords()
        {
            // write the group city name
            Console.WriteLine("Customer Group: " + City);
            // print out a list of customers
            _customers.ForEach(customer => Console.WriteLine(" " + customer));
        }
    }
}
