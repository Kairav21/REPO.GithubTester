namespace WindowsFormsApp1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lbldragonName = new System.Windows.Forms.Label();
            this.txtDragonName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(40, 79);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(781, 48);
            this.txtPlayerName.TabIndex = 1;
            // 
            // lbldragonName
            // 
            this.lbldragonName.AutoSize = true;
            this.lbldragonName.Location = new System.Drawing.Point(37, 157);
            this.lbldragonName.Name = "lbldragonName";
            this.lbldragonName.Size = new System.Drawing.Size(92, 16);
            this.lbldragonName.TabIndex = 2;
            this.lbldragonName.Text = "Dragon Name";
            // 
            // txtDragonName
            // 
            this.txtDragonName.Location = new System.Drawing.Point(40, 207);
            this.txtDragonName.Multiline = true;
            this.txtDragonName.Name = "txtDragonName";
            this.txtDragonName.Size = new System.Drawing.Size(781, 60);
            this.txtDragonName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(781, 62);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(40, 412);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(781, 96);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDragonName);
            this.Controls.Add(this.lbldragonName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lbldragonName;
        private System.Windows.Forms.TextBox txtDragonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

