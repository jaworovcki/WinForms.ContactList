using Azure;
using Azure.Data.Tables;

namespace ContactsList
{
    class TableService
    {
        private const string tableName = "Contacts";
        const string CONNECTION_STRING = "DefaultEndpointsProtocol=https;AccountName=contactslistaccount;AccountKey=V561DxN3JVf5wZ33mSZmis+J15HCcZVr2vm2VwhTq4e9A2Q6IyUrQ8ItFgFsp8RbvSjGPXClVOg0+AStpDJReA==;EndpointSuffix=core.windows.net";
        public TableService()
        {
           
        }

        private async Task<TableClient> GetTableClient()
        {
            var serviceClient = new TableServiceClient(CONNECTION_STRING);

            var tableClient = serviceClient.GetTableClient(tableName);
            await tableClient.CreateIfNotExistsAsync();

            return tableClient;
        }

        public async Task AddContactAsync(Contact contact)
        {
            var tableClient = await GetTableClient();

            var tableEntity = (ITableEntity)contact;
            tableEntity.PartitionKey = "ContactPartition";  
            tableEntity.RowKey = contact.Phone; 

            await tableClient.AddEntityAsync(contact);
        }

        public async Task<Contact> GetContactByPhoneAsync(string phone)
        {
            var tableClient = await GetTableClient();

            try
            {
                var response = await tableClient.GetEntityAsync<Contact>("ContactPartition", phone);
                return response.Value;
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Error retrieving contact: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            var tableClient = await GetTableClient();
            List<Contact> contacts = new List<Contact>();

            await foreach (var contact in tableClient.QueryAsync<Contact>(filter: $"PartitionKey eq 'ContactPartition'"))
            {
                contacts.Add(contact);
            }

            return contacts;
        }

    }
}

