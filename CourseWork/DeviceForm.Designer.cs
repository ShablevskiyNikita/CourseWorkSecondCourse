namespace CourseWork
{
    partial class DeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceForm));
            this.addImage_button = new System.Windows.Forms.Button();
            this.brand_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.communicationType_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signalFrequency_textBox = new System.Windows.Forms.TextBox();
            this.guaranteeMonth_textBox = new System.Windows.Forms.TextBox();
            this.workingHours_textBox = new System.Windows.Forms.TextBox();
            this.dataTranmissionRange_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.communicationTypes_listBox1 = new System.Windows.Forms.ListBox();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addImage_button
            // 
            this.addImage_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addImage_button.BackgroundImage")));
            this.addImage_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addImage_button.FlatAppearance.BorderSize = 0;
            this.addImage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImage_button.Location = new System.Drawing.Point(24, 12);
            this.addImage_button.Name = "addImage_button";
            this.addImage_button.Size = new System.Drawing.Size(201, 200);
            this.addImage_button.TabIndex = 0;
            this.addImage_button.UseVisualStyleBackColor = true;
            this.addImage_button.Click += new System.EventHandler(this.addImage_button_Click);
            // 
            // brand_textBox
            // 
            this.brand_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand_textBox.Location = new System.Drawing.Point(12, 35);
            this.brand_textBox.Name = "brand_textBox";
            this.brand_textBox.Size = new System.Drawing.Size(206, 23);
            this.brand_textBox.TabIndex = 1;
            // 
            // model_textBox
            // 
            this.model_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_textBox.Location = new System.Drawing.Point(280, 35);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(206, 23);
            this.model_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.description_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.model_textBox);
            this.groupBox1.Controls.Add(this.brand_textBox);
            this.groupBox1.Controls.Add(this.price_textBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(276, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Price:";
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_textBox.Location = new System.Drawing.Point(12, 112);
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(206, 23);
            this.description_textBox.TabIndex = 7;
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textBox.Location = new System.Drawing.Point(280, 112);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(206, 23);
            this.price_textBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.communicationTypes_listBox1);
            this.groupBox2.Controls.Add(this.communicationType_label);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.weight_textBox);
            this.groupBox2.Controls.Add(this.signalFrequency_textBox);
            this.groupBox2.Controls.Add(this.guaranteeMonth_textBox);
            this.groupBox2.Controls.Add(this.workingHours_textBox);
            this.groupBox2.Controls.Add(this.dataTranmissionRange_textBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(24, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // communicationType_label
            // 
            this.communicationType_label.AutoSize = true;
            this.communicationType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.communicationType_label.Location = new System.Drawing.Point(539, 82);
            this.communicationType_label.Name = "communicationType_label";
            this.communicationType_label.Size = new System.Drawing.Size(123, 20);
            this.communicationType_label.TabIndex = 16;
            this.communicationType_label.Text = "Тип комунікації:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(270, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Weight:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Signal frequency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(539, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Guarantee month:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(270, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Working hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data transmission range:";
            // 
            // signalFrequency_textBox
            // 
            this.signalFrequency_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signalFrequency_textBox.Location = new System.Drawing.Point(6, 132);
            this.signalFrequency_textBox.Name = "signalFrequency_textBox";
            this.signalFrequency_textBox.Size = new System.Drawing.Size(206, 23);
            this.signalFrequency_textBox.TabIndex = 11;
            // 
            // guaranteeMonth_textBox
            // 
            this.guaranteeMonth_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guaranteeMonth_textBox.Location = new System.Drawing.Point(543, 42);
            this.guaranteeMonth_textBox.Name = "guaranteeMonth_textBox";
            this.guaranteeMonth_textBox.Size = new System.Drawing.Size(206, 23);
            this.guaranteeMonth_textBox.TabIndex = 10;
            // 
            // workingHours_textBox
            // 
            this.workingHours_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingHours_textBox.Location = new System.Drawing.Point(274, 42);
            this.workingHours_textBox.Name = "workingHours_textBox";
            this.workingHours_textBox.Size = new System.Drawing.Size(206, 23);
            this.workingHours_textBox.TabIndex = 9;
            // 
            // dataTranmissionRange_textBox
            // 
            this.dataTranmissionRange_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTranmissionRange_textBox.Location = new System.Drawing.Point(6, 42);
            this.dataTranmissionRange_textBox.Name = "dataTranmissionRange_textBox";
            this.dataTranmissionRange_textBox.Size = new System.Drawing.Size(206, 23);
            this.dataTranmissionRange_textBox.TabIndex = 8;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(542, 477);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(87, 31);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(692, 477);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(87, 31);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // communicationTypes_listBox1
            // 
            this.communicationTypes_listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.communicationTypes_listBox1.FormattingEnabled = true;
            this.communicationTypes_listBox1.ItemHeight = 20;
            this.communicationTypes_listBox1.Items.AddRange(new object[] {
            "Bluetooth",
            "WiFi",
            "Satellite",
            "Mobile",
            "Radio"});
            this.communicationTypes_listBox1.Location = new System.Drawing.Point(543, 131);
            this.communicationTypes_listBox1.Name = "communicationTypes_listBox1";
            this.communicationTypes_listBox1.Size = new System.Drawing.Size(206, 24);
            this.communicationTypes_listBox1.TabIndex = 20;
            // 
            // weight_textBox
            // 
            this.weight_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight_textBox.Location = new System.Drawing.Point(274, 132);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(206, 23);
            this.weight_textBox.TabIndex = 12;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addImage_button);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addImage_button;
        private System.Windows.Forms.TextBox brand_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox signalFrequency_textBox;
        private System.Windows.Forms.TextBox guaranteeMonth_textBox;
        private System.Windows.Forms.TextBox workingHours_textBox;
        private System.Windows.Forms.TextBox dataTranmissionRange_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label communicationType_label;
        private System.Windows.Forms.ListBox communicationTypes_listBox1;
        private System.Windows.Forms.TextBox weight_textBox;
    }
}