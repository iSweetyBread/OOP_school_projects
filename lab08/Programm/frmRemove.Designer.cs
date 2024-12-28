namespace Programm
{
    partial class frmRemove
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
            this.btnRemoveRemove = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveRemove
            // 
            this.btnRemoveRemove.Location = new System.Drawing.Point(12, 59);
            this.btnRemoveRemove.Name = "btnRemoveRemove";
            this.btnRemoveRemove.Size = new System.Drawing.Size(160, 40);
            this.btnRemoveRemove.TabIndex = 0;
            this.btnRemoveRemove.Text = "Remove";
            this.btnRemoveRemove.UseVisualStyleBackColor = true;
            this.btnRemoveRemove.Click += new System.EventHandler(this.btnRemoveRemove_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 23);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(160, 20);
            this.tbId.TabIndex = 1;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(85, 7);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnRemoveRemove);
            this.Name = "frmRemove";
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveRemove;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label ID;
    }
}