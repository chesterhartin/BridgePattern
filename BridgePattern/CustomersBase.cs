namespace BridgePattern
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class CustomersBase
    {
        // Gets or sets data object
        public IDataObject<string> DataObject { get; set; }

        /// <summary>
        /// Advance to the the next record
        /// </summary>
        public virtual void Next()
        {
            DataObject.NextRecord();
        }

        /// <summary>
        /// Go back to the previous record
        /// </summary>
        public virtual void Prior()
        {
            DataObject.PriorRecord();
        }

        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="name">name to add</param>
        public virtual void Add(string name)
        {
            DataObject.AddRecord(name);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="name">name to remove</param>
        public virtual void Delete(string name)
        {
            DataObject.DeleteRecord(name);
        }

        /// <summary>
        /// Show the current record
        /// </summary>
        public virtual void Show()
        {
            DataObject.ShowRecord();
        }

        /// <summary>
        /// Show all records
        /// </summary>
        public virtual void ShowAll()
        {

            DataObject.ShowAllRecords();
        }
    }
}
