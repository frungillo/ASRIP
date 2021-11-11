namespace ASRIP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtUtenteSel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.approvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rifiutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichiestetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaricaVariazioni = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.grigliaRichieste = new System.Windows.Forms.DataGridView();
            this.bnCOMANDI = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.btnMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.btnMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnABILITAZIONI = new System.Windows.Forms.ToolStripButton();
            this.btn_STAMPA_DATI = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtRicerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pbLogo_Wait = new System.Windows.Forms.PictureBox();
            this.btnCestino = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.btnStampa = new System.Windows.Forms.Button();
            this.txtUtenteSel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RichiestetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApprovaTutte = new System.Windows.Forms.Button();
            this.btnNegaTutte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
=======
            this.lblINFO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.variazioniRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAllineaDB = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCOMANDI)).BeginInit();
            this.bnCOMANDI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Wait)).BeginInit();
            this.menuStrip1.SuspendLayout();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUtenteSel,
            this.toolStripSeparator1,
            this.approvaToolStripMenuItem,
            this.rifiutaToolStripMenuItem,
            this.attesaToolStripMenuItem,
            this.RichiestetoolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(261, 126);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // txtUtenteSel
            // 
            this.txtUtenteSel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtenteSel.Name = "txtUtenteSel";
            this.txtUtenteSel.ReadOnly = true;
            this.txtUtenteSel.Size = new System.Drawing.Size(200, 26);
            this.txtUtenteSel.Text = "Utente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // approvaToolStripMenuItem
            // 
            this.approvaToolStripMenuItem.Name = "approvaToolStripMenuItem";
            this.approvaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.approvaToolStripMenuItem.Text = "Approva";
            // 
            // rifiutaToolStripMenuItem
            // 
            this.rifiutaToolStripMenuItem.Name = "rifiutaToolStripMenuItem";
            this.rifiutaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.rifiutaToolStripMenuItem.Text = "Rifiuta";
            // 
            // attesaToolStripMenuItem
            // 
            this.attesaToolStripMenuItem.Name = "attesaToolStripMenuItem";
            this.attesaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.attesaToolStripMenuItem.Text = "Attesa";
            // 
            // RichiestetoolStripMenuItem1
            // 
            this.RichiestetoolStripMenuItem1.Name = "RichiestetoolStripMenuItem1";
            this.RichiestetoolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.RichiestetoolStripMenuItem1.Text = "Info Richieste";
            // 
            // btnCaricaVariazioni
            // 
            this.btnCaricaVariazioni.BackColor = System.Drawing.Color.IndianRed;
            this.btnCaricaVariazioni.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaVariazioni.Location = new System.Drawing.Point(485, 32);
            this.btnCaricaVariazioni.Name = "btnCaricaVariazioni";
            this.btnCaricaVariazioni.Size = new System.Drawing.Size(138, 33);
            this.btnCaricaVariazioni.TabIndex = 15;
            this.btnCaricaVariazioni.Text = "Carica in BDROP";
            this.btnCaricaVariazioni.UseVisualStyleBackColor = false;
            this.btnCaricaVariazioni.Click += new System.EventHandler(this.btnCaricaVariazioni_Click);
            // 
            // txtData
            // 
            this.txtData.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(3, 78);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(144, 30);
            this.txtData.TabIndex = 10;
            this.txtData.ValueChanged += new System.EventHandler(this.TxtData_ValueChanged);
            // 
            // grigliaRichieste
            // 
            this.grigliaRichieste.AllowUserToAddRows = false;
            this.grigliaRichieste.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grigliaRichieste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grigliaRichieste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grigliaRichieste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaRichieste.ContextMenuStrip = this.contextMenu;
            this.grigliaRichieste.Location = new System.Drawing.Point(3, 114);
            this.grigliaRichieste.MultiSelect = false;
            this.grigliaRichieste.Name = "grigliaRichieste";
            this.grigliaRichieste.ReadOnly = true;
            this.grigliaRichieste.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grigliaRichieste.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grigliaRichieste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaRichieste.Size = new System.Drawing.Size(1247, 604);
            this.grigliaRichieste.TabIndex = 8;
            // 
            // bnCOMANDI
            // 
            this.bnCOMANDI.AddNewItem = null;
            this.bnCOMANDI.AutoSize = false;
            this.bnCOMANDI.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bnCOMANDI.CountItem = this.bindingNavigatorCountItem;
            this.bnCOMANDI.DeleteItem = null;
            this.bnCOMANDI.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCOMANDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveFirstItem,
            this.btnMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.btnMoveNextItem,
            this.btnMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator2,
            this.btnABILITAZIONI,
            this.btn_STAMPA_DATI,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.txtRicerca,
            this.toolStripSeparator5,
            this.toolStripSeparator6});
            this.bnCOMANDI.Location = new System.Drawing.Point(0, 24);
            this.bnCOMANDI.MoveFirstItem = this.btnMoveFirstItem;
            this.bnCOMANDI.MoveLastItem = this.btnMoveLastItem;
            this.bnCOMANDI.MoveNextItem = this.btnMoveNextItem;
            this.bnCOMANDI.MovePreviousItem = this.btnMovePreviousItem;
            this.bnCOMANDI.Name = "bnCOMANDI";
            this.bnCOMANDI.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCOMANDI.Size = new System.Drawing.Size(1254, 51);
            this.bnCOMANDI.TabIndex = 131;
            this.bnCOMANDI.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(63, 48);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // btnMoveFirstItem
            // 
            this.btnMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirstItem.Image")));
            this.btnMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveFirstItem.Name = "btnMoveFirstItem";
            this.btnMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.btnMoveFirstItem.Size = new System.Drawing.Size(36, 48);
            this.btnMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // btnMovePreviousItem
            // 
            this.btnMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePreviousItem.Image")));
            this.btnMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMovePreviousItem.Name = "btnMovePreviousItem";
            this.btnMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.btnMovePreviousItem.Size = new System.Drawing.Size(36, 48);
            this.btnMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // btnMoveNextItem
            // 
            this.btnMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNextItem.Image")));
            this.btnMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveNextItem.Name = "btnMoveNextItem";
            this.btnMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.btnMoveNextItem.Size = new System.Drawing.Size(36, 48);
            this.btnMoveNextItem.Text = "Sposta avanti";
            // 
            // btnMoveLastItem
            // 
            this.btnMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveLastItem.Image")));
            this.btnMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveLastItem.Name = "btnMoveLastItem";
            this.btnMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.btnMoveLastItem.Size = new System.Drawing.Size(36, 48);
            this.btnMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // btnABILITAZIONI
            // 
            this.btnABILITAZIONI.AutoSize = false;
            this.btnABILITAZIONI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnABILITAZIONI.Image = ((System.Drawing.Image)(resources.GetObject("btnABILITAZIONI.Image")));
            this.btnABILITAZIONI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnABILITAZIONI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnABILITAZIONI.Name = "btnABILITAZIONI";
            this.btnABILITAZIONI.Size = new System.Drawing.Size(40, 40);
            this.btnABILITAZIONI.ToolTipText = "Gestione abilitazioni utenti(F2)";
            this.btnABILITAZIONI.Click += new System.EventHandler(this.btnVARIAZIONI_USERLIST_Click);
            // 
            // btn_STAMPA_DATI
            // 
            this.btn_STAMPA_DATI.AutoSize = false;
            this.btn_STAMPA_DATI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_STAMPA_DATI.Image = ((System.Drawing.Image)(resources.GetObject("btn_STAMPA_DATI.Image")));
            this.btn_STAMPA_DATI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_STAMPA_DATI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_STAMPA_DATI.Name = "btn_STAMPA_DATI";
            this.btn_STAMPA_DATI.Size = new System.Drawing.Size(40, 40);
            this.btn_STAMPA_DATI.ToolTipText = "Stampa dati(F7)";
            this.btn_STAMPA_DATI.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(261, 48);
            this.toolStripLabel2.Text = "toolStripLabel2jsdghsjkgguuu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 48);
            this.toolStripLabel1.Text = "Ricerca";
            // 
            // txtRicerca
            // 
            this.txtRicerca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(300, 51);
            this.txtRicerca.TextChanged += new System.EventHandler(this.TxtRicerca_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator6
            // 
<<<<<<< Updated upstream
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.btnNegaTutte);
            this.panel3.Controls.Add(this.btnApprovaTutte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 34);
            this.panel3.TabIndex = 2;
=======
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 51);
            // 
            // pbLogo_Wait
            // 
            this.pbLogo_Wait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo_Wait.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbLogo_Wait.Image = global::ASRIP.Properties.Resources.NewLogoANM;
            this.pbLogo_Wait.Location = new System.Drawing.Point(1118, 24);
            this.pbLogo_Wait.Name = "pbLogo_Wait";
            this.pbLogo_Wait.Size = new System.Drawing.Size(132, 51);
            this.pbLogo_Wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo_Wait.TabIndex = 156;
            this.pbLogo_Wait.TabStop = false;
            // 
            // btnCestino
            // 
            this.btnCestino.BackColor = System.Drawing.Color.LightGreen;
            this.btnCestino.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCestino.Location = new System.Drawing.Point(379, 32);
            this.btnCestino.Name = "btnCestino";
            this.btnCestino.Size = new System.Drawing.Size(100, 33);
            this.btnCestino.TabIndex = 13;
            this.btnCestino.Text = "Cestino";
            this.btnCestino.UseVisualStyleBackColor = false;
            this.btnCestino.Click += new System.EventHandler(this.BtnCestino_Click);
            // 
            // lblINFO
            // 
            this.lblINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblINFO.AutoSize = true;
            this.lblINFO.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINFO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblINFO.Location = new System.Drawing.Point(627, 721);
            this.lblINFO.Name = "lblINFO";
            this.lblINFO.Size = new System.Drawing.Size(623, 15);
            this.lblINFO.TabIndex = 157;
            this.lblINFO.Text = "Doppio click oppure click col tasto destro su un record per la gestione delle ric" +
    "hieste.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.variazioniRosterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 158;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEXIT});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEXIT.Image")));
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(93, 22);
            this.btnEXIT.Text = "Exit";
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // variazioniRosterToolStripMenuItem
            // 
            this.variazioniRosterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAllineaDB});
            this.variazioniRosterToolStripMenuItem.Name = "variazioniRosterToolStripMenuItem";
            this.variazioniRosterToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.variazioniRosterToolStripMenuItem.Text = "Variazioni roster";
            // 
            // btnAllineaDB
            // 
            this.btnAllineaDB.Image = ((System.Drawing.Image)(resources.GetObject("btnAllineaDB.Image")));
            this.btnAllineaDB.Name = "btnAllineaDB";
            this.btnAllineaDB.Size = new System.Drawing.Size(160, 22);
            this.btnAllineaDB.Text = "Allinea database";
            this.btnAllineaDB.Click += new System.EventHandler(this.btnAllineaDB_Click);
>>>>>>> Stashed changes
            // 
            // btnApprovaTutte
            // 
            this.btnApprovaTutte.Location = new System.Drawing.Point(7, 6);
            this.btnApprovaTutte.Name = "btnApprovaTutte";
            this.btnApprovaTutte.Size = new System.Drawing.Size(88, 23);
            this.btnApprovaTutte.TabIndex = 0;
            this.btnApprovaTutte.Text = "Approva Tutte";
            this.btnApprovaTutte.UseVisualStyleBackColor = true;
            // 
            // btnNegaTutte
            // 
            this.btnNegaTutte.Location = new System.Drawing.Point(99, 6);
            this.btnNegaTutte.Name = "btnNegaTutte";
            this.btnNegaTutte.Size = new System.Drawing.Size(75, 23);
            this.btnNegaTutte.TabIndex = 1;
            this.btnNegaTutte.Text = "Nega Tutte";
            this.btnNegaTutte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 739);
            this.Controls.Add(this.lblINFO);
            this.Controls.Add(this.pbLogo_Wait);
            this.Controls.Add(this.btnCaricaVariazioni);
            this.Controls.Add(this.btnCestino);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.grigliaRichieste);
            this.Controls.Add(this.bnCOMANDI);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Alterazione Stato RIchieste Perrsonale";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
<<<<<<< Updated upstream
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
=======
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCOMANDI)).EndInit();
            this.bnCOMANDI.ResumeLayout(false);
            this.bnCOMANDI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Wait)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem approvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rifiutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtUtenteSel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RichiestetoolStripMenuItem1;
<<<<<<< Updated upstream
        private System.Windows.Forms.Button btnNegaTutte;
        private System.Windows.Forms.Button btnApprovaTutte;
=======
        private System.Windows.Forms.Button btnCaricaVariazioni;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DataGridView grigliaRichieste;
        private System.Windows.Forms.BindingNavigator bnCOMANDI;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnMoveFirstItem;
        private System.Windows.Forms.ToolStripButton btnMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnMoveNextItem;
        private System.Windows.Forms.ToolStripButton btnMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtRicerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pbLogo_Wait;
        private System.Windows.Forms.ToolStripButton btn_STAMPA_DATI;
        private System.Windows.Forms.Button btnCestino;
        private System.Windows.Forms.ToolStripButton btnABILITAZIONI;
        private System.Windows.Forms.Label lblINFO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEXIT;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem variazioniRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAllineaDB;
>>>>>>> Stashed changes
    }
}

