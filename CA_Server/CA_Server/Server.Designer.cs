namespace CA_Server
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.unLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.hideCheckBox = new System.Windows.Forms.CheckBox();
            this.addBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.unBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.disButton = new System.Windows.Forms.Button();
            this.tcLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Our Chat Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(46, 75);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(331, 59);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(41, 156);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(116, 25);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "IP Address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(41, 244);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(84, 25);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port No";
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(41, 390);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(110, 25);
            this.unLabel.TabIndex = 4;
            this.unLabel.Text = "Username";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(41, 489);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(106, 25);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Password";
            // 
            // hideCheckBox
            // 
            this.hideCheckBox.AutoSize = true;
            this.hideCheckBox.Location = new System.Drawing.Point(46, 580);
            this.hideCheckBox.Name = "hideCheckBox";
            this.hideCheckBox.Size = new System.Drawing.Size(188, 29);
            this.hideCheckBox.TabIndex = 6;
            this.hideCheckBox.Text = "Hide Password";
            this.hideCheckBox.UseVisualStyleBackColor = true;
            this.hideCheckBox.CheckedChanged += new System.EventHandler(this.hideCheckBox_CheckedChanged);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(46, 197);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(331, 31);
            this.addBox.TabIndex = 7;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(46, 272);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(331, 31);
            this.portBox.TabIndex = 8;
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(46, 432);
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(331, 31);
            this.unBox.TabIndex = 9;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(46, 527);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(331, 31);
            this.keyBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Server Login";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(431, 61);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(768, 659);
            this.logBox.TabIndex = 12;
            // 
            // sendBox
            // 
            this.sendBox.Location = new System.Drawing.Point(431, 736);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(768, 31);
            this.sendBox.TabIndex = 13;
            this.sendBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendBox_KeyDown);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MistyRose;
            this.clearButton.Location = new System.Drawing.Point(46, 724);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(322, 40);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear chat";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            this.clientsGrid.AllowUserToResizeColumns = false;
            this.clientsGrid.AllowUserToResizeRows = false;
            this.clientsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clientsGrid.ColumnHeadersHeight = 24;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientID,
            this.clientName,
            this.clientRemove});
            this.clientsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientsGrid.EnableHeadersVisualStyles = false;
            this.clientsGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clientsGrid.Location = new System.Drawing.Point(1236, 61);
            this.clientsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.clientsGrid.MultiSelect = false;
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clientsGrid.RowHeadersWidth = 30;
            this.clientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGrid.RowTemplate.Height = 33;
            this.clientsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGrid.ShowCellErrors = false;
            this.clientsGrid.ShowCellToolTips = false;
            this.clientsGrid.ShowEditingIcon = false;
            this.clientsGrid.ShowRowErrors = false;
            this.clientsGrid.Size = new System.Drawing.Size(675, 650);
            this.clientsGrid.TabIndex = 30;
            this.clientsGrid.TabStop = false;
            this.clientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsGrid_CellContentClick);
            // 
            // disButton
            // 
            this.disButton.BackColor = System.Drawing.Color.Snow;
            this.disButton.Location = new System.Drawing.Point(1687, 731);
            this.disButton.Name = "disButton";
            this.disButton.Size = new System.Drawing.Size(224, 41);
            this.disButton.TabIndex = 16;
            this.disButton.Text = "Disconnect All";
            this.disButton.UseVisualStyleBackColor = false;
            this.disButton.Click += new System.EventHandler(this.disButton_Click);
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(1241, 739);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(132, 25);
            this.tcLabel.TabIndex = 17;
            this.tcLabel.Text = "Total user: 0";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(793, 21);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(48, 25);
            this.logLabel.TabIndex = 18;
            this.logLabel.Text = "Log";
            // 
            // clientID
            // 
            this.clientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clientID.DefaultCellStyle = dataGridViewCellStyle28;
            this.clientID.HeaderText = "ID";
            this.clientID.MaxInputLength = 20;
            this.clientID.MinimumWidth = 20;
            this.clientID.Name = "clientID";
            this.clientID.ReadOnly = true;
            this.clientID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientID.Width = 70;
            // 
            // clientName
            // 
            this.clientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clientName.DefaultCellStyle = dataGridViewCellStyle29;
            this.clientName.HeaderText = "Name";
            this.clientName.MaxInputLength = 20;
            this.clientName.MinimumWidth = 20;
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientName.Width = 136;
            // 
            // clientRemove
            // 
            this.clientRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientRemove.DefaultCellStyle = dataGridViewCellStyle30;
            this.clientRemove.HeaderText = "Remove";
            this.clientRemove.MinimumWidth = 10;
            this.clientRemove.Name = "clientRemove";
            this.clientRemove.ReadOnly = true;
            this.clientRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientRemove.Text = "Kick";
            this.clientRemove.UseColumnTextForButtonValue = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2096, 929);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.disButton);
            this.Controls.Add(this.clientsGrid);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.unBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.hideCheckBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.CheckBox hideCheckBox;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Button disButton;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewButtonColumn clientRemove;
    }
}

