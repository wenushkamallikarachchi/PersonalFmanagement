namespace w1673746.Views
{
    partial class AddExpenseForm
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
            this.comboBoxExpense = new System.Windows.Forms.ComboBox();
            this.expenseDescription = new System.Windows.Forms.TextBox();
            this.amountExpense = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expenseType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addExpense = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proza Libre", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Expense";
            // 
            // comboBoxExpense
            // 
            this.comboBoxExpense.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExpense.FormattingEnabled = true;
            this.comboBoxExpense.Location = new System.Drawing.Point(183, 79);
            this.comboBoxExpense.Name = "comboBoxExpense";
            this.comboBoxExpense.Size = new System.Drawing.Size(214, 28);
            this.comboBoxExpense.TabIndex = 13;
            // 
            // expenseDescription
            // 
            this.expenseDescription.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDescription.Location = new System.Drawing.Point(183, 124);
            this.expenseDescription.Name = "expenseDescription";
            this.expenseDescription.Size = new System.Drawing.Size(214, 28);
            this.expenseDescription.TabIndex = 14;
            // 
            // amountExpense
            // 
            this.amountExpense.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountExpense.Location = new System.Drawing.Point(183, 172);
            this.amountExpense.Name = "amountExpense";
            this.amountExpense.Size = new System.Drawing.Size(214, 28);
            this.amountExpense.TabIndex = 15;
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExpense.Location = new System.Drawing.Point(552, 126);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(251, 28);
            this.dateTimePickerExpense.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Payment To*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Payment Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Payment Type:";
            // 
            // expenseType
            // 
            this.expenseType.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseType.Location = new System.Drawing.Point(552, 79);
            this.expenseType.Name = "expenseType";
            this.expenseType.Size = new System.Drawing.Size(251, 28);
            this.expenseType.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Transaction Date*:";
            // 
            // addExpense
            // 
            this.addExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.addExpense.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.addExpense.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addExpense.Location = new System.Drawing.Point(146, 245);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(148, 33);
            this.addExpense.TabIndex = 25;
            this.addExpense.Text = "Add";
            this.addExpense.UseVisualStyleBackColor = false;
            this.addExpense.Click += new System.EventHandler(this.addExpense_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.Reset.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reset.Location = new System.Drawing.Point(356, 245);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(148, 33);
            this.Reset.TabIndex = 26;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.cancel.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(561, 245);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(148, 33);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(815, 311);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.addExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expenseType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerExpense);
            this.Controls.Add(this.amountExpense);
            this.Controls.Add(this.expenseDescription);
            this.Controls.Add(this.comboBoxExpense);
            this.Controls.Add(this.label1);
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Financial Management | Add Expense Form";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExpense;
        private System.Windows.Forms.TextBox expenseDescription;
        private System.Windows.Forms.TextBox amountExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expenseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addExpense;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button cancel;
    }
}