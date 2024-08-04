namespace mystore.Forms
{
    partial class form_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelside = new System.Windows.Forms.Panel();
            this.btnvoirvente = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnachArt = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btnvente = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelcontrols = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnma = new System.Windows.Forms.Button();
            this.entree1 = new mystore.UserControls.entree();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelcontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.btnma);
            this.panelLeft.Controls.Add(this.pictureBox2);
            this.panelLeft.Controls.Add(this.panelside);
            this.panelLeft.Controls.Add(this.btnvoirvente);
            this.panelLeft.Controls.Add(this.btnfour);
            this.panelLeft.Controls.Add(this.btnachArt);
            this.panelLeft.Controls.Add(this.btndep);
            this.panelLeft.Controls.Add(this.btnvente);
            this.panelLeft.Controls.Add(this.btnacc);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 653);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 55);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.White;
            this.panelside.Location = new System.Drawing.Point(20, 146);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(7, 60);
            this.panelside.TabIndex = 3;
            // 
            // btnvoirvente
            // 
            this.btnvoirvente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoirvente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoirvente.ForeColor = System.Drawing.Color.White;
            this.btnvoirvente.Image = ((System.Drawing.Image)(resources.GetObject("btnvoirvente.Image")));
            this.btnvoirvente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoirvente.Location = new System.Drawing.Point(23, 530);
            this.btnvoirvente.Name = "btnvoirvente";
            this.btnvoirvente.Size = new System.Drawing.Size(189, 57);
            this.btnvoirvente.TabIndex = 3;
            this.btnvoirvente.Text = "Sortie";
            this.btnvoirvente.UseVisualStyleBackColor = true;
            this.btnvoirvente.Click += new System.EventHandler(this.btnvoirvente_Click);
            // 
            // btnfour
            // 
            this.btnfour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.ForeColor = System.Drawing.Color.White;
            this.btnfour.Image = ((System.Drawing.Image)(resources.GetObject("btnfour.Image")));
            this.btnfour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfour.Location = new System.Drawing.Point(23, 467);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(189, 57);
            this.btnfour.TabIndex = 3;
            this.btnfour.Text = "Fournisseurs\r\n";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnachArt
            // 
            this.btnachArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnachArt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnachArt.ForeColor = System.Drawing.Color.White;
            this.btnachArt.Image = ((System.Drawing.Image)(resources.GetObject("btnachArt.Image")));
            this.btnachArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnachArt.Location = new System.Drawing.Point(26, 275);
            this.btnachArt.Name = "btnachArt";
            this.btnachArt.Size = new System.Drawing.Size(189, 57);
            this.btnachArt.TabIndex = 3;
            this.btnachArt.Text = "Medicaments";
            this.btnachArt.UseVisualStyleBackColor = true;
            this.btnachArt.Click += new System.EventHandler(this.btnachArt_Click);
            // 
            // btndep
            // 
            this.btndep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.ForeColor = System.Drawing.Color.White;
            this.btndep.Image = ((System.Drawing.Image)(resources.GetObject("btndep.Image")));
            this.btndep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndep.Location = new System.Drawing.Point(26, 211);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(189, 57);
            this.btndep.TabIndex = 3;
            this.btndep.Text = "Categories";
            this.btndep.UseVisualStyleBackColor = true;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnvente
            // 
            this.btnvente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvente.ForeColor = System.Drawing.Color.White;
            this.btnvente.Image = ((System.Drawing.Image)(resources.GetObject("btnvente.Image")));
            this.btnvente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvente.Location = new System.Drawing.Point(26, 338);
            this.btnvente.Name = "btnvente";
            this.btnvente.Size = new System.Drawing.Size(189, 57);
            this.btnvente.TabIndex = 3;
            this.btnvente.Text = "AchatMedocs";
            this.btnvente.UseVisualStyleBackColor = true;
            this.btnvente.Click += new System.EventHandler(this.btnvente_Click);
            // 
            // btnacc
            // 
            this.btnacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacc.ForeColor = System.Drawing.Color.White;
            this.btnacc.Image = ((System.Drawing.Image)(resources.GetObject("btnacc.Image")));
            this.btnacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacc.Location = new System.Drawing.Point(26, 146);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(189, 57);
            this.btnacc.TabIndex = 3;
            this.btnacc.Text = "Accueil";
            this.btnacc.UseVisualStyleBackColor = true;
            this.btnacc.Click += new System.EventHandler(this.btnacc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 140);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion Pharmacie";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(171, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 32);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 44);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.label3.Location = new System.Drawing.Point(25, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gestion Pharmacie de L\'ISTM";
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(940, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 44);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.labeltime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 53);
            this.panel4.TabIndex = 2;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.White;
            this.labeltime.Location = new System.Drawing.Point(796, 19);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(83, 19);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "HH:MM:SS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelcontrols
            // 
            this.panelcontrols.Controls.Add(this.entree1);
            this.panelcontrols.Controls.Add(this.panel1);
            this.panelcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontrols.Location = new System.Drawing.Point(215, 97);
            this.panelcontrols.Name = "panelcontrols";
            this.panelcontrols.Size = new System.Drawing.Size(985, 623);
            this.panelcontrols.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.TabIndex = 2;
            // 
            // btnma
            // 
            this.btnma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnma.ForeColor = System.Drawing.Color.White;
            this.btnma.Image = ((System.Drawing.Image)(resources.GetObject("btnma.Image")));
            this.btnma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnma.Location = new System.Drawing.Point(26, 404);
            this.btnma.Name = "btnma";
            this.btnma.Size = new System.Drawing.Size(189, 57);
            this.btnma.TabIndex = 5;
            this.btnma.Text = "Malades";
            this.btnma.UseVisualStyleBackColor = true;
            this.btnma.Click += new System.EventHandler(this.btnma_Click_1);
            // 
            // entree1
            // 
            this.entree1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.entree1.Location = new System.Drawing.Point(510, 204);
            this.entree1.Name = "entree1";
            this.entree1.Size = new System.Drawing.Size(8, 8);
            this.entree1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deconnexion";
            // 
            // form_dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelcontrols);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_dashboard";
            this.Text = "form_dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelcontrols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnacc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnvente;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnvoirvente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnachArt;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelcontrols;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnfour;
        private UserControls.entree entree1;
        private System.Windows.Forms.Button btnma;
        private System.Windows.Forms.Label label1;
    }
}