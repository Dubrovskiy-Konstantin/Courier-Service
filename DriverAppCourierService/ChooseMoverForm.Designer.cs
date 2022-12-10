
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
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moversDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(25, 25);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.Size = new System.Drawing.Size(750, 500);
            this.carsDataGridView.TabIndex = 0;
            // 
            // moversDataGridView
            // 
            this.moversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moversDataGridView.Location = new System.Drawing.Point(805, 25);
            this.moversDataGridView.Name = "moversDataGridView";
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
            // 
            // ChooseMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moversDataGridView);
            this.Controls.Add(this.carsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChooseMoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverApp";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moversDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridView moversDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
    }
}