namespace CohTempRecRemover
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
            this.components = new System.ComponentModel.Container();
            this.LblTitle_Line1 = new System.Windows.Forms.Label();
            this.LblTitle_Line2 = new System.Windows.Forms.Label();
            this.BtnRunAndStop = new System.Windows.Forms.Button();
            this.LblHowTo_Line1 = new System.Windows.Forms.Label();
            this.LblHowTo_Line2 = new System.Windows.Forms.Label();
            this.LblMessage_Line1 = new System.Windows.Forms.Label();
            this.TimerRemoveTempRec = new System.Windows.Forms.Timer(this.components);
            this.LblMessage_Line2 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle_Line1
            // 
            this.LblTitle_Line1.AutoSize = true;
            this.LblTitle_Line1.Location = new System.Drawing.Point(12, 9);
            this.LblTitle_Line1.Name = "LblTitle_Line1";
            this.LblTitle_Line1.Size = new System.Drawing.Size(650, 13);
            this.LblTitle_Line1.TabIndex = 0;
            this.LblTitle_Line1.Text = "Dieses Programm dient dem Zweck, die \"temp.rec\" von \"Company of Heroes\" automatis" +
    "ch zu entfernen, sobald diese vorgefunden wird.";
            // 
            // LblTitle_Line2
            // 
            this.LblTitle_Line2.AutoSize = true;
            this.LblTitle_Line2.Location = new System.Drawing.Point(12, 22);
            this.LblTitle_Line2.Name = "LblTitle_Line2";
            this.LblTitle_Line2.Size = new System.Drawing.Size(586, 13);
            this.LblTitle_Line2.TabIndex = 1;
            this.LblTitle_Line2.Text = "Diese befindet sich im jeweiligen Benutzer-Ordner unter \"Documents\\My Games\\Compa" +
    "ny of Heroes Relaunch\\playback\".";
            // 
            // BtnRunAndStop
            // 
            this.BtnRunAndStop.BackColor = System.Drawing.Color.Lime;
            this.BtnRunAndStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunAndStop.Location = new System.Drawing.Point(15, 77);
            this.BtnRunAndStop.Name = "BtnRunAndStop";
            this.BtnRunAndStop.Size = new System.Drawing.Size(281, 23);
            this.BtnRunAndStop.TabIndex = 2;
            this.BtnRunAndStop.Text = "automatisches Entfernen der \"temp.rec\" aktivieren";
            this.BtnRunAndStop.UseVisualStyleBackColor = false;
            this.BtnRunAndStop.Click += new System.EventHandler(this.BtnRunAndStop_Click);
            // 
            // LblHowTo_Line1
            // 
            this.LblHowTo_Line1.AutoSize = true;
            this.LblHowTo_Line1.Location = new System.Drawing.Point(12, 48);
            this.LblHowTo_Line1.Name = "LblHowTo_Line1";
            this.LblHowTo_Line1.Size = new System.Drawing.Size(456, 13);
            this.LblHowTo_Line1.TabIndex = 3;
            this.LblHowTo_Line1.Text = "Klicken Sie einfach auf den Knopf unten, um diese oben beschriebene Automatik zu " +
    "aktivieren.";
            // 
            // LblHowTo_Line2
            // 
            this.LblHowTo_Line2.AutoSize = true;
            this.LblHowTo_Line2.Location = new System.Drawing.Point(12, 61);
            this.LblHowTo_Line2.Name = "LblHowTo_Line2";
            this.LblHowTo_Line2.Size = new System.Drawing.Size(363, 13);
            this.LblHowTo_Line2.TabIndex = 4;
            this.LblHowTo_Line2.Text = "Klicken Sie erneut auf diesen Knopf um diese Automatik wieder zu stoppen.";
            // 
            // LblMessage_Line1
            // 
            this.LblMessage_Line1.AutoSize = true;
            this.LblMessage_Line1.ForeColor = System.Drawing.Color.Red;
            this.LblMessage_Line1.Location = new System.Drawing.Point(12, 103);
            this.LblMessage_Line1.Name = "LblMessage_Line1";
            this.LblMessage_Line1.Size = new System.Drawing.Size(96, 13);
            this.LblMessage_Line1.TabIndex = 5;
            this.LblMessage_Line1.Text = "LblMessage_Line1";
            // 
            // TimerRemoveTempRec
            // 
            this.TimerRemoveTempRec.Tick += new System.EventHandler(this.TimerRemoveTempRec_Tick);
            // 
            // LblMessage_Line2
            // 
            this.LblMessage_Line2.AutoSize = true;
            this.LblMessage_Line2.ForeColor = System.Drawing.Color.Red;
            this.LblMessage_Line2.Location = new System.Drawing.Point(12, 116);
            this.LblMessage_Line2.Name = "LblMessage_Line2";
            this.LblMessage_Line2.Size = new System.Drawing.Size(96, 13);
            this.LblMessage_Line2.TabIndex = 6;
            this.LblMessage_Line2.Text = "LblMessage_Line2";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(592, 122);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblVersion.Size = new System.Drawing.Size(42, 13);
            this.LblVersion.TabIndex = 7;
            this.LblVersion.Text = "Version";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 144);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblMessage_Line2);
            this.Controls.Add(this.LblMessage_Line1);
            this.Controls.Add(this.LblHowTo_Line2);
            this.Controls.Add(this.LblHowTo_Line1);
            this.Controls.Add(this.BtnRunAndStop);
            this.Controls.Add(this.LblTitle_Line2);
            this.Controls.Add(this.LblTitle_Line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "automatischer \"temp.rec\"-Entferner für \"Company of Heroes\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle_Line1;
        private System.Windows.Forms.Label LblTitle_Line2;
        private System.Windows.Forms.Button BtnRunAndStop;
        private System.Windows.Forms.Label LblHowTo_Line1;
        private System.Windows.Forms.Label LblHowTo_Line2;
        private System.Windows.Forms.Label LblMessage_Line1;
        private System.Windows.Forms.Timer TimerRemoveTempRec;
        private System.Windows.Forms.Label LblMessage_Line2;
        private System.Windows.Forms.Label LblVersion;
    }
}