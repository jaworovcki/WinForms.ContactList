namespace ContactsList
{
    public partial class Form1 : Form
    {
        BlobService blobService;
        string imagePath;
        public Form1()
        {
            InitializeComponent();
            lstContacts.SelectedIndexChanged += lstContacts_SelectedIndexChanged;
            blobService = new BlobService();
            imagePath = string.Empty;

            LoadContacts();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            contact.FirstName = txtFistName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;

            if (!string.IsNullOrEmpty(imagePath))
            {
                contact.ImageUrl = imagePath;
                lstContacts.Items.Add(contact);

                TableService tableService = new TableService();
                await tableService.AddContactAsync(contact);

                MessageBox.Show("Contact added successfully!");
            }
            else
            {
                MessageBox.Show("Please choose the image");
            }

        }

        private void txtFistName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    imagePath = await blobService.UploadBlobAsync(selectedFilePath);
                }
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem != null)
            {
                Contact selectedContact = (Contact)lstContacts.SelectedItem;

                if (!string.IsNullOrEmpty(selectedContact.ImageUrl))
                {
                    try
                    {
                        pictureBox2.Load(selectedContact.ImageUrl); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                        pictureBox2.Image = null;
                    }
                }
                else
                {
                    pictureBox2.Image = null;
                }
            }
        }

        private async void LoadContacts()
        {
            TableService tableService = new TableService();
            var contacts = await tableService.GetAllContactsAsync();

            lstContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                lstContacts.Items.Add(contact);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
