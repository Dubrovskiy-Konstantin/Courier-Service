
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dropDownList = new System.Windows.Forms.ComboBox();
            this.addTab = new System.Windows.Forms.TabPage();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.textBoxCarLastMaintenance = new System.Windows.Forms.TextBox();
            this.textBoxCarYear = new System.Windows.Forms.TextBox();
            this.textBoxCarMileage = new System.Windows.Forms.TextBox();
            this.textBoxCarNumber = new System.Windows.Forms.TextBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.groupBoxMover = new System.Windows.Forms.GroupBox();
            this.addMoverButton = new System.Windows.Forms.Button();
            this.textBoxMoverPhone = new System.Windows.Forms.TextBox();
            this.textBoxMoverName = new System.Windows.Forms.TextBox();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.textBoxDriverPhone = new System.Windows.Forms.TextBox();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.archiveTab = new System.Windows.Forms.TabPage();
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.countOfOrdersLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
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
            this.tablesTab.Controls.Add(this.ordersDataGridView);
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
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 78);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(1358, 735);
            this.ordersDataGridView.TabIndex = 3;
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
            // 
            // dropDownList
            // 
            this.dropDownList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.Location = new System.Drawing.Point(12, 24);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(200, 37);
            this.dropDownList.TabIndex = 0;
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
            this.groupBoxCar.Controls.Add(this.addCarButton);
            this.groupBoxCar.Controls.Add(this.textBoxCarLastMaintenance);
            this.groupBoxCar.Controls.Add(this.textBoxCarYear);
            this.groupBoxCar.Controls.Add(this.textBoxCarMileage);
            this.groupBoxCar.Controls.Add(this.textBoxCarNumber);
            this.groupBoxCar.Controls.Add(this.textBoxCarName);
            this.groupBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCar.Location = new System.Drawing.Point(920, 100);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(400, 600);
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
            // 
            // textBoxCarLastMaintenance
            // 
            this.textBoxCarLastMaintenance.Location = new System.Drawing.Point(50, 420);
            this.textBoxCarLastMaintenance.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarLastMaintenance.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarLastMaintenance.Name = "textBoxCarLastMaintenance";
            this.textBoxCarLastMaintenance.Size = new System.Drawing.Size(300, 30);
            this.textBoxCarLastMaintenance.TabIndex = 8;
            // 
            // textBoxCarYear
            // 
            this.textBoxCarYear.Location = new System.Drawing.Point(50, 340);
            this.textBoxCarYear.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarYear.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarYear.Name = "textBoxCarYear";
            this.textBoxCarYear.Size = new System.Drawing.Size(300, 30);
            this.textBoxCarYear.TabIndex = 7;
            // 
            // textBoxCarMileage
            // 
            this.textBoxCarMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarMileage.Location = new System.Drawing.Point(50, 260);
            this.textBoxCarMileage.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarMileage.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarMileage.Name = "textBoxCarMileage";
            this.textBoxCarMileage.Size = new System.Drawing.Size(300, 36);
            this.textBoxCarMileage.TabIndex = 6;
            // 
            // textBoxCarNumber
            // 
            this.textBoxCarNumber.Location = new System.Drawing.Point(50, 180);
            this.textBoxCarNumber.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarNumber.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarNumber.Name = "textBoxCarNumber";
            this.textBoxCarNumber.Size = new System.Drawing.Size(300, 30);
            this.textBoxCarNumber.TabIndex = 5;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarName.Location = new System.Drawing.Point(50, 100);
            this.textBoxCarName.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarName.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(300, 36);
            this.textBoxCarName.TabIndex = 4;
            // 
            // groupBoxMover
            // 
            this.groupBoxMover.Controls.Add(this.addMoverButton);
            this.groupBoxMover.Controls.Add(this.textBoxMoverPhone);
            this.groupBoxMover.Controls.Add(this.textBoxMoverName);
            this.groupBoxMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMover.Location = new System.Drawing.Point(480, 100);
            this.groupBoxMover.Name = "groupBoxMover";
            this.groupBoxMover.Size = new System.Drawing.Size(400, 375);
            this.groupBoxMover.TabIndex = 1;
            this.groupBoxMover.TabStop = false;
            this.groupBoxMover.Text = "Mover";
            // 
            // addMoverButton
            // 
            this.addMoverButton.Location = new System.Drawing.Point(120, 260);
            this.addMoverButton.Name = "addMoverButton";
            this.addMoverButton.Size = new System.Drawing.Size(180, 50);
            this.addMoverButton.TabIndex = 4;
            this.addMoverButton.Text = "Add";
            this.addMoverButton.UseVisualStyleBackColor = true;
            // 
            // textBoxMoverPhone
            // 
            this.textBoxMoverPhone.Location = new System.Drawing.Point(50, 180);
            this.textBoxMoverPhone.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxMoverPhone.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxMoverPhone.Name = "textBoxMoverPhone";
            this.textBoxMoverPhone.Size = new System.Drawing.Size(300, 30);
            this.textBoxMoverPhone.TabIndex = 3;
            // 
            // textBoxMoverName
            // 
            this.textBoxMoverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMoverName.Location = new System.Drawing.Point(50, 100);
            this.textBoxMoverName.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxMoverName.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxMoverName.Name = "textBoxMoverName";
            this.textBoxMoverName.Size = new System.Drawing.Size(300, 36);
            this.textBoxMoverName.TabIndex = 2;
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.addDriverButton);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverPhone);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverName);
            this.groupBoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDriver.Location = new System.Drawing.Point(40, 100);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(400, 375);
            this.groupBoxDriver.TabIndex = 0;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Driver";
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(120, 260);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(180, 50);
            this.addDriverButton.TabIndex = 2;
            this.addDriverButton.Text = "Add";
            this.addDriverButton.UseVisualStyleBackColor = true;
            // 
            // textBoxDriverPhone
            // 
            this.textBoxDriverPhone.Location = new System.Drawing.Point(50, 180);
            this.textBoxDriverPhone.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxDriverPhone.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxDriverPhone.Name = "textBoxDriverPhone";
            this.textBoxDriverPhone.Size = new System.Drawing.Size(300, 30);
            this.textBoxDriverPhone.TabIndex = 1;
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDriverName.Location = new System.Drawing.Point(50, 100);
            this.textBoxDriverName.MaximumSize = new System.Drawing.Size(300, 50);
            this.textBoxDriverName.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(300, 36);
            this.textBoxDriverName.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.GroupBox groupBoxMover;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.TextBox textBoxCarLastMaintenance;
        private System.Windows.Forms.TextBox textBoxCarYear;
        private System.Windows.Forms.TextBox textBoxCarMileage;
        private System.Windows.Forms.TextBox textBoxCarNumber;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.Button addMoverButton;
        private System.Windows.Forms.TextBox textBoxMoverPhone;
        private System.Windows.Forms.TextBox textBoxMoverName;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.TextBox textBoxDriverPhone;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.DataGridView archiveDataGridView;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label countOfOrdersLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
    }
}