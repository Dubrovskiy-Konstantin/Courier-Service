
namespace DriverAppCourierService
{
    partial class ChooseMoverForm
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
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.moversDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsDescriptionLabel = new System.Windows.Forms.Label();
            this.unitsAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moversDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(25, 25);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.Size = new System.Drawing.Size(750, 425);
            this.carsDataGridView.TabIndex = 0;
            // 
            // moversDataGridView
            // 
            this.moversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moversDataGridView.Location = new System.Drawing.Point(805, 25);
            this.moversDataGridView.Name = "moversDataGridView";
            this.moversDataGridView.ReadOnly = true;
            this.moversDataGridView.RowHeadersWidth = 51;
            this.moversDataGridView.RowTemplate.Height = 24;
            this.moversDataGridView.Size = new System.Drawing.Size(350, 425);
            this.moversDataGridView.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(805, 475);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 50);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(1030, 475);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(125, 50);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitsLabel.Location = new System.Drawing.Point(25, 455);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(102, 17);
            this.unitsLabel.TabIndex = 4;
            this.unitsLabel.Text = "Order\'s units";
            // 
            // unitsDescriptionLabel
            // 
            this.unitsDescriptionLabel.AutoSize = true;
            this.unitsDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitsDescriptionLabel.Location = new System.Drawing.Point(25, 475);
            this.unitsDescriptionLabel.Name = "unitsDescriptionLabel";
            this.unitsDescriptionLabel.Size = new System.Drawing.Size(134, 17);
            this.unitsDescriptionLabel.TabIndex = 5;
            this.unitsDescriptionLabel.Text = "Units\' description";
            // 
            // unitsAmountLabel
            // 
            this.unitsAmountLabel.AutoSize = true;
            this.unitsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitsAmountLabel.Location = new System.Drawing.Point(25, 527);
            this.unitsAmountLabel.Name = "unitsAmountLabel";
            this.unitsAmountLabel.Size = new System.Drawing.Size(103, 17);
            this.unitsAmountLabel.TabIndex = 6;
            this.unitsAmountLabel.Text = "Units amount";
            // 
            // ChooseMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.unitsAmountLabel);
            this.Controls.Add(this.unitsDescriptionLabel);
            this.Controls.Add(this.unitsLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moversDataGridView);
            this.Controls.Add(this.carsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChooseMoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseMoverForm_FormClosed);
            this.Load += new System.EventHandler(this.ChooseMoverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moversDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridView moversDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label unitsDescriptionLabel;
        private System.Windows.Forms.Label unitsAmountLabel;
    }
}