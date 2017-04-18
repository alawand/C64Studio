﻿namespace C64Studio
{
  partial class SpriteEditor
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      GR.Image.FastImage fastImage10 = new GR.Image.FastImage();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteEditor));
      GR.Image.FastImage fastImage9 = new GR.Image.FastImage();
      this.tabSpriteEditor = new System.Windows.Forms.TabControl();
      this.tabEditor = new System.Windows.Forms.TabPage();
      this.btnExchangeColors = new C64Studio.Controls.MenuButton();
      this.contextMenuExchangeColors = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exchangeMultiColor1WithBGColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exchangeMultiColor2WithBGColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabSpriteDetails = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.panelSprites = new GR.Forms.ImageListbox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.checkExpandY = new System.Windows.Forms.CheckBox();
      this.checkExpandX = new System.Windows.Forms.CheckBox();
      this.listLayerSprites = new C64Studio.ArrangedItemList();
      this.listLayers = new C64Studio.ArrangedItemList();
      this.editLayerY = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.editLayerName = new System.Windows.Forms.TextBox();
      this.editLayerX = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.comboLayerBGColor = new System.Windows.Forms.ComboBox();
      this.comboLayerColor = new System.Windows.Forms.ComboBox();
      this.comboSprite = new System.Windows.Forms.ComboBox();
      this.layerPreview = new GR.Forms.FastPictureBox();
      this.btnDeleteSprite = new System.Windows.Forms.Button();
      this.btnInvert = new System.Windows.Forms.Button();
      this.btnMirrorY = new System.Windows.Forms.Button();
      this.btnMirrorX = new System.Windows.Forms.Button();
      this.btnShiftDown = new System.Windows.Forms.Button();
      this.btnShiftUp = new System.Windows.Forms.Button();
      this.btnShiftRight = new System.Windows.Forms.Button();
      this.btnRotateRight = new System.Windows.Forms.Button();
      this.btnRotateLeft = new System.Windows.Forms.Button();
      this.btnShiftLeft = new System.Windows.Forms.Button();
      this.btnCopyToClipboard = new System.Windows.Forms.Button();
      this.btnPasteFromClipboard = new System.Windows.Forms.Button();
      this.labelCharNo = new System.Windows.Forms.Label();
      this.checkShowGrid = new System.Windows.Forms.CheckBox();
      this.checkMulticolor = new System.Windows.Forms.CheckBox();
      this.radioSpriteColor = new System.Windows.Forms.RadioButton();
      this.radioMulticolor2 = new System.Windows.Forms.RadioButton();
      this.radioMultiColor1 = new System.Windows.Forms.RadioButton();
      this.radioBackground = new System.Windows.Forms.RadioButton();
      this.comboSpriteColor = new System.Windows.Forms.ComboBox();
      this.comboMulticolor2 = new System.Windows.Forms.ComboBox();
      this.comboMulticolor1 = new System.Windows.Forms.ComboBox();
      this.comboBackground = new System.Windows.Forms.ComboBox();
      this.pictureEditor = new GR.Forms.FastPictureBox();
      this.tabProject = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnImportFromFile = new System.Windows.Forms.Button();
      this.btnImportFromHex = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.groupExport = new System.Windows.Forms.GroupBox();
      this.comboExportRange = new System.Windows.Forms.ComboBox();
      this.editSpriteCount = new System.Windows.Forms.TextBox();
      this.editSpriteFrom = new System.Windows.Forms.TextBox();
      this.labelCharactersTo = new System.Windows.Forms.Label();
      this.labelCharactersFrom = new System.Windows.Forms.Label();
      this.editPrefix = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.editWrapByteCount = new System.Windows.Forms.TextBox();
      this.checkExportToDataWrap = new System.Windows.Forms.CheckBox();
      this.checkExportToDataIncludeRes = new System.Windows.Forms.CheckBox();
      this.editDataExport = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.btnExportToData = new System.Windows.Forms.Button();
      this.btnExportCharset = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openCharsetProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveSpriteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeCharsetProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.forAllSpritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.forSelectedSpritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.m_FileWatcher)).BeginInit();
      this.tabSpriteEditor.SuspendLayout();
      this.tabEditor.SuspendLayout();
      this.contextMenuExchangeColors.SuspendLayout();
      this.tabSpriteDetails.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layerPreview)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).BeginInit();
      this.tabProject.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupExport.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabSpriteEditor
      // 
      this.tabSpriteEditor.Controls.Add(this.tabEditor);
      this.tabSpriteEditor.Controls.Add(this.tabProject);
      this.tabSpriteEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabSpriteEditor.Location = new System.Drawing.Point(0, 24);
      this.tabSpriteEditor.Name = "tabSpriteEditor";
      this.tabSpriteEditor.SelectedIndex = 0;
      this.tabSpriteEditor.Size = new System.Drawing.Size(994, 503);
      this.tabSpriteEditor.TabIndex = 0;
      // 
      // tabEditor
      // 
      this.tabEditor.Controls.Add(this.btnExchangeColors);
      this.tabEditor.Controls.Add(this.tabSpriteDetails);
      this.tabEditor.Controls.Add(this.btnDeleteSprite);
      this.tabEditor.Controls.Add(this.btnInvert);
      this.tabEditor.Controls.Add(this.btnMirrorY);
      this.tabEditor.Controls.Add(this.btnMirrorX);
      this.tabEditor.Controls.Add(this.btnShiftDown);
      this.tabEditor.Controls.Add(this.btnShiftUp);
      this.tabEditor.Controls.Add(this.btnShiftRight);
      this.tabEditor.Controls.Add(this.btnRotateRight);
      this.tabEditor.Controls.Add(this.btnRotateLeft);
      this.tabEditor.Controls.Add(this.btnShiftLeft);
      this.tabEditor.Controls.Add(this.btnCopyToClipboard);
      this.tabEditor.Controls.Add(this.btnPasteFromClipboard);
      this.tabEditor.Controls.Add(this.labelCharNo);
      this.tabEditor.Controls.Add(this.checkShowGrid);
      this.tabEditor.Controls.Add(this.checkMulticolor);
      this.tabEditor.Controls.Add(this.radioSpriteColor);
      this.tabEditor.Controls.Add(this.radioMulticolor2);
      this.tabEditor.Controls.Add(this.radioMultiColor1);
      this.tabEditor.Controls.Add(this.radioBackground);
      this.tabEditor.Controls.Add(this.comboSpriteColor);
      this.tabEditor.Controls.Add(this.comboMulticolor2);
      this.tabEditor.Controls.Add(this.comboMulticolor1);
      this.tabEditor.Controls.Add(this.comboBackground);
      this.tabEditor.Controls.Add(this.pictureEditor);
      this.tabEditor.Location = new System.Drawing.Point(4, 22);
      this.tabEditor.Name = "tabEditor";
      this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
      this.tabEditor.Size = new System.Drawing.Size(986, 477);
      this.tabEditor.TabIndex = 0;
      this.tabEditor.Text = "Sprite";
      this.tabEditor.UseVisualStyleBackColor = true;
      // 
      // btnExchangeColors
      // 
      this.btnExchangeColors.Location = new System.Drawing.Point(258, 207);
      this.btnExchangeColors.Menu = this.contextMenuExchangeColors;
      this.btnExchangeColors.Name = "btnExchangeColors";
      this.btnExchangeColors.Size = new System.Drawing.Size(121, 26);
      this.btnExchangeColors.TabIndex = 15;
      this.btnExchangeColors.Text = "Exchange Colors";
      this.btnExchangeColors.UseVisualStyleBackColor = true;
      // 
      // contextMenuExchangeColors
      // 
      this.contextMenuExchangeColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeMultiColor1WithBGColorToolStripMenuItem,
            this.exchangeMultiColor2WithBGColorToolStripMenuItem,
            this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem,
            this.forAllSpritesToolStripMenuItem,
            this.forSelectedSpritesToolStripMenuItem});
      this.contextMenuExchangeColors.Name = "contextMenuExchangeColors";
      this.contextMenuExchangeColors.Size = new System.Drawing.Size(295, 136);
      // 
      // exchangeMultiColor1WithMultiColor2ToolStripMenuItem
      // 
      this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem.Name = "exchangeMultiColor1WithMultiColor2ToolStripMenuItem";
      this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
      this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem.Text = "Exchange Multi Color 1 with Multi Color 2";
      this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem.Click += new System.EventHandler(this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem_Click);
      // 
      // exchangeMultiColor1WithBGColorToolStripMenuItem
      // 
      this.exchangeMultiColor1WithBGColorToolStripMenuItem.Name = "exchangeMultiColor1WithBGColorToolStripMenuItem";
      this.exchangeMultiColor1WithBGColorToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
      this.exchangeMultiColor1WithBGColorToolStripMenuItem.Text = "Exchange Multi Color 1 with BG Color";
      this.exchangeMultiColor1WithBGColorToolStripMenuItem.Click += new System.EventHandler(this.exchangeMultiColor1WithBGColorToolStripMenuItem_Click);
      // 
      // exchangeMultiColor2WithBGColorToolStripMenuItem
      // 
      this.exchangeMultiColor2WithBGColorToolStripMenuItem.Name = "exchangeMultiColor2WithBGColorToolStripMenuItem";
      this.exchangeMultiColor2WithBGColorToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
      this.exchangeMultiColor2WithBGColorToolStripMenuItem.Text = "Exchange Multi Color 2 with BG Color";
      this.exchangeMultiColor2WithBGColorToolStripMenuItem.Click += new System.EventHandler(this.exchangeMultiColor2WithBGColorToolStripMenuItem_Click);
      // 
      // tabSpriteDetails
      // 
      this.tabSpriteDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabSpriteDetails.Controls.Add(this.tabPage1);
      this.tabSpriteDetails.Controls.Add(this.tabPage2);
      this.tabSpriteDetails.Location = new System.Drawing.Point(446, 2);
      this.tabSpriteDetails.Name = "tabSpriteDetails";
      this.tabSpriteDetails.SelectedIndex = 0;
      this.tabSpriteDetails.Size = new System.Drawing.Size(540, 449);
      this.tabSpriteDetails.TabIndex = 9;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.panelSprites);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(532, 423);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Sprites";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // panelSprites
      // 
      this.panelSprites.AutoScroll = true;
      this.panelSprites.AutoScrollHorizontalMaximum = 100;
      this.panelSprites.AutoScrollHorizontalMinimum = 0;
      this.panelSprites.AutoScrollHPos = 0;
      this.panelSprites.AutoScrollVerticalMaximum = -23;
      this.panelSprites.AutoScrollVerticalMinimum = 0;
      this.panelSprites.AutoScrollVPos = 0;
      this.panelSprites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelSprites.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelSprites.EnableAutoScrollHorizontal = true;
      this.panelSprites.EnableAutoScrollVertical = true;
      this.panelSprites.HottrackColor = ((uint)(2151694591u));
      this.panelSprites.ItemHeight = 21;
      this.panelSprites.ItemWidth = 24;
      this.panelSprites.Location = new System.Drawing.Point(3, 3);
      this.panelSprites.Name = "panelSprites";
      this.panelSprites.PixelFormat = System.Drawing.Imaging.PixelFormat.DontCare;
      this.panelSprites.SelectedIndex = -1;
      this.panelSprites.Size = new System.Drawing.Size(526, 417);
      this.panelSprites.TabIndex = 4;
      this.panelSprites.TabStop = true;
      this.panelSprites.VisibleAutoScrollHorizontal = false;
      this.panelSprites.VisibleAutoScrollVertical = false;
      this.panelSprites.SelectedIndexChanged += new System.EventHandler(this.panelCharacters_SelectedIndexChanged);
      this.panelSprites.Resize += new System.EventHandler(this.panelSprites_Resize);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.checkExpandY);
      this.tabPage2.Controls.Add(this.checkExpandX);
      this.tabPage2.Controls.Add(this.listLayerSprites);
      this.tabPage2.Controls.Add(this.listLayers);
      this.tabPage2.Controls.Add(this.editLayerY);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.editLayerName);
      this.tabPage2.Controls.Add(this.editLayerX);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.comboLayerBGColor);
      this.tabPage2.Controls.Add(this.comboLayerColor);
      this.tabPage2.Controls.Add(this.comboSprite);
      this.tabPage2.Controls.Add(this.layerPreview);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(532, 423);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Preview";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // checkExpandY
      // 
      this.checkExpandY.AutoSize = true;
      this.checkExpandY.Location = new System.Drawing.Point(91, 265);
      this.checkExpandY.Name = "checkExpandY";
      this.checkExpandY.Size = new System.Drawing.Size(43, 17);
      this.checkExpandY.TabIndex = 23;
      this.checkExpandY.Text = "Y*2";
      this.checkExpandY.UseVisualStyleBackColor = true;
      this.checkExpandY.CheckedChanged += new System.EventHandler(this.checkExpandY_CheckedChanged);
      // 
      // checkExpandX
      // 
      this.checkExpandX.AutoSize = true;
      this.checkExpandX.Location = new System.Drawing.Point(91, 240);
      this.checkExpandX.Name = "checkExpandX";
      this.checkExpandX.Size = new System.Drawing.Size(43, 17);
      this.checkExpandX.TabIndex = 23;
      this.checkExpandX.Text = "X*2";
      this.checkExpandX.UseVisualStyleBackColor = true;
      this.checkExpandX.CheckedChanged += new System.EventHandler(this.checkExpandX_CheckedChanged);
      // 
      // listLayerSprites
      // 
      this.listLayerSprites.Location = new System.Drawing.Point(0, 0);
      this.listLayerSprites.MustHaveOneElement = false;
      this.listLayerSprites.Name = "listLayerSprites";
      this.listLayerSprites.Size = new System.Drawing.Size(133, 148);
      this.listLayerSprites.TabIndex = 22;
      this.listLayerSprites.AddingItem += new C64Studio.ArrangedItemList.AddingItemEventHandler(this.listLayerSprites_AddingItem);
      this.listLayerSprites.ItemAdded += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayerSprites_ItemAdded);
      this.listLayerSprites.ItemRemoved += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayerSprites_ItemRemoved);
      this.listLayerSprites.MovingItem += new C64Studio.ArrangedItemList.ItemExchangedEventHandler(this.listLayerSprites_MovingItem);
      this.listLayerSprites.ItemMoved += new C64Studio.ArrangedItemList.ItemExchangedEventHandler(this.listLayerSprites_ItemMoved);
      this.listLayerSprites.SelectedIndexChanged += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayerSprites_SelectedIndexChanged);
      // 
      // listLayers
      // 
      this.listLayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listLayers.Location = new System.Drawing.Point(0, 290);
      this.listLayers.MustHaveOneElement = true;
      this.listLayers.Name = "listLayers";
      this.listLayers.Size = new System.Drawing.Size(133, 93);
      this.listLayers.TabIndex = 22;
      this.listLayers.AddingItem += new C64Studio.ArrangedItemList.AddingItemEventHandler(this.listLayers_AddingItem);
      this.listLayers.ItemAdded += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayers_ItemAdded);
      this.listLayers.ItemRemoved += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayers_ItemRemoved);
      this.listLayers.MovingItem += new C64Studio.ArrangedItemList.ItemExchangedEventHandler(this.listLayers_MovingItem);
      this.listLayers.ItemMoved += new C64Studio.ArrangedItemList.ItemExchangedEventHandler(this.listLayers_ItemMoved);
      this.listLayers.SelectedIndexChanged += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listLayers_SelectedIndexChanged);
      // 
      // editLayerY
      // 
      this.editLayerY.Location = new System.Drawing.Point(91, 208);
      this.editLayerY.Name = "editLayerY";
      this.editLayerY.Size = new System.Drawing.Size(39, 20);
      this.editLayerY.TabIndex = 16;
      this.editLayerY.TextChanged += new System.EventHandler(this.editLayerY_TextChanged);
      this.editLayerY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editLayerY_KeyPress);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 266);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(25, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "BG:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 239);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Col:";
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 386);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(26, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "Nm:";
      // 
      // editLayerName
      // 
      this.editLayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.editLayerName.Location = new System.Drawing.Point(39, 383);
      this.editLayerName.Name = "editLayerName";
      this.editLayerName.Size = new System.Drawing.Size(91, 20);
      this.editLayerName.TabIndex = 17;
      this.editLayerName.TextChanged += new System.EventHandler(this.editLayerName_TextChanged);
      // 
      // editLayerX
      // 
      this.editLayerX.Location = new System.Drawing.Point(39, 208);
      this.editLayerX.Name = "editLayerX";
      this.editLayerX.Size = new System.Drawing.Size(45, 20);
      this.editLayerX.TabIndex = 17;
      this.editLayerX.TextChanged += new System.EventHandler(this.editLayerX_TextChanged);
      this.editLayerX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editLayerX_KeyPress);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 170);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Nr:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 211);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Pos:";
      // 
      // comboLayerBGColor
      // 
      this.comboLayerBGColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboLayerBGColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboLayerBGColor.FormattingEnabled = true;
      this.comboLayerBGColor.Location = new System.Drawing.Point(39, 263);
      this.comboLayerBGColor.Name = "comboLayerBGColor";
      this.comboLayerBGColor.Size = new System.Drawing.Size(45, 21);
      this.comboLayerBGColor.TabIndex = 8;
      this.comboLayerBGColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboLayerBGColor.SelectedIndexChanged += new System.EventHandler(this.comboLayerBGColor_SelectedIndexChanged);
      // 
      // comboLayerColor
      // 
      this.comboLayerColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboLayerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboLayerColor.FormattingEnabled = true;
      this.comboLayerColor.Location = new System.Drawing.Point(39, 236);
      this.comboLayerColor.Name = "comboLayerColor";
      this.comboLayerColor.Size = new System.Drawing.Size(45, 21);
      this.comboLayerColor.TabIndex = 9;
      this.comboLayerColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboLayerColor.SelectedIndexChanged += new System.EventHandler(this.comboLayerColor_SelectedIndexChanged);
      // 
      // comboSprite
      // 
      this.comboSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboSprite.DropDownHeight = 320;
      this.comboSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboSprite.FormattingEnabled = true;
      this.comboSprite.IntegralHeight = false;
      this.comboSprite.ItemHeight = 42;
      this.comboSprite.Location = new System.Drawing.Point(39, 154);
      this.comboSprite.Name = "comboSprite";
      this.comboSprite.Size = new System.Drawing.Size(91, 48);
      this.comboSprite.TabIndex = 10;
      this.comboSprite.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboSprite_DrawItem);
      this.comboSprite.SelectedIndexChanged += new System.EventHandler(this.comboSprite_SelectedIndexChanged);
      // 
      // layerPreview
      // 
      this.layerPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.layerPreview.DisplayPage = fastImage10;
      this.layerPreview.Image = null;
      this.layerPreview.Location = new System.Drawing.Point(136, 3);
      this.layerPreview.Name = "layerPreview";
      this.layerPreview.Size = new System.Drawing.Size(644, 404);
      this.layerPreview.TabIndex = 7;
      this.layerPreview.TabStop = false;
      // 
      // btnDeleteSprite
      // 
      this.btnDeleteSprite.Enabled = false;
      this.btnDeleteSprite.Location = new System.Drawing.Point(258, 281);
      this.btnDeleteSprite.Name = "btnDeleteSprite";
      this.btnDeleteSprite.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteSprite.TabIndex = 8;
      this.btnDeleteSprite.Text = "Delete";
      this.btnDeleteSprite.UseVisualStyleBackColor = true;
      this.btnDeleteSprite.Click += new System.EventHandler(this.btnDeleteSprite_Click);
      // 
      // btnInvert
      // 
      this.btnInvert.Image = ((System.Drawing.Image)(resources.GetObject("btnInvert.Image")));
      this.btnInvert.Location = new System.Drawing.Point(200, 226);
      this.btnInvert.Name = "btnInvert";
      this.btnInvert.Size = new System.Drawing.Size(26, 26);
      this.btnInvert.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnInvert, "Invert selected sprites colors");
      this.btnInvert.UseVisualStyleBackColor = true;
      this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
      // 
      // btnMirrorY
      // 
      this.btnMirrorY.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorY.Image")));
      this.btnMirrorY.Location = new System.Drawing.Point(168, 226);
      this.btnMirrorY.Name = "btnMirrorY";
      this.btnMirrorY.Size = new System.Drawing.Size(26, 26);
      this.btnMirrorY.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnMirrorY, "Mirror selected sprites vertically");
      this.btnMirrorY.UseVisualStyleBackColor = true;
      this.btnMirrorY.Click += new System.EventHandler(this.btnMirrorY_Click);
      // 
      // btnMirrorX
      // 
      this.btnMirrorX.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorX.Image")));
      this.btnMirrorX.Location = new System.Drawing.Point(136, 226);
      this.btnMirrorX.Name = "btnMirrorX";
      this.btnMirrorX.Size = new System.Drawing.Size(26, 26);
      this.btnMirrorX.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnMirrorX, "Mirror selected sprites horizontally");
      this.btnMirrorX.UseVisualStyleBackColor = true;
      this.btnMirrorX.Click += new System.EventHandler(this.btnMirrorX_Click);
      // 
      // btnShiftDown
      // 
      this.btnShiftDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftDown.Image")));
      this.btnShiftDown.Location = new System.Drawing.Point(104, 226);
      this.btnShiftDown.Name = "btnShiftDown";
      this.btnShiftDown.Size = new System.Drawing.Size(26, 26);
      this.btnShiftDown.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnShiftDown, "Shift selected sprites down");
      this.btnShiftDown.UseVisualStyleBackColor = true;
      this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
      // 
      // btnShiftUp
      // 
      this.btnShiftUp.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftUp.Image")));
      this.btnShiftUp.Location = new System.Drawing.Point(72, 226);
      this.btnShiftUp.Name = "btnShiftUp";
      this.btnShiftUp.Size = new System.Drawing.Size(26, 26);
      this.btnShiftUp.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnShiftUp, "Shift selected sprites up");
      this.btnShiftUp.UseVisualStyleBackColor = true;
      this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
      // 
      // btnShiftRight
      // 
      this.btnShiftRight.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftRight.Image")));
      this.btnShiftRight.Location = new System.Drawing.Point(40, 226);
      this.btnShiftRight.Name = "btnShiftRight";
      this.btnShiftRight.Size = new System.Drawing.Size(26, 26);
      this.btnShiftRight.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnShiftRight, "Shift selected sprites right");
      this.btnShiftRight.UseVisualStyleBackColor = true;
      this.btnShiftRight.Click += new System.EventHandler(this.btnShiftRight_Click);
      // 
      // btnRotateRight
      // 
      this.btnRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateRight.Image")));
      this.btnRotateRight.Location = new System.Drawing.Point(40, 258);
      this.btnRotateRight.Name = "btnRotateRight";
      this.btnRotateRight.Size = new System.Drawing.Size(26, 26);
      this.btnRotateRight.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnRotateRight, "Rotate selected sprites right");
      this.btnRotateRight.UseVisualStyleBackColor = true;
      this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
      // 
      // btnRotateLeft
      // 
      this.btnRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateLeft.Image")));
      this.btnRotateLeft.Location = new System.Drawing.Point(8, 258);
      this.btnRotateLeft.Name = "btnRotateLeft";
      this.btnRotateLeft.Size = new System.Drawing.Size(26, 26);
      this.btnRotateLeft.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnRotateLeft, "Rotate selected sprites left");
      this.btnRotateLeft.UseVisualStyleBackColor = true;
      this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
      // 
      // btnShiftLeft
      // 
      this.btnShiftLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftLeft.Image")));
      this.btnShiftLeft.Location = new System.Drawing.Point(8, 226);
      this.btnShiftLeft.Name = "btnShiftLeft";
      this.btnShiftLeft.Size = new System.Drawing.Size(26, 26);
      this.btnShiftLeft.TabIndex = 7;
      this.toolTip1.SetToolTip(this.btnShiftLeft, "Shift selected sprites left");
      this.btnShiftLeft.UseVisualStyleBackColor = true;
      this.btnShiftLeft.Click += new System.EventHandler(this.btnShiftLeft_Click);
      // 
      // btnCopyToClipboard
      // 
      this.btnCopyToClipboard.Location = new System.Drawing.Point(258, 178);
      this.btnCopyToClipboard.Name = "btnCopyToClipboard";
      this.btnCopyToClipboard.Size = new System.Drawing.Size(121, 23);
      this.btnCopyToClipboard.TabIndex = 6;
      this.btnCopyToClipboard.Text = "Copy to Clipboard";
      this.btnCopyToClipboard.UseVisualStyleBackColor = true;
      this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
      // 
      // btnPasteFromClipboard
      // 
      this.btnPasteFromClipboard.Location = new System.Drawing.Point(258, 149);
      this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
      this.btnPasteFromClipboard.Size = new System.Drawing.Size(121, 23);
      this.btnPasteFromClipboard.TabIndex = 6;
      this.btnPasteFromClipboard.Text = "Paste from Clipboard";
      this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
      this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
      // 
      // labelCharNo
      // 
      this.labelCharNo.Location = new System.Drawing.Point(344, 123);
      this.labelCharNo.Name = "labelCharNo";
      this.labelCharNo.Size = new System.Drawing.Size(82, 23);
      this.labelCharNo.TabIndex = 5;
      this.labelCharNo.Text = "label1";
      // 
      // checkShowGrid
      // 
      this.checkShowGrid.AutoSize = true;
      this.checkShowGrid.Location = new System.Drawing.Point(258, 251);
      this.checkShowGrid.Name = "checkShowGrid";
      this.checkShowGrid.Size = new System.Drawing.Size(75, 17);
      this.checkShowGrid.TabIndex = 3;
      this.checkShowGrid.Text = "Show Grid";
      this.checkShowGrid.UseVisualStyleBackColor = true;
      this.checkShowGrid.CheckedChanged += new System.EventHandler(this.checkShowGrid_CheckedChanged);
      // 
      // checkMulticolor
      // 
      this.checkMulticolor.AutoSize = true;
      this.checkMulticolor.Location = new System.Drawing.Point(258, 122);
      this.checkMulticolor.Name = "checkMulticolor";
      this.checkMulticolor.Size = new System.Drawing.Size(71, 17);
      this.checkMulticolor.TabIndex = 3;
      this.checkMulticolor.Text = "Multicolor";
      this.checkMulticolor.UseVisualStyleBackColor = true;
      this.checkMulticolor.CheckedChanged += new System.EventHandler(this.checkMulticolor_CheckedChanged);
      // 
      // radioSpriteColor
      // 
      this.radioSpriteColor.AutoSize = true;
      this.radioSpriteColor.Location = new System.Drawing.Point(258, 84);
      this.radioSpriteColor.Name = "radioSpriteColor";
      this.radioSpriteColor.Size = new System.Drawing.Size(79, 17);
      this.radioSpriteColor.TabIndex = 2;
      this.radioSpriteColor.TabStop = true;
      this.radioSpriteColor.Text = "Sprite Color";
      this.radioSpriteColor.UseVisualStyleBackColor = true;
      this.radioSpriteColor.CheckedChanged += new System.EventHandler(this.radioCharColor_CheckedChanged);
      // 
      // radioMulticolor2
      // 
      this.radioMulticolor2.AutoSize = true;
      this.radioMulticolor2.Location = new System.Drawing.Point(258, 57);
      this.radioMulticolor2.Name = "radioMulticolor2";
      this.radioMulticolor2.Size = new System.Drawing.Size(79, 17);
      this.radioMulticolor2.TabIndex = 2;
      this.radioMulticolor2.TabStop = true;
      this.radioMulticolor2.Text = "Multicolor 2";
      this.radioMulticolor2.UseVisualStyleBackColor = true;
      this.radioMulticolor2.CheckedChanged += new System.EventHandler(this.radioMulticolor2_CheckedChanged);
      // 
      // radioMultiColor1
      // 
      this.radioMultiColor1.AutoSize = true;
      this.radioMultiColor1.Location = new System.Drawing.Point(258, 30);
      this.radioMultiColor1.Name = "radioMultiColor1";
      this.radioMultiColor1.Size = new System.Drawing.Size(79, 17);
      this.radioMultiColor1.TabIndex = 2;
      this.radioMultiColor1.TabStop = true;
      this.radioMultiColor1.Text = "Multicolor 1";
      this.radioMultiColor1.UseVisualStyleBackColor = true;
      this.radioMultiColor1.CheckedChanged += new System.EventHandler(this.radioMultiColor1_CheckedChanged);
      // 
      // radioBackground
      // 
      this.radioBackground.AutoSize = true;
      this.radioBackground.Location = new System.Drawing.Point(258, 3);
      this.radioBackground.Name = "radioBackground";
      this.radioBackground.Size = new System.Drawing.Size(83, 17);
      this.radioBackground.TabIndex = 2;
      this.radioBackground.TabStop = true;
      this.radioBackground.Text = "Background";
      this.radioBackground.UseVisualStyleBackColor = true;
      this.radioBackground.CheckedChanged += new System.EventHandler(this.radioBackground_CheckedChanged);
      // 
      // comboSpriteColor
      // 
      this.comboSpriteColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboSpriteColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboSpriteColor.FormattingEnabled = true;
      this.comboSpriteColor.Location = new System.Drawing.Point(347, 84);
      this.comboSpriteColor.Name = "comboSpriteColor";
      this.comboSpriteColor.Size = new System.Drawing.Size(79, 21);
      this.comboSpriteColor.TabIndex = 1;
      this.comboSpriteColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboMulticolor_DrawItem);
      this.comboSpriteColor.SelectedIndexChanged += new System.EventHandler(this.comboSpriteColor_SelectedIndexChanged);
      // 
      // comboMulticolor2
      // 
      this.comboMulticolor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor2.FormattingEnabled = true;
      this.comboMulticolor2.Location = new System.Drawing.Point(347, 57);
      this.comboMulticolor2.Name = "comboMulticolor2";
      this.comboMulticolor2.Size = new System.Drawing.Size(79, 21);
      this.comboMulticolor2.TabIndex = 1;
      this.comboMulticolor2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboMulticolor2.SelectedIndexChanged += new System.EventHandler(this.comboMulticolor2_SelectedIndexChanged);
      // 
      // comboMulticolor1
      // 
      this.comboMulticolor1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor1.FormattingEnabled = true;
      this.comboMulticolor1.Location = new System.Drawing.Point(347, 30);
      this.comboMulticolor1.Name = "comboMulticolor1";
      this.comboMulticolor1.Size = new System.Drawing.Size(79, 21);
      this.comboMulticolor1.TabIndex = 1;
      this.comboMulticolor1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboMulticolor1.SelectedIndexChanged += new System.EventHandler(this.comboMulticolor1_SelectedIndexChanged);
      // 
      // comboBackground
      // 
      this.comboBackground.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBackground.FormattingEnabled = true;
      this.comboBackground.Location = new System.Drawing.Point(347, 2);
      this.comboBackground.Name = "comboBackground";
      this.comboBackground.Size = new System.Drawing.Size(79, 21);
      this.comboBackground.TabIndex = 1;
      this.comboBackground.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboBackground.SelectedIndexChanged += new System.EventHandler(this.comboBackground_SelectedIndexChanged);
      // 
      // pictureEditor
      // 
      this.pictureEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureEditor.DisplayPage = fastImage9;
      this.pictureEditor.Image = null;
      this.pictureEditor.Location = new System.Drawing.Point(8, 6);
      this.pictureEditor.Name = "pictureEditor";
      this.pictureEditor.Size = new System.Drawing.Size(244, 214);
      this.pictureEditor.TabIndex = 0;
      this.pictureEditor.TabStop = false;
      this.pictureEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureEditor_MouseDown);
      this.pictureEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureEditor_MouseMove);
      // 
      // tabProject
      // 
      this.tabProject.Controls.Add(this.groupBox1);
      this.tabProject.Controls.Add(this.groupExport);
      this.tabProject.Location = new System.Drawing.Point(4, 22);
      this.tabProject.Name = "tabProject";
      this.tabProject.Padding = new System.Windows.Forms.Padding(3);
      this.tabProject.Size = new System.Drawing.Size(986, 477);
      this.tabProject.TabIndex = 1;
      this.tabProject.Text = "Project";
      this.tabProject.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnImportFromFile);
      this.groupBox1.Controls.Add(this.btnImportFromHex);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Location = new System.Drawing.Point(455, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(135, 272);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Import";
      // 
      // btnImportFromFile
      // 
      this.btnImportFromFile.Location = new System.Drawing.Point(9, 19);
      this.btnImportFromFile.Name = "btnImportFromFile";
      this.btnImportFromFile.Size = new System.Drawing.Size(117, 23);
      this.btnImportFromFile.TabIndex = 2;
      this.btnImportFromFile.Text = "From File...";
      this.btnImportFromFile.UseVisualStyleBackColor = true;
      this.btnImportFromFile.Click += new System.EventHandler(this.btnImportSprite_Click);
      // 
      // btnImportFromHex
      // 
      this.btnImportFromHex.Location = new System.Drawing.Point(9, 77);
      this.btnImportFromHex.Name = "btnImportFromHex";
      this.btnImportFromHex.Size = new System.Drawing.Size(117, 23);
      this.btnImportFromHex.TabIndex = 2;
      this.btnImportFromHex.Text = "From Hex";
      this.btnImportFromHex.UseVisualStyleBackColor = true;
      this.btnImportFromHex.Click += new System.EventHandler(this.btnImportFromHex_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(9, 48);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(117, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "From Image...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btnImportFromImage_Click);
      // 
      // groupExport
      // 
      this.groupExport.Controls.Add(this.comboExportRange);
      this.groupExport.Controls.Add(this.editSpriteCount);
      this.groupExport.Controls.Add(this.editSpriteFrom);
      this.groupExport.Controls.Add(this.labelCharactersTo);
      this.groupExport.Controls.Add(this.labelCharactersFrom);
      this.groupExport.Controls.Add(this.editPrefix);
      this.groupExport.Controls.Add(this.label2);
      this.groupExport.Controls.Add(this.editWrapByteCount);
      this.groupExport.Controls.Add(this.checkExportToDataWrap);
      this.groupExport.Controls.Add(this.checkExportToDataIncludeRes);
      this.groupExport.Controls.Add(this.editDataExport);
      this.groupExport.Controls.Add(this.button1);
      this.groupExport.Controls.Add(this.btnExportToData);
      this.groupExport.Controls.Add(this.btnExportCharset);
      this.groupExport.Location = new System.Drawing.Point(8, 6);
      this.groupExport.Name = "groupExport";
      this.groupExport.Size = new System.Drawing.Size(441, 272);
      this.groupExport.TabIndex = 3;
      this.groupExport.TabStop = false;
      this.groupExport.Text = "Export";
      // 
      // comboExportRange
      // 
      this.comboExportRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboExportRange.FormattingEnabled = true;
      this.comboExportRange.Location = new System.Drawing.Point(129, 21);
      this.comboExportRange.Name = "comboExportRange";
      this.comboExportRange.Size = new System.Drawing.Size(88, 21);
      this.comboExportRange.TabIndex = 14;
      this.comboExportRange.SelectedIndexChanged += new System.EventHandler(this.comboExportRange_SelectedIndexChanged);
      // 
      // editSpriteCount
      // 
      this.editSpriteCount.Location = new System.Drawing.Point(367, 21);
      this.editSpriteCount.Name = "editSpriteCount";
      this.editSpriteCount.Size = new System.Drawing.Size(56, 20);
      this.editSpriteCount.TabIndex = 12;
      this.editSpriteCount.TextChanged += new System.EventHandler(this.editSpriteCount_TextChanged);
      // 
      // editSpriteFrom
      // 
      this.editSpriteFrom.Location = new System.Drawing.Point(262, 21);
      this.editSpriteFrom.Name = "editSpriteFrom";
      this.editSpriteFrom.Size = new System.Drawing.Size(56, 20);
      this.editSpriteFrom.TabIndex = 11;
      this.editSpriteFrom.TextChanged += new System.EventHandler(this.editSpriteFrom_TextChanged);
      // 
      // labelCharactersTo
      // 
      this.labelCharactersTo.AutoSize = true;
      this.labelCharactersTo.Location = new System.Drawing.Point(324, 24);
      this.labelCharactersTo.Name = "labelCharactersTo";
      this.labelCharactersTo.Size = new System.Drawing.Size(37, 13);
      this.labelCharactersTo.TabIndex = 10;
      this.labelCharactersTo.Text = "count:";
      // 
      // labelCharactersFrom
      // 
      this.labelCharactersFrom.AutoSize = true;
      this.labelCharactersFrom.Location = new System.Drawing.Point(226, 24);
      this.labelCharactersFrom.Name = "labelCharactersFrom";
      this.labelCharactersFrom.Size = new System.Drawing.Size(30, 13);
      this.labelCharactersFrom.TabIndex = 9;
      this.labelCharactersFrom.Text = "from:";
      // 
      // editPrefix
      // 
      this.editPrefix.Location = new System.Drawing.Point(225, 48);
      this.editPrefix.Name = "editPrefix";
      this.editPrefix.Size = new System.Drawing.Size(54, 20);
      this.editPrefix.TabIndex = 7;
      this.editPrefix.Text = "!byte ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(285, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "bytes";
      // 
      // editWrapByteCount
      // 
      this.editWrapByteCount.Enabled = false;
      this.editWrapByteCount.Location = new System.Drawing.Point(225, 77);
      this.editWrapByteCount.Name = "editWrapByteCount";
      this.editWrapByteCount.Size = new System.Drawing.Size(54, 20);
      this.editWrapByteCount.TabIndex = 5;
      this.editWrapByteCount.Text = "8";
      // 
      // checkExportToDataWrap
      // 
      this.checkExportToDataWrap.AutoSize = true;
      this.checkExportToDataWrap.Location = new System.Drawing.Point(129, 79);
      this.checkExportToDataWrap.Name = "checkExportToDataWrap";
      this.checkExportToDataWrap.Size = new System.Drawing.Size(64, 17);
      this.checkExportToDataWrap.TabIndex = 4;
      this.checkExportToDataWrap.Text = "Wrap at";
      this.checkExportToDataWrap.UseVisualStyleBackColor = true;
      this.checkExportToDataWrap.CheckedChanged += new System.EventHandler(this.checkExportToDataWrap_CheckedChanged);
      // 
      // checkExportToDataIncludeRes
      // 
      this.checkExportToDataIncludeRes.AutoSize = true;
      this.checkExportToDataIncludeRes.Location = new System.Drawing.Point(129, 50);
      this.checkExportToDataIncludeRes.Name = "checkExportToDataIncludeRes";
      this.checkExportToDataIncludeRes.Size = new System.Drawing.Size(74, 17);
      this.checkExportToDataIncludeRes.TabIndex = 4;
      this.checkExportToDataIncludeRes.Text = "Prefix with";
      this.checkExportToDataIncludeRes.UseVisualStyleBackColor = true;
      this.checkExportToDataIncludeRes.CheckedChanged += new System.EventHandler(this.checkExportToDataIncludeRes_CheckedChanged);
      // 
      // editDataExport
      // 
      this.editDataExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editDataExport.Location = new System.Drawing.Point(6, 118);
      this.editDataExport.Multiline = true;
      this.editDataExport.Name = "editDataExport";
      this.editDataExport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.editDataExport.Size = new System.Drawing.Size(429, 148);
      this.editDataExport.TabIndex = 3;
      this.editDataExport.WordWrap = false;
      this.editDataExport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDataExport_KeyPress);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 77);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(117, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "To Image...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnExportSpriteToImage_Click);
      // 
      // btnExportToData
      // 
      this.btnExportToData.Location = new System.Drawing.Point(6, 48);
      this.btnExportToData.Name = "btnExportToData";
      this.btnExportToData.Size = new System.Drawing.Size(117, 23);
      this.btnExportToData.TabIndex = 2;
      this.btnExportToData.Text = "To Data...";
      this.btnExportToData.UseVisualStyleBackColor = true;
      this.btnExportToData.Click += new System.EventHandler(this.btnExportSpriteToData_Click);
      // 
      // btnExportCharset
      // 
      this.btnExportCharset.Location = new System.Drawing.Point(6, 19);
      this.btnExportCharset.Name = "btnExportCharset";
      this.btnExportCharset.Size = new System.Drawing.Size(117, 23);
      this.btnExportCharset.TabIndex = 2;
      this.btnExportCharset.Text = "To File...";
      this.btnExportCharset.UseVisualStyleBackColor = true;
      this.btnExportCharset.Click += new System.EventHandler(this.btnExportSprite_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(994, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCharsetProjectToolStripMenuItem,
            this.saveSpriteProjectToolStripMenuItem,
            this.closeCharsetProjectToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fileToolStripMenuItem.Text = "&Sprites";
      // 
      // openCharsetProjectToolStripMenuItem
      // 
      this.openCharsetProjectToolStripMenuItem.Name = "openCharsetProjectToolStripMenuItem";
      this.openCharsetProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.openCharsetProjectToolStripMenuItem.Text = "&Open Sprite Project...";
      this.openCharsetProjectToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveSpriteProjectToolStripMenuItem
      // 
      this.saveSpriteProjectToolStripMenuItem.Name = "saveSpriteProjectToolStripMenuItem";
      this.saveSpriteProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.saveSpriteProjectToolStripMenuItem.Text = "&Save Project";
      this.saveSpriteProjectToolStripMenuItem.Click += new System.EventHandler(this.saveCharsetProjectToolStripMenuItem_Click);
      // 
      // closeCharsetProjectToolStripMenuItem
      // 
      this.closeCharsetProjectToolStripMenuItem.Enabled = false;
      this.closeCharsetProjectToolStripMenuItem.Name = "closeCharsetProjectToolStripMenuItem";
      this.closeCharsetProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.closeCharsetProjectToolStripMenuItem.Text = "&Close Sprite Project";
      this.closeCharsetProjectToolStripMenuItem.Click += new System.EventHandler(this.closeCharsetProjectToolStripMenuItem_Click);
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Nr.";
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "X";
      this.columnHeader5.Width = 30;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Y";
      this.columnHeader6.Width = 30;
      // 
      // forAllSpritesToolStripMenuItem
      // 
      this.forAllSpritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeMultiColor1WithBGColorToolStripMenuItem,
            this.exchangeMultiColor1WithMultiColor2ToolStripMenuItem,
            this.exchangeMultiColor2WithBGColorToolStripMenuItem});
      this.forAllSpritesToolStripMenuItem.Name = "forAllSpritesToolStripMenuItem";
      this.forAllSpritesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
      this.forAllSpritesToolStripMenuItem.Text = "For all Sprites";
      // 
      // forSelectedSpritesToolStripMenuItem
      // 
      this.forSelectedSpritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1,
            this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1});
      this.forSelectedSpritesToolStripMenuItem.Name = "forSelectedSpritesToolStripMenuItem";
      this.forSelectedSpritesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
      this.forSelectedSpritesToolStripMenuItem.Text = "For selected Sprites";
      // 
      // exchangeMulticolor1WithSpriteColorToolStripMenuItem1
      // 
      this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1.Name = "exchangeMulticolor1WithSpriteColorToolStripMenuItem1";
      this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
      this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1.Text = "Exchange Multicolor 1 with sprite color";
      this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1.Click += new System.EventHandler(this.exchangeMulticolor1WithSpriteColorToolStripMenuItem1_Click);
      // 
      // exchangeMulticolor2WithSpriteColorToolStripMenuItem1
      // 
      this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1.Name = "exchangeMulticolor2WithSpriteColorToolStripMenuItem1";
      this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
      this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1.Text = "Exchange Multicolor 2 with sprite color";
      this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1.Click += new System.EventHandler(this.exchangeMulticolor2WithSpriteColorToolStripMenuItem1_Click);
      // 
      // SpriteEditor
      // 
      this.ClientSize = new System.Drawing.Size(994, 527);
      this.Controls.Add(this.tabSpriteEditor);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SpriteEditor";
      this.Text = "Sprite Editor";
      ((System.ComponentModel.ISupportInitialize)(this.m_FileWatcher)).EndInit();
      this.tabSpriteEditor.ResumeLayout(false);
      this.tabEditor.ResumeLayout(false);
      this.tabEditor.PerformLayout();
      this.contextMenuExchangeColors.ResumeLayout(false);
      this.tabSpriteDetails.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layerPreview)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).EndInit();
      this.tabProject.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupExport.ResumeLayout(false);
      this.groupExport.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabSpriteEditor;
    private System.Windows.Forms.TabPage tabEditor;
    private System.Windows.Forms.TabPage tabProject;
    private GR.Forms.FastPictureBox pictureEditor;
    private System.Windows.Forms.ComboBox comboBackground;
    private System.Windows.Forms.RadioButton radioBackground;
    private System.Windows.Forms.RadioButton radioSpriteColor;
    private System.Windows.Forms.RadioButton radioMulticolor2;
    private System.Windows.Forms.RadioButton radioMultiColor1;
    private System.Windows.Forms.ComboBox comboSpriteColor;
    private System.Windows.Forms.ComboBox comboMulticolor2;
    private System.Windows.Forms.ComboBox comboMulticolor1;
    private System.Windows.Forms.CheckBox checkMulticolor;
    private GR.Forms.ImageListbox panelSprites;
    private System.Windows.Forms.Label labelCharNo;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openCharsetProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeCharsetProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveSpriteProjectToolStripMenuItem;
    private System.Windows.Forms.Button btnExportCharset;
    private System.Windows.Forms.GroupBox groupExport;
    private System.Windows.Forms.TextBox editDataExport;
    private System.Windows.Forms.Button btnExportToData;
    private System.Windows.Forms.CheckBox checkExportToDataIncludeRes;
    private System.Windows.Forms.CheckBox checkExportToDataWrap;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox editWrapByteCount;
    private System.Windows.Forms.TextBox editPrefix;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnImportFromFile;
    private System.Windows.Forms.Button btnCopyToClipboard;
    private System.Windows.Forms.Button btnPasteFromClipboard;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnShiftLeft;
    private System.Windows.Forms.Button btnShiftDown;
    private System.Windows.Forms.Button btnShiftUp;
    private System.Windows.Forms.Button btnShiftRight;
    private System.Windows.Forms.Button btnMirrorX;
    private System.Windows.Forms.Button btnMirrorY;
    private System.Windows.Forms.CheckBox checkShowGrid;
    private System.Windows.Forms.Button btnInvert;
    private System.Windows.Forms.Button btnRotateLeft;
    private System.Windows.Forms.Button btnRotateRight;
    private System.Windows.Forms.Button btnDeleteSprite;
    private System.Windows.Forms.TabControl tabSpriteDetails;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox editLayerY;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox editLayerX;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboLayerBGColor;
    private System.Windows.Forms.ComboBox comboLayerColor;
    private System.Windows.Forms.ComboBox comboSprite;
    private GR.Forms.FastPictureBox layerPreview;
    private ArrangedItemList listLayers;
    private ArrangedItemList listLayerSprites;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.TextBox editLayerName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboExportRange;
    private System.Windows.Forms.TextBox editSpriteCount;
    private System.Windows.Forms.TextBox editSpriteFrom;
    private System.Windows.Forms.Label labelCharactersTo;
    private System.Windows.Forms.Label labelCharactersFrom;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.CheckBox checkExpandY;
    private System.Windows.Forms.CheckBox checkExpandX;
    private System.Windows.Forms.Button btnImportFromHex;
    private Controls.MenuButton btnExchangeColors;
    private System.Windows.Forms.ContextMenuStrip contextMenuExchangeColors;
    private System.Windows.Forms.ToolStripMenuItem exchangeMultiColor1WithMultiColor2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exchangeMultiColor1WithBGColorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exchangeMultiColor2WithBGColorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem forAllSpritesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem forSelectedSpritesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exchangeMulticolor1WithSpriteColorToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exchangeMulticolor2WithSpriteColorToolStripMenuItem1;



  }
}
