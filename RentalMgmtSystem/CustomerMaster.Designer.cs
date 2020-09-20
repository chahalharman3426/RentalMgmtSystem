namespace RentalMgmtSystem
{
    partial class CustomerMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_mobile_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_customerDelete = new System.Windows.Forms.Button();
            this.btn_customerEdit = new System.Windows.Forms.Button();
            this.btn_customerAdd = new System.Windows.Forms.Button();
            this.grid_CustomerMaster = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_customerBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CustomerMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Name";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(224, 123);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(307, 20);
            this.text_name.TabIndex = 9;
            this.text_name.Validating += new System.ComponentModel.CancelEventHandler(this.text_name_Validating);
            // 
            // text_mobile_no
            // 
            this.text_mobile_no.Location = new System.Drawing.Point(224, 199);
            this.text_mobile_no.Name = "text_mobile_no";
            this.text_mobile_no.Size = new System.Drawing.Size(307, 20);
            this.text_mobile_no.TabIndex = 11;
            this.text_mobile_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_mobile_no_KeyPress);
            this.text_mobile_no.Validating += new System.ComponentModel.CancelEventHandler(this.text_mobile_no_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mobile No";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(224, 265);
            this.text_address.Multiline = true;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(307, 97);
            this.text_address.TabIndex = 13;
            this.text_address.Validating += new System.ComponentModel.CancelEventHandler(this.text_address_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // btn_customerDelete
            // 
            this.btn_customerDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_customerDelete.CausesValidation = false;
            this.btn_customerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerDelete.ForeColor = System.Drawing.Color.White;
            this.btn_customerDelete.Location = new System.Drawing.Point(445, 390);
            this.btn_customerDelete.Name = "btn_customerDelete";
            this.btn_customerDelete.Size = new System.Drawing.Size(86, 37);
            this.btn_customerDelete.TabIndex = 41;
            this.btn_customerDelete.Text = "Delete";
            this.btn_customerDelete.UseVisualStyleBackColor = false;
            this.btn_customerDelete.Click += new System.EventHandler(this.btn_customerDelete_Click);
            // 
            // btn_customerEdit
            // 
            this.btn_customerEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_customerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerEdit.ForeColor = System.Drawing.Color.White;
            this.btn_customerEdit.Location = new System.Drawing.Point(336, 390);
            this.btn_customerEdit.Name = "btn_customerEdit";
            this.btn_customerEdit.Size = new System.Drawing.Size(91, 37);
            this.btn_customerEdit.TabIndex = 40;
            this.btn_customerEdit.Text = "Edit";
            this.btn_customerEdit.UseVisualStyleBackColor = false;
            this.btn_customerEdit.Click += new System.EventHandler(this.btn_customerEdit_Click);
            // 
            // btn_customerAdd
            // 
            this.btn_customerAdd.BackColor = System.Drawing.Color.DarkRed;
            this.btn_customerAdd.CausesValidation = false;
            this.btn_customerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerAdd.ForeColor = System.Drawing.Color.White;
            this.btn_customerAdd.Location = new System.Drawing.Point(224, 390);
            this.btn_customerAdd.Name = "btn_customerAdd";
            this.btn_customerAdd.Size = new System.Drawing.Size(91, 37);
            this.btn_customerAdd.TabIndex = 39;
            this.btn_customerAdd.Text = "Add";
            this.btn_customerAdd.UseVisualStyleBackColor = false;
            this.btn_customerAdd.Click += new System.EventHandler(this.btn_customerAdd_Click);
            // 
            // grid_CustomerMaster
            // 
            this.grid_CustomerMaster.AllowUserToAddRows = false;
            this.grid_CustomerMaster.AllowUserToDeleteRows = false;
            this.grid_CustomerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CustomerMaster.Location = new System.Drawing.Point(565, 120);
            this.grid_CustomerMaster.Name = "grid_CustomerMaster";
            this.grid_CustomerMaster.ReadOnly = true;
            this.grid_CustomerMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_CustomerMaster.Size = new System.Drawing.Size(436, 242);
            this.grid_CustomerMaster.TabIndex = 42;
            this.grid_CustomerMaster.Click += new System.EventHandler(this.grid_CustomerMaster_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_customerBack
            // 
            this.btn_customerBack.BackColor = System.Drawing.Color.DarkRed;
            this.btn_customerBack.CausesValidation = false;
            this.btn_customerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerBack.ForeColor = System.Drawing.Color.White;
            this.btn_customerBack.Location = new System.Drawing.Point(550, 390);
            this.btn_customerBack.Name = "btn_customerBack";
            this.btn_customerBack.Size = new System.Drawing.Size(95, 37);
            this.btn_customerBack.TabIndex = 43;
            this.btn_customerBack.Text = "<<Back";
            this.btn_customerBack.UseVisualStyleBackColor = false;
            this.btn_customerBack.Click += new System.EventHandler(this.btn_customerBack_Click);
            // 
            // CustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.btn_customerBack);
            this.Controls.Add(this.grid_CustomerMaster);
            this.Controls.Add(this.btn_customerDelete);
            this.Controls.Add(this.btn_customerEdit);
            this.Controls.Add(this.btn_customerAdd);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_mobile_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMaster";
            this.Load += new System.EventHandler(this.CustomerMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CustomerMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_mobile_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_customerDelete;
        private System.Windows.Forms.Button btn_customerEdit;
        private System.Windows.Forms.Button btn_customerAdd;
        private System.Windows.Forms.DataGridView grid_CustomerMaster;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_customerBack;
    }
}