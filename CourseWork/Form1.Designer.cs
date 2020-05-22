namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.devices_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bluetoothDevice_button = new System.Windows.Forms.Button();
            this.mobileDevices_button = new System.Windows.Forms.Button();
            this.radioDevices_button = new System.Windows.Forms.Button();
            this.satelliteDevices_button = new System.Windows.Forms.Button();
            this.wifiDevices_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFilters_button = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.weightMax_textBox = new System.Windows.Forms.TextBox();
            this.dataTranmissionRangeMax_textBox = new System.Windows.Forms.TextBox();
            this.workingHoursMax_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.communicationTypes_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.workingHoursMin_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataTranmissionRangeMin_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.priceMax_textBox = new System.Windows.Forms.TextBox();
            this.priceMin_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weightMin_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.brand_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.BackColor = System.Drawing.SystemColors.Control;
            this.add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button.BackgroundImage")));
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Location = new System.Drawing.Point(760, 642);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(50, 50);
            this.add_button.TabIndex = 1;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.Control;
            this.edit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_button.BackgroundImage")));
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Location = new System.Drawing.Point(838, 641);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(50, 50);
            this.edit_button.TabIndex = 2;
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.Control;
            this.delete_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button.BackgroundImage")));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(907, 641);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(50, 50);
            this.delete_button.TabIndex = 3;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(347, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список всіх елементів:";
            // 
            // devices_listView
            // 
            this.devices_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.devices_listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devices_listView.FullRowSelect = true;
            this.devices_listView.Location = new System.Drawing.Point(351, 186);
            this.devices_listView.MultiSelect = false;
            this.devices_listView.Name = "devices_listView";
            this.devices_listView.Size = new System.Drawing.Size(606, 437);
            this.devices_listView.TabIndex = 5;
            this.devices_listView.TileSize = new System.Drawing.Size(500, 70);
            this.devices_listView.UseCompatibleStateImageBehavior = false;
            this.devices_listView.View = System.Windows.Forms.View.Tile;
            this.devices_listView.SelectedIndexChanged += new System.EventHandler(this.devices_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Icon";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Device";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 470;
            // 
            // bluetoothDevice_button
            // 
            this.bluetoothDevice_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluetoothDevice_button.BackgroundImage")));
            this.bluetoothDevice_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluetoothDevice_button.Location = new System.Drawing.Point(351, 44);
            this.bluetoothDevice_button.Name = "bluetoothDevice_button";
            this.bluetoothDevice_button.Size = new System.Drawing.Size(70, 54);
            this.bluetoothDevice_button.TabIndex = 6;
            this.bluetoothDevice_button.UseVisualStyleBackColor = true;
            this.bluetoothDevice_button.Click += new System.EventHandler(this.bluetoothDevice_button_Click);
            // 
            // mobileDevices_button
            // 
            this.mobileDevices_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mobileDevices_button.BackgroundImage")));
            this.mobileDevices_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mobileDevices_button.Location = new System.Drawing.Point(448, 44);
            this.mobileDevices_button.Name = "mobileDevices_button";
            this.mobileDevices_button.Size = new System.Drawing.Size(70, 54);
            this.mobileDevices_button.TabIndex = 7;
            this.mobileDevices_button.UseVisualStyleBackColor = true;
            this.mobileDevices_button.Click += new System.EventHandler(this.mobileDevices_button_Click);
            // 
            // radioDevices_button
            // 
            this.radioDevices_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioDevices_button.BackgroundImage")));
            this.radioDevices_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioDevices_button.Location = new System.Drawing.Point(550, 44);
            this.radioDevices_button.Name = "radioDevices_button";
            this.radioDevices_button.Size = new System.Drawing.Size(70, 54);
            this.radioDevices_button.TabIndex = 8;
            this.radioDevices_button.UseVisualStyleBackColor = true;
            this.radioDevices_button.Click += new System.EventHandler(this.radioDevices_button_Click);
            // 
            // satelliteDevices_button
            // 
            this.satelliteDevices_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("satelliteDevices_button.BackgroundImage")));
            this.satelliteDevices_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.satelliteDevices_button.Location = new System.Drawing.Point(654, 44);
            this.satelliteDevices_button.Name = "satelliteDevices_button";
            this.satelliteDevices_button.Size = new System.Drawing.Size(70, 54);
            this.satelliteDevices_button.TabIndex = 9;
            this.satelliteDevices_button.UseVisualStyleBackColor = true;
            this.satelliteDevices_button.Click += new System.EventHandler(this.satelliteDevices_button_Click);
            // 
            // wifiDevices_button
            // 
            this.wifiDevices_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wifiDevices_button.BackgroundImage")));
            this.wifiDevices_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wifiDevices_button.Location = new System.Drawing.Point(760, 44);
            this.wifiDevices_button.Name = "wifiDevices_button";
            this.wifiDevices_button.Size = new System.Drawing.Size(70, 54);
            this.wifiDevices_button.TabIndex = 10;
            this.wifiDevices_button.UseVisualStyleBackColor = true;
            this.wifiDevices_button.Click += new System.EventHandler(this.wifiDevices_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Категорії:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bluetooth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Radio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Satellite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "WiFi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.clearFilters_button);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.weightMax_textBox);
            this.groupBox1.Controls.Add(this.dataTranmissionRangeMax_textBox);
            this.groupBox1.Controls.Add(this.workingHoursMax_textBox);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.communicationTypes_checkedListBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.workingHoursMin_textBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dataTranmissionRangeMin_textBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.priceMax_textBox);
            this.groupBox1.Controls.Add(this.priceMin_textBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.weightMin_textBox);
            this.groupBox1.Controls.Add(this.model_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.brand_textBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 680);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // clearFilters_button
            // 
            this.clearFilters_button.BackColor = System.Drawing.Color.White;
            this.clearFilters_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearFilters_button.BackgroundImage")));
            this.clearFilters_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearFilters_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFilters_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clearFilters_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilters_button.Location = new System.Drawing.Point(36, 641);
            this.clearFilters_button.Name = "clearFilters_button";
            this.clearFilters_button.Size = new System.Drawing.Size(30, 26);
            this.clearFilters_button.TabIndex = 27;
            this.clearFilters_button.UseVisualStyleBackColor = false;
            this.clearFilters_button.Click += new System.EventHandler(this.clearFilters_button_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(159, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "До:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(160, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "До:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(163, 581);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "До:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(36, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Від:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(36, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Від:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(36, 581);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Від:";
            // 
            // weightMax_textBox
            // 
            this.weightMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightMax_textBox.Location = new System.Drawing.Point(163, 601);
            this.weightMax_textBox.Name = "weightMax_textBox";
            this.weightMax_textBox.Size = new System.Drawing.Size(81, 23);
            this.weightMax_textBox.TabIndex = 20;
            // 
            // dataTranmissionRangeMax_textBox
            // 
            this.dataTranmissionRangeMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTranmissionRangeMax_textBox.Location = new System.Drawing.Point(160, 201);
            this.dataTranmissionRangeMax_textBox.Name = "dataTranmissionRangeMax_textBox";
            this.dataTranmissionRangeMax_textBox.Size = new System.Drawing.Size(81, 23);
            this.dataTranmissionRangeMax_textBox.TabIndex = 19;
            // 
            // workingHoursMax_textBox
            // 
            this.workingHoursMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingHoursMax_textBox.Location = new System.Drawing.Point(160, 291);
            this.workingHoursMax_textBox.Name = "workingHoursMax_textBox";
            this.workingHoursMax_textBox.Size = new System.Drawing.Size(81, 23);
            this.workingHoursMax_textBox.TabIndex = 18;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.White;
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(211, 641);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(30, 26);
            this.search_button.TabIndex = 17;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // communicationTypes_checkedListBox
            // 
            this.communicationTypes_checkedListBox.FormattingEnabled = true;
            this.communicationTypes_checkedListBox.Items.AddRange(new object[] {
            "Bluetooth",
            "Mobile",
            "Radio",
            "Satellite",
            "WiFi"});
            this.communicationTypes_checkedListBox.Location = new System.Drawing.Point(36, 361);
            this.communicationTypes_checkedListBox.Name = "communicationTypes_checkedListBox";
            this.communicationTypes_checkedListBox.Size = new System.Drawing.Size(205, 79);
            this.communicationTypes_checkedListBox.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(36, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Тип комунікації:";
            // 
            // workingHoursMin_textBox
            // 
            this.workingHoursMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingHoursMin_textBox.Location = new System.Drawing.Point(36, 291);
            this.workingHoursMin_textBox.Name = "workingHoursMin_textBox";
            this.workingHoursMin_textBox.Size = new System.Drawing.Size(81, 23);
            this.workingHoursMin_textBox.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(37, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Поточний час роботи(місяці):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(36, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Дальність роботи(м):";
            // 
            // dataTranmissionRangeMin_textBox
            // 
            this.dataTranmissionRangeMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTranmissionRangeMin_textBox.Location = new System.Drawing.Point(36, 201);
            this.dataTranmissionRangeMin_textBox.Name = "dataTranmissionRangeMin_textBox";
            this.dataTranmissionRangeMin_textBox.Size = new System.Drawing.Size(81, 23);
            this.dataTranmissionRangeMin_textBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(163, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "До:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(37, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Від:";
            // 
            // priceMax_textBox
            // 
            this.priceMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMax_textBox.Location = new System.Drawing.Point(166, 511);
            this.priceMax_textBox.Name = "priceMax_textBox";
            this.priceMax_textBox.Size = new System.Drawing.Size(78, 23);
            this.priceMax_textBox.TabIndex = 8;
            // 
            // priceMin_textBox
            // 
            this.priceMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMin_textBox.Location = new System.Drawing.Point(39, 511);
            this.priceMin_textBox.Name = "priceMin_textBox";
            this.priceMin_textBox.Size = new System.Drawing.Size(78, 23);
            this.priceMin_textBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(36, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ціна(грн):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(37, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Сортування за вагою(кг):";
            // 
            // weightMin_textBox
            // 
            this.weightMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightMin_textBox.Location = new System.Drawing.Point(36, 601);
            this.weightMin_textBox.Name = "weightMin_textBox";
            this.weightMin_textBox.Size = new System.Drawing.Size(81, 23);
            this.weightMin_textBox.TabIndex = 4;
            // 
            // model_textBox
            // 
            this.model_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_textBox.Location = new System.Drawing.Point(36, 111);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(208, 23);
            this.model_textBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(37, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Модель:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Бренд:";
            // 
            // brand_textBox
            // 
            this.brand_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand_textBox.Location = new System.Drawing.Point(36, 41);
            this.brand_textBox.Name = "brand_textBox";
            this.brand_textBox.Size = new System.Drawing.Size(208, 23);
            this.brand_textBox.TabIndex = 0;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.Control;
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Location = new System.Drawing.Point(898, 135);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(74, 45);
            this.save_button.TabIndex = 18;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.SystemColors.Control;
            this.info_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info_button.BackgroundImage")));
            this.info_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_button.FlatAppearance.BorderSize = 0;
            this.info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_button.Location = new System.Drawing.Point(928, 12);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(37, 31);
            this.info_button.TabIndex = 19;
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 704);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wifiDevices_button);
            this.Controls.Add(this.satelliteDevices_button);
            this.Controls.Add(this.radioDevices_button);
            this.Controls.Add(this.mobileDevices_button);
            this.Controls.Add(this.bluetoothDevice_button);
            this.Controls.Add(this.devices_listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Система обліку";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView devices_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bluetoothDevice_button;
        private System.Windows.Forms.Button mobileDevices_button;
        private System.Windows.Forms.Button radioDevices_button;
        private System.Windows.Forms.Button satelliteDevices_button;
        private System.Windows.Forms.Button wifiDevices_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox brand_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weightMin_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox dataTranmissionRangeMin_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox priceMax_textBox;
        private System.Windows.Forms.TextBox priceMin_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox workingHoursMin_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox communicationTypes_checkedListBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox workingHoursMax_textBox;
        private System.Windows.Forms.TextBox weightMax_textBox;
        private System.Windows.Forms.TextBox dataTranmissionRangeMax_textBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button clearFilters_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button info_button;
    }
}

