
namespace DriverAppCourierService
{
    partial class OrdersForm
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.currentOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(40, 100);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(1300, 650);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellDoubleClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(40, 25);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(125, 50);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // mapButton
            // 
            this.mapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapButton.Location = new System.Drawing.Point(40, 775);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(125, 50);
            this.mapButton.TabIndex = 2;
            this.mapButton.Text = "Map";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishOrderButton.Location = new System.Drawing.Point(1215, 775);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(125, 50);
            this.finishOrderButton.TabIndex = 3;
            this.finishOrderButton.Text = "Finish\r\nOrder";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfoLabel.Location = new System.Drawing.Point(1250, 38);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(90, 25);
            this.userInfoLabel.TabIndex = 4;
            this.userInfoLabel.Text = "User Info";
            // 
            // currentOrderLabel
            // 
            this.currentOrderLabel.AutoSize = true;
            this.currentOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentOrderLabel.Location = new System.Drawing.Point(590, 755);
            this.currentOrderLabel.Name = "currentOrderLabel";
            this.currentOrderLabel.Size = new System.Drawing.Size(222, 29);
            this.currentOrderLabel.TabIndex = 5;
            this.currentOrderLabel.Text = "Pick up new order!";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.currentOrderLabel);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.ordersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label currentOrderLabel;
    }
}

