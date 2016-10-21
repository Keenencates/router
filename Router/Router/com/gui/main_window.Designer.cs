﻿namespace router.com.gui
{
    partial class main_window
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
            this.input_box_kid = new System.Windows.Forms.TextBox();
            this.input_box_vehicle = new System.Windows.Forms.TextBox();
            this.compute_button = new System.Windows.Forms.Button();
            this.list_box_vehicle = new observable_list_box();
            this.kid_label = new System.Windows.Forms.Label();
            this.vehicle_label = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.list_box_kid = new router.com.gui.observable_list_box();
            this.SuspendLayout();
            // 
            // input_box_kid
            // 
            this.input_box_kid.AcceptsReturn = true;
            this.input_box_kid.Location = new System.Drawing.Point(28, 145);
            this.input_box_kid.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.input_box_kid.Name = "input_box_kid";
            this.input_box_kid.Size = new System.Drawing.Size(809, 35);
            this.input_box_kid.TabIndex = 0;
            this.input_box_kid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_kid_KeyDown);
            // 
            // input_box_vehicle
            // 
            this.input_box_vehicle.Location = new System.Drawing.Point(878, 145);
            this.input_box_vehicle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.input_box_vehicle.Name = "input_box_vehicle";
            this.input_box_vehicle.Size = new System.Drawing.Size(820, 35);
            this.input_box_vehicle.TabIndex = 1;
            this.input_box_vehicle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_vehicle_KeyDown);
            // 
            // compute_button
            // 
            this.compute_button.Location = new System.Drawing.Point(637, 549);
            this.compute_button.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(472, 87);
            this.compute_button.TabIndex = 2;
            this.compute_button.Text = "Compute Route";
            this.compute_button.UseVisualStyleBackColor = true;
            // 
            // list_box_vehicle
            // 
            this.list_box_vehicle.FormattingEnabled = true;
            this.list_box_vehicle.ItemHeight = 29;
            this.list_box_vehicle.Location = new System.Drawing.Point(878, 183);
            this.list_box_vehicle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.list_box_vehicle.Name = "list_box_vehicle";
            this.list_box_vehicle.Size = new System.Drawing.Size(820, 323);
            this.list_box_vehicle.TabIndex = 4;
            // 
            // kid_label
            // 
            this.kid_label.AutoSize = true;
            this.kid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kid_label.Location = new System.Drawing.Point(374, 76);
            this.kid_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.kid_label.Name = "kid_label";
            this.kid_label.Size = new System.Drawing.Size(133, 63);
            this.kid_label.TabIndex = 5;
            this.kid_label.Text = "Kids";
            // 
            // vehicle_label
            // 
            this.vehicle_label.AutoSize = true;
            this.vehicle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_label.Location = new System.Drawing.Point(1187, 76);
            this.vehicle_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.vehicle_label.Name = "vehicle_label";
            this.vehicle_label.Size = new System.Drawing.Size(233, 63);
            this.vehicle_label.TabIndex = 6;
            this.vehicle_label.Text = "Vehicles";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(564, 9);
            this.main_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(591, 122);
            this.main_label.TabIndex = 7;
            this.main_label.Text = "Bus Router";
            // 
            // list_box_kid
            // 
            this.list_box_kid.FormattingEnabled = true;
            this.list_box_kid.ItemHeight = 29;
            this.list_box_kid.Location = new System.Drawing.Point(28, 183);
            this.list_box_kid.Margin = new System.Windows.Forms.Padding(7);
            this.list_box_kid.Name = "list_box_kid";
            this.list_box_kid.Size = new System.Drawing.Size(809, 323);
            this.list_box_kid.TabIndex = 3;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 701);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.vehicle_label);
            this.Controls.Add(this.kid_label);
            this.Controls.Add(this.list_box_vehicle);
            this.Controls.Add(this.list_box_kid);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.input_box_vehicle);
            this.Controls.Add(this.input_box_kid);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "main_window";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box_kid;
        private System.Windows.Forms.TextBox input_box_vehicle;
        private System.Windows.Forms.Button compute_button;
        private observable_list_box list_box_kid;
        private observable_list_box list_box_vehicle;
        private System.Windows.Forms.Label kid_label;
        private System.Windows.Forms.Label vehicle_label;
        private System.Windows.Forms.Label main_label;
    }
}

