
namespace AdminAppCourierService
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablesTab = new System.Windows.Forms.TabPage();
            this.tablesDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dropDownList = new System.Windows.Forms.ComboBox();
            this.addTab = new System.Windows.Forms.TabPage();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.groupBoxMover = new System.Windows.Forms.GroupBox();
            this.addMoverButton = new System.Windows.Forms.Button();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.archiveTab = new System.Windows.Forms.TabPage();
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.countOfOrdersLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.driverPhoneTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.moverPhoneTextBox = new System.Windows.Forms.TextBox();
            this.moverNameTextBox = new System.Windows.Forms.TextBox();
            this.carMarkTextBox = new System.Windows.Forms.TextBox();
            this.carRegistryNumberTextBox = new System.Windows.Forms.TextBox();
            this.carIssueYearTextBox = new System.Windows.Forms.TextBox();
            this.carMileageTextBox = new System.Windows.Forms.TextBox();
            this.carLastMaintenanceTextBox = new System.Windows.Forms.TextBox();
            this.accountEmailTextBox = new System.Windows.Forms.TextBox();
            this.accountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).BeginInit();
            this.addTab.SuspendLayout();
            this.groupBoxCar.SuspendLayout();
            this.groupBoxMover.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.archiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablesTab);
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.archiveTab);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1390, 865);
            this.tabControl1.TabIndex = 0;
            // 
            // tablesTab
            // 
            this.tablesTab.Controls.Add(this.tablesDataGridView);
            this.tablesTab.Controls.Add(this.deleteButton);
            this.tablesTab.Controls.Add(this.refreshButton);
            this.tablesTab.Controls.Add(this.dropDownList);
            this.tablesTab.Location = new System.Drawing.Point(4, 25);
            this.tablesTab.Name = "tablesTab";
            this.tablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.tablesTab.Size = new System.Drawing.Size(1382, 836);
            this.tablesTab.TabIndex = 0;
            this.tablesTab.Text = "Tables";
            this.tablesTab.UseVisualStyleBackColor = true;
            // 
            // tablesDataGridView
            // 
            this.tablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGridView.Location = new System.Drawing.Point(12, 78);
            this.tablesDataGridView.Name = "tablesDataGridView";
            this.tablesDataGridView.RowHeadersWidth = 51;
            this.tablesDataGridView.RowTemplate.Height = 24;
            this.tablesDataGridView.Size = new System.Drawing.Size(1358, 735);
            this.tablesDataGridView.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(1250, 25);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 37);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(235, 24);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 37);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dropDownList
            // 
            this.dropDownList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.Items.AddRange(new object[] {
            "Accounts",
            "Adresses",
            "Cars",
            "Details",
            "Drivers",
            "Log",
            "Movers",
            "Nodes",
            "Orders",
            "Taxes"});
            this.dropDownList.Location = new System.Drawing.Point(12, 24);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(200, 37);
            this.dropDownList.TabIndex = 0;
            this.dropDownList.SelectedIndexChanged += new System.EventHandler(this.dropDownList_SelectedIndexChanged);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.groupBoxCar);
            this.addTab.Controls.Add(this.groupBoxMover);
            this.addTab.Controls.Add(this.groupBoxDriver);
            this.addTab.Location = new System.Drawing.Point(4, 25);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1382, 836);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Update";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.carLastMaintenanceTextBox);
            this.groupBoxCar.Controls.Add(this.carMileageTextBox);
            this.groupBoxCar.Controls.Add(this.carIssueYearTextBox);
            this.groupBoxCar.Controls.Add(this.carRegistryNumberTextBox);
            this.groupBoxCar.Controls.Add(this.carMarkTextBox);
            this.groupBoxCar.Controls.Add(this.addCarButton);
            this.groupBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCar.Location = new System.Drawing.Point(920, 100);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(400, 575);
            this.groupBoxCar.TabIndex = 1;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Car";
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(120, 500);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(180, 50);
            this.addCarButton.TabIndex = 5;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // groupBoxMover
            // 
            this.groupBoxMover.Controls.Add(this.moverNameTextBox);
            this.groupBoxMover.Controls.Add(this.moverPhoneTextBox);
            this.groupBoxMover.Controls.Add(this.addMoverButton);
            this.groupBoxMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMover.Location = new System.Drawing.Point(480, 100);
            this.groupBoxMover.Name = "groupBoxMover";
            this.groupBoxMover.Size = new System.Drawing.Size(400, 325);
            this.groupBoxMover.TabIndex = 1;
            this.groupBoxMover.TabStop = false;
            this.groupBoxMover.Text = "Mover";
            // 
            // addMoverButton
            // 
            this.addMoverButton.Location = new System.Drawing.Point(120, 240);
            this.addMoverButton.Name = "addMoverButton";
            this.addMoverButton.Size = new System.Drawing.Size(180, 50);
            this.addMoverButton.TabIndex = 4;
            this.addMoverButton.Text = "Add";
            this.addMoverButton.UseVisualStyleBackColor = true;
            this.addMoverButton.Click += new System.EventHandler(this.addMoverButton_Click);
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.accountPasswordTextBox);
            this.groupBoxDriver.Controls.Add(this.accountEmailTextBox);
            this.groupBoxDriver.Controls.Add(this.driverNameTextBox);
            this.groupBoxDriver.Controls.Add(this.driverPhoneTextBox);
            this.groupBoxDriver.Controls.Add(this.addDriverButton);
            this.groupBoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDriver.Location = new System.Drawing.Point(40, 100);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(400, 475);
            this.groupBoxDriver.TabIndex = 0;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Driver";
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(120, 400);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(180, 50);
            this.addDriverButton.TabIndex = 2;
            this.addDriverButton.Text = "Add";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // archiveTab
            // 
            this.archiveTab.Controls.Add(this.archiveDataGridView);
            this.archiveTab.Controls.Add(this.totalIncomeLabel);
            this.archiveTab.Controls.Add(this.countOfOrdersLabel);
            this.archiveTab.Controls.Add(this.showButton);
            this.archiveTab.Controls.Add(this.dateTimePickerEnd);
            this.archiveTab.Controls.Add(this.dateTimePickerStart);
            this.archiveTab.Location = new System.Drawing.Point(4, 25);
            this.archiveTab.Name = "archiveTab";
            this.archiveTab.Size = new System.Drawing.Size(1382, 836);
            this.archiveTab.TabIndex = 2;
            this.archiveTab.Text = "Archive";
            this.archiveTab.UseVisualStyleBackColor = true;
            // 
            // archiveDataGridView
            // 
            this.archiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGridView.Location = new System.Drawing.Point(12, 74);
            this.archiveDataGridView.Name = "archiveDataGridView";
            this.archiveDataGridView.RowHeadersWidth = 51;
            this.archiveDataGridView.RowTemplate.Height = 24;
            this.archiveDataGridView.Size = new System.Drawing.Size(1358, 685);
            this.archiveDataGridView.TabIndex = 5;
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalIncomeLabel.Location = new System.Drawing.Point(219, 780);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(124, 25);
            this.totalIncomeLabel.TabIndex = 4;
            this.totalIncomeLabel.Text = "Total income";
            // 
            // countOfOrdersLabel
            // 
            this.countOfOrdersLabel.AutoSize = true;
            this.countOfOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfOrdersLabel.Location = new System.Drawing.Point(12, 780);
            this.countOfOrdersLabel.Name = "countOfOrdersLabel";
            this.countOfOrdersLabel.Size = new System.Drawing.Size(146, 25);
            this.countOfOrdersLabel.TabIndex = 3;
            this.countOfOrdersLabel.Text = "Count of orders";
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(1270, 27);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 40);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(358, 30);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(340, 30);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 30);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(340, 30);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // driverPhoneTextBox
            // 
            this.driverPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverPhoneTextBox.Location = new System.Drawing.Point(50, 160);
            this.driverPhoneTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.driverPhoneTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.driverPhoneTextBox.Name = "driverPhoneTextBox";
            this.driverPhoneTextBox.Size = new System.Drawing.Size(300, 50);
            this.driverPhoneTextBox.TabIndex = 2;
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverNameTextBox.Location = new System.Drawing.Point(50, 80);
            this.driverNameTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.driverNameTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(300, 50);
            this.driverNameTextBox.TabIndex = 3;
            // 
            // moverPhoneTextBox
            // 
            this.moverPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moverPhoneTextBox.Location = new System.Drawing.Point(50, 160);
            this.moverPhoneTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.moverPhoneTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.moverPhoneTextBox.Name = "moverPhoneTextBox";
            this.moverPhoneTextBox.Size = new System.Drawing.Size(300, 50);
            this.moverPhoneTextBox.TabIndex = 4;
            // 
            // moverNameTextBox
            // 
            this.moverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moverNameTextBox.Location = new System.Drawing.Point(50, 80);
            this.moverNameTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.moverNameTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.moverNameTextBox.Name = "moverNameTextBox";
            this.moverNameTextBox.Size = new System.Drawing.Size(300, 50);
            this.moverNameTextBox.TabIndex = 5;
            // 
            // carMarkTextBox
            // 
            this.carMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carMarkTextBox.Location = new System.Drawing.Point(50, 80);
            this.carMarkTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.carMarkTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.carMarkTextBox.Name = "carMarkTextBox";
            this.carMarkTextBox.Size = new System.Drawing.Size(300, 50);
            this.carMarkTextBox.TabIndex = 6;
            // 
            // carRegistryNumberTextBox
            // 
            this.carRegistryNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carRegistryNumberTextBox.Location = new System.Drawing.Point(50, 160);
            this.carRegistryNumberTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.carRegistryNumberTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.carRegistryNumberTextBox.Name = "carRegistryNumberTextBox";
            this.carRegistryNumberTextBox.Size = new System.Drawing.Size(300, 50);
            this.carRegistryNumberTextBox.TabIndex = 9;
            // 
            // carIssueYearTextBox
            // 
            this.carIssueYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carIssueYearTextBox.Location = new System.Drawing.Point(50, 240);
            this.carIssueYearTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.carIssueYearTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.carIssueYearTextBox.Name = "carIssueYearTextBox";
            this.carIssueYearTextBox.Size = new System.Drawing.Size(300, 50);
            this.carIssueYearTextBox.TabIndex = 10;
            // 
            // carMileageTextBox
            // 
            this.carMileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carMileageTextBox.Location = new System.Drawing.Point(50, 320);
            this.carMileageTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.carMileageTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.carMileageTextBox.Name = "carMileageTextBox";
            this.carMileageTextBox.Size = new System.Drawing.Size(300, 50);
            this.carMileageTextBox.TabIndex = 11;
            // 
            // carLastMaintenanceTextBox
            // 
            this.carLastMaintenanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carLastMaintenanceTextBox.Location = new System.Drawing.Point(50, 400);
            this.carLastMaintenanceTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.carLastMaintenanceTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.carLastMaintenanceTextBox.Name = "carLastMaintenanceTextBox";
            this.carLastMaintenanceTextBox.Size = new System.Drawing.Size(300, 50);
            this.carLastMaintenanceTextBox.TabIndex = 12;
            // 
            // accountEmailTextBox
            // 
            this.accountEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountEmailTextBox.Location = new System.Drawing.Point(50, 240);
            this.accountEmailTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.accountEmailTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.accountEmailTextBox.Name = "accountEmailTextBox";
            this.accountEmailTextBox.Size = new System.Drawing.Size(300, 50);
            this.accountEmailTextBox.TabIndex = 7;
            // 
            // accountPasswordTextBox
            // 
            this.accountPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountPasswordTextBox.Location = new System.Drawing.Point(50, 320);
            this.accountPasswordTextBox.MaximumSize = new System.Drawing.Size(300, 50);
            this.accountPasswordTextBox.MinimumSize = new System.Drawing.Size(300, 50);
            this.accountPasswordTextBox.Name = "accountPasswordTextBox";
            this.accountPasswordTextBox.Size = new System.Drawing.Size(300, 50);
            this.accountPasswordTextBox.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourierService";
            this.tabControl1.ResumeLayout(false);
            this.tablesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).EndInit();
            this.addTab.ResumeLayout(false);
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            this.groupBoxMover.ResumeLayout(false);
            this.groupBoxMover.PerformLayout();
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            this.archiveTab.ResumeLayout(false);
            this.archiveTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablesTab;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox dropDownList;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage archiveTab;
        private System.Windows.Forms.DataGridView tablesDataGridView;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.GroupBox groupBoxMover;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button addMoverButton;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.DataGridView archiveDataGridView;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label countOfOrdersLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox carLastMaintenanceTextBox;
        private System.Windows.Forms.TextBox carMileageTextBox;
        private System.Windows.Forms.TextBox carIssueYearTextBox;
        private System.Windows.Forms.TextBox carRegistryNumberTextBox;
        private System.Windows.Forms.TextBox carMarkTextBox;
        private System.Windows.Forms.TextBox moverNameTextBox;
        private System.Windows.Forms.TextBox moverPhoneTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.TextBox driverPhoneTextBox;
        private System.Windows.Forms.TextBox accountPasswordTextBox;
        private System.Windows.Forms.TextBox accountEmailTextBox;
    }
}