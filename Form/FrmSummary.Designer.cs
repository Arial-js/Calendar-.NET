
namespace Calendar
{
    partial class FrmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummary));
            this.LblYear = new System.Windows.Forms.Label();
            this.FlMonthContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblYear
            // 
            this.LblYear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LblYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(284, 9);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(227, 27);
            this.LblYear.TabIndex = 11;
            this.LblYear.Text = "Anno";
            this.LblYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FlMonthContainer
            // 
            this.FlMonthContainer.Location = new System.Drawing.Point(12, 85);
            this.FlMonthContainer.Name = "FlMonthContainer";
            this.FlMonthContainer.Size = new System.Drawing.Size(776, 329);
            this.FlMonthContainer.TabIndex = 12;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(713, 435);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 26);
            this.BtnNext.TabIndex = 14;
            this.BtnNext.Text = "Avanti";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(616, 435);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 26);
            this.BtnPrevious.TabIndex = 13;
            this.BtnPrevious.Text = "Indietro";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.FlMonthContainer);
            this.Controls.Add(this.LblYear);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.FrmSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.FlowLayoutPanel FlMonthContainer;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
    }
}