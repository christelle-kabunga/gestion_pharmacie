namespace mystore.Forms
{
    partial class bienvenu
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
            this.progress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Animated = false;
            this.progress.AnimationInterval = 1;
            this.progress.AnimationSpeed = 1;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.CircleMargin = 10;
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.progress.ForeColor = System.Drawing.Color.White;
            this.progress.IsPercentage = false;
            this.progress.LineProgressThickness = 10;
            this.progress.LineThickness = 10;
            this.progress.Location = new System.Drawing.Point(201, 93);
            this.progress.Name = "progress";
            this.progress.ProgressAnimationSpeed = 200;
            this.progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progress.ProgressColor = System.Drawing.Color.Red;
            this.progress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.progress.Size = new System.Drawing.Size(148, 148);
            this.progress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progress.SubScriptText = ".00";
            this.progress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progress.SuperScriptText = "°C";
            this.progress.TabIndex = 17;
            this.progress.Text = "30";
            this.progress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progress.Value = 30;
            this.progress.ValueByTransition = 30;
            this.progress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "SYSTEME DE GESTION DE LA PHARMACIE\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Version1.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = " DE L\'ISTM BUTEMBO";
            // 
            // bienvenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bienvenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bienvenu";
            this.Load += new System.EventHandler(this.bienvenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuCircleProgress progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}