
namespace Calendar
{
    partial class FrmCalendar
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendar));
            this.FlDayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblMonday = new System.Windows.Forms.Label();
            this.LblTuesday = new System.Windows.Forms.Label();
            this.LblWednesday = new System.Windows.Forms.Label();
            this.LblThursday = new System.Windows.Forms.Label();
            this.LblFriday = new System.Windows.Forms.Label();
            this.LblSaturday = new System.Windows.Forms.Label();
            this.LblSunday = new System.Windows.Forms.Label();
            this.LblMonthYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlDayContainer
            // 
            this.FlDayContainer.AutoScroll = true;
            this.FlDayContainer.BackColor = System.Drawing.Color.LightSlateGray;
            this.FlDayContainer.Location = new System.Drawing.Point(4, 95);
            this.FlDayContainer.Name = "FlDayContainer";
            this.FlDayContainer.Size = new System.Drawing.Size(1031, 554);
            this.FlDayContainer.TabIndex = 0;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnPrevious.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.Image")));
            this.BtnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrevious.Location = new System.Drawing.Point(842, 655);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(88, 24);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.Text = "Indietro";
            this.BtnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(936, 655);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(88, 24);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "Avanti";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblMonday
            // 
            this.LblMonday.AutoSize = true;
            this.LblMonday.BackColor = System.Drawing.Color.Transparent;
            this.LblMonday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonday.Location = new System.Drawing.Point(57, 55);
            this.LblMonday.Name = "LblMonday";
            this.LblMonday.Size = new System.Drawing.Size(51, 17);
            this.LblMonday.TabIndex = 3;
            this.LblMonday.Text = "Lunedì";
            // 
            // LblTuesday
            // 
            this.LblTuesday.AutoSize = true;
            this.LblTuesday.BackColor = System.Drawing.Color.Transparent;
            this.LblTuesday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuesday.Location = new System.Drawing.Point(202, 55);
            this.LblTuesday.Name = "LblTuesday";
            this.LblTuesday.Size = new System.Drawing.Size(55, 17);
            this.LblTuesday.TabIndex = 4;
            this.LblTuesday.Text = "Martedì";
            // 
            // LblWednesday
            // 
            this.LblWednesday.AutoSize = true;
            this.LblWednesday.BackColor = System.Drawing.Color.Transparent;
            this.LblWednesday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWednesday.Location = new System.Drawing.Point(337, 55);
            this.LblWednesday.Name = "LblWednesday";
            this.LblWednesday.Size = new System.Drawing.Size(70, 17);
            this.LblWednesday.TabIndex = 5;
            this.LblWednesday.Text = "Mercoledì";
            // 
            // LblThursday
            // 
            this.LblThursday.AutoSize = true;
            this.LblThursday.BackColor = System.Drawing.Color.Transparent;
            this.LblThursday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThursday.Location = new System.Drawing.Point(485, 55);
            this.LblThursday.Name = "LblThursday";
            this.LblThursday.Size = new System.Drawing.Size(56, 17);
            this.LblThursday.TabIndex = 6;
            this.LblThursday.Text = "Giovedì";
            // 
            // LblFriday
            // 
            this.LblFriday.AutoSize = true;
            this.LblFriday.BackColor = System.Drawing.Color.Transparent;
            this.LblFriday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFriday.Location = new System.Drawing.Point(627, 55);
            this.LblFriday.Name = "LblFriday";
            this.LblFriday.Size = new System.Drawing.Size(56, 17);
            this.LblFriday.TabIndex = 7;
            this.LblFriday.Text = "Venerdì";
            // 
            // LblSaturday
            // 
            this.LblSaturday.AutoSize = true;
            this.LblSaturday.BackColor = System.Drawing.Color.Transparent;
            this.LblSaturday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaturday.Location = new System.Drawing.Point(774, 55);
            this.LblSaturday.Name = "LblSaturday";
            this.LblSaturday.Size = new System.Drawing.Size(54, 17);
            this.LblSaturday.TabIndex = 8;
            this.LblSaturday.Text = "Sabato";
            // 
            // LblSunday
            // 
            this.LblSunday.AutoSize = true;
            this.LblSunday.BackColor = System.Drawing.Color.Transparent;
            this.LblSunday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSunday.Location = new System.Drawing.Point(909, 55);
            this.LblSunday.Name = "LblSunday";
            this.LblSunday.Size = new System.Drawing.Size(75, 17);
            this.LblSunday.TabIndex = 9;
            this.LblSunday.Text = "Domenica";
            // 
            // LblMonthYear
            // 
            this.LblMonthYear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LblMonthYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthYear.ForeColor = System.Drawing.Color.Crimson;
            this.LblMonthYear.Image = ((System.Drawing.Image)(resources.GetObject("LblMonthYear.Image")));
            this.LblMonthYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblMonthYear.Location = new System.Drawing.Point(0, 0);
            this.LblMonthYear.Name = "LblMonthYear";
            this.LblMonthYear.Size = new System.Drawing.Size(1035, 43);
            this.LblMonthYear.TabIndex = 10;
            this.LblMonthYear.Text = "Mese Anno";
            this.LblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMonthYear.Click += new System.EventHandler(this.LblMonthYear_Click);
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1036, 716);
            this.Controls.Add(this.LblMonthYear);
            this.Controls.Add(this.LblSunday);
            this.Controls.Add(this.LblSaturday);
            this.Controls.Add(this.LblFriday);
            this.Controls.Add(this.LblThursday);
            this.Controls.Add(this.LblWednesday);
            this.Controls.Add(this.LblTuesday);
            this.Controls.Add(this.LblMonday);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.FlDayContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlDayContainer;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblMonday;
        private System.Windows.Forms.Label LblTuesday;
        private System.Windows.Forms.Label LblWednesday;
        private System.Windows.Forms.Label LblThursday;
        private System.Windows.Forms.Label LblFriday;
        private System.Windows.Forms.Label LblSaturday;
        private System.Windows.Forms.Label LblSunday;
        private System.Windows.Forms.Label LblMonthYear;
    }
}

