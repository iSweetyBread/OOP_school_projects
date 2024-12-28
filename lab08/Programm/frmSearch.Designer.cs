namespace Programm
{
    partial class frmSearch
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSurname1 = new System.Windows.Forms.RadioButton();
            this.rbtnPhone1 = new System.Windows.Forms.RadioButton();
            this.rbtnName1 = new System.Windows.Forms.RadioButton();
            this.rbtnEmail1 = new System.Windows.Forms.RadioButton();
            this.Text = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSeacrhSearch = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 12);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(360, 150);
            this.tbResult.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSurname1);
            this.groupBox2.Controls.Add(this.rbtnPhone1);
            this.groupBox2.Controls.Add(this.rbtnName1);
            this.groupBox2.Controls.Add(this.rbtnEmail1);
            this.groupBox2.Location = new System.Drawing.Point(117, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // rbtnSurname1
            // 
            this.rbtnSurname1.AutoSize = true;
            this.rbtnSurname1.Location = new System.Drawing.Point(6, 33);
            this.rbtnSurname1.Name = "rbtnSurname1";
            this.rbtnSurname1.Size = new System.Drawing.Size(74, 17);
            this.rbtnSurname1.TabIndex = 6;
            this.rbtnSurname1.TabStop = true;
            this.rbtnSurname1.Text = "Last name";
            this.rbtnSurname1.UseVisualStyleBackColor = true;
            // 
            // rbtnPhone1
            // 
            this.rbtnPhone1.AutoSize = true;
            this.rbtnPhone1.Location = new System.Drawing.Point(6, 79);
            this.rbtnPhone1.Name = "rbtnPhone1";
            this.rbtnPhone1.Size = new System.Drawing.Size(94, 17);
            this.rbtnPhone1.TabIndex = 8;
            this.rbtnPhone1.TabStop = true;
            this.rbtnPhone1.Text = "Phone number";
            this.rbtnPhone1.UseVisualStyleBackColor = true;
            // 
            // rbtnName1
            // 
            this.rbtnName1.AutoSize = true;
            this.rbtnName1.Location = new System.Drawing.Point(6, 10);
            this.rbtnName1.Name = "rbtnName1";
            this.rbtnName1.Size = new System.Drawing.Size(73, 17);
            this.rbtnName1.TabIndex = 5;
            this.rbtnName1.TabStop = true;
            this.rbtnName1.Text = "First name";
            this.rbtnName1.UseVisualStyleBackColor = true;
            // 
            // rbtnEmail1
            // 
            this.rbtnEmail1.AutoSize = true;
            this.rbtnEmail1.Location = new System.Drawing.Point(6, 56);
            this.rbtnEmail1.Name = "rbtnEmail1";
            this.rbtnEmail1.Size = new System.Drawing.Size(90, 17);
            this.rbtnEmail1.TabIndex = 7;
            this.rbtnEmail1.TabStop = true;
            this.rbtnEmail1.Text = "Email address";
            this.rbtnEmail1.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(183, 170);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(28, 13);
            this.Text.TabIndex = 21;
            this.Text.Text = "Text";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(117, 186);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(160, 20);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSeacrhSearch
            // 
            this.btnSeacrhSearch.Location = new System.Drawing.Point(117, 318);
            this.btnSeacrhSearch.Name = "btnSeacrhSearch";
            this.btnSeacrhSearch.Size = new System.Drawing.Size(160, 40);
            this.btnSeacrhSearch.TabIndex = 19;
            this.btnSeacrhSearch.Text = "Search";
            this.btnSeacrhSearch.UseVisualStyleBackColor = true;
            this.btnSeacrhSearch.Click += new System.EventHandler(this.btnSeacrhSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSeacrhSearch);
            this.Name = "frmSearch";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnSurname1;
        private System.Windows.Forms.RadioButton rbtnPhone1;
        private System.Windows.Forms.RadioButton rbtnName1;
        private System.Windows.Forms.RadioButton rbtnEmail1;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSeacrhSearch;
    }
}