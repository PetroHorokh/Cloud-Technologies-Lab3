namespace Lab2.Forms
{
    partial class FindContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.AutoSize = true;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(12, 67);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(109, 42);
            this.FindButton.TabIndex = 16;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 39);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(255, 22);
            this.PhoneNumberTextBox.TabIndex = 15;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(117, 20);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddressTextBox.Location = new System.Drawing.Point(16, 379);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(255, 22);
            this.AddressTextBox.TabIndex = 24;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(12, 347);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(71, 20);
            this.AddressLabel.TabIndex = 23;
            this.AddressLabel.Text = "Address";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MiddleNameTextBox.Location = new System.Drawing.Point(16, 307);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.ReadOnly = true;
            this.MiddleNameTextBox.Size = new System.Drawing.Size(255, 22);
            this.MiddleNameTextBox.TabIndex = 22;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(12, 275);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(104, 20);
            this.MiddleNameLabel.TabIndex = 21;
            this.MiddleNameLabel.Text = "Middle name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LastNameTextBox.Location = new System.Drawing.Point(16, 238);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(255, 22);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 206);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(88, 20);
            this.LastNameLabel.TabIndex = 19;
            this.LastNameLabel.Text = "Last name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 168);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(255, 22);
            this.NameTextBox.TabIndex = 18;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 136);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // ImageBox
            // 
            this.ImageBox.Image = global::Lab2.Properties.Resources.anonimus;
            this.ImageBox.Location = new System.Drawing.Point(311, 136);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(120, 120);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 25;
            this.ImageBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(348, 424);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 42);
            this.CloseButton.TabIndex = 42;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FindContactForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 478);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Name = "FindContactForm";
            this.Text = "FindContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button CloseButton;
    }
}