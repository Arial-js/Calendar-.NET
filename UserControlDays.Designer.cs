
namespace Calendar
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.LblDays = new System.Windows.Forms.Label();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.TmrUCD = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDays.Location = new System.Drawing.Point(3, 8);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(24, 17);
            this.LblDays.TabIndex = 1;
            this.LblDays.Text = "00";
            // 
            // LstBox
            // 
            this.LstBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LstBox.ItemHeight = 15;
            this.LstBox.Location = new System.Drawing.Point(0, 28);
            this.LstBox.Name = "LstBox";
            this.LstBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LstBox.Size = new System.Drawing.Size(135, 60);
            this.LstBox.TabIndex = 2;
            // 
            // TmrUCD
            // 
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.LblDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(138, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.ListBox LstBox;
        private System.Windows.Forms.Timer TmrUCD;
    }
}
