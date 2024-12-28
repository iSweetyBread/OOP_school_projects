namespace Programm
{
    partial class frmAdd
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
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Location = new System.Drawing.Point(12, 187);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(200, 63);
            this.btnAddAdd.TabIndex = 20;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone number";
            // 
            // tbAddPhone
            // 
            this.tbAddPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddPhone.Location = new System.Drawing.Point(12, 143);
            this.tbAddPhone.Name = "tbAddPhone";
            this.tbAddPhone.Size = new System.Drawing.Size(200, 20);
            this.tbAddPhone.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email addres";
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddEmail.Location = new System.Drawing.Point(12, 104);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(200, 20);
            this.tbAddEmail.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last name";
            // 
            // tbAddSurname
            // 
            this.tbAddSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddSurname.Location = new System.Drawing.Point(12, 65);
            this.tbAddSurname.Name = "tbAddSurname";
            this.tbAddSurname.Size = new System.Drawing.Size(200, 20);
            this.tbAddSurname.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First name";
            // 
            // tbAddName
            // 
            this.tbAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddName.Location = new System.Drawing.Point(12, 26);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(200, 20);
            this.tbAddName.TabIndex = 12;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.btnAddAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddName);
            this.Name = "frmAdd";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddName;
    }
}