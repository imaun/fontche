namespace Fontche
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.lblFontsCount = new Telerik.WinControls.UI.RadLabelElement();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.windowInstallFont = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnAddFont = new Telerik.WinControls.UI.CommandBarButton();
            this.btnRemoveFont = new Telerik.WinControls.UI.CommandBarButton();
            this.btnInstallFonts = new Telerik.WinControls.UI.CommandBarButton();
            this.listInstall = new Telerik.WinControls.UI.RadListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.tabFonts = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.MainPanel = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.FontTestWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.numTestFontSize = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtTestFont = new Telerik.WinControls.UI.RadTextBox();
            this.ddlTestFonts = new Telerik.WinControls.UI.RadDropDownList();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.btnThemeSelect = new Telerik.WinControls.UI.RadSplitButtonElement();
            this.mnuThemeLight = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuThemeDark = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar2 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.windowInstallFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabFonts)).BeginInit();
            this.tabFonts.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.FontTestWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTestFonts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.lblFontsCount,
            this.commandBarSeparator1,
            this.btnThemeSelect});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 387);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(820, 26);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "کل فونت ها :";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Click += new System.EventHandler(this.radLabelElement1_Click);
            // 
            // lblFontsCount
            // 
            this.lblFontsCount.Name = "lblFontsCount";
            this.radStatusStrip1.SetSpring(this.lblFontsCount, false);
            this.lblFontsCount.Text = "";
            this.lblFontsCount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblFontsCount.TextWrap = true;
            // 
            // radDock1
            // 
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.toolTabStrip1);
            this.radDock1.Controls.Add(this.MainContainer);
            this.radDock1.Controls.Add(this.toolTabStrip2);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.MainContainer;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(820, 387);
            this.radDock1.TabIndex = 4;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.windowInstallFont);
            this.toolTabStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 377);
            this.toolTabStrip1.TabIndex = 4;
            this.toolTabStrip1.TabStop = false;
            // 
            // windowInstallFont
            // 
            this.windowInstallFont.Caption = null;
            this.windowInstallFont.Controls.Add(this.radCommandBar1);
            this.windowInstallFont.Controls.Add(this.listInstall);
            this.windowInstallFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.windowInstallFont.Location = new System.Drawing.Point(1, 24);
            this.windowInstallFont.Name = "windowInstallFont";
            this.windowInstallFont.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.windowInstallFont.Size = new System.Drawing.Size(198, 351);
            this.windowInstallFont.Text = "نصب فونت جدید";
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(198, 32);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnAddFont,
            this.btnRemoveFont,
            this.btnInstallFonts});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // btnAddFont
            // 
            this.btnAddFont.DisplayName = "اضافه کردن فونت";
            this.btnAddFont.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddFont.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFont.Image")));
            this.btnAddFont.Name = "btnAddFont";
            this.btnAddFont.Text = "اضافه کردن فونت";
            this.btnAddFont.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFont.Click += new System.EventHandler(this.btnAddFont_Click);
            // 
            // btnRemoveFont
            // 
            this.btnRemoveFont.DisplayName = "commandBarButton1";
            this.btnRemoveFont.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFont.Image")));
            this.btnRemoveFont.Name = "btnRemoveFont";
            this.btnRemoveFont.Text = "حذف فونت از لیست";
            this.btnRemoveFont.Click += new System.EventHandler(this.btnRemoveFont_Click);
            // 
            // btnInstallFonts
            // 
            this.btnInstallFonts.AutoToolTip = true;
            this.btnInstallFonts.DisplayName = "نصب فونت ها";
            this.btnInstallFonts.DrawBackgroundImage = true;
            this.btnInstallFonts.DrawImage = true;
            this.btnInstallFonts.DrawText = true;
            this.btnInstallFonts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInstallFonts.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallFonts.Image")));
            this.btnInstallFonts.Name = "btnInstallFonts";
            this.btnInstallFonts.Text = "نصب";
            this.btnInstallFonts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstallFonts.ToolTipText = "نصب";
            this.btnInstallFonts.Click += new System.EventHandler(this.btnInstallFonts_Click);
            // 
            // listInstall
            // 
            this.listInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInstall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listInstall.FullRowSelect = false;
            this.listInstall.ImageList = this.imageList1;
            this.listInstall.ItemSize = new System.Drawing.Size(64, 64);
            this.listInstall.Location = new System.Drawing.Point(0, 33);
            this.listInstall.MultiSelect = true;
            this.listInstall.Name = "listInstall";
            this.listInstall.Size = new System.Drawing.Size(198, 319);
            this.listInstall.SmallImageList = this.imageList1;
            this.listInstall.TabIndex = 0;
            this.listInstall.Text = "radListView1";
            this.listInstall.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.listInstall.SelectedItemChanged += new System.EventHandler(this.listInstall_SelectedItemChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Font_Install.png");
            // 
            // MainContainer
            // 
            this.MainContainer.CausesValidation = false;
            this.MainContainer.Controls.Add(this.tabFonts);
            this.MainContainer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainContainer.Name = "MainContainer";
            // 
            // 
            // 
            this.MainContainer.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.MainContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.MainContainer.TabIndex = 5;
            // 
            // tabFonts
            // 
            this.tabFonts.CanUpdateChildIndex = true;
            this.tabFonts.CausesValidation = false;
            this.tabFonts.Controls.Add(this.MainPanel);
            this.tabFonts.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabFonts.Location = new System.Drawing.Point(0, 0);
            this.tabFonts.Name = "tabFonts";
            // 
            // 
            // 
            this.tabFonts.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.tabFonts.SelectedIndex = 0;
            this.tabFonts.Size = new System.Drawing.Size(402, 377);
            this.tabFonts.TabIndex = 0;
            this.tabFonts.TabStop = false;
            this.tabFonts.TabStripVisible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.radCommandBar2);
            this.MainPanel.Controls.Add(this.gridView);
            this.MainPanel.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MainPanel.Location = new System.Drawing.Point(6, 6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.MainPanel.Size = new System.Drawing.Size(390, 365);
            this.MainPanel.Text = "فونت ها";
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeRows = true;
            this.gridView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView.Location = new System.Drawing.Point(-3, 43);
            // 
            // 
            // 
            this.gridView.MasterTemplate.AllowAddNewRow = false;
            this.gridView.MasterTemplate.AllowCellContextMenu = false;
            this.gridView.MasterTemplate.AllowDeleteRow = false;
            this.gridView.MasterTemplate.AllowDragToGroup = false;
            this.gridView.MasterTemplate.AllowEditRow = false;
            this.gridView.MasterTemplate.AllowSearchRow = true;
            this.gridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "فونت";
            gridViewTextBoxColumn1.IsPinned = true;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left;
            gridViewTextBoxColumn1.Width = 177;
            gridViewTextBoxColumn2.FieldName = "EnglishSample";
            gridViewTextBoxColumn2.HeaderText = "نمونه لاتین";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 99;
            gridViewTextBoxColumn3.FieldName = "PersianSample";
            gridViewTextBoxColumn3.HeaderText = "نمونه فارسی";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 99;
            this.gridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(393, 326);
            this.gridView.TabIndex = 4;
            this.gridView.Text = "لیست فونت ها";
            this.gridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseDown);
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Controls.Add(this.FontTestWindow);
            this.toolTabStrip2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolTabStrip2.Location = new System.Drawing.Point(615, 5);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(200, 377);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // FontTestWindow
            // 
            this.FontTestWindow.AutoScroll = true;
            this.FontTestWindow.Caption = "تست فونت";
            this.FontTestWindow.Controls.Add(this.numTestFontSize);
            this.FontTestWindow.Controls.Add(this.txtTestFont);
            this.FontTestWindow.Controls.Add(this.ddlTestFonts);
            this.FontTestWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.FontTestWindow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FontTestWindow.Location = new System.Drawing.Point(1, 24);
            this.FontTestWindow.Name = "FontTestWindow";
            this.FontTestWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.FontTestWindow.Size = new System.Drawing.Size(198, 351);
            this.FontTestWindow.Text = "تست فونت";
            // 
            // numTestFontSize
            // 
            this.numTestFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTestFontSize.Location = new System.Drawing.Point(6, 13);
            this.numTestFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numTestFontSize.Name = "numTestFontSize";
            this.numTestFontSize.Size = new System.Drawing.Size(43, 20);
            this.numTestFontSize.TabIndex = 4;
            this.numTestFontSize.TabStop = false;
            this.numTestFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTestFontSize.ValueChanged += new System.EventHandler(this.numTestFontSize_ValueChanged);
            // 
            // txtTestFont
            // 
            this.txtTestFont.AcceptsReturn = true;
            this.txtTestFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestFont.AutoSize = false;
            this.txtTestFont.Location = new System.Drawing.Point(3, 40);
            this.txtTestFont.Multiline = true;
            this.txtTestFont.Name = "txtTestFont";
            this.txtTestFont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTestFont.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTestFont.Size = new System.Drawing.Size(192, 298);
            this.txtTestFont.TabIndex = 3;
            this.txtTestFont.Text = "Fuck This Shit\r\nفاک یو مهدی فاکینگ رضایی\r\n\r\n";
            this.txtTestFont.ThemeName = "Desert";
            // 
            // ddlTestFonts
            // 
            this.ddlTestFonts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTestFonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlTestFonts.DropDownHeight = 200;
            this.ddlTestFonts.EnableAlternatingItemColor = true;
            this.ddlTestFonts.Location = new System.Drawing.Point(55, 14);
            this.ddlTestFonts.Name = "ddlTestFonts";
            this.ddlTestFonts.NullText = "فونت را انتخاب کنید...";
            this.ddlTestFonts.Size = new System.Drawing.Size(141, 20);
            this.ddlTestFonts.TabIndex = 1;
            this.ddlTestFonts.ThemeName = "Desert";
            this.ddlTestFonts.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlTestFonts_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlTestFonts.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlTestFonts.GetChildAt(0))).Shape = null;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Text = "";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // btnThemeSelect
            // 
            this.btnThemeSelect.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.btnThemeSelect.DefaultItem = null;
            this.btnThemeSelect.DropDownDirection = Telerik.WinControls.UI.RadDirection.Up;
            this.btnThemeSelect.ExpandArrowButton = false;
            this.btnThemeSelect.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuThemeLight,
            this.mnuThemeDark});
            this.btnThemeSelect.Name = "btnThemeSelect";
            this.radStatusStrip1.SetSpring(this.btnThemeSelect, false);
            this.btnThemeSelect.Text = "ظاهر برنامه";
            this.btnThemeSelect.DefaultItemChanged += new System.EventHandler(this.btnThemeSelect_DefaultItemChanged);
            this.btnThemeSelect.Click += new System.EventHandler(this.btnThemeSelect_Click);
            this.btnThemeSelect.ChildrenChanged += new Telerik.WinControls.ChildrenChangedEventHandler(this.btnThemeSelect_ChildrenChanged);
            // 
            // mnuThemeLight
            // 
            this.mnuThemeLight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mnuThemeLight.Name = "mnuThemeLight";
            this.mnuThemeLight.Text = "ظاهر روشن";
            // 
            // mnuThemeDark
            // 
            this.mnuThemeDark.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mnuThemeDark.IsChecked = true;
            this.mnuThemeDark.Name = "mnuThemeDark";
            this.mnuThemeDark.Text = "ظاهر تیره";
            this.mnuThemeDark.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCommandBar2
            // 
            this.radCommandBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar2.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar2.Name = "radCommandBar2";
            this.radCommandBar2.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2});
            this.radCommandBar2.Size = new System.Drawing.Size(390, 30);
            this.radCommandBar2.TabIndex = 5;
            this.radCommandBar2.Text = "radCommandBar2";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton1.Image")));
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "commandBarButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 413);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radStatusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فونتچی";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.windowInstallFont.ResumeLayout(false);
            this.windowInstallFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabFonts)).EndInit();
            this.tabFonts.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.FontTestWindow.ResumeLayout(false);
            this.FontTestWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTestFonts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement lblFontsCount;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow MainPanel;
        private Telerik.WinControls.UI.Docking.DocumentContainer MainContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip tabFonts;
        private Telerik.WinControls.UI.Docking.ToolWindow FontTestWindow;
        private Telerik.WinControls.UI.RadGridView gridView;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.RadDropDownList ddlTestFonts;
        private Telerik.WinControls.UI.RadTextBox txtTestFont;
        private Telerik.WinControls.UI.RadSpinEditor numTestFontSize;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.Docking.ToolWindow windowInstallFont;
        private Telerik.WinControls.UI.RadListView listInstall;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnAddFont;
        private Telerik.WinControls.UI.CommandBarButton btnRemoveFont;
        private Telerik.WinControls.UI.CommandBarButton btnInstallFonts;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadSplitButtonElement btnThemeSelect;
        private Telerik.WinControls.UI.RadMenuItem mnuThemeLight;
        private Telerik.WinControls.UI.RadMenuItem mnuThemeDark;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar2;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
    }
}
