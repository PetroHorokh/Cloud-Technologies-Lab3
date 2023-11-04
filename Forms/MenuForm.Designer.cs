namespace Lab2.Forms
{
    partial class MenuForm
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
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.UpdateContactButton = new System.Windows.Forms.Button();
            this.FindContactButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.CreateContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteContactButton.Location = new System.Drawing.Point(0, 208);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(398, 46);
            this.DeleteContactButton.TabIndex = 0;
            this.DeleteContactButton.Text = "Delete Contact";
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // UpdateContactButton
            // 
            this.UpdateContactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateContactButton.Location = new System.Drawing.Point(0, 162);
            this.UpdateContactButton.Name = "UpdateContactButton";
            this.UpdateContactButton.Size = new System.Drawing.Size(398, 46);
            this.UpdateContactButton.TabIndex = 1;
            this.UpdateContactButton.Text = "Update Button";
            this.UpdateContactButton.UseVisualStyleBackColor = true;
            this.UpdateContactButton.Click += new System.EventHandler(this.UpdateContactButton_Click);
            // 
            // FindContactButton
            // 
            this.FindContactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FindContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindContactButton.Location = new System.Drawing.Point(0, 116);
            this.FindContactButton.Name = "FindContactButton";
            this.FindContactButton.Size = new System.Drawing.Size(398, 46);
            this.FindContactButton.TabIndex = 2;
            this.FindContactButton.Text = "Find Contact";
            this.FindContactButton.UseVisualStyleBackColor = true;
            this.FindContactButton.Click += new System.EventHandler(this.FindContactButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.Location = new System.Drawing.Point(0, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(398, 34);
            this.MenuLabel.TabIndex = 3;
            this.MenuLabel.Text = "Menu";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateContactButton
            // 
            this.CreateContactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateContactButton.Location = new System.Drawing.Point(0, 70);
            this.CreateContactButton.Name = "CreateContactButton";
            this.CreateContactButton.Size = new System.Drawing.Size(398, 46);
            this.CreateContactButton.TabIndex = 4;
            this.CreateContactButton.Text = "Create contact";
            this.CreateContactButton.UseVisualStyleBackColor = true;
            this.CreateContactButton.Click += new System.EventHandler(this.CreateContactButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 254);
            this.Controls.Add(this.CreateContactButton);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.FindContactButton);
            this.Controls.Add(this.UpdateContactButton);
            this.Controls.Add(this.DeleteContactButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteContactButton;
        private System.Windows.Forms.Button UpdateContactButton;
        private System.Windows.Forms.Button FindContactButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button CreateContactButton;
    }
}