namespace BridgePattern
{
    /// <summary>
    /// The 'Implementor' interface
    /// </summary>
    public interface IDataObject<T>
    {
        /// <summary>
        /// Advance one record
        /// </summary>
        void NextRecord();
        /// <summary>
        /// Go back one record
        /// </summary>
        void PriorRecord();
        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="t">Record to add</param>
        void AddRecord(T t);
        /// <summary>
        /// Delete a record
        /// </summary>
        /// <param name="t">record to delete</param>
        void DeleteRecord(T t);
        /// <summary>
        /// Get the current record
        /// </summary>
        /// <returns></returns>
        T GetCurrentRecord();
        /// <summary>
        /// Show the current record
        /// </summary>
        void ShowRecord();
        /// <summary>
        /// Show all records
        /// </summary>
        void ShowAllRecords();
    }
}
