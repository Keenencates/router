namespace Router.com.gui
{
    partial class editPopup
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
            this.kid_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.kid_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kid_textbox
            // 
            this.kid_textbox.Location = new System.Drawing.Point(50, 6);
            this.kid_textbox.Name = "kid_textbox";
            this.kid_textbox.Size = new System.Drawing.Size(176, 20);
            this.kid_textbox.TabIndex = 0;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(50, 35);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(176, 20);
            this.address_textbox.TabIndex = 1;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(90, 78);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_clicked);
            // 
            // kid_label
            // 
            this.kid_label.AutoSize = true;
            this.kid_label.Location = new System.Drawing.Point(9, 9);
            this.kid_label.Name = "kid_label";
            this.kid_label.Size = new System.Drawing.Size(21, 13);
            this.kid_label.TabIndex = 3;
            this.kid_label.Text = "kid";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(0, 38);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(44, 13);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "address";
            // 
            // editPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 113);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.kid_label);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.kid_textbox);
            this.Name = "editPopup";
            this.Text = "editPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kid_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label kid_label;
        private System.Windows.Forms.Label address_label;
    }
}