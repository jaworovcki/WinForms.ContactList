using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;

namespace ContactsList
{
    internal class BlobService
    {
        const string CONNECTION_STRING = "DefaultEndpointsProtocol=https;AccountName=contactslistaccount;AccountKey=V561DxN3JVf5wZ33mSZmis+J15HCcZVr2vm2VwhTq4e9A2Q6IyUrQ8ItFgFsp8RbvSjGPXClVOg0+AStpDJReA==;EndpointSuffix=core.windows.net";
        const string CONTAINER_NAME = "images";
        const string IMAGE_PATH = "https://contactslistaccount.blob.core.windows.net";

        public async Task<string> UploadBlobAsync(string imagePath)
        {
            string blobName = Path.GetFileName(imagePath);

            var container = await GetBlobContainerClientAsync();

            try
            {
                using (FileStream fileStream = File.OpenRead(imagePath))
                {
                    BlobClient blobClient = container.GetBlobClient(blobName);
                    await blobClient.UploadAsync(fileStream, true);
                }

                MessageBox.Show("Image uploaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}");
            }

            return string.Format("{0}/{1}/{2}", IMAGE_PATH, CONTAINER_NAME, blobName);
        }

        private async Task<BlobContainerClient> GetBlobContainerClientAsync()
        {
            try
            {
                var container = new BlobContainerClient(CONNECTION_STRING, CONTAINER_NAME);

                await container.CreateIfNotExistsAsync(PublicAccessType.Blob);

                return container;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
