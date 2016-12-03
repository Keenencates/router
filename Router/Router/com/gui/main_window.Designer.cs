using Router.com.system;

namespace router.com.gui
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
            this.kid_label = new System.Windows.Forms.Label();
            this.vehicle_label = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.remove_kid_button = new System.Windows.Forms.Button();
            this.remove_vehicle_button = new System.Windows.Forms.Button();
            this.add_prev_kid = new System.Windows.Forms.Button();
            this.add_prev_vehicles = new System.Windows.Forms.Button();
            this.vehicle_list_box = new Router.com.system.vehicleListBox();
            this.kids_list_box = new Router.com.system.kidListBox();
            this.SuspendLayout();
            // 
            // input_box_kid
            // 
            this.input_box_kid.AcceptsReturn = true;
            this.input_box_kid.Location = new System.Drawing.Point(12, 65);
            this.input_box_kid.Name = "input_box_kid";
            this.input_box_kid.Size = new System.Drawing.Size(349, 20);
            this.input_box_kid.TabIndex = 0;
            this.input_box_kid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_kid_KeyDown);
            // 
            // input_box_vehicle
            // 
            this.input_box_vehicle.Location = new System.Drawing.Point(376, 65);
            this.input_box_vehicle.Name = "input_box_vehicle";
            this.input_box_vehicle.Size = new System.Drawing.Size(354, 20);
            this.input_box_vehicle.TabIndex = 1;
            this.input_box_vehicle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_vehicle_KeyDown);
            // 
            // compute_button
            // 
            this.compute_button.Location = new System.Drawing.Point(273, 246);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(202, 39);
            this.compute_button.TabIndex = 2;
            this.compute_button.Text = "Compute Route";
            this.compute_button.UseVisualStyleBackColor = true;
            this.compute_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.compute_button_MouseClick);
            // 
            // kid_label
            // 
            this.kid_label.AutoSize = true;
            this.kid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kid_label.Location = new System.Drawing.Point(160, 34);
            this.kid_label.Name = "kid_label";
            this.kid_label.Size = new System.Drawing.Size(61, 29);
            this.kid_label.TabIndex = 5;
            this.kid_label.Text = "Kids";
            // 
            // vehicle_label
            // 
            this.vehicle_label.AutoSize = true;
            this.vehicle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_label.Location = new System.Drawing.Point(509, 34);
            this.vehicle_label.Name = "vehicle_label";
            this.vehicle_label.Size = new System.Drawing.Size(105, 29);
            this.vehicle_label.TabIndex = 6;
            this.vehicle_label.Text = "Vehicles";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(242, 4);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(265, 55);
            this.main_label.TabIndex = 7;
            this.main_label.Text = "Bus Router";
            // 
            // remove_kid_button
            // 
            this.remove_kid_button.Location = new System.Drawing.Point(252, 204);
            this.remove_kid_button.Name = "remove_kid_button";
            this.remove_kid_button.Size = new System.Drawing.Size(107, 20);
            this.remove_kid_button.TabIndex = 10;
            this.remove_kid_button.Text = "Remove Selected";
            this.remove_kid_button.UseVisualStyleBackColor = true;
            this.remove_kid_button.Click += new System.EventHandler(this.remove_kid_button_Click);
            // 
            // remove_vehicle_button
            // 
            this.remove_vehicle_button.Location = new System.Drawing.Point(626, 204);
            this.remove_vehicle_button.Name = "remove_vehicle_button";
            this.remove_vehicle_button.Size = new System.Drawing.Size(107, 20);
            this.remove_vehicle_button.TabIndex = 11;
            this.remove_vehicle_button.Text = "Remove Selected";
            this.remove_vehicle_button.UseVisualStyleBackColor = true;
            this.remove_vehicle_button.Click += new System.EventHandler(this.remove_vehicle_button_Click);
            // 
            // add_prev_kid
            // 
            this.add_prev_kid.Location = new System.Drawing.Point(254, 65);
            this.add_prev_kid.Name = "add_prev_kid";
            this.add_prev_kid.Size = new System.Drawing.Size(107, 20);
            this.add_prev_kid.TabIndex = 12;
            this.add_prev_kid.Text = "Add Previous";
            this.add_prev_kid.UseVisualStyleBackColor = true;
            this.add_prev_kid.Click += new System.EventHandler(this.add_prev_kid_Click);
            // 
            // add_prev_vehicles
            // 
            this.add_prev_vehicles.Location = new System.Drawing.Point(623, 65);
            this.add_prev_vehicles.Name = "add_prev_vehicles";
            this.add_prev_vehicles.Size = new System.Drawing.Size(107, 20);
            this.add_prev_vehicles.TabIndex = 13;
            this.add_prev_vehicles.Text = "Add Previous";
            this.add_prev_vehicles.UseVisualStyleBackColor = true;
            this.add_prev_vehicles.Click += new System.EventHandler(this.add_prev_vehicles_Click);
            // 
            // vehicle_list_box
            // 
            this.vehicle_list_box.FormattingEnabled = true;
            this.vehicle_list_box.Location = new System.Drawing.Point(376, 85);
            this.vehicle_list_box.Name = "vehicle_list_box";
            this.vehicle_list_box.Size = new System.Drawing.Size(354, 139);
            this.vehicle_list_box.TabIndex = 9;
            this.vehicle_list_box.DoubleClick += new System.EventHandler(this.vehicle_list_box_DoubleClick);
            this.vehicle_list_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_vehicle_KeyDown);
            // 
            // kids_list_box
            // 
            this.kids_list_box.FormattingEnabled = true;
            this.kids_list_box.Location = new System.Drawing.Point(12, 85);
            this.kids_list_box.Name = "kids_list_box";
            this.kids_list_box.Size = new System.Drawing.Size(347, 139);
            this.kids_list_box.TabIndex = 8;
            this.kids_list_box.DoubleClick += new System.EventHandler(this.kids_list_box_DoubleClick);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 314);
            this.Controls.Add(this.add_prev_vehicles);
            this.Controls.Add(this.add_prev_kid);
            this.Controls.Add(this.remove_vehicle_button);
            this.Controls.Add(this.remove_kid_button);
            this.Controls.Add(this.vehicle_list_box);
            this.Controls.Add(this.kids_list_box);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.vehicle_label);
            this.Controls.Add(this.kid_label);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.input_box_vehicle);
            this.Controls.Add(this.input_box_kid);
            this.Name = "main_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box_kid;
        private System.Windows.Forms.TextBox input_box_vehicle;
        private System.Windows.Forms.Button compute_button;

        private System.Windows.Forms.Label kid_label;
        private System.Windows.Forms.Label vehicle_label;
        private System.Windows.Forms.Label main_label;
        public kidListBox kids_list_box;
        public vehicleListBox vehicle_list_box;
        private System.Windows.Forms.Button remove_kid_button;
        private System.Windows.Forms.Button remove_vehicle_button;
        private System.Windows.Forms.Button add_prev_kid;
        private System.Windows.Forms.Button add_prev_vehicles;
    }
}

