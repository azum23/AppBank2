namespace ADO_disconectedModel
{
    partial class Form1
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
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.btn_LinkData = new System.Windows.Forms.Button();
            this.btn_GetCount = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.btn_RowState = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Reject = new System.Windows.Forms.Button();
            this.lbl_Design_01 = new System.Windows.Forms.Label();
            this.lbl_Desing_02 = new System.Windows.Forms.Label();
            this.dgv_Credits = new System.Windows.Forms.DataGridView();
            this.dtp_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddNewCredit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(12, 84);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.Size = new System.Drawing.Size(669, 150);
            this.dgv_Customers.TabIndex = 0;
            // 
            // btn_LinkData
            // 
            this.btn_LinkData.Location = new System.Drawing.Point(12, 12);
            this.btn_LinkData.Name = "btn_LinkData";
            this.btn_LinkData.Size = new System.Drawing.Size(75, 23);
            this.btn_LinkData.TabIndex = 0;
            this.btn_LinkData.Text = "Link data";
            this.btn_LinkData.UseVisualStyleBackColor = true;
            this.btn_LinkData.Click += new System.EventHandler(this.btn_LinkData_Click);
            // 
            // btn_GetCount
            // 
            this.btn_GetCount.Location = new System.Drawing.Point(93, 12);
            this.btn_GetCount.Name = "btn_GetCount";
            this.btn_GetCount.Size = new System.Drawing.Size(75, 23);
            this.btn_GetCount.TabIndex = 1;
            this.btn_GetCount.Text = "Count in DataTable";
            this.btn_GetCount.UseVisualStyleBackColor = true;
            this.btn_GetCount.Click += new System.EventHandler(this.btn_GetCount_Click);
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Location = new System.Drawing.Point(174, 12);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRow.TabIndex = 2;
            this.btn_AddRow.Text = "Add Row";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // btn_RowState
            // 
            this.btn_RowState.Location = new System.Drawing.Point(255, 12);
            this.btn_RowState.Name = "btn_RowState";
            this.btn_RowState.Size = new System.Drawing.Size(75, 23);
            this.btn_RowState.TabIndex = 3;
            this.btn_RowState.Text = "Row State";
            this.btn_RowState.UseVisualStyleBackColor = true;
            this.btn_RowState.Click += new System.EventHandler(this.btn_RowState_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(336, 12);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 4;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(417, 12);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(75, 23);
            this.btn_Reject.TabIndex = 5;
            this.btn_Reject.Text = "Reject";
            this.btn_Reject.UseVisualStyleBackColor = true;
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            // 
            // lbl_Design_01
            // 
            this.lbl_Design_01.AutoSize = true;
            this.lbl_Design_01.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Design_01.Location = new System.Drawing.Point(7, 56);
            this.lbl_Design_01.Name = "lbl_Design_01";
            this.lbl_Design_01.Size = new System.Drawing.Size(106, 25);
            this.lbl_Design_01.TabIndex = 6;
            this.lbl_Design_01.Text = "Customers";
            // 
            // lbl_Desing_02
            // 
            this.lbl_Desing_02.AutoSize = true;
            this.lbl_Desing_02.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Desing_02.Location = new System.Drawing.Point(7, 271);
            this.lbl_Desing_02.Name = "lbl_Desing_02";
            this.lbl_Desing_02.Size = new System.Drawing.Size(74, 25);
            this.lbl_Desing_02.TabIndex = 6;
            this.lbl_Desing_02.Text = "Credits";
            // 
            // dgv_Credits
            // 
            this.dgv_Credits.AllowUserToAddRows = false;
            this.dgv_Credits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credits.Location = new System.Drawing.Point(12, 299);
            this.dgv_Credits.Name = "dgv_Credits";
            this.dgv_Credits.Size = new System.Drawing.Size(669, 150);
            this.dgv_Credits.TabIndex = 7;
            // 
            // dtp_SelectDate
            // 
            this.dtp_SelectDate.Location = new System.Drawing.Point(320, 268);
            this.dtp_SelectDate.Name = "dtp_SelectDate";
            this.dtp_SelectDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_SelectDate.TabIndex = 8;
            // 
            // btn_AddNewCredit
            // 
            this.btn_AddNewCredit.Location = new System.Drawing.Point(526, 268);
            this.btn_AddNewCredit.Name = "btn_AddNewCredit";
            this.btn_AddNewCredit.Size = new System.Drawing.Size(155, 20);
            this.btn_AddNewCredit.TabIndex = 9;
            this.btn_AddNewCredit.Text = "Add Credit To Current";
            this.btn_AddNewCredit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сумма кредита:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_AddNewCredit);
            this.Controls.Add(this.dtp_SelectDate);
            this.Controls.Add(this.dgv_Credits);
            this.Controls.Add(this.lbl_Desing_02);
            this.Controls.Add(this.lbl_Design_01);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_RowState);
            this.Controls.Add(this.btn_AddRow);
            this.Controls.Add(this.btn_GetCount);
            this.Controls.Add(this.btn_LinkData);
            this.Controls.Add(this.dgv_Customers);
            this.Name = "Form1";
            this.Text = "ADO.NET Disconected App";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Button btn_LinkData;
        private System.Windows.Forms.Button btn_GetCount;
        private System.Windows.Forms.Button btn_AddRow;
        private System.Windows.Forms.Button btn_RowState;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.Label lbl_Design_01;
        private System.Windows.Forms.Label lbl_Desing_02;
        private System.Windows.Forms.DataGridView dgv_Credits;
        private System.Windows.Forms.DateTimePicker dtp_SelectDate;
        private System.Windows.Forms.Button btn_AddNewCredit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

