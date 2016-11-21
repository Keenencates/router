namespace Router.com.gui
{
    partial class editKid
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
            this.save_button = new System.Windows.Forms.Button();
            this.edit_name_box = new System.Windows.Forms.RichTextBox();
            this.edit_address_box = new System.Windows.Forms.RichTextBox();
            this.kid_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(157, 221);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(168, 43);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // edit_name_box
            // 
            this.edit_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name_box.Location = new System.Drawing.Point(67, 51);
            this.edit_name_box.Name = "edit_name_box";
            this.edit_name_box.Size = new System.Drawing.Size(363, 45);
            this.edit_name_box.TabIndex = 1;
            this.edit_name_box.Text = "";
            // 
            // edit_address_box
            // 
            this.edit_address_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_address_box.Location = new System.Drawing.Point(67, 155);
            this.edit_address_box.Name = "edit_address_box";
            this.edit_address_box.Size = new System.Drawing.Size(363, 45);
            this.edit_address_box.TabIndex = 2;
            this.edit_address_box.Text = "";
            // 
            // kid_label
            // 
            this.kid_label.AutoSize = true;
            this.kid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kid_label.Location = new System.Drawing.Point(62, 23);
            this.kid_label.Name = "kid_label";
            this.kid_label.Size = new System.Drawing.Size(72, 25);
            this.kid_label.TabIndex = 3;
            this.kid_label.Text = "Name";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(62, 127);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(98, 25);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // editKid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 276);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.kid_label);
            this.Controls.Add(this.edit_address_box);
            this.Controls.Add(this.edit_name_box);
            this.Controls.Add(this.save_button);
            this.Name = "editKid";
            this.Text = "editKid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.RichTextBox edit_name_box;
        private System.Windows.Forms.RichTextBox edit_address_box;
        private System.Windows.Forms.Label kid_label;
        private System.Windows.Forms.Label address_label;
    }
}