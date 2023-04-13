
namespace Papalagi_Ground_Station.forms
{
    partial class Tracking
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
            this.labelTest = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.panelPersonList = new System.Windows.Forms.Panel();
            this.dataGridViewPersonList = new System.Windows.Forms.DataGridView();
            this.buttonPersonTrack = new System.Windows.Forms.Button();
            this.labelExitPersonList = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelPersonAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLocationTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTracking = new System.Windows.Forms.Button();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.buttonSendMessageToPhone = new System.Windows.Forms.Button();
            this.textBoxMessageToPhone = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelPersonSituation = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPersonPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOpenPersonList = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPhoneLatitude = new System.Windows.Forms.Label();
            this.labelPhoneId = new System.Windows.Forms.Label();
            this.labelPhoneLongitude = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSendLocation = new System.Windows.Forms.Button();
            this.textBoxDroneLatitude = new System.Windows.Forms.TextBox();
            this.textBoxDroneLongitude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxManuelLocation = new System.Windows.Forms.CheckBox();
            this.labelDroneId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelPersonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonList)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTest.ForeColor = System.Drawing.Color.White;
            this.labelTest.Location = new System.Drawing.Point(27, 19);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(116, 29);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "Papalagi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.map);
            this.panel3.Location = new System.Drawing.Point(32, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 745);
            this.panel3.TabIndex = 5;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(840, 745);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // panelPersonList
            // 
            this.panelPersonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panelPersonList.Controls.Add(this.dataGridViewPersonList);
            this.panelPersonList.Controls.Add(this.buttonPersonTrack);
            this.panelPersonList.Controls.Add(this.labelExitPersonList);
            this.panelPersonList.Location = new System.Drawing.Point(3, 3);
            this.panelPersonList.Name = "panelPersonList";
            this.panelPersonList.Size = new System.Drawing.Size(280, 460);
            this.panelPersonList.TabIndex = 14;
            // 
            // dataGridViewPersonList
            // 
            this.dataGridViewPersonList.AllowDrop = true;
            this.dataGridViewPersonList.AllowUserToAddRows = false;
            this.dataGridViewPersonList.AllowUserToDeleteRows = false;
            this.dataGridViewPersonList.AllowUserToResizeColumns = false;
            this.dataGridViewPersonList.AllowUserToResizeRows = false;
            this.dataGridViewPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonList.Location = new System.Drawing.Point(22, 48);
            this.dataGridViewPersonList.MultiSelect = false;
            this.dataGridViewPersonList.Name = "dataGridViewPersonList";
            this.dataGridViewPersonList.ReadOnly = true;
            this.dataGridViewPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonList.Size = new System.Drawing.Size(236, 352);
            this.dataGridViewPersonList.TabIndex = 16;
            this.dataGridViewPersonList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonList_CellClick);
            // 
            // buttonPersonTrack
            // 
            this.buttonPersonTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPersonTrack.Location = new System.Drawing.Point(16, 424);
            this.buttonPersonTrack.Name = "buttonPersonTrack";
            this.buttonPersonTrack.Size = new System.Drawing.Size(243, 23);
            this.buttonPersonTrack.TabIndex = 15;
            this.buttonPersonTrack.Text = "Track";
            this.buttonPersonTrack.UseVisualStyleBackColor = true;
            this.buttonPersonTrack.Click += new System.EventHandler(this.buttonPersonTrack_Click);
            // 
            // labelExitPersonList
            // 
            this.labelExitPersonList.AutoSize = true;
            this.labelExitPersonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExitPersonList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelExitPersonList.Location = new System.Drawing.Point(13, 16);
            this.labelExitPersonList.Name = "labelExitPersonList";
            this.labelExitPersonList.Size = new System.Drawing.Size(26, 16);
            this.labelExitPersonList.TabIndex = 8;
            this.labelExitPersonList.Text = "<--";
            this.labelExitPersonList.Click += new System.EventHandler(this.labelExitPersonList_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel6.Controls.Add(this.panelPersonList);
            this.panel6.Controls.Add(this.labelPersonAge);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.labelLocationTime);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.buttonTracking);
            this.panel6.Controls.Add(this.buttonSafe);
            this.panel6.Controls.Add(this.buttonSendMessageToPhone);
            this.panel6.Controls.Add(this.textBoxMessageToPhone);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.labelDistance);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.labelPersonSituation);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.labelPersonPhone);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.labelPersonName);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.labelOpenPersonList);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.labelPhoneLatitude);
            this.panel6.Controls.Add(this.labelPhoneId);
            this.panel6.Controls.Add(this.labelPhoneLongitude);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(895, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 460);
            this.panel6.TabIndex = 6;
            // 
            // labelPersonAge
            // 
            this.labelPersonAge.AutoSize = true;
            this.labelPersonAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPersonAge.Location = new System.Drawing.Point(155, 51);
            this.labelPersonAge.Name = "labelPersonAge";
            this.labelPersonAge.Size = new System.Drawing.Size(12, 16);
            this.labelPersonAge.TabIndex = 31;
            this.labelPersonAge.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label7.Location = new System.Drawing.Point(21, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Age:";
            // 
            // labelLocationTime
            // 
            this.labelLocationTime.AutoSize = true;
            this.labelLocationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLocationTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelLocationTime.Location = new System.Drawing.Point(155, 178);
            this.labelLocationTime.Name = "labelLocationTime";
            this.labelLocationTime.Size = new System.Drawing.Size(12, 16);
            this.labelLocationTime.TabIndex = 29;
            this.labelLocationTime.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(19, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Time: ";
            // 
            // buttonTracking
            // 
            this.buttonTracking.Location = new System.Drawing.Point(22, 390);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(111, 39);
            this.buttonTracking.TabIndex = 27;
            this.buttonTracking.Text = "Stop Tracking";
            this.buttonTracking.UseVisualStyleBackColor = true;
            this.buttonTracking.Click += new System.EventHandler(this.buttonTracking_Click);
            // 
            // buttonSafe
            // 
            this.buttonSafe.Location = new System.Drawing.Point(156, 390);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(111, 39);
            this.buttonSafe.TabIndex = 26;
            this.buttonSafe.Text = "Stop Starcking And Mark As Safe";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSafe_Click);
            // 
            // buttonSendMessageToPhone
            // 
            this.buttonSendMessageToPhone.Location = new System.Drawing.Point(203, 337);
            this.buttonSendMessageToPhone.Name = "buttonSendMessageToPhone";
            this.buttonSendMessageToPhone.Size = new System.Drawing.Size(65, 23);
            this.buttonSendMessageToPhone.TabIndex = 25;
            this.buttonSendMessageToPhone.Text = "Send";
            this.buttonSendMessageToPhone.UseVisualStyleBackColor = true;
            // 
            // textBoxMessageToPhone
            // 
            this.textBoxMessageToPhone.Location = new System.Drawing.Point(22, 339);
            this.textBoxMessageToPhone.Name = "textBoxMessageToPhone";
            this.textBoxMessageToPhone.Size = new System.Drawing.Size(172, 20);
            this.textBoxMessageToPhone.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label18.Location = new System.Drawing.Point(19, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Send Message To Phone";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelDistance.Location = new System.Drawing.Point(155, 261);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(12, 16);
            this.labelDistance.TabIndex = 22;
            this.labelDistance.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label16.Location = new System.Drawing.Point(21, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Distance:";
            // 
            // labelPersonSituation
            // 
            this.labelPersonSituation.AutoSize = true;
            this.labelPersonSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonSituation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPersonSituation.Location = new System.Drawing.Point(155, 135);
            this.labelPersonSituation.Name = "labelPersonSituation";
            this.labelPersonSituation.Size = new System.Drawing.Size(12, 16);
            this.labelPersonSituation.TabIndex = 20;
            this.labelPersonSituation.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label10.Location = new System.Drawing.Point(19, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Situation:";
            // 
            // labelPersonPhone
            // 
            this.labelPersonPhone.AutoSize = true;
            this.labelPersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPersonPhone.Location = new System.Drawing.Point(155, 79);
            this.labelPersonPhone.Name = "labelPersonPhone";
            this.labelPersonPhone.Size = new System.Drawing.Size(12, 16);
            this.labelPersonPhone.TabIndex = 18;
            this.labelPersonPhone.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone:";
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPersonName.Location = new System.Drawing.Point(155, 23);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(12, 16);
            this.labelPersonName.TabIndex = 16;
            this.labelPersonName.Text = "-";
            this.labelPersonName.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // labelOpenPersonList
            // 
            this.labelOpenPersonList.AutoSize = true;
            this.labelOpenPersonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOpenPersonList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelOpenPersonList.Location = new System.Drawing.Point(244, 13);
            this.labelOpenPersonList.Name = "labelOpenPersonList";
            this.labelOpenPersonList.Size = new System.Drawing.Size(24, 16);
            this.labelOpenPersonList.TabIndex = 14;
            this.labelOpenPersonList.Text = "==";
            this.labelOpenPersonList.Click += new System.EventHandler(this.labelOpenPersonList_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label12.Location = new System.Drawing.Point(21, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Latitude    :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label11.Location = new System.Drawing.Point(21, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Longitude :";
            // 
            // labelPhoneLatitude
            // 
            this.labelPhoneLatitude.AutoSize = true;
            this.labelPhoneLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPhoneLatitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPhoneLatitude.Location = new System.Drawing.Point(155, 234);
            this.labelPhoneLatitude.Name = "labelPhoneLatitude";
            this.labelPhoneLatitude.Size = new System.Drawing.Size(12, 16);
            this.labelPhoneLatitude.TabIndex = 11;
            this.labelPhoneLatitude.Text = "-";
            // 
            // labelPhoneId
            // 
            this.labelPhoneId.AutoSize = true;
            this.labelPhoneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPhoneId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPhoneId.Location = new System.Drawing.Point(155, 107);
            this.labelPhoneId.Name = "labelPhoneId";
            this.labelPhoneId.Size = new System.Drawing.Size(12, 16);
            this.labelPhoneId.TabIndex = 10;
            this.labelPhoneId.Text = "-";
            // 
            // labelPhoneLongitude
            // 
            this.labelPhoneLongitude.AutoSize = true;
            this.labelPhoneLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPhoneLongitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelPhoneLongitude.Location = new System.Drawing.Point(155, 205);
            this.labelPhoneLongitude.Name = "labelPhoneLongitude";
            this.labelPhoneLongitude.Size = new System.Drawing.Size(12, 16);
            this.labelPhoneLongitude.TabIndex = 9;
            this.labelPhoneLongitude.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.buttonSendLocation);
            this.panel1.Controls.Add(this.textBoxDroneLatitude);
            this.panel1.Controls.Add(this.textBoxDroneLongitude);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.checkBoxManuelLocation);
            this.panel1.Controls.Add(this.labelDroneId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(895, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 267);
            this.panel1.TabIndex = 11;
            // 
            // buttonSendLocation
            // 
            this.buttonSendLocation.Location = new System.Drawing.Point(24, 197);
            this.buttonSendLocation.Name = "buttonSendLocation";
            this.buttonSendLocation.Size = new System.Drawing.Size(243, 23);
            this.buttonSendLocation.TabIndex = 14;
            this.buttonSendLocation.Text = "Send";
            this.buttonSendLocation.UseVisualStyleBackColor = true;
            this.buttonSendLocation.Click += new System.EventHandler(this.buttonSendLocation_Click);
            // 
            // textBoxDroneLatitude
            // 
            this.textBoxDroneLatitude.Location = new System.Drawing.Point(167, 119);
            this.textBoxDroneLatitude.Name = "textBoxDroneLatitude";
            this.textBoxDroneLatitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxDroneLatitude.TabIndex = 18;
            // 
            // textBoxDroneLongitude
            // 
            this.textBoxDroneLongitude.Location = new System.Drawing.Point(167, 89);
            this.textBoxDroneLongitude.Name = "textBoxDroneLongitude";
            this.textBoxDroneLongitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxDroneLongitude.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label13.Location = new System.Drawing.Point(40, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Latitude    :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label14.Location = new System.Drawing.Point(40, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Longitude :";
            // 
            // checkBoxManuelLocation
            // 
            this.checkBoxManuelLocation.AutoSize = true;
            this.checkBoxManuelLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxManuelLocation.Location = new System.Drawing.Point(24, 160);
            this.checkBoxManuelLocation.Name = "checkBoxManuelLocation";
            this.checkBoxManuelLocation.Size = new System.Drawing.Size(128, 17);
            this.checkBoxManuelLocation.TabIndex = 11;
            this.checkBoxManuelLocation.Text = "Enter manuel location";
            this.checkBoxManuelLocation.UseVisualStyleBackColor = true;
            this.checkBoxManuelLocation.CheckedChanged += new System.EventHandler(this.checkBoxManuelLocation_CheckedChanged);
            // 
            // labelDroneId
            // 
            this.labelDroneId.AutoSize = true;
            this.labelDroneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDroneId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.labelDroneId.Location = new System.Drawing.Point(164, 20);
            this.labelDroneId.Name = "labelDroneId";
            this.labelDroneId.Size = new System.Drawing.Size(57, 16);
            this.labelDroneId.TabIndex = 9;
            this.labelDroneId.Text = "6843653";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label8.Location = new System.Drawing.Point(21, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Drone ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label9.Location = new System.Drawing.Point(21, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Drone Location";
            // 
            // Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1222, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tracking";
            this.Text = "Tracking";
            this.Load += new System.EventHandler(this.Tracking_Load);
            this.panel3.ResumeLayout(false);
            this.panelPersonList.ResumeLayout(false);
            this.panelPersonList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Panel panel3;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel panelPersonList;
        private System.Windows.Forms.Button buttonPersonTrack;
        private System.Windows.Forms.Label labelExitPersonList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPhoneLatitude;
        private System.Windows.Forms.Label labelPhoneId;
        private System.Windows.Forms.Label labelPhoneLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSendLocation;
        private System.Windows.Forms.TextBox textBoxDroneLatitude;
        private System.Windows.Forms.TextBox textBoxDroneLongitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxManuelLocation;
        private System.Windows.Forms.Label labelDroneId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewPersonList;
        private System.Windows.Forms.Label labelOpenPersonList;
        private System.Windows.Forms.Button buttonSendMessageToPhone;
        private System.Windows.Forms.TextBox textBoxMessageToPhone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelPersonSituation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPersonPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSafe;
        private System.Windows.Forms.Label labelPersonAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLocationTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTracking;
    }
}