namespace w1673746.Views
{
    partial class UpdateIncomeForm
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
            this.comboBoxPaymentFrom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelIncome = new System.Windows.Forms.Button();
            this.resetIncome = new System.Windows.Forms.Button();
            this.addIncome = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.paymentDes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxPaymentFrom
            // 
            this.comboBoxPaymentFrom.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentFrom.FormattingEnabled = true;
            this.comboBoxPaymentFrom.Location = new System.Drawing.Point(179, 89);
            this.comboBoxPaymentFrom.Name = "comboBoxPaymentFrom";
            this.comboBoxPaymentFrom.Size = new System.Drawing.Size(214, 28);
            this.comboBoxPaymentFrom.TabIndex = 33;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(571, 140);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 25);
            this.dateTimePicker.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Transaction Date*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Payment Type:";
            // 
            // paymentType
            // 
            this.paymentType.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType.Location = new System.Drawing.Point(571, 87);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(214, 28);
            this.paymentType.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proza Libre", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Update Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Payment Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment From*:";
            // 
            // cancelIncome
            // 
            this.cancelIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.cancelIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelIncome.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.cancelIncome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelIncome.Location = new System.Drawing.Point(604, 246);
            this.cancelIncome.Name = "cancelIncome";
            this.cancelIncome.Size = new System.Drawing.Size(148, 33);
            this.cancelIncome.TabIndex = 24;
            this.cancelIncome.Text = "Cancel";
            this.cancelIncome.UseVisualStyleBackColor = false;
            // 
            // resetIncome
            // 
            this.resetIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.resetIncome.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.resetIncome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetIncome.Location = new System.Drawing.Point(371, 246);
            this.resetIncome.Name = "resetIncome";
            this.resetIncome.Size = new System.Drawing.Size(148, 33);
            this.resetIncome.TabIndex = 23;
            this.resetIncome.Text = "Reset";
            this.resetIncome.UseVisualStyleBackColor = false;
            // 
            // addIncome
            // 
            this.addIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.addIncome.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addIncome.Location = new System.Drawing.Point(149, 246);
            this.addIncome.Name = "addIncome";
            this.addIncome.Size = new System.Drawing.Size(148, 33);
            this.addIncome.TabIndex = 22;
            this.addIncome.TabStop = false;
            this.addIncome.Text = "Update";
            this.addIncome.UseVisualStyleBackColor = false;
            this.addIncome.Click += new System.EventHandler(this.updateIncome_Click);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(179, 181);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(214, 28);
            this.amount.TabIndex = 21;
            // 
            // paymentDes
            // 
            this.paymentDes.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDes.Location = new System.Drawing.Point(179, 132);
            this.paymentDes.Name = "paymentDes";
            this.paymentDes.Size = new System.Drawing.Size(214, 28);
            this.paymentDes.TabIndex = 20;
            // 
            // UpdateIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(815, 311);
            this.Controls.Add(this.comboBoxPaymentFrom);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelIncome);
            this.Controls.Add(this.resetIncome);
            this.Controls.Add(this.addIncome);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.paymentDes);
            this.MaximizeBox = false;
            this.Name = "UpdateIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Financial Management | Update Income";
            this.Load += new System.EventHandler(this.UpdateIncomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaymentFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelIncome;
        private System.Windows.Forms.Button resetIncome;
        private System.Windows.Forms.Button addIncome;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox paymentDes;
    }
}