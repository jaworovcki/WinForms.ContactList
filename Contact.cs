using Azure;
using Azure.Data.Tables;

namespace ContactsList
{
    internal class Contact : ITableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }

        string ITableEntity.PartitionKey { get; set; }
        string ITableEntity.RowKey { get; set; }
        DateTimeOffset? ITableEntity.Timestamp { get; set; }
        ETag ITableEntity.ETag { get; set; }

        public Contact(string phone)
        {
            Phone = phone;
        }

        public Contact()
        {
            FirstName = "Jhon";
            LastName = "Doe";
            Phone = "0990873418";
            ImageUrl = "https://picsum.photos/200/300";
        }

        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += $"{FirstName} {LastName} - ({Phone})";

            return output;
        }
    }
}
