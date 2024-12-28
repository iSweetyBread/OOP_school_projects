namespace Programm
{
    partial class frmUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSurname = new System.Windows.Forms.RadioButton();
            this.rbtnPhone = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.Change = new System.Windows.Forms.Label();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.btnUpdateUpdate = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.tbId1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSurname);
            this.groupBox1.Controls.Add(this.rbtnPhone);
            this.groupBox1.Controls.Add(this.rbtnName);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbtnSurname
            // 
            this.rbtnSurname.AutoSize = true;
            this.rbtnSurname.Location = new System.Drawing.Point(6, 33);
            this.rbtnSurname.Name = "rbtnSurname";
            this.rbtnSurname.Size = new System.Drawing.Size(74, 17);
            this.rbtnSurname.TabIndex = 6;
            this.rbtnSurname.TabStop = true;
            this.rbtnSurname.Text = "Last name";
            this.rbtnSurname.UseVisualStyleBackColor = true;
            // 
            // rbtnPhone
            // 
            this.rbtnPhone.AutoSize = true;
            this.rbtnPhone.Location = new System.Drawing.Point(6, 79);
            this.rbtnPhone.Name = "rbtnPhone";
            this.rbtnPhone.Size = new System.Drawing.Size(94, 17);
            this.rbtnPhone.TabIndex = 8;
            this.rbtnPhone.TabStop = true;
            this.rbtnPhone.Text = "Phone number";
            this.rbtnPhone.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Location = new System.Drawing.Point(6, 10);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(73, 17);
            this.rbtnName.TabIndex = 5;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "First name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(6, 56);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(90, 17);
            this.rbtnEmail.TabIndex = 7;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "Email address";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(69, 46);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(44, 13);
            this.Change.TabIndex = 12;
            this.Change.Text = "Change";
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(12, 62);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(160, 20);
            this.tbChange.TabIndex = 11;
            this.tbChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateUpdate
            // 
            this.btnUpdateUpdate.Location = new System.Drawing.Point(12, 194);
            this.btnUpdateUpdate.Name = "btnUpdateUpdate";
            this.btnUpdateUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnUpdateUpdate.TabIndex = 10;
            this.btnUpdateUpdate.Text = "Update";
            this.btnUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateUpdate.Click += new System.EventHandler(this.btnUpdateUpdate_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(83, 7);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID";
            // 
            // tbId1
            // 
            this.tbId1.Location = new System.Drawing.Point(12, 23);
            this.tbId1.Name = "tbId1";
            this.tbId1.Size = new System.Drawing.Size(160, 20);
            this.tbId1.TabIndex = 14;
            this.tbId1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 241);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tbId1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.btnUpdateUpdate);
            this.Name = "frmUpdate";
            this.Text = "Update";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSurname;
        private System.Windows.Forms.RadioButton rbtnPhone;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.Button btnUpdateUpdate;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox tbId1;
    }
}