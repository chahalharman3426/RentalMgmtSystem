namespace RentalMgmtSystem
{
    partial class frmMostBuyerList
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridMostBuyer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 46);
            this.label1.TabIndex = 47;
            this.label1.Text = "Most Borrows Customer List";
            // 
            // gridMostBuyer
            // 
            this.gridMostBuyer.AllowUserToAddRows = false;
            this.gridMostBuyer.AllowUserToDeleteRows = false;
            this.gridMostBuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostBuyer.Location = new System.Drawing.Point(183, 96);
            this.gridMostBuyer.Name = "gridMostBuyer";
            this.gridMostBuyer.ReadOnly = true;
            this.gridMostBuyer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMostBuyer.Size = new System.Drawing.Size(467, 317);
            this.gridMostBuyer.TabIndex = 48;
            // 
            // frmMostBuyerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridMostBuyer);
            this.Controls.Add(this.label1);
            this.Name = "frmMostBuyerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostBuyerList";
            this.Load += new System.EventHandler(this.frmMostBuyerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBuyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMostBuyer;
    }
}