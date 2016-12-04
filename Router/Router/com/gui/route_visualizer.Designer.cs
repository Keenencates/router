namespace Router.com.gui
{
    partial class route_visualizer
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
            this.PrintAll = new System.Windows.Forms.Button();
            this.vehicles = new System.Windows.Forms.ListBox();
            this.kids = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PrintAll
            // 
            this.PrintAll.Location = new System.Drawing.Point(1295, 105);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(193, 116);
            this.PrintAll.TabIndex = 0;
            this.PrintAll.Text = "Print All";
            this.PrintAll.UseVisualStyleBackColor = true;
            this.PrintAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrintAll_MouseClick);
            // 
            // vehicles
            // 
            this.vehicles.FormattingEnabled = true;
            this.vehicles.ItemHeight = 31;
            this.vehicles.Location = new System.Drawing.Point(27, 22);
            this.vehicles.Name = "vehicles";
            this.vehicles.Size = new System.Drawing.Size(442, 655);
            this.vehicles.TabIndex = 1;
            this.vehicles.SelectedIndexChanged += new System.EventHandler(this.vehicles_SelectedIndexChanged);
            // 
            // kids
            // 
            this.kids.FormattingEnabled = true;
            this.kids.ItemHeight = 31;
            this.kids.Location = new System.Drawing.Point(506, 24);
            this.kids.Name = "kids";
            this.kids.Size = new System.Drawing.Size(690, 655);
            // 
            // route_visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 725);
            this.Controls.Add(this.kids);
            this.Controls.Add(this.vehicles);
            this.Controls.Add(this.PrintAll);
            this.Name = "route_visualizer";
            this.Text = "route_visualizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintAll;
        private System.Windows.Forms.ListBox vehicles;
        private System.Windows.Forms.ListBox kids;
    }
}