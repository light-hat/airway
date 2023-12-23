namespace Airway
{
    partial class InterfaceChooseForm
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
            this.OpenDumpButton = new System.Windows.Forms.Button();
            this.NetworkInterfaceListView = new System.Windows.Forms.ListView();
            this.DeviceNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterfaceTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MacColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpeedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BytesReceivedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BytesSentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterfaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenDumpButton
            // 
            this.OpenDumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDumpButton.Location = new System.Drawing.Point(724, 12);
            this.OpenDumpButton.Name = "OpenDumpButton";
            this.OpenDumpButton.Size = new System.Drawing.Size(155, 22);
            this.OpenDumpButton.TabIndex = 0;
            this.OpenDumpButton.Text = "Select a dump file";
            this.OpenDumpButton.UseVisualStyleBackColor = true;
            // 
            // NetworkInterfaceListView
            // 
            this.NetworkInterfaceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkInterfaceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceNameColumn,
            this.DescriptionColumn,
            this.InterfaceTypeColumn,
            this.MacColumn,
            this.StatusColumn,
            this.SpeedColumn,
            this.BytesReceivedColumn,
            this.BytesSentColumn});
            this.NetworkInterfaceListView.FullRowSelect = true;
            this.NetworkInterfaceListView.HideSelection = false;
            this.NetworkInterfaceListView.Location = new System.Drawing.Point(12, 40);
            this.NetworkInterfaceListView.MinimumSize = new System.Drawing.Size(867, 358);
            this.NetworkInterfaceListView.MultiSelect = false;
            this.NetworkInterfaceListView.Name = "NetworkInterfaceListView";
            this.NetworkInterfaceListView.Size = new System.Drawing.Size(867, 358);
            this.NetworkInterfaceListView.TabIndex = 1;
            this.NetworkInterfaceListView.UseCompatibleStateImageBehavior = false;
            this.NetworkInterfaceListView.View = System.Windows.Forms.View.Details;
            this.NetworkInterfaceListView.DoubleClick += new System.EventHandler(this.NetworkInterfaceListView_DoubleClick);
            // 
            // DeviceNameColumn
            // 
            this.DeviceNameColumn.Text = "Name";
            this.DeviceNameColumn.Width = 202;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 204;
            // 
            // InterfaceTypeColumn
            // 
            this.InterfaceTypeColumn.Text = "Network interface type";
            this.InterfaceTypeColumn.Width = 198;
            // 
            // MacColumn
            // 
            this.MacColumn.Text = "MAC";
            this.MacColumn.Width = 142;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            // 
            // SpeedColumn
            // 
            this.SpeedColumn.Text = "Speed";
            // 
            // BytesReceivedColumn
            // 
            this.BytesReceivedColumn.Text = "Received (bytes)";
            this.BytesReceivedColumn.Width = 64;
            // 
            // BytesSentColumn
            // 
            this.BytesSentColumn.Text = "Sent (bytes)";
            this.BytesSentColumn.Width = 64;
            // 
            // InterfaceLabel
            // 
            this.InterfaceLabel.AutoSize = true;
            this.InterfaceLabel.Location = new System.Drawing.Point(12, 17);
            this.InterfaceLabel.Name = "InterfaceLabel";
            this.InterfaceLabel.Size = new System.Drawing.Size(172, 13);
            this.InterfaceLabel.TabIndex = 2;
            this.InterfaceLabel.Text = "Select a network interface from list:";
            // 
            // InterfaceChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 410);
            this.Controls.Add(this.InterfaceLabel);
            this.Controls.Add(this.NetworkInterfaceListView);
            this.Controls.Add(this.OpenDumpButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfaceChooseForm";
            this.Text = "Choose network interface or dump";
            this.Load += new System.EventHandler(this.InterfaceChooseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDumpButton;
        private System.Windows.Forms.ListView NetworkInterfaceListView;
        private System.Windows.Forms.Label InterfaceLabel;
        private System.Windows.Forms.ColumnHeader DeviceNameColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader InterfaceTypeColumn;
        private System.Windows.Forms.ColumnHeader MacColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader SpeedColumn;
        private System.Windows.Forms.ColumnHeader BytesReceivedColumn;
        private System.Windows.Forms.ColumnHeader BytesSentColumn;
    }
}

