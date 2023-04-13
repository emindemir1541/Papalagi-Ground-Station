
namespace Papalagi_Ground_Station
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnDroneCenter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnlFormSpace = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlUp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlUp.Controls.Add(this.lblTitle);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1504, 32);
            this.pnlUp.TabIndex = 0;
            this.pnlUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUp_MouseDown);
            this.pnlUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUp_MouseMove);
            this.pnlUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUp_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.lblTitle.Location = new System.Drawing.Point(688, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Ground Station";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.navPanel);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnTracking);
            this.panel2.Controls.Add(this.btnDroneCenter);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 844);
            this.panel2.TabIndex = 3;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.navPanel.Location = new System.Drawing.Point(0, 230);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(4, 180);
            this.navPanel.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 784);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(282, 60);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Drone Center";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTracking
            // 
            this.btnTracking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTracking.FlatAppearance.BorderSize = 0;
            this.btnTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.btnTracking.Image = ((System.Drawing.Image)(resources.GetObject("btnTracking.Image")));
            this.btnTracking.Location = new System.Drawing.Point(0, 290);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(282, 60);
            this.btnTracking.TabIndex = 3;
            this.btnTracking.Text = "Tracking        ";
            this.btnTracking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTracking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // btnDroneCenter
            // 
            this.btnDroneCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDroneCenter.FlatAppearance.BorderSize = 0;
            this.btnDroneCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDroneCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDroneCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.btnDroneCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnDroneCenter.Image")));
            this.btnDroneCenter.Location = new System.Drawing.Point(0, 230);
            this.btnDroneCenter.Name = "btnDroneCenter";
            this.btnDroneCenter.Size = new System.Drawing.Size(282, 60);
            this.btnDroneCenter.TabIndex = 3;
            this.btnDroneCenter.Text = "Drone Center";
            this.btnDroneCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDroneCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDroneCenter.UseVisualStyleBackColor = true;
            this.btnDroneCenter.Click += new System.EventHandler(this.btnDroneCenter_Click);
            this.btnDroneCenter.Leave += new System.EventHandler(this.btnDroneCenter_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 230);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(78, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drone Ground Station";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(95, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Papalagi";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(40, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(194, 115);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pnlFormSpace
            // 
            this.pnlFormSpace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormSpace.Location = new System.Drawing.Point(282, 32);
            this.pnlFormSpace.Name = "pnlFormSpace";
            this.pnlFormSpace.Size = new System.Drawing.Size(1222, 844);
            this.pnlFormSpace.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1504, 876);
            this.Controls.Add(this.pnlFormSpace);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papalagi Ground Station";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnDroneCenter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel pnlFormSpace;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

