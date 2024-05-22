namespace HRCINVENTORYUPDATED
{
    partial class Warehouse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colWarehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouseIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouseCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWarehouseId,
            this.colWarehouseDescription,
            this.colWarehouseIsDeleted,
            this.colWarehouseCreatedDate});
            this.dataGridView1.Location = new System.Drawing.Point(129, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(913, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // colWarehouseId
            // 
            this.colWarehouseId.HeaderText = "WarehouseId";
            this.colWarehouseId.MinimumWidth = 8;
            this.colWarehouseId.Name = "colWarehouseId";
            this.colWarehouseId.Width = 150;
            // 
            // colWarehouseDescription
            // 
            this.colWarehouseDescription.HeaderText = "Description";
            this.colWarehouseDescription.MinimumWidth = 8;
            this.colWarehouseDescription.Name = "colWarehouseDescription";
            this.colWarehouseDescription.Width = 150;
            // 
            // colWarehouseIsDeleted
            // 
            this.colWarehouseIsDeleted.HeaderText = "IsDeleted";
            this.colWarehouseIsDeleted.MinimumWidth = 8;
            this.colWarehouseIsDeleted.Name = "colWarehouseIsDeleted";
            this.colWarehouseIsDeleted.Width = 150;
            // 
            // colWarehouseCreatedDate
            // 
            this.colWarehouseCreatedDate.HeaderText = "CreatedDate";
            this.colWarehouseCreatedDate.MinimumWidth = 8;
            this.colWarehouseCreatedDate.Name = "colWarehouseCreatedDate";
            this.colWarehouseCreatedDate.Width = 150;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(787, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 51);
            this.button4.TabIndex = 19;
            this.button4.Text = "CANCEL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 51);
            this.button3.TabIndex = 18;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 850);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Warehouse";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouseIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouseCreatedDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}