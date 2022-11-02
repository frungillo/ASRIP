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
            this.txtProtocolloTT = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.approvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rifiutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichiestetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaricaVariazioni = new System.Windows.Forms.Button();
            this.txtDataDa = new System.Windows.Forms.DateTimePicker();
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
            this.btnRicercaAvanzata = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCestino = new System.Windows.Forms.Button();
            this.lblINFO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.variazioniRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAllineaDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ricaricaDatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMostraSoloRichieste = new System.Windows.Forms.CheckBox();
            this.txtDataA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelTutti = new System.Windows.Forms.Button();
            this.btnAttesaSel = new System.Windows.Forms.Button();
            this.btnRifiutaSel = new System.Windows.Forms.Button();
            this.btnApprovaSel = new System.Windows.Forms.Button();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.pbLogo_Wait = new System.Windows.Forms.PictureBox();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCOMANDI)).BeginInit();
            this.bnCOMANDI.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Wait)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUtenteSel,
            this.txtProtocolloTT,
            this.toolStripSeparator1,
            this.approvaToolStripMenuItem,
            this.rifiutaToolStripMenuItem,
            this.attesaToolStripMenuItem,
            this.RichiestetoolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(261, 150);
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
            // txtProtocolloTT
            // 
            this.txtProtocolloTT.BackColor = System.Drawing.SystemColors.Info;
            this.txtProtocolloTT.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtocolloTT.Name = "txtProtocolloTT";
            this.txtProtocolloTT.ReadOnly = true;
            this.txtProtocolloTT.Size = new System.Drawing.Size(200, 22);
            this.txtProtocolloTT.Text = "Protocollo";
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
            this.approvaToolStripMenuItem.Click += new System.EventHandler(this.approvaToolStripMenuItem_Click);
            // 
            // rifiutaToolStripMenuItem
            // 
            this.rifiutaToolStripMenuItem.Name = "rifiutaToolStripMenuItem";
            this.rifiutaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.rifiutaToolStripMenuItem.Text = "Rifiuta";
            this.rifiutaToolStripMenuItem.Click += new System.EventHandler(this.rifiutaToolStripMenuItem_Click);
            // 
            // attesaToolStripMenuItem
            // 
            this.attesaToolStripMenuItem.Name = "attesaToolStripMenuItem";
            this.attesaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.attesaToolStripMenuItem.Text = "Attesa";
            this.attesaToolStripMenuItem.Click += new System.EventHandler(this.attesaToolStripMenuItem_Click);
            // 
            // RichiestetoolStripMenuItem1
            // 
            this.RichiestetoolStripMenuItem1.Name = "RichiestetoolStripMenuItem1";
            this.RichiestetoolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.RichiestetoolStripMenuItem1.Text = "Info Richieste";
            this.RichiestetoolStripMenuItem1.Click += new System.EventHandler(this.RichiestetoolStripMenuItem1_Click);
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
            // txtDataDa
            // 
            this.txtDataDa.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDa.Location = new System.Drawing.Point(79, 78);
            this.txtDataDa.Name = "txtDataDa";
            this.txtDataDa.Size = new System.Drawing.Size(144, 30);
            this.txtDataDa.TabIndex = 1;
            this.txtDataDa.ValueChanged += new System.EventHandler(this.txtDataDa_ValueChanged);
            // 
            // grigliaRichieste
            // 
            this.grigliaRichieste.AllowUserToAddRows = false;
            this.grigliaRichieste.AllowUserToDeleteRows = false;
            this.grigliaRichieste.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            this.grigliaRichieste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grigliaRichieste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grigliaRichieste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaRichieste.ContextMenuStrip = this.contextMenu;
            this.grigliaRichieste.Location = new System.Drawing.Point(3, 151);
            this.grigliaRichieste.MultiSelect = false;
            this.grigliaRichieste.Name = "grigliaRichieste";
            this.grigliaRichieste.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grigliaRichieste.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grigliaRichieste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaRichieste.Size = new System.Drawing.Size(1247, 567);
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
            this.btnRicercaAvanzata,
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
            // btnRicercaAvanzata
            // 
            this.btnRicercaAvanzata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRicercaAvanzata.Image = global::ASRIP.Properties.Resources.list_add;
            this.btnRicercaAvanzata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRicercaAvanzata.Name = "btnRicercaAvanzata";
            this.btnRicercaAvanzata.Size = new System.Drawing.Size(23, 48);
            this.btnRicercaAvanzata.Text = "toolStripButton1";
            this.btnRicercaAvanzata.Click += new System.EventHandler(this.btnRicercaAvanzata_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 51);
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
            this.btnAllineaDB,
            this.ricaricaDatiToolStripMenuItem});
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
            // 
            // ricaricaDatiToolStripMenuItem
            // 
            this.ricaricaDatiToolStripMenuItem.Name = "ricaricaDatiToolStripMenuItem";
            this.ricaricaDatiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ricaricaDatiToolStripMenuItem.Text = "Ricarica dati";
            this.ricaricaDatiToolStripMenuItem.Click += new System.EventHandler(this.ricaricaDatiToolStripMenuItem_Click);
            // 
            // chkMostraSoloRichieste
            // 
            this.chkMostraSoloRichieste.AutoSize = true;
            this.chkMostraSoloRichieste.Location = new System.Drawing.Point(450, 78);
            this.chkMostraSoloRichieste.Name = "chkMostraSoloRichieste";
            this.chkMostraSoloRichieste.Size = new System.Drawing.Size(173, 19);
            this.chkMostraSoloRichieste.TabIndex = 159;
            this.chkMostraSoloRichieste.Text = "Mostra solo richieste";
            this.chkMostraSoloRichieste.UseVisualStyleBackColor = true;
            this.chkMostraSoloRichieste.CheckedChanged += new System.EventHandler(this.chkMostraSoloRichieste_CheckedChanged);
            // 
            // txtDataA
            // 
            this.txtDataA.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataA.Location = new System.Drawing.Point(229, 78);
            this.txtDataA.Name = "txtDataA";
            this.txtDataA.Size = new System.Drawing.Size(144, 30);
            this.txtDataA.TabIndex = 2;
            this.txtDataA.ValueChanged += new System.EventHandler(this.txtDataA_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 162;
            this.label1.Text = "Range Date";
            // 
            // btnSelTutti
            // 
            this.btnSelTutti.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelTutti.Image = global::ASRIP.Properties.Resources.format_list_unordered;
            this.btnSelTutti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelTutti.Location = new System.Drawing.Point(3, 115);
            this.btnSelTutti.Name = "btnSelTutti";
            this.btnSelTutti.Size = new System.Drawing.Size(32, 30);
            this.btnSelTutti.TabIndex = 166;
            this.btnSelTutti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelTutti.UseVisualStyleBackColor = true;
            this.btnSelTutti.Click += new System.EventHandler(this.btnSelTutti_Click);
            // 
            // btnAttesaSel
            // 
            this.btnAttesaSel.Enabled = false;
            this.btnAttesaSel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttesaSel.Image = global::ASRIP.Properties.Resources.flag_yellow;
            this.btnAttesaSel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttesaSel.Location = new System.Drawing.Point(229, 114);
            this.btnAttesaSel.Name = "btnAttesaSel";
            this.btnAttesaSel.Size = new System.Drawing.Size(103, 30);
            this.btnAttesaSel.TabIndex = 165;
            this.btnAttesaSel.Text = "Attesa Sel";
            this.btnAttesaSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttesaSel.UseVisualStyleBackColor = true;
            // 
            // btnRifiutaSel
            // 
            this.btnRifiutaSel.Enabled = false;
            this.btnRifiutaSel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRifiutaSel.Image = global::ASRIP.Properties.Resources.flag_red;
            this.btnRifiutaSel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRifiutaSel.Location = new System.Drawing.Point(338, 114);
            this.btnRifiutaSel.Name = "btnRifiutaSel";
            this.btnRifiutaSel.Size = new System.Drawing.Size(103, 30);
            this.btnRifiutaSel.TabIndex = 164;
            this.btnRifiutaSel.Text = "Nega Sel";
            this.btnRifiutaSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRifiutaSel.UseVisualStyleBackColor = true;
            // 
            // btnApprovaSel
            // 
            this.btnApprovaSel.Enabled = false;
            this.btnApprovaSel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovaSel.Image = global::ASRIP.Properties.Resources.flag_green;
            this.btnApprovaSel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovaSel.Location = new System.Drawing.Point(120, 114);
            this.btnApprovaSel.Name = "btnApprovaSel";
            this.btnApprovaSel.Size = new System.Drawing.Size(103, 30);
            this.btnApprovaSel.TabIndex = 163;
            this.btnApprovaSel.Text = "Approva Sel";
            this.btnApprovaSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApprovaSel.UseVisualStyleBackColor = true;
            this.btnApprovaSel.Click += new System.EventHandler(this.btnApprovaSel_Click);
            // 
            // btnFiltra
            // 
            this.btnFiltra.Image = global::ASRIP.Properties.Resources.system_search;
            this.btnFiltra.Location = new System.Drawing.Point(379, 78);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(46, 30);
            this.btnFiltra.TabIndex = 161;
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 739);
            this.Controls.Add(this.btnSelTutti);
            this.Controls.Add(this.btnAttesaSel);
            this.Controls.Add(this.btnRifiutaSel);
            this.Controls.Add(this.btnApprovaSel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltra);
            this.Controls.Add(this.txtDataA);
            this.Controls.Add(this.chkMostraSoloRichieste);
            this.Controls.Add(this.lblINFO);
            this.Controls.Add(this.pbLogo_Wait);
            this.Controls.Add(this.btnCaricaVariazioni);
            this.Controls.Add(this.btnCestino);
            this.Controls.Add(this.txtDataDa);
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
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCOMANDI)).EndInit();
            this.bnCOMANDI.ResumeLayout(false);
            this.bnCOMANDI.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Wait)).EndInit();
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
        private System.Windows.Forms.Button btnCaricaVariazioni;
        private System.Windows.Forms.DateTimePicker txtDataDa;
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
        private System.Windows.Forms.ToolStripMenuItem ricaricaDatiToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkMostraSoloRichieste;
        private System.Windows.Forms.DateTimePicker txtDataA;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprovaSel;
        private System.Windows.Forms.Button btnRifiutaSel;
        private System.Windows.Forms.Button btnAttesaSel;
        private System.Windows.Forms.Button btnSelTutti;
        private System.Windows.Forms.ToolStripButton btnRicercaAvanzata;
        private System.Windows.Forms.ToolStripTextBox txtProtocolloTT;
    }
}

