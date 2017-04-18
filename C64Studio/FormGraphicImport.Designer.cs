﻿namespace C64Studio
{
  partial class FormGraphicImport
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormGraphicImport ) );
      GR.Image.FastImage fastImage1 = new GR.Image.FastImage();
      GR.Image.FastImage fastImage2 = new GR.Image.FastImage();
      this.tabImportSettings = new System.Windows.Forms.TabControl();
      this.tabSettings = new System.Windows.Forms.TabPage();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.comboColorMatching = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.comboImportType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.checkMulticolor = new System.Windows.Forms.CheckBox();
      this.comboBackground = new System.Windows.Forms.ComboBox();
      this.radioMulticolor2 = new System.Windows.Forms.RadioButton();
      this.comboMulticolor1 = new System.Windows.Forms.ComboBox();
      this.radioMultiColor1 = new System.Windows.Forms.RadioButton();
      this.comboMulticolor2 = new System.Windows.Forms.ComboBox();
      this.radioBackground = new System.Windows.Forms.RadioButton();
      this.tabPalette = new System.Windows.Forms.TabPage();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.listProblems = new System.Windows.Forms.ListView();
      this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.menuImport = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnZoomIn = new System.Windows.Forms.Button();
      this.btnZoomOut = new System.Windows.Forms.Button();
      this.picPreview = new GR.Forms.FastPictureBox();
      this.picOriginal = new GR.Forms.FastPictureBox();
      this.tabImportSettings.SuspendLayout();
      this.tabSettings.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.menuImport.SuspendLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.picPreview ) ).BeginInit();
      ( (System.ComponentModel.ISupportInitialize)( this.picOriginal ) ).BeginInit();
      this.SuspendLayout();
      // 
      // tabImportSettings
      // 
      this.tabImportSettings.Controls.Add( this.tabSettings );
      this.tabImportSettings.Controls.Add( this.tabPalette );
      this.tabImportSettings.Location = new System.Drawing.Point( 650, 29 );
      this.tabImportSettings.Name = "tabImportSettings";
      this.tabImportSettings.SelectedIndex = 0;
      this.tabImportSettings.Size = new System.Drawing.Size( 291, 442 );
      this.tabImportSettings.TabIndex = 2;
      // 
      // tabSettings
      // 
      this.tabSettings.Controls.Add( this.groupBox3 );
      this.tabSettings.Controls.Add( this.groupBox2 );
      this.tabSettings.Controls.Add( this.groupBox1 );
      this.tabSettings.Location = new System.Drawing.Point( 4, 22 );
      this.tabSettings.Name = "tabSettings";
      this.tabSettings.Padding = new System.Windows.Forms.Padding( 3 );
      this.tabSettings.Size = new System.Drawing.Size( 283, 416 );
      this.tabSettings.TabIndex = 0;
      this.tabSettings.Text = "Settings";
      this.tabSettings.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add( this.comboColorMatching );
      this.groupBox3.Controls.Add( this.label2 );
      this.groupBox3.Location = new System.Drawing.Point( 6, 199 );
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size( 271, 51 );
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Color Matching";
      // 
      // comboColorMatching
      // 
      this.comboColorMatching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboColorMatching.FormattingEnabled = true;
      this.comboColorMatching.Location = new System.Drawing.Point( 65, 16 );
      this.comboColorMatching.Name = "comboColorMatching";
      this.comboColorMatching.Size = new System.Drawing.Size( 200, 21 );
      this.comboColorMatching.TabIndex = 1;
      this.comboColorMatching.SelectedIndexChanged += new System.EventHandler( this.comboColorMatching_SelectedIndexChanged );
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point( 6, 19 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 54, 13 );
      this.label2.TabIndex = 0;
      this.label2.Text = "Match by:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add( this.comboImportType );
      this.groupBox2.Controls.Add( this.label1 );
      this.groupBox2.Location = new System.Drawing.Point( 6, 6 );
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size( 271, 51 );
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Import Settings";
      // 
      // comboImportType
      // 
      this.comboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboImportType.FormattingEnabled = true;
      this.comboImportType.Location = new System.Drawing.Point( 65, 16 );
      this.comboImportType.Name = "comboImportType";
      this.comboImportType.Size = new System.Drawing.Size( 200, 21 );
      this.comboImportType.TabIndex = 1;
      this.comboImportType.SelectedIndexChanged += new System.EventHandler( this.comboImportType_SelectedIndexChanged );
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point( 6, 19 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 53, 13 );
      this.label1.TabIndex = 0;
      this.label1.Text = "Import as:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add( this.checkMulticolor );
      this.groupBox1.Controls.Add( this.comboBackground );
      this.groupBox1.Controls.Add( this.radioMulticolor2 );
      this.groupBox1.Controls.Add( this.comboMulticolor1 );
      this.groupBox1.Controls.Add( this.radioMultiColor1 );
      this.groupBox1.Controls.Add( this.comboMulticolor2 );
      this.groupBox1.Controls.Add( this.radioBackground );
      this.groupBox1.Location = new System.Drawing.Point( 6, 63 );
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size( 271, 130 );
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Predefined Colors";
      // 
      // checkMulticolor
      // 
      this.checkMulticolor.AutoSize = true;
      this.checkMulticolor.Location = new System.Drawing.Point( 7, 101 );
      this.checkMulticolor.Name = "checkMulticolor";
      this.checkMulticolor.Size = new System.Drawing.Size( 71, 17 );
      this.checkMulticolor.TabIndex = 9;
      this.checkMulticolor.Text = "Multicolor";
      this.checkMulticolor.UseVisualStyleBackColor = true;
      // 
      // comboBackground
      // 
      this.comboBackground.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBackground.FormattingEnabled = true;
      this.comboBackground.Location = new System.Drawing.Point( 113, 19 );
      this.comboBackground.Name = "comboBackground";
      this.comboBackground.Size = new System.Drawing.Size( 121, 21 );
      this.comboBackground.TabIndex = 5;
      this.comboBackground.DrawItem += new System.Windows.Forms.DrawItemEventHandler( this.combo_DrawItem );
      // 
      // radioMulticolor2
      // 
      this.radioMulticolor2.AutoSize = true;
      this.radioMulticolor2.Location = new System.Drawing.Point( 6, 73 );
      this.radioMulticolor2.Name = "radioMulticolor2";
      this.radioMulticolor2.Size = new System.Drawing.Size( 79, 17 );
      this.radioMulticolor2.TabIndex = 6;
      this.radioMulticolor2.TabStop = true;
      this.radioMulticolor2.Text = "Multicolor 2";
      this.radioMulticolor2.UseVisualStyleBackColor = true;
      // 
      // comboMulticolor1
      // 
      this.comboMulticolor1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor1.FormattingEnabled = true;
      this.comboMulticolor1.Location = new System.Drawing.Point( 113, 46 );
      this.comboMulticolor1.Name = "comboMulticolor1";
      this.comboMulticolor1.Size = new System.Drawing.Size( 121, 21 );
      this.comboMulticolor1.TabIndex = 3;
      this.comboMulticolor1.DrawItem += new System.Windows.Forms.DrawItemEventHandler( this.combo_DrawItem );
      // 
      // radioMultiColor1
      // 
      this.radioMultiColor1.AutoSize = true;
      this.radioMultiColor1.Location = new System.Drawing.Point( 6, 46 );
      this.radioMultiColor1.Name = "radioMultiColor1";
      this.radioMultiColor1.Size = new System.Drawing.Size( 79, 17 );
      this.radioMultiColor1.TabIndex = 7;
      this.radioMultiColor1.TabStop = true;
      this.radioMultiColor1.Text = "Multicolor 1";
      this.radioMultiColor1.UseVisualStyleBackColor = true;
      // 
      // comboMulticolor2
      // 
      this.comboMulticolor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor2.FormattingEnabled = true;
      this.comboMulticolor2.Location = new System.Drawing.Point( 113, 73 );
      this.comboMulticolor2.Name = "comboMulticolor2";
      this.comboMulticolor2.Size = new System.Drawing.Size( 121, 21 );
      this.comboMulticolor2.TabIndex = 4;
      this.comboMulticolor2.DrawItem += new System.Windows.Forms.DrawItemEventHandler( this.combo_DrawItem );
      // 
      // radioBackground
      // 
      this.radioBackground.AutoSize = true;
      this.radioBackground.Location = new System.Drawing.Point( 6, 19 );
      this.radioBackground.Name = "radioBackground";
      this.radioBackground.Size = new System.Drawing.Size( 83, 17 );
      this.radioBackground.TabIndex = 8;
      this.radioBackground.TabStop = true;
      this.radioBackground.Text = "Background";
      this.radioBackground.UseVisualStyleBackColor = true;
      // 
      // tabPalette
      // 
      this.tabPalette.Location = new System.Drawing.Point( 4, 22 );
      this.tabPalette.Name = "tabPalette";
      this.tabPalette.Padding = new System.Windows.Forms.Padding( 3 );
      this.tabPalette.Size = new System.Drawing.Size( 283, 416 );
      this.tabPalette.TabIndex = 1;
      this.tabPalette.Text = "Palette";
      this.tabPalette.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point( 862, 820 );
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point( 781, 820 );
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size( 75, 23 );
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
      // 
      // listProblems
      // 
      this.listProblems.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2} );
      this.listProblems.FullRowSelect = true;
      this.listProblems.Location = new System.Drawing.Point( 650, 477 );
      this.listProblems.Name = "listProblems";
      this.listProblems.Size = new System.Drawing.Size( 287, 337 );
      this.listProblems.TabIndex = 4;
      this.listProblems.UseCompatibleStateImageBehavior = false;
      this.listProblems.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Pos";
      this.columnHeader1.Width = 70;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Problem";
      this.columnHeader2.Width = 190;
      // 
      // menuImport
      // 
      this.menuImport.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem} );
      this.menuImport.Location = new System.Drawing.Point( 0, 0 );
      this.menuImport.Name = "menuImport";
      this.menuImport.Size = new System.Drawing.Size( 939, 24 );
      this.menuImport.TabIndex = 5;
      this.menuImport.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem} );
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size( 112, 22 );
      this.openToolStripMenuItem.Text = "&Open...";
      this.openToolStripMenuItem.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size( 112, 22 );
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
      // 
      // btnZoomIn
      // 
      this.btnZoomIn.Image = ( (System.Drawing.Image)( resources.GetObject( "btnZoomIn.Image" ) ) );
      this.btnZoomIn.Location = new System.Drawing.Point( 650, 819 );
      this.btnZoomIn.Name = "btnZoomIn";
      this.btnZoomIn.Size = new System.Drawing.Size( 24, 24 );
      this.btnZoomIn.TabIndex = 6;
      this.btnZoomIn.UseVisualStyleBackColor = true;
      this.btnZoomIn.Click += new System.EventHandler( this.btnZoomIn_Click );
      // 
      // btnZoomOut
      // 
      this.btnZoomOut.Image = ( (System.Drawing.Image)( resources.GetObject( "btnZoomOut.Image" ) ) );
      this.btnZoomOut.Location = new System.Drawing.Point( 680, 819 );
      this.btnZoomOut.Name = "btnZoomOut";
      this.btnZoomOut.Size = new System.Drawing.Size( 24, 24 );
      this.btnZoomOut.TabIndex = 6;
      this.btnZoomOut.UseVisualStyleBackColor = true;
      this.btnZoomOut.Click += new System.EventHandler( this.btnZoomOut_Click );
      // 
      // picPreview
      // 
      this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picPreview.DisplayPage = fastImage1;
      this.picPreview.Image = null;
      this.picPreview.Location = new System.Drawing.Point( 0, 439 );
      this.picPreview.Name = "picPreview";
      this.picPreview.Size = new System.Drawing.Size( 644, 404 );
      this.picPreview.TabIndex = 1;
      this.picPreview.TabStop = false;
      this.picPreview.MouseMove += new System.Windows.Forms.MouseEventHandler( this.picPreview_MouseMove );
      this.picPreview.MouseDown += new System.Windows.Forms.MouseEventHandler( this.picPreview_MouseDown );
      this.picPreview.MouseUp += new System.Windows.Forms.MouseEventHandler( this.picPreview_MouseUp );
      // 
      // picOriginal
      // 
      this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picOriginal.DisplayPage = fastImage2;
      this.picOriginal.Image = null;
      this.picOriginal.Location = new System.Drawing.Point( 0, 29 );
      this.picOriginal.Name = "picOriginal";
      this.picOriginal.Size = new System.Drawing.Size( 644, 404 );
      this.picOriginal.TabIndex = 1;
      this.picOriginal.TabStop = false;
      this.picOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler( this.picOriginal_MouseMove );
      this.picOriginal.MouseDown += new System.Windows.Forms.MouseEventHandler( this.picOriginal_MouseDown );
      this.picOriginal.MouseUp += new System.Windows.Forms.MouseEventHandler( this.picOriginal_MouseUp );
      // 
      // FormGraphicImport
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size( 939, 846 );
      this.Controls.Add( this.btnZoomOut );
      this.Controls.Add( this.btnZoomIn );
      this.Controls.Add( this.listProblems );
      this.Controls.Add( this.btnOK );
      this.Controls.Add( this.btnCancel );
      this.Controls.Add( this.tabImportSettings );
      this.Controls.Add( this.picPreview );
      this.Controls.Add( this.picOriginal );
      this.Controls.Add( this.menuImport );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MainMenuStrip = this.menuImport;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormGraphicImport";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Import Graphic";
      this.tabImportSettings.ResumeLayout( false );
      this.tabSettings.ResumeLayout( false );
      this.groupBox3.ResumeLayout( false );
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout( false );
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout( false );
      this.groupBox1.PerformLayout();
      this.menuImport.ResumeLayout( false );
      this.menuImport.PerformLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.picPreview ) ).EndInit();
      ( (System.ComponentModel.ISupportInitialize)( this.picOriginal ) ).EndInit();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private GR.Forms.FastPictureBox picOriginal;
    private System.Windows.Forms.TabControl tabImportSettings;
    private System.Windows.Forms.TabPage tabSettings;
    private System.Windows.Forms.TabPage tabPalette;
    private GR.Forms.FastPictureBox picPreview;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.ListView listProblems;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox comboBackground;
    private System.Windows.Forms.RadioButton radioMulticolor2;
    private System.Windows.Forms.ComboBox comboMulticolor1;
    private System.Windows.Forms.RadioButton radioMultiColor1;
    private System.Windows.Forms.ComboBox comboMulticolor2;
    private System.Windows.Forms.RadioButton radioBackground;
    private System.Windows.Forms.CheckBox checkMulticolor;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox comboImportType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuImport;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox comboColorMatching;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnZoomIn;
    private System.Windows.Forms.Button btnZoomOut;
  }
}