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
            this.Kids = new Router.com.system.objectListBox();
            this.Vehicles = new Router.com.system.objectListBox();
            this.SuspendLayout();
            // 
            // PrintAll
            // 
            this.PrintAll.Location = new System.Drawing.Point(666, 590);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(193, 116);
            this.PrintAll.TabIndex = 0;
            this.PrintAll.Text = "Print All";
            this.PrintAll.UseVisualStyleBackColor = true;
            // 
            // Kids
            // 
            this.Kids.FormattingEnabled = true;
            this.Kids.Location = new System.Drawing.Point(544, 28);
            this.Kids.Name = "Kids";
            this.Kids.Size = new System.Drawing.Size(1003, 532);
            this.Kids.TabIndex = 2;
            this.Kids.SelectedIndexChanged += new System.EventHandler(this.objectListBox1_SelectedIndexChanged);
            // 
            // Vehicles
            // 
            this.Vehicles.FormattingEnabled = true;
            this.Vehicles.Location = new System.Drawing.Point(46, 28);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(465, 532);
            this.Vehicles.TabIndex = 1;
            // 
            // route_visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 725);
            this.Controls.Add(this.Kids);
            this.Controls.Add(this.Vehicles);
            this.Controls.Add(this.PrintAll);
            this.Name = "route_visualizer";
            this.Text = "route_visualizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintAll;
        private system.objectListBox Vehicles;
        private system.objectListBox Kids;
    }
}