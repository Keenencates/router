namespace Router.com.gui
{
    partial class previous_items
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
            this.add_button = new System.Windows.Forms.Button();
            this.previous_items_box = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(169, 271);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(152, 48);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add Items";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // previous_items_box
            // 
            this.previous_items_box.FormattingEnabled = true;
            this.previous_items_box.Location = new System.Drawing.Point(41, 22);
            this.previous_items_box.Name = "previous_items_box";
            this.previous_items_box.Size = new System.Drawing.Size(449, 229);
            this.previous_items_box.TabIndex = 1;
            // 
            // previous_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.previous_items_box);
            this.Controls.Add(this.add_button);
            this.Name = "previous_item";
            this.Text = "previous_item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckedListBox previous_items_box;
    }
}