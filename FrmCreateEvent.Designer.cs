
namespace Calendar
{
    partial class FrmCreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateEvent));
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtEvent = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblEvent = new System.Windows.Forms.Label();
            this.BtnSaveEvent = new System.Windows.Forms.Button();
            this.LblNewEvent = new System.Windows.Forms.Label();
            this.ChkBoxIterable = new System.Windows.Forms.CheckBox();
            this.LblNewStart = new System.Windows.Forms.Label();
            this.TxtStart = new System.Windows.Forms.TextBox();
            this.LblNewEnd = new System.Windows.Forms.Label();
            this.TxtEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtDate
            // 
            this.TxtDate.Enabled = false;
            this.TxtDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(62, 107);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(265, 26);
            this.TxtDate.TabIndex = 0;
            // 
            // TxtEvent
            // 
            this.TxtEvent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEvent.Location = new System.Drawing.Point(62, 184);
            this.TxtEvent.Name = "TxtEvent";
            this.TxtEvent.Size = new System.Drawing.Size(265, 22);
            this.TxtEvent.TabIndex = 1;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(59, 74);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(29, 14);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Data";
            // 
            // LblEvent
            // 
            this.LblEvent.AutoSize = true;
            this.LblEvent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvent.Location = new System.Drawing.Point(59, 148);
            this.LblEvent.Name = "LblEvent";
            this.LblEvent.Size = new System.Drawing.Size(40, 14);
            this.LblEvent.TabIndex = 3;
            this.LblEvent.Text = "Evento";
            // 
            // BtnSaveEvent
            // 
            this.BtnSaveEvent.Location = new System.Drawing.Point(252, 303);
            this.BtnSaveEvent.Name = "BtnSaveEvent";
            this.BtnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveEvent.TabIndex = 4;
            this.BtnSaveEvent.Text = "Salva";
            this.BtnSaveEvent.UseVisualStyleBackColor = true;
            this.BtnSaveEvent.Click += new System.EventHandler(this.BtnSaveEvent_Click);
            // 
            // LblNewEvent
            // 
            this.LblNewEvent.AutoSize = true;
            this.LblNewEvent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewEvent.Location = new System.Drawing.Point(127, 31);
            this.LblNewEvent.Name = "LblNewEvent";
            this.LblNewEvent.Size = new System.Drawing.Size(128, 22);
            this.LblNewEvent.TabIndex = 5;
            this.LblNewEvent.Text = "Nuovo Evento";
            // 
            // ChkBoxIterable
            // 
            this.ChkBoxIterable.AutoSize = true;
            this.ChkBoxIterable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxIterable.Location = new System.Drawing.Point(218, 250);
            this.ChkBoxIterable.Name = "ChkBoxIterable";
            this.ChkBoxIterable.Size = new System.Drawing.Size(93, 18);
            this.ChkBoxIterable.TabIndex = 6;
            this.ChkBoxIterable.Text = "Sempre Attivo";
            this.ChkBoxIterable.UseVisualStyleBackColor = true;
            // 
            // LblNewStart
            // 
            this.LblNewStart.AutoSize = true;
            this.LblNewStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewStart.Location = new System.Drawing.Point(72, 229);
            this.LblNewStart.Name = "LblNewStart";
            this.LblNewStart.Size = new System.Drawing.Size(31, 14);
            this.LblNewStart.TabIndex = 8;
            this.LblNewStart.Text = "Inizio";
            // 
            // TxtStart
            // 
            this.TxtStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStart.Location = new System.Drawing.Point(66, 246);
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(59, 22);
            this.TxtStart.TabIndex = 7;
            // 
            // LblNewEnd
            // 
            this.LblNewEnd.AutoSize = true;
            this.LblNewEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewEnd.Location = new System.Drawing.Point(141, 229);
            this.LblNewEnd.Name = "LblNewEnd";
            this.LblNewEnd.Size = new System.Drawing.Size(27, 14);
            this.LblNewEnd.TabIndex = 10;
            this.LblNewEnd.Text = "Fine";
            // 
            // TxtEnd
            // 
            this.TxtEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnd.Location = new System.Drawing.Point(131, 246);
            this.TxtEnd.Name = "TxtEnd";
            this.TxtEnd.Size = new System.Drawing.Size(59, 22);
            this.TxtEnd.TabIndex = 9;
            // 
            // FrmCreateEvent
            // 
            this.AcceptButton = this.BtnSaveEvent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(417, 365);
            this.Controls.Add(this.LblNewEnd);
            this.Controls.Add(this.TxtEnd);
            this.Controls.Add(this.LblNewStart);
            this.Controls.Add(this.TxtStart);
            this.Controls.Add(this.ChkBoxIterable);
            this.Controls.Add(this.LblNewEvent);
            this.Controls.Add(this.BtnSaveEvent);
            this.Controls.Add(this.LblEvent);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.TxtEvent);
            this.Controls.Add(this.TxtDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crea Evento";
            this.Load += new System.EventHandler(this.FrmCreateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtEvent;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblEvent;
        private System.Windows.Forms.Button BtnSaveEvent;
        private System.Windows.Forms.Label LblNewEvent;
        private System.Windows.Forms.CheckBox ChkBoxIterable;
        private System.Windows.Forms.Label LblNewStart;
        private System.Windows.Forms.TextBox TxtStart;
        private System.Windows.Forms.Label LblNewEnd;
        private System.Windows.Forms.TextBox TxtEnd;
    }
}