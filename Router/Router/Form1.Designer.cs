namespace Router
{
    partial class Form1
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
            this.list_box_kid = new System.Windows.Forms.ListBox();
            this.list_box_vehicle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_box_kid
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compute Route";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 147);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 

            this.input_box_kid.AcceptsReturn = true;
            this.input_box_kid.Location = new System.Drawing.Point(12, 65);
            this.input_box_kid.Name = "input_box_kid";
            this.input_box_kid.Size = new System.Drawing.Size(304, 20);
            this.input_box_kid.TabIndex = 0;
            this.input_box_kid.TextChanged += new System.EventHandler(this.input_box_kid_TextChanged);
            // 
            // input_box_vehicle
            // 
            this.input_box_vehicle.Location = new System.Drawing.Point(376, 65);
            this.input_box_vehicle.Name = "input_box_vehicle";
            this.input_box_vehicle.Size = new System.Drawing.Size(354, 20);
            this.input_box_vehicle.TabIndex = 1;
            this.input_box_vehicle.TextChanged += new System.EventHandler(this.input_box_vehicle_TextChanged);
            // 
            // compute_button
            // 
            this.compute_button.Location = new System.Drawing.Point(273, 246);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(202, 39);
            this.compute_button.TabIndex = 2;
            this.compute_button.Text = "Compute Route";
            this.compute_button.UseVisualStyleBackColor = true;
            // 
            // list_box_kid
            // 
            this.list_box_kid.FormattingEnabled = true;
            this.list_box_kid.Location = new System.Drawing.Point(12, 82);
            this.list_box_kid.Name = "list_box_kid";
            this.list_box_kid.Size = new System.Drawing.Size(349, 147);
            this.list_box_kid.TabIndex = 3;
            this.list_box_kid.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // list_box_vehicle
            // 
            this.list_box_vehicle.FormattingEnabled = true;
            this.list_box_vehicle.Location = new System.Drawing.Point(376, 82);
            this.list_box_vehicle.Name = "list_box_vehicle";
            this.list_box_vehicle.Size = new System.Drawing.Size(354, 147);
            this.list_box_vehicle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bus Router";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_box_vehicle);
            this.Controls.Add(this.list_box_kid);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.input_box_vehicle);
            this.Controls.Add(this.input_box_kid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box_kid;
        private System.Windows.Forms.TextBox input_box_vehicle;
        private System.Windows.Forms.Button compute_button;
        private System.Windows.Forms.ListBox list_box_kid;
        private System.Windows.Forms.ListBox list_box_vehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

