namespace mystore.UserControls
{
    partial class entree
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entree));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.prixmed = new Bunifu.UI.WinForms.BunifuTextBox();
            this.qtemed = new Bunifu.UI.WinForms.BunifuTextBox();
            this.catmed = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataent = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.catfour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmed = new System.Windows.Forms.Label();
            this.lblfour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datefab = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateexp = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combo = new System.Windows.Forms.ComboBox();
            this.lab = new System.Windows.Forms.Label();
            this.lama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicaments Entrés";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prixmed
            // 
            this.prixmed.AcceptsReturn = false;
            this.prixmed.AcceptsTab = false;
            this.prixmed.AnimationSpeed = 200;
            this.prixmed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.prixmed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.prixmed.BackColor = System.Drawing.Color.Transparent;
            this.prixmed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prixmed.BackgroundImage")));
            this.prixmed.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.prixmed.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.prixmed.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.prixmed.BorderColorIdle = System.Drawing.Color.Silver;
            this.prixmed.BorderRadius = 1;
            this.prixmed.BorderThickness = 1;
            this.prixmed.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prixmed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixmed.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixmed.DefaultText = "";
            this.prixmed.FillColor = System.Drawing.Color.White;
            this.prixmed.HideSelection = true;
            this.prixmed.IconLeft = null;
            this.prixmed.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.prixmed.IconPadding = 10;
            this.prixmed.IconRight = null;
            this.prixmed.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.prixmed.Lines = new string[0];
            this.prixmed.Location = new System.Drawing.Point(31, 248);
            this.prixmed.MaxLength = 32767;
            this.prixmed.MinimumSize = new System.Drawing.Size(1, 1);
            this.prixmed.Modified = false;
            this.prixmed.Multiline = false;
            this.prixmed.Name = "prixmed";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.prixmed.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.prixmed.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.prixmed.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.prixmed.OnIdleState = stateProperties4;
            this.prixmed.Padding = new System.Windows.Forms.Padding(3);
            this.prixmed.PasswordChar = '\0';
            this.prixmed.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.prixmed.PlaceholderText = "Entrer le prix en $";
            this.prixmed.ReadOnly = false;
            this.prixmed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prixmed.SelectedText = "";
            this.prixmed.SelectionLength = 0;
            this.prixmed.SelectionStart = 0;
            this.prixmed.ShortcutsEnabled = true;
            this.prixmed.Size = new System.Drawing.Size(272, 40);
            this.prixmed.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.prixmed.TabIndex = 1;
            this.prixmed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prixmed.TextMarginBottom = 0;
            this.prixmed.TextMarginLeft = 3;
            this.prixmed.TextMarginTop = 0;
            this.prixmed.TextPlaceholder = "Entrer le prix en $";
            this.prixmed.UseSystemPasswordChar = false;
            this.prixmed.WordWrap = true;
            // 
            // qtemed
            // 
            this.qtemed.AcceptsReturn = false;
            this.qtemed.AcceptsTab = false;
            this.qtemed.AnimationSpeed = 200;
            this.qtemed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.qtemed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.qtemed.BackColor = System.Drawing.Color.Transparent;
            this.qtemed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("qtemed.BackgroundImage")));
            this.qtemed.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.qtemed.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.qtemed.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.qtemed.BorderColorIdle = System.Drawing.Color.Silver;
            this.qtemed.BorderRadius = 1;
            this.qtemed.BorderThickness = 1;
            this.qtemed.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.qtemed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtemed.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtemed.DefaultText = "";
            this.qtemed.FillColor = System.Drawing.Color.White;
            this.qtemed.HideSelection = true;
            this.qtemed.IconLeft = null;
            this.qtemed.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.qtemed.IconPadding = 10;
            this.qtemed.IconRight = null;
            this.qtemed.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.qtemed.Lines = new string[0];
            this.qtemed.Location = new System.Drawing.Point(30, 314);
            this.qtemed.MaxLength = 32767;
            this.qtemed.MinimumSize = new System.Drawing.Size(1, 1);
            this.qtemed.Modified = false;
            this.qtemed.Multiline = false;
            this.qtemed.Name = "qtemed";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.qtemed.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.qtemed.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.qtemed.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.qtemed.OnIdleState = stateProperties8;
            this.qtemed.Padding = new System.Windows.Forms.Padding(3);
            this.qtemed.PasswordChar = '\0';
            this.qtemed.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.qtemed.PlaceholderText = "Entrer le Quantité";
            this.qtemed.ReadOnly = false;
            this.qtemed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qtemed.SelectedText = "";
            this.qtemed.SelectionLength = 0;
            this.qtemed.SelectionStart = 0;
            this.qtemed.ShortcutsEnabled = true;
            this.qtemed.Size = new System.Drawing.Size(272, 40);
            this.qtemed.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.qtemed.TabIndex = 1;
            this.qtemed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qtemed.TextMarginBottom = 0;
            this.qtemed.TextMarginLeft = 3;
            this.qtemed.TextMarginTop = 0;
            this.qtemed.TextPlaceholder = "Entrer le Quantité";
            this.qtemed.UseSystemPasswordChar = false;
            this.qtemed.WordWrap = true;
            // 
            // catmed
            // 
            this.catmed.FormattingEnabled = true;
            this.catmed.Location = new System.Drawing.Point(31, 124);
            this.catmed.Name = "catmed";
            this.catmed.Size = new System.Drawing.Size(271, 29);
            this.catmed.TabIndex = 2;
            this.catmed.SelectedIndexChanged += new System.EventHandler(this.catmed_SelectedIndexChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Ajouter";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 25;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(25, 512);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(98, 41);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dataent
            // 
            this.dataent.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataent.BackgroundColor = System.Drawing.Color.White;
            this.dataent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataent.ColumnHeadersHeight = 40;
            this.dataent.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataent.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataent.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataent.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataent.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataent.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataent.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataent.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataent.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataent.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataent.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataent.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataent.CurrentTheme.Name = null;
            this.dataent.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataent.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataent.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataent.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataent.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataent.EnableHeadersVisualStyles = false;
            this.dataent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataent.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataent.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataent.HeaderForeColor = System.Drawing.Color.White;
            this.dataent.Location = new System.Drawing.Point(363, 96);
            this.dataent.Name = "dataent";
            this.dataent.RowHeadersVisible = false;
            this.dataent.RowTemplate.Height = 40;
            this.dataent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataent.Size = new System.Drawing.Size(700, 494);
            this.dataent.TabIndex = 5;
            this.dataent.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamed_CellContentClick);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Modifier";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 25;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(133, 512);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(98, 41);
            this.bunifuThinButton22.TabIndex = 4;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Supprimer";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 25;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(241, 512);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(98, 41);
            this.bunifuThinButton23.TabIndex = 4;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock";
            // 
            // catfour
            // 
            this.catfour.FormattingEnabled = true;
            this.catfour.Location = new System.Drawing.Point(31, 182);
            this.catfour.Name = "catfour";
            this.catfour.Size = new System.Drawing.Size(272, 29);
            this.catfour.TabIndex = 2;
            this.catfour.SelectedIndexChanged += new System.EventHandler(this.catfour_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medicament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fournisseur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Fabrication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date Expiration";
            // 
            // lblmed
            // 
            this.lblmed.AutoSize = true;
            this.lblmed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmed.Location = new System.Drawing.Point(329, 130);
            this.lblmed.Name = "lblmed";
            this.lblmed.Size = new System.Drawing.Size(28, 23);
            this.lblmed.TabIndex = 0;
            this.lblmed.Text = "m";
            // 
            // lblfour
            // 
            this.lblfour.AutoSize = true;
            this.lblfour.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfour.Location = new System.Drawing.Point(329, 183);
            this.lblfour.Name = "lblfour";
            this.lblfour.Size = new System.Drawing.Size(28, 23);
            this.lblfour.TabIndex = 0;
            this.lblfour.Text = "m";
            this.lblfour.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prix en $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantité";
            // 
            // datefab
            // 
            this.datefab.BackColor = System.Drawing.Color.Transparent;
            this.datefab.BorderRadius = 1;
            this.datefab.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.datefab.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.datefab.Color = System.Drawing.Color.DodgerBlue;
            this.datefab.CustomFormat = "yyyy-MM-dd";
            this.datefab.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datefab.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datefab.DisabledColor = System.Drawing.Color.Gray;
            this.datefab.DisplayWeekNumbers = false;
            this.datefab.DPHeight = 0;
            this.datefab.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datefab.FillDatePicker = false;
            this.datefab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datefab.ForeColor = System.Drawing.Color.Black;
            this.datefab.Icon = ((System.Drawing.Image)(resources.GetObject("datefab.Icon")));
            this.datefab.IconColor = System.Drawing.Color.Gray;
            this.datefab.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datefab.LeftTextMargin = 5;
            this.datefab.Location = new System.Drawing.Point(39, 393);
            this.datefab.MinimumSize = new System.Drawing.Size(0, 32);
            this.datefab.Name = "datefab";
            this.datefab.Size = new System.Drawing.Size(263, 32);
            this.datefab.TabIndex = 6;
            // 
            // dateexp
            // 
            this.dateexp.BackColor = System.Drawing.Color.Transparent;
            this.dateexp.BorderRadius = 1;
            this.dateexp.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.dateexp.Color = System.Drawing.Color.DodgerBlue;
            this.dateexp.CustomFormat = "yyyy-MM-dd";
            this.dateexp.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateexp.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateexp.DisabledColor = System.Drawing.Color.Gray;
            this.dateexp.DisplayWeekNumbers = false;
            this.dateexp.DPHeight = 0;
            this.dateexp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateexp.FillDatePicker = false;
            this.dateexp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateexp.ForeColor = System.Drawing.Color.Black;
            this.dateexp.Icon = ((System.Drawing.Image)(resources.GetObject("dateexp.Icon")));
            this.dateexp.IconColor = System.Drawing.Color.Gray;
            this.dateexp.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateexp.LeftTextMargin = 5;
            this.dateexp.Location = new System.Drawing.Point(38, 454);
            this.dateexp.MinimumSize = new System.Drawing.Size(0, 32);
            this.dateexp.Name = "dateexp";
            this.dateexp.Size = new System.Drawing.Size(264, 32);
            this.dateexp.TabIndex = 6;
            this.dateexp.ValueChanged += new System.EventHandler(this.bunifuDatePicker2_ValueChanged);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Rafraichir";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(755, 56);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(152, 41);
            this.bunifuThinButton24.TabIndex = 50;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Recherche";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Location = new System.Drawing.Point(613, 56);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(132, 41);
            this.bunifuThinButton25.TabIndex = 49;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(407, 62);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(198, 29);
            this.combo.TabIndex = 48;
            this.combo.Text = "select";
            this.combo.SelectedIndexChanged += new System.EventHandler(this.comboser_SelectedIndexChanged);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(303, 274);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(14, 21);
            this.lab.TabIndex = 51;
            this.lab.Text = ".";
            // 
            // lama
            // 
            this.lama.AutoSize = true;
            this.lama.Location = new System.Drawing.Point(307, 56);
            this.lama.Name = "lama";
            this.lama.Size = new System.Drawing.Size(57, 21);
            this.lama.TabIndex = 52;
            this.lama.Text = "label9";
            // 
            // entree
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lama);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.dateexp);
            this.Controls.Add(this.datefab);
            this.Controls.Add(this.dataent);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.catfour);
            this.Controls.Add(this.catmed);
            this.Controls.Add(this.qtemed);
            this.Controls.Add(this.prixmed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfour);
            this.Controls.Add(this.lblmed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(95)))));
            this.Name = "entree";
            this.Size = new System.Drawing.Size(1105, 623);
            this.Load += new System.EventHandler(this.entree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox prixmed;
        private Bunifu.UI.WinForms.BunifuTextBox qtemed;
        private System.Windows.Forms.ComboBox catmed;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.UI.WinForms.BunifuDataGridView dataent;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox catfour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmed;
        private System.Windows.Forms.Label lblfour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDatePicker datefab;
        private Bunifu.UI.WinForms.BunifuDatePicker dateexp;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lama;
    }
}
