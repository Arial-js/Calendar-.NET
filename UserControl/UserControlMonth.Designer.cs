
namespace Calendar
{
    partial class UserControlMonth
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMonth = new System.Windows.Forms.Label();
            this.LblMonthNumber = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMonth
            // 
            this.LblMonth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonth.Location = new System.Drawing.Point(3, 26);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(182, 31);
            this.LblMonth.TabIndex = 2;
            this.LblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMonth.Click += new System.EventHandler(this.LblMonth_Click);
            // 
            // LblMonthNumber
            // 
            this.LblMonthNumber.AutoSize = true;
            this.LblMonthNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthNumber.Location = new System.Drawing.Point(3, 13);
            this.LblMonthNumber.Name = "LblMonthNumber";
            this.LblMonthNumber.Size = new System.Drawing.Size(13, 14);
            this.LblMonthNumber.TabIndex = 3;
            this.LblMonthNumber.Text = "0";
            this.LblMonthNumber.Visible = false;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(78, 13);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(27, 13);
            this.LblYear.TabIndex = 4;
            this.LblYear.Text = "year";
            this.LblYear.Visible = false;
            // 
            // UserControlMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblMonthNumber);
            this.Controls.Add(this.LblMonth);
            this.Name = "UserControlMonth";
            this.Size = new System.Drawing.Size(188, 86);
            this.Click += new System.EventHandler(this.UserControlMonth_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonth;
        private System.Windows.Forms.Label LblMonthNumber;
        private System.Windows.Forms.Label LblYear;
    }
}
