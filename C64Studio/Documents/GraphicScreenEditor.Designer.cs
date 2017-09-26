﻿namespace C64Studio
{
  partial class GraphicScreenEditor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicScreenEditor));
      GR.Image.FastImage fastImage1 = new GR.Image.FastImage();
      GR.Image.FastImage fastImage2 = new GR.Image.FastImage();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveCharsetProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeCharsetProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabProject = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnImportCharsetFromImage = new System.Windows.Forms.Button();
      this.btnImportFromFile = new System.Windows.Forms.Button();
      this.groupExport = new System.Windows.Forms.GroupBox();
      this.comboCharScreens = new System.Windows.Forms.ComboBox();
      this.comboExportData = new System.Windows.Forms.ComboBox();
      this.comboExportType = new System.Windows.Forms.ComboBox();
      this.btnExportToCharScreen = new System.Windows.Forms.Button();
      this.labelCharInfoExport = new System.Windows.Forms.Label();
      this.btnExportAsBinary = new System.Windows.Forms.Button();
      this.btnExportAs = new System.Windows.Forms.Button();
      this.editPrefix = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.editWrapByteCount = new System.Windows.Forms.TextBox();
      this.checkExportToDataWrap = new System.Windows.Forms.CheckBox();
      this.checkExportToDataIncludeRes = new System.Windows.Forms.CheckBox();
      this.editDataExport = new System.Windows.Forms.TextBox();
      this.tabEditor = new System.Windows.Forms.TabPage();
      this.btnApplyScreenSize = new System.Windows.Forms.Button();
      this.editScreenHeight = new System.Windows.Forms.TextBox();
      this.editScreenWidth = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.screenVScroll = new System.Windows.Forms.VScrollBar();
      this.screenHScroll = new System.Windows.Forms.HScrollBar();
      this.comboCheckType = new System.Windows.Forms.ComboBox();
      this.btnMirrorY = new System.Windows.Forms.Button();
      this.btnMirrorX = new System.Windows.Forms.Button();
      this.btnShiftDown = new System.Windows.Forms.Button();
      this.btnShiftUp = new System.Windows.Forms.Button();
      this.btnShiftRight = new System.Windows.Forms.Button();
      this.btnShiftLeft = new System.Windows.Forms.Button();
      this.charEditor = new GR.Forms.FastPictureBox();
      this.btnPaste = new System.Windows.Forms.Button();
      this.btnCopy = new System.Windows.Forms.Button();
      this.btnCheck = new System.Windows.Forms.Button();
      this.btnPasteFromClipboard = new System.Windows.Forms.Button();
      this.labelCharInfo = new System.Windows.Forms.Label();
      this.checkMulticolor = new System.Windows.Forms.CheckBox();
      this.radioCharColor = new System.Windows.Forms.RadioButton();
      this.radioMulticolor2 = new System.Windows.Forms.RadioButton();
      this.radioMultiColor1 = new System.Windows.Forms.RadioButton();
      this.radioBackground = new System.Windows.Forms.RadioButton();
      this.comboCharColor = new System.Windows.Forms.ComboBox();
      this.comboMulticolor2 = new System.Windows.Forms.ComboBox();
      this.comboMulticolor1 = new System.Windows.Forms.ComboBox();
      this.comboBackground = new System.Windows.Forms.ComboBox();
      this.pictureEditor = new GR.Forms.FastPictureBox();
      this.tabGraphicScreenEditor = new System.Windows.Forms.TabControl();
      this.tabColorMapping = new System.Windows.Forms.TabPage();
      this.groupColorMapping = new System.Windows.Forms.GroupBox();
      this.listColorMappingTargets = new C64Studio.ArrangedItemList();
      this.comboColorMappingTargets = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.listColorMappingColors = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.m_FileWatcher)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.tabProject.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupExport.SuspendLayout();
      this.tabEditor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.charEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).BeginInit();
      this.tabGraphicScreenEditor.SuspendLayout();
      this.tabColorMapping.SuspendLayout();
      this.groupColorMapping.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(964, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageToolStripMenuItem,
            this.saveCharsetProjectToolStripMenuItem,
            this.closeCharsetProjectToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fileToolStripMenuItem.Text = "&Screen";
      // 
      // importImageToolStripMenuItem
      // 
      this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
      this.importImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
      this.importImageToolStripMenuItem.Text = "&Import Image";
      this.importImageToolStripMenuItem.Click += new System.EventHandler(this.importImagetoolStripMenuItem_Click);
      // 
      // saveCharsetProjectToolStripMenuItem
      // 
      this.saveCharsetProjectToolStripMenuItem.Enabled = false;
      this.saveCharsetProjectToolStripMenuItem.Name = "saveCharsetProjectToolStripMenuItem";
      this.saveCharsetProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
      this.saveCharsetProjectToolStripMenuItem.Text = "&Save Project";
      this.saveCharsetProjectToolStripMenuItem.Click += new System.EventHandler(this.saveCharsetProjectToolStripMenuItem_Click);
      // 
      // closeCharsetProjectToolStripMenuItem
      // 
      this.closeCharsetProjectToolStripMenuItem.Enabled = false;
      this.closeCharsetProjectToolStripMenuItem.Name = "closeCharsetProjectToolStripMenuItem";
      this.closeCharsetProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
      this.closeCharsetProjectToolStripMenuItem.Text = "&Close Charset Project";
      this.closeCharsetProjectToolStripMenuItem.Click += new System.EventHandler(this.closeCharsetProjectToolStripMenuItem_Click);
      // 
      // tabProject
      // 
      this.tabProject.Controls.Add(this.groupBox1);
      this.tabProject.Controls.Add(this.groupExport);
      this.tabProject.Location = new System.Drawing.Point(4, 22);
      this.tabProject.Name = "tabProject";
      this.tabProject.Padding = new System.Windows.Forms.Padding(3);
      this.tabProject.Size = new System.Drawing.Size(956, 475);
      this.tabProject.TabIndex = 1;
      this.tabProject.Text = "Project";
      this.tabProject.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnImportCharsetFromImage);
      this.groupBox1.Controls.Add(this.btnImportFromFile);
      this.groupBox1.Location = new System.Drawing.Point(458, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(324, 386);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Import";
      // 
      // btnImportCharsetFromImage
      // 
      this.btnImportCharsetFromImage.Location = new System.Drawing.Point(6, 77);
      this.btnImportCharsetFromImage.Name = "btnImportCharsetFromImage";
      this.btnImportCharsetFromImage.Size = new System.Drawing.Size(117, 23);
      this.btnImportCharsetFromImage.TabIndex = 2;
      this.btnImportCharsetFromImage.Text = "From Image...";
      this.btnImportCharsetFromImage.UseVisualStyleBackColor = true;
      this.btnImportCharsetFromImage.Click += new System.EventHandler(this.btnImportCharsetFromFile_Click);
      // 
      // btnImportFromFile
      // 
      this.btnImportFromFile.Location = new System.Drawing.Point(6, 19);
      this.btnImportFromFile.Name = "btnImportFromFile";
      this.btnImportFromFile.Size = new System.Drawing.Size(117, 23);
      this.btnImportFromFile.TabIndex = 2;
      this.btnImportFromFile.Text = "From File...";
      this.btnImportFromFile.UseVisualStyleBackColor = true;
      this.btnImportFromFile.Click += new System.EventHandler(this.btnImportCharset_Click);
      // 
      // groupExport
      // 
      this.groupExport.Controls.Add(this.comboCharScreens);
      this.groupExport.Controls.Add(this.comboExportData);
      this.groupExport.Controls.Add(this.comboExportType);
      this.groupExport.Controls.Add(this.btnExportToCharScreen);
      this.groupExport.Controls.Add(this.labelCharInfoExport);
      this.groupExport.Controls.Add(this.btnExportAsBinary);
      this.groupExport.Controls.Add(this.btnExportAs);
      this.groupExport.Controls.Add(this.editPrefix);
      this.groupExport.Controls.Add(this.label2);
      this.groupExport.Controls.Add(this.editWrapByteCount);
      this.groupExport.Controls.Add(this.checkExportToDataWrap);
      this.groupExport.Controls.Add(this.checkExportToDataIncludeRes);
      this.groupExport.Controls.Add(this.editDataExport);
      this.groupExport.Location = new System.Drawing.Point(11, 6);
      this.groupExport.Name = "groupExport";
      this.groupExport.Size = new System.Drawing.Size(441, 386);
      this.groupExport.TabIndex = 3;
      this.groupExport.TabStop = false;
      this.groupExport.Text = "Export";
      // 
      // comboCharScreens
      // 
      this.comboCharScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboCharScreens.FormattingEnabled = true;
      this.comboCharScreens.Location = new System.Drawing.Point(132, 74);
      this.comboCharScreens.Name = "comboCharScreens";
      this.comboCharScreens.Size = new System.Drawing.Size(303, 21);
      this.comboCharScreens.TabIndex = 11;
      // 
      // comboExportData
      // 
      this.comboExportData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboExportData.FormattingEnabled = true;
      this.comboExportData.Location = new System.Drawing.Point(132, 47);
      this.comboExportData.Name = "comboExportData";
      this.comboExportData.Size = new System.Drawing.Size(303, 21);
      this.comboExportData.TabIndex = 11;
      // 
      // comboExportType
      // 
      this.comboExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboExportType.FormattingEnabled = true;
      this.comboExportType.Location = new System.Drawing.Point(132, 101);
      this.comboExportType.Name = "comboExportType";
      this.comboExportType.Size = new System.Drawing.Size(303, 21);
      this.comboExportType.TabIndex = 11;
      // 
      // btnExportToCharScreen
      // 
      this.btnExportToCharScreen.Location = new System.Drawing.Point(6, 72);
      this.btnExportToCharScreen.Name = "btnExportToCharScreen";
      this.btnExportToCharScreen.Size = new System.Drawing.Size(120, 23);
      this.btnExportToCharScreen.TabIndex = 8;
      this.btnExportToCharScreen.Text = "Export to Char Screen";
      this.btnExportToCharScreen.UseVisualStyleBackColor = true;
      this.btnExportToCharScreen.Click += new System.EventHandler(this.btnExportToCharScreen_Click);
      // 
      // labelCharInfoExport
      // 
      this.labelCharInfoExport.Location = new System.Drawing.Point(129, 24);
      this.labelCharInfoExport.Name = "labelCharInfoExport";
      this.labelCharInfoExport.Size = new System.Drawing.Size(306, 18);
      this.labelCharInfoExport.TabIndex = 10;
      this.labelCharInfoExport.Text = "No selected block";
      // 
      // btnExportAsBinary
      // 
      this.btnExportAsBinary.Location = new System.Drawing.Point(6, 45);
      this.btnExportAsBinary.Name = "btnExportAsBinary";
      this.btnExportAsBinary.Size = new System.Drawing.Size(120, 23);
      this.btnExportAsBinary.TabIndex = 8;
      this.btnExportAsBinary.Text = "Export binary";
      this.btnExportAsBinary.UseVisualStyleBackColor = true;
      this.btnExportAsBinary.Click += new System.EventHandler(this.btnExportAsBinary_Click);
      // 
      // btnExportAs
      // 
      this.btnExportAs.Location = new System.Drawing.Point(6, 99);
      this.btnExportAs.Name = "btnExportAs";
      this.btnExportAs.Size = new System.Drawing.Size(120, 23);
      this.btnExportAs.TabIndex = 8;
      this.btnExportAs.Text = "Export image data as";
      this.btnExportAs.UseVisualStyleBackColor = true;
      this.btnExportAs.Click += new System.EventHandler(this.btnExportAsCharset_Click);
      // 
      // editPrefix
      // 
      this.editPrefix.Location = new System.Drawing.Point(209, 138);
      this.editPrefix.Name = "editPrefix";
      this.editPrefix.Size = new System.Drawing.Size(43, 20);
      this.editPrefix.TabIndex = 7;
      this.editPrefix.Text = "!byte ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(403, 141);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "bytes";
      // 
      // editWrapByteCount
      // 
      this.editWrapByteCount.Enabled = false;
      this.editWrapByteCount.Location = new System.Drawing.Point(343, 138);
      this.editWrapByteCount.Name = "editWrapByteCount";
      this.editWrapByteCount.Size = new System.Drawing.Size(54, 20);
      this.editWrapByteCount.TabIndex = 5;
      this.editWrapByteCount.Text = "8";
      // 
      // checkExportToDataWrap
      // 
      this.checkExportToDataWrap.AutoSize = true;
      this.checkExportToDataWrap.Location = new System.Drawing.Point(273, 140);
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
      this.checkExportToDataIncludeRes.Location = new System.Drawing.Point(138, 140);
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
      this.editDataExport.Location = new System.Drawing.Point(6, 167);
      this.editDataExport.Multiline = true;
      this.editDataExport.Name = "editDataExport";
      this.editDataExport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.editDataExport.Size = new System.Drawing.Size(429, 213);
      this.editDataExport.TabIndex = 3;
      this.editDataExport.WordWrap = false;
      this.editDataExport.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editDataExport_PreviewKeyDown);
      // 
      // tabEditor
      // 
      this.tabEditor.Controls.Add(this.btnApplyScreenSize);
      this.tabEditor.Controls.Add(this.editScreenHeight);
      this.tabEditor.Controls.Add(this.editScreenWidth);
      this.tabEditor.Controls.Add(this.label7);
      this.tabEditor.Controls.Add(this.screenVScroll);
      this.tabEditor.Controls.Add(this.screenHScroll);
      this.tabEditor.Controls.Add(this.comboCheckType);
      this.tabEditor.Controls.Add(this.btnMirrorY);
      this.tabEditor.Controls.Add(this.btnMirrorX);
      this.tabEditor.Controls.Add(this.btnShiftDown);
      this.tabEditor.Controls.Add(this.btnShiftUp);
      this.tabEditor.Controls.Add(this.btnShiftRight);
      this.tabEditor.Controls.Add(this.btnShiftLeft);
      this.tabEditor.Controls.Add(this.charEditor);
      this.tabEditor.Controls.Add(this.btnPaste);
      this.tabEditor.Controls.Add(this.btnCopy);
      this.tabEditor.Controls.Add(this.btnCheck);
      this.tabEditor.Controls.Add(this.btnPasteFromClipboard);
      this.tabEditor.Controls.Add(this.labelCharInfo);
      this.tabEditor.Controls.Add(this.checkMulticolor);
      this.tabEditor.Controls.Add(this.radioCharColor);
      this.tabEditor.Controls.Add(this.radioMulticolor2);
      this.tabEditor.Controls.Add(this.radioMultiColor1);
      this.tabEditor.Controls.Add(this.radioBackground);
      this.tabEditor.Controls.Add(this.comboCharColor);
      this.tabEditor.Controls.Add(this.comboMulticolor2);
      this.tabEditor.Controls.Add(this.comboMulticolor1);
      this.tabEditor.Controls.Add(this.comboBackground);
      this.tabEditor.Controls.Add(this.pictureEditor);
      this.tabEditor.Location = new System.Drawing.Point(4, 22);
      this.tabEditor.Name = "tabEditor";
      this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
      this.tabEditor.Size = new System.Drawing.Size(956, 475);
      this.tabEditor.TabIndex = 0;
      this.tabEditor.Text = "Screen";
      this.tabEditor.UseVisualStyleBackColor = true;
      // 
      // btnApplyScreenSize
      // 
      this.btnApplyScreenSize.Location = new System.Drawing.Point(893, 120);
      this.btnApplyScreenSize.Name = "btnApplyScreenSize";
      this.btnApplyScreenSize.Size = new System.Drawing.Size(50, 20);
      this.btnApplyScreenSize.TabIndex = 34;
      this.btnApplyScreenSize.Text = "Apply";
      this.btnApplyScreenSize.UseVisualStyleBackColor = true;
      this.btnApplyScreenSize.Click += new System.EventHandler(this.btnApplyScreenSize_Click);
      // 
      // editScreenHeight
      // 
      this.editScreenHeight.Location = new System.Drawing.Point(846, 118);
      this.editScreenHeight.Name = "editScreenHeight";
      this.editScreenHeight.Size = new System.Drawing.Size(37, 20);
      this.editScreenHeight.TabIndex = 33;
      this.editScreenHeight.TextChanged += new System.EventHandler(this.editScreenHeight_TextChanged);
      // 
      // editScreenWidth
      // 
      this.editScreenWidth.Location = new System.Drawing.Point(803, 118);
      this.editScreenWidth.Name = "editScreenWidth";
      this.editScreenWidth.Size = new System.Drawing.Size(37, 20);
      this.editScreenWidth.TabIndex = 32;
      this.editScreenWidth.TextChanged += new System.EventHandler(this.editScreenWidth_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(767, 121);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(30, 13);
      this.label7.TabIndex = 31;
      this.label7.Text = "Size:";
      // 
      // screenVScroll
      // 
      this.screenVScroll.Location = new System.Drawing.Point(655, 6);
      this.screenVScroll.Name = "screenVScroll";
      this.screenVScroll.Size = new System.Drawing.Size(16, 404);
      this.screenVScroll.TabIndex = 26;
      this.screenVScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.screenVScroll_Scroll);
      // 
      // screenHScroll
      // 
      this.screenHScroll.Location = new System.Drawing.Point(8, 413);
      this.screenHScroll.Name = "screenHScroll";
      this.screenHScroll.Size = new System.Drawing.Size(644, 16);
      this.screenHScroll.TabIndex = 25;
      this.screenHScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.screenHScroll_Scroll);
      // 
      // comboCheckType
      // 
      this.comboCheckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboCheckType.FormattingEnabled = true;
      this.comboCheckType.Location = new System.Drawing.Point(376, 443);
      this.comboCheckType.Name = "comboCheckType";
      this.comboCheckType.Size = new System.Drawing.Size(100, 21);
      this.comboCheckType.TabIndex = 21;
      this.comboCheckType.SelectedIndexChanged += new System.EventHandler(this.comboCheckType_SelectedIndexChanged);
      // 
      // btnMirrorY
      // 
      this.btnMirrorY.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorY.Image")));
      this.btnMirrorY.Location = new System.Drawing.Point(843, 414);
      this.btnMirrorY.Name = "btnMirrorY";
      this.btnMirrorY.Size = new System.Drawing.Size(26, 26);
      this.btnMirrorY.TabIndex = 18;
      this.btnMirrorY.UseVisualStyleBackColor = true;
      // 
      // btnMirrorX
      // 
      this.btnMirrorX.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorX.Image")));
      this.btnMirrorX.Location = new System.Drawing.Point(811, 414);
      this.btnMirrorX.Name = "btnMirrorX";
      this.btnMirrorX.Size = new System.Drawing.Size(26, 26);
      this.btnMirrorX.TabIndex = 19;
      this.btnMirrorX.UseVisualStyleBackColor = true;
      // 
      // btnShiftDown
      // 
      this.btnShiftDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftDown.Image")));
      this.btnShiftDown.Location = new System.Drawing.Point(779, 414);
      this.btnShiftDown.Name = "btnShiftDown";
      this.btnShiftDown.Size = new System.Drawing.Size(26, 26);
      this.btnShiftDown.TabIndex = 20;
      this.btnShiftDown.UseVisualStyleBackColor = true;
      // 
      // btnShiftUp
      // 
      this.btnShiftUp.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftUp.Image")));
      this.btnShiftUp.Location = new System.Drawing.Point(747, 414);
      this.btnShiftUp.Name = "btnShiftUp";
      this.btnShiftUp.Size = new System.Drawing.Size(26, 26);
      this.btnShiftUp.TabIndex = 15;
      this.btnShiftUp.UseVisualStyleBackColor = true;
      // 
      // btnShiftRight
      // 
      this.btnShiftRight.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftRight.Image")));
      this.btnShiftRight.Location = new System.Drawing.Point(715, 414);
      this.btnShiftRight.Name = "btnShiftRight";
      this.btnShiftRight.Size = new System.Drawing.Size(26, 26);
      this.btnShiftRight.TabIndex = 16;
      this.btnShiftRight.UseVisualStyleBackColor = true;
      // 
      // btnShiftLeft
      // 
      this.btnShiftLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftLeft.Image")));
      this.btnShiftLeft.Location = new System.Drawing.Point(683, 414);
      this.btnShiftLeft.Name = "btnShiftLeft";
      this.btnShiftLeft.Size = new System.Drawing.Size(26, 26);
      this.btnShiftLeft.TabIndex = 17;
      this.btnShiftLeft.UseVisualStyleBackColor = true;
      // 
      // charEditor
      // 
      this.charEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.charEditor.DisplayPage = fastImage1;
      this.charEditor.Image = null;
      this.charEditor.Location = new System.Drawing.Point(683, 148);
      this.charEditor.Name = "charEditor";
      this.charEditor.Size = new System.Drawing.Size(260, 260);
      this.charEditor.TabIndex = 14;
      this.charEditor.TabStop = false;
      this.charEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charEditor_MouseDown);
      this.charEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charEditor_MouseMove);
      // 
      // btnPaste
      // 
      this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
      this.btnPaste.Location = new System.Drawing.Point(40, 439);
      this.btnPaste.Name = "btnPaste";
      this.btnPaste.Size = new System.Drawing.Size(26, 26);
      this.btnPaste.TabIndex = 11;
      this.btnPaste.UseVisualStyleBackColor = true;
      this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
      // 
      // btnCopy
      // 
      this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
      this.btnCopy.Location = new System.Drawing.Point(8, 439);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(26, 26);
      this.btnCopy.TabIndex = 11;
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // btnCheck
      // 
      this.btnCheck.Location = new System.Drawing.Point(303, 441);
      this.btnCheck.Name = "btnCheck";
      this.btnCheck.Size = new System.Drawing.Size(67, 23);
      this.btnCheck.TabIndex = 6;
      this.btnCheck.Text = "Check as";
      this.btnCheck.UseVisualStyleBackColor = true;
      this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
      // 
      // btnPasteFromClipboard
      // 
      this.btnPasteFromClipboard.Location = new System.Drawing.Point(72, 441);
      this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
      this.btnPasteFromClipboard.Size = new System.Drawing.Size(117, 23);
      this.btnPasteFromClipboard.TabIndex = 6;
      this.btnPasteFromClipboard.Text = "Big Paste";
      this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
      this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
      // 
      // labelCharInfo
      // 
      this.labelCharInfo.Location = new System.Drawing.Point(482, 446);
      this.labelCharInfo.Name = "labelCharInfo";
      this.labelCharInfo.Size = new System.Drawing.Size(170, 24);
      this.labelCharInfo.TabIndex = 5;
      this.labelCharInfo.Text = "No selected block";
      // 
      // checkMulticolor
      // 
      this.checkMulticolor.AutoSize = true;
      this.checkMulticolor.Location = new System.Drawing.Point(683, 120);
      this.checkMulticolor.Name = "checkMulticolor";
      this.checkMulticolor.Size = new System.Drawing.Size(71, 17);
      this.checkMulticolor.TabIndex = 3;
      this.checkMulticolor.Text = "Multicolor";
      this.checkMulticolor.UseVisualStyleBackColor = true;
      this.checkMulticolor.CheckedChanged += new System.EventHandler(this.checkMulticolor_CheckedChanged);
      // 
      // radioCharColor
      // 
      this.radioCharColor.AutoSize = true;
      this.radioCharColor.Location = new System.Drawing.Point(683, 87);
      this.radioCharColor.Name = "radioCharColor";
      this.radioCharColor.Size = new System.Drawing.Size(74, 17);
      this.radioCharColor.TabIndex = 2;
      this.radioCharColor.TabStop = true;
      this.radioCharColor.Text = "Char Color";
      this.radioCharColor.UseVisualStyleBackColor = true;
      this.radioCharColor.CheckedChanged += new System.EventHandler(this.radioCharColor_CheckedChanged);
      // 
      // radioMulticolor2
      // 
      this.radioMulticolor2.AutoSize = true;
      this.radioMulticolor2.Location = new System.Drawing.Point(683, 60);
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
      this.radioMultiColor1.Location = new System.Drawing.Point(683, 33);
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
      this.radioBackground.Location = new System.Drawing.Point(683, 6);
      this.radioBackground.Name = "radioBackground";
      this.radioBackground.Size = new System.Drawing.Size(83, 17);
      this.radioBackground.TabIndex = 2;
      this.radioBackground.TabStop = true;
      this.radioBackground.Text = "Background";
      this.radioBackground.UseVisualStyleBackColor = true;
      this.radioBackground.CheckedChanged += new System.EventHandler(this.radioBackground_CheckedChanged);
      // 
      // comboCharColor
      // 
      this.comboCharColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboCharColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboCharColor.FormattingEnabled = true;
      this.comboCharColor.Location = new System.Drawing.Point(790, 87);
      this.comboCharColor.Name = "comboCharColor";
      this.comboCharColor.Size = new System.Drawing.Size(121, 21);
      this.comboCharColor.TabIndex = 1;
      this.comboCharColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboMulticolor_DrawItem);
      this.comboCharColor.SelectedIndexChanged += new System.EventHandler(this.comboCharColor_SelectedIndexChanged);
      // 
      // comboMulticolor2
      // 
      this.comboMulticolor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor2.FormattingEnabled = true;
      this.comboMulticolor2.Location = new System.Drawing.Point(790, 60);
      this.comboMulticolor2.Name = "comboMulticolor2";
      this.comboMulticolor2.Size = new System.Drawing.Size(121, 21);
      this.comboMulticolor2.TabIndex = 1;
      this.comboMulticolor2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboMulticolor2.SelectedIndexChanged += new System.EventHandler(this.comboMulticolor2_SelectedIndexChanged);
      // 
      // comboMulticolor1
      // 
      this.comboMulticolor1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboMulticolor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboMulticolor1.FormattingEnabled = true;
      this.comboMulticolor1.Location = new System.Drawing.Point(790, 33);
      this.comboMulticolor1.Name = "comboMulticolor1";
      this.comboMulticolor1.Size = new System.Drawing.Size(121, 21);
      this.comboMulticolor1.TabIndex = 1;
      this.comboMulticolor1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboMulticolor1.SelectedIndexChanged += new System.EventHandler(this.comboMulticolor1_SelectedIndexChanged);
      // 
      // comboBackground
      // 
      this.comboBackground.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBackground.FormattingEnabled = true;
      this.comboBackground.Location = new System.Drawing.Point(790, 6);
      this.comboBackground.Name = "comboBackground";
      this.comboBackground.Size = new System.Drawing.Size(121, 21);
      this.comboBackground.TabIndex = 1;
      this.comboBackground.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
      this.comboBackground.SelectedIndexChanged += new System.EventHandler(this.comboBackground_SelectedIndexChanged);
      // 
      // pictureEditor
      // 
      this.pictureEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureEditor.DisplayPage = fastImage2;
      this.pictureEditor.Image = null;
      this.pictureEditor.Location = new System.Drawing.Point(8, 6);
      this.pictureEditor.Name = "pictureEditor";
      this.pictureEditor.Size = new System.Drawing.Size(644, 404);
      this.pictureEditor.TabIndex = 0;
      this.pictureEditor.TabStop = false;
      this.pictureEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureEditor_Paint);
      this.pictureEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureEditor_MouseDown);
      this.pictureEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureEditor_MouseMove);
      // 
      // tabGraphicScreenEditor
      // 
      this.tabGraphicScreenEditor.Controls.Add(this.tabEditor);
      this.tabGraphicScreenEditor.Controls.Add(this.tabColorMapping);
      this.tabGraphicScreenEditor.Controls.Add(this.tabProject);
      this.tabGraphicScreenEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabGraphicScreenEditor.Location = new System.Drawing.Point(0, 24);
      this.tabGraphicScreenEditor.Name = "tabGraphicScreenEditor";
      this.tabGraphicScreenEditor.SelectedIndex = 0;
      this.tabGraphicScreenEditor.Size = new System.Drawing.Size(964, 501);
      this.tabGraphicScreenEditor.TabIndex = 0;
      // 
      // tabColorMapping
      // 
      this.tabColorMapping.Controls.Add(this.groupColorMapping);
      this.tabColorMapping.Location = new System.Drawing.Point(4, 22);
      this.tabColorMapping.Name = "tabColorMapping";
      this.tabColorMapping.Padding = new System.Windows.Forms.Padding(3);
      this.tabColorMapping.Size = new System.Drawing.Size(956, 475);
      this.tabColorMapping.TabIndex = 2;
      this.tabColorMapping.Text = "Color Mapping";
      this.tabColorMapping.UseVisualStyleBackColor = true;
      // 
      // groupColorMapping
      // 
      this.groupColorMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupColorMapping.Controls.Add(this.listColorMappingTargets);
      this.groupColorMapping.Controls.Add(this.comboColorMappingTargets);
      this.groupColorMapping.Controls.Add(this.label1);
      this.groupColorMapping.Controls.Add(this.listColorMappingColors);
      this.groupColorMapping.Location = new System.Drawing.Point(6, 6);
      this.groupColorMapping.Name = "groupColorMapping";
      this.groupColorMapping.Size = new System.Drawing.Size(942, 461);
      this.groupColorMapping.TabIndex = 0;
      this.groupColorMapping.TabStop = false;
      this.groupColorMapping.Text = "Map Multi-Colors";
      // 
      // listColorMappingTargets
      // 
      this.listColorMappingTargets.AddButtonEnabled = true;
      this.listColorMappingTargets.DeleteButtonEnabled = false;
      this.listColorMappingTargets.Location = new System.Drawing.Point(206, 16);
      this.listColorMappingTargets.MustHaveOneElement = true;
      this.listColorMappingTargets.Name = "listColorMappingTargets";
      this.listColorMappingTargets.Size = new System.Drawing.Size(207, 247);
      this.listColorMappingTargets.TabIndex = 5;
      this.listColorMappingTargets.AddingItem += new C64Studio.ArrangedItemList.AddingItemEventHandler(this.listColorMappingTargets_AddingItem);
      this.listColorMappingTargets.ItemAdded += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listColorMappingTargets_ItemAdded);
      this.listColorMappingTargets.ItemRemoved += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listColorMappingTargets_ItemRemoved);
      this.listColorMappingTargets.MovingItem += new C64Studio.ArrangedItemList.ItemExchangingEventHandler(this.listColorMappingTargets_MovingItem);
      this.listColorMappingTargets.ItemMoved += new C64Studio.ArrangedItemList.ItemExchangedEventHandler(this.listColorMappingTargets_ItemMoved);
      this.listColorMappingTargets.SelectedIndexChanged += new C64Studio.ArrangedItemList.ItemModifiedEventHandler(this.listColorMappingTargets_SelectedIndexChanged);
      // 
      // comboColorMappingTargets
      // 
      this.comboColorMappingTargets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboColorMappingTargets.FormattingEnabled = true;
      this.comboColorMappingTargets.Location = new System.Drawing.Point(486, 16);
      this.comboColorMappingTargets.Name = "comboColorMappingTargets";
      this.comboColorMappingTargets.Size = new System.Drawing.Size(133, 21);
      this.comboColorMappingTargets.TabIndex = 3;
      this.comboColorMappingTargets.SelectedIndexChanged += new System.EventHandler(this.comboColorMappingTargets_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(419, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Mapped to:";
      // 
      // listColorMappingColors
      // 
      this.listColorMappingColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.listColorMappingColors.FormattingEnabled = true;
      this.listColorMappingColors.ItemHeight = 16;
      this.listColorMappingColors.Location = new System.Drawing.Point(6, 19);
      this.listColorMappingColors.Name = "listColorMappingColors";
      this.listColorMappingColors.Size = new System.Drawing.Size(194, 244);
      this.listColorMappingColors.TabIndex = 0;
      this.listColorMappingColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listColorMappingColors_DrawItem);
      this.listColorMappingColors.SelectedIndexChanged += new System.EventHandler(this.listColorMappingColors_SelectedIndexChanged);
      // 
      // GraphicScreenEditor
      // 
      this.ClientSize = new System.Drawing.Size(964, 525);
      this.Controls.Add(this.tabGraphicScreenEditor);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "GraphicScreenEditor";
      this.Text = "Graphic Screen Editor";
      ((System.ComponentModel.ISupportInitialize)(this.m_FileWatcher)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabProject.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupExport.ResumeLayout(false);
      this.groupExport.PerformLayout();
      this.tabEditor.ResumeLayout(false);
      this.tabEditor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.charEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).EndInit();
      this.tabGraphicScreenEditor.ResumeLayout(false);
      this.tabColorMapping.ResumeLayout(false);
      this.groupColorMapping.ResumeLayout(false);
      this.groupColorMapping.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeCharsetProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveCharsetProjectToolStripMenuItem;
    private System.Windows.Forms.TabPage tabProject;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnImportCharsetFromImage;
    private System.Windows.Forms.Button btnImportFromFile;
    private System.Windows.Forms.GroupBox groupExport;
    private System.Windows.Forms.TextBox editPrefix;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox editWrapByteCount;
    private System.Windows.Forms.CheckBox checkExportToDataWrap;
    private System.Windows.Forms.CheckBox checkExportToDataIncludeRes;
    private System.Windows.Forms.TextBox editDataExport;
    private System.Windows.Forms.TabPage tabEditor;
    private System.Windows.Forms.Button btnPaste;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.Button btnPasteFromClipboard;
    private System.Windows.Forms.Label labelCharInfo;
    private System.Windows.Forms.CheckBox checkMulticolor;
    private System.Windows.Forms.RadioButton radioCharColor;
    private System.Windows.Forms.RadioButton radioMulticolor2;
    private System.Windows.Forms.RadioButton radioMultiColor1;
    private System.Windows.Forms.RadioButton radioBackground;
    private System.Windows.Forms.ComboBox comboCharColor;
    private System.Windows.Forms.ComboBox comboMulticolor2;
    private System.Windows.Forms.ComboBox comboMulticolor1;
    private System.Windows.Forms.ComboBox comboBackground;
    private GR.Forms.FastPictureBox pictureEditor;
    private System.Windows.Forms.TabControl tabGraphicScreenEditor;
    private System.Windows.Forms.Button btnMirrorY;
    private System.Windows.Forms.Button btnMirrorX;
    private System.Windows.Forms.Button btnShiftDown;
    private System.Windows.Forms.Button btnShiftUp;
    private System.Windows.Forms.Button btnShiftRight;
    private System.Windows.Forms.Button btnShiftLeft;
    private GR.Forms.FastPictureBox charEditor;
    private System.Windows.Forms.Button btnExportAs;
    private System.Windows.Forms.Button btnCheck;
    private System.Windows.Forms.Label labelCharInfoExport;
    private System.Windows.Forms.ComboBox comboCheckType;
    private System.Windows.Forms.ComboBox comboExportType;
    private System.Windows.Forms.Button btnExportAsBinary;
    private System.Windows.Forms.ComboBox comboExportData;
    private System.Windows.Forms.HScrollBar screenHScroll;
    private System.Windows.Forms.VScrollBar screenVScroll;
    private System.Windows.Forms.ComboBox comboCharScreens;
    private System.Windows.Forms.Button btnExportToCharScreen;
    private System.Windows.Forms.Button btnApplyScreenSize;
    private System.Windows.Forms.TextBox editScreenHeight;
    private System.Windows.Forms.TextBox editScreenWidth;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TabPage tabColorMapping;
    private System.Windows.Forms.GroupBox groupColorMapping;
    private System.Windows.Forms.ComboBox comboColorMappingTargets;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listColorMappingColors;
    private ArrangedItemList listColorMappingTargets;



  }
}
