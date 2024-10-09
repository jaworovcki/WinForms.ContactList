namespace ContactsList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFistName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            btnAddButton = new Button();
            lstContacts = new ListBox();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 87);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "FirstName:";
            label1.Click += label1_Click;
            // 
            // txtFistName
            // 
            txtFistName.Location = new Point(182, 90);
            txtFistName.Name = "txtFistName";
            txtFistName.Size = new Size(150, 31);
            txtFistName.TabIndex = 3;
            txtFistName.TextChanged += txtFistName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(182, 160);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(182, 226);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 5;
            // 
            // btnAddButton
            // 
            btnAddButton.Location = new Point(20, 369);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(166, 54);
            btnAddButton.TabIndex = 6;
            btnAddButton.Text = "Add Contact";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += button1_Click;
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 25;
            lstContacts.Location = new Point(547, 90);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(345, 254);
            lstContacts.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(20, 160);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 8;
            label4.Text = "LastName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 225);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 9;
            label2.Text = "Phone:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(20, 290);
            button1.Name = "button1";
            button1.Size = new Size(122, 36);
            button1.TabIndex = 10;
            button1.Text = "Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1232, 485);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 205);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(623, 428);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1004, 724);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lstContacts);
            Controls.Add(btnAddButton);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFistName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFistName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Button btnAddButton;
        private ListBox lstContacts;
        private Label label4;
        private Label label2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
