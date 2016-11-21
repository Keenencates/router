namespace Router.com.gui
{
    partial class edit
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
            this.edit_name_box = new System.Windows.Forms.RichTextBox();
            this.edit_address_box = new System.Windows.Forms.RichTextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.address_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edit_name_box
            // 
            this.edit_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name_box.Location = new System.Drawing.Point(83, 52);
            this.edit_name_box.Name = "edit_name_box";
            this.edit_name_box.Size = new System.Drawing.Size(390, 49);
            this.edit_name_box.TabIndex = 0;
            this.edit_name_box.Text = "";
            // 
            // edit_address_box
            // 
            this.edit_address_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_address_box.Location = new System.Drawing.Point(83, 148);
            this.edit_address_box.Name = "edit_address_box";
            this.edit_address_box.Size = new System.Drawing.Size(390, 49);
            this.edit_address_box.TabIndex = 1;
            this.edit_address_box.Text = "";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(176, 203);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(188, 35);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(84, 120);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(98, 25);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Address";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(84, 24);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(72, 25);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 250);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.edit_address_box);
            this.Controls.Add(this.edit_name_box);
            this.Name = "edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox edit_name_box;
        private System.Windows.Forms.RichTextBox edit_address_box;
        private System.Windows.Forms.Button save_button;
        public System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label name_label;
    }
}