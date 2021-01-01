namespace w1673746.Views
{
    partial class AddContactForm
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
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jobText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addContactBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.resetBt = new System.Windows.Forms.Button();
            this.phNoText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name*:";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(135, 77);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(164, 28);
            this.firstNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Proza Libre", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No:";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(135, 127);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(164, 28);
            this.lastNameText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address:";
            // 
            // jobText
            // 
            this.jobText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobText.Location = new System.Drawing.Point(135, 176);
            this.jobText.Name = "jobText";
            this.jobText.Size = new System.Drawing.Size(164, 28);
            this.jobText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Designation:";
            // 
            // addContactBt
            // 
            this.addContactBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.addContactBt.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.addContactBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addContactBt.Location = new System.Drawing.Point(72, 244);
            this.addContactBt.Name = "addContactBt";
            this.addContactBt.Size = new System.Drawing.Size(158, 33);
            this.addContactBt.TabIndex = 14;
            this.addContactBt.Text = "Add";
            this.addContactBt.UseVisualStyleBackColor = false;
            this.addContactBt.Click += new System.EventHandler(this.addContactBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.cancelBt.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.cancelBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBt.Location = new System.Drawing.Point(474, 244);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(158, 33);
            this.cancelBt.TabIndex = 15;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // resetBt
            // 
            this.resetBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.resetBt.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.resetBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetBt.Location = new System.Drawing.Point(268, 244);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(158, 33);
            this.resetBt.TabIndex = 16;
            this.resetBt.Text = "Reset";
            this.resetBt.UseVisualStyleBackColor = false;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // phNoText
            // 
            this.phNoText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phNoText.Location = new System.Drawing.Point(468, 77);
            this.phNoText.Name = "phNoText";
            this.phNoText.Size = new System.Drawing.Size(164, 28);
            this.phNoText.TabIndex = 17;
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(468, 126);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(164, 28);
            this.addressText.TabIndex = 18;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phNoText);
            this.Controls.Add(this.resetBt);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.addContactBt);
            this.Controls.Add(this.jobText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label1);
            this.Name = "AddContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Financial Management | Add Contact Form";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jobText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addContactBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button resetBt;
        private System.Windows.Forms.TextBox phNoText;
        private System.Windows.Forms.TextBox addressText;
    }
}