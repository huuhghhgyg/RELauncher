namespace RELauncher
{
    partial class LaunchForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("启动");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchForm));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.settingslLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loadSetttings2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.gameWidth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gameHeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveSettingBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.autoMemory = new MaterialSkin.Controls.MaterialFlatButton();
            this.autoJava = new MaterialSkin.Controls.MaterialFlatButton();
            this.memorySettings = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.javaPathText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usrName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveBtn2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.bgiLabel = new MaterialSkin.Controls.MaterialLabel();
            this.openDir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openPic = new MaterialSkin.Controls.MaterialFlatButton();
            this.launchModeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.launchMode2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.launchMode1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.nightButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.changeColor = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.needTime = new System.Windows.Forms.Label();
            this.downLabel2 = new System.Windows.Forms.Label();
            this.downLabel1 = new System.Windows.Forms.Label();
            this.downMod = new MaterialSkin.Controls.MaterialFlatButton();
            this.downAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.REJoiner = new MaterialSkin.Controls.MaterialLabel();
            this.REMaker = new MaterialSkin.Controls.MaterialLabel();
            this.RElabel = new MaterialSkin.Controls.MaterialLabel();
            this.downCal = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.materialListView1.Location = new System.Drawing.Point(0, 117);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(600, 282);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 48);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 111);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(800, 390);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "启动";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownWidth = 106;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(425, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Silver;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(634, 289);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(150, 60);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "启动";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.settingslLabel);
            this.tabPage2.Controls.Add(this.loadSetttings2);
            this.tabPage2.Controls.Add(this.settingsLabel1);
            this.tabPage2.Controls.Add(this.gameWidth);
            this.tabPage2.Controls.Add(this.gameHeight);
            this.tabPage2.Controls.Add(this.saveSettingBtn);
            this.tabPage2.Controls.Add(this.autoMemory);
            this.tabPage2.Controls.Add(this.autoJava);
            this.tabPage2.Controls.Add(this.memorySettings);
            this.tabPage2.Controls.Add(this.javaPathText);
            this.tabPage2.Controls.Add(this.usrName);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "游戏设置";
            // 
            // settingslLabel
            // 
            this.settingslLabel.AutoSize = true;
            this.settingslLabel.Depth = 0;
            this.settingslLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingslLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingslLabel.Location = new System.Drawing.Point(17, 24);
            this.settingslLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingslLabel.Name = "settingslLabel";
            this.settingslLabel.Size = new System.Drawing.Size(144, 27);
            this.settingslLabel.TabIndex = 10;
            this.settingslLabel.Text = "游戏基本设置";
            // 
            // loadSetttings2
            // 
            this.loadSetttings2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadSetttings2.AutoSize = true;
            this.loadSetttings2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadSetttings2.Depth = 0;
            this.loadSetttings2.Location = new System.Drawing.Point(704, 309);
            this.loadSetttings2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadSetttings2.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadSetttings2.Name = "loadSetttings2";
            this.loadSetttings2.Primary = false;
            this.loadSetttings2.Size = new System.Drawing.Size(67, 36);
            this.loadSetttings2.TabIndex = 9;
            this.loadSetttings2.Text = "load";
            this.loadSetttings2.UseVisualStyleBackColor = true;
            this.loadSetttings2.Click += new System.EventHandler(this.loadSetttings2_Click);
            // 
            // settingsLabel1
            // 
            this.settingsLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsLabel1.AutoSize = true;
            this.settingsLabel1.Depth = 0;
            this.settingsLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingsLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsLabel1.Location = new System.Drawing.Point(452, 24);
            this.settingsLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsLabel1.Name = "settingsLabel1";
            this.settingsLabel1.Size = new System.Drawing.Size(144, 27);
            this.settingsLabel1.TabIndex = 8;
            this.settingsLabel1.Text = "游戏窗口大小";
            // 
            // gameWidth
            // 
            this.gameWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameWidth.Depth = 0;
            this.gameWidth.Hint = "宽度";
            this.gameWidth.Location = new System.Drawing.Point(457, 86);
            this.gameWidth.MaxLength = 32767;
            this.gameWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameWidth.Name = "gameWidth";
            this.gameWidth.PasswordChar = '\0';
            this.gameWidth.SelectedText = "";
            this.gameWidth.SelectionLength = 0;
            this.gameWidth.SelectionStart = 0;
            this.gameWidth.Size = new System.Drawing.Size(291, 32);
            this.gameWidth.TabIndex = 7;
            this.gameWidth.TabStop = false;
            this.gameWidth.UseSystemPasswordChar = false;
            // 
            // gameHeight
            // 
            this.gameHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameHeight.Depth = 0;
            this.gameHeight.Hint = "高度";
            this.gameHeight.Location = new System.Drawing.Point(457, 148);
            this.gameHeight.MaxLength = 32767;
            this.gameHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameHeight.Name = "gameHeight";
            this.gameHeight.PasswordChar = '\0';
            this.gameHeight.SelectedText = "";
            this.gameHeight.SelectionLength = 0;
            this.gameHeight.SelectionStart = 0;
            this.gameHeight.Size = new System.Drawing.Size(291, 32);
            this.gameHeight.TabIndex = 6;
            this.gameHeight.TabStop = false;
            this.gameHeight.UseSystemPasswordChar = false;
            // 
            // saveSettingBtn
            // 
            this.saveSettingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveSettingBtn.AutoSize = true;
            this.saveSettingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSettingBtn.Depth = 0;
            this.saveSettingBtn.Location = new System.Drawing.Point(22, 309);
            this.saveSettingBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveSettingBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveSettingBtn.Name = "saveSettingBtn";
            this.saveSettingBtn.Primary = true;
            this.saveSettingBtn.Size = new System.Drawing.Size(65, 36);
            this.saveSettingBtn.TabIndex = 5;
            this.saveSettingBtn.Text = "save";
            this.saveSettingBtn.UseVisualStyleBackColor = true;
            this.saveSettingBtn.Click += new System.EventHandler(this.saveSettingBtn_Click);
            // 
            // autoMemory
            // 
            this.autoMemory.AutoSize = true;
            this.autoMemory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoMemory.Depth = 0;
            this.autoMemory.Location = new System.Drawing.Point(322, 216);
            this.autoMemory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.autoMemory.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoMemory.Name = "autoMemory";
            this.autoMemory.Primary = false;
            this.autoMemory.Size = new System.Drawing.Size(68, 36);
            this.autoMemory.TabIndex = 4;
            this.autoMemory.Text = "AUTO";
            this.autoMemory.UseVisualStyleBackColor = true;
            this.autoMemory.Click += new System.EventHandler(this.autoMemory_Click);
            // 
            // autoJava
            // 
            this.autoJava.AutoSize = true;
            this.autoJava.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoJava.Depth = 0;
            this.autoJava.Location = new System.Drawing.Point(322, 148);
            this.autoJava.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.autoJava.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoJava.Name = "autoJava";
            this.autoJava.Primary = false;
            this.autoJava.Size = new System.Drawing.Size(68, 36);
            this.autoJava.TabIndex = 3;
            this.autoJava.Text = "AUTO";
            this.autoJava.UseVisualStyleBackColor = true;
            this.autoJava.Click += new System.EventHandler(this.autoJava_Click);
            // 
            // memorySettings
            // 
            this.memorySettings.Depth = 0;
            this.memorySettings.Hint = "内存大小(MB)";
            this.memorySettings.Location = new System.Drawing.Point(22, 220);
            this.memorySettings.MaxLength = 32767;
            this.memorySettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.memorySettings.Name = "memorySettings";
            this.memorySettings.PasswordChar = '\0';
            this.memorySettings.SelectedText = "";
            this.memorySettings.SelectionLength = 0;
            this.memorySettings.SelectionStart = 0;
            this.memorySettings.Size = new System.Drawing.Size(293, 32);
            this.memorySettings.TabIndex = 2;
            this.memorySettings.TabStop = false;
            this.memorySettings.UseSystemPasswordChar = false;
            // 
            // javaPathText
            // 
            this.javaPathText.Depth = 0;
            this.javaPathText.Hint = "Java路径";
            this.javaPathText.Location = new System.Drawing.Point(22, 148);
            this.javaPathText.MaxLength = 32767;
            this.javaPathText.MouseState = MaterialSkin.MouseState.HOVER;
            this.javaPathText.Name = "javaPathText";
            this.javaPathText.PasswordChar = '\0';
            this.javaPathText.SelectedText = "";
            this.javaPathText.SelectionLength = 0;
            this.javaPathText.SelectionStart = 0;
            this.javaPathText.Size = new System.Drawing.Size(293, 32);
            this.javaPathText.TabIndex = 1;
            this.javaPathText.TabStop = false;
            this.javaPathText.UseSystemPasswordChar = false;
            // 
            // usrName
            // 
            this.usrName.Depth = 0;
            this.usrName.Hint = "用户名";
            this.usrName.Location = new System.Drawing.Point(22, 86);
            this.usrName.MaxLength = 32767;
            this.usrName.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrName.Name = "usrName";
            this.usrName.PasswordChar = '\0';
            this.usrName.SelectedText = "";
            this.usrName.SelectionLength = 0;
            this.usrName.SelectionStart = 0;
            this.usrName.Size = new System.Drawing.Size(368, 32);
            this.usrName.TabIndex = 0;
            this.usrName.TabStop = false;
            this.usrName.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.saveBtn2);
            this.tabPage3.Controls.Add(this.bgiLabel);
            this.tabPage3.Controls.Add(this.openDir);
            this.tabPage3.Controls.Add(this.openPic);
            this.tabPage3.Controls.Add(this.launchModeLabel);
            this.tabPage3.Controls.Add(this.launchMode2);
            this.tabPage3.Controls.Add(this.launchMode1);
            this.tabPage3.Controls.Add(this.nightButton);
            this.tabPage3.Controls.Add(this.changeColor);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "启动器设置";
            // 
            // saveBtn2
            // 
            this.saveBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn2.AutoSize = true;
            this.saveBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn2.Depth = 0;
            this.saveBtn2.Location = new System.Drawing.Point(26, 315);
            this.saveBtn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn2.Name = "saveBtn2";
            this.saveBtn2.Primary = false;
            this.saveBtn2.Size = new System.Drawing.Size(65, 36);
            this.saveBtn2.TabIndex = 9;
            this.saveBtn2.Text = "save";
            this.saveBtn2.UseVisualStyleBackColor = true;
            this.saveBtn2.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // bgiLabel
            // 
            this.bgiLabel.AutoSize = true;
            this.bgiLabel.Depth = 0;
            this.bgiLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.bgiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bgiLabel.Location = new System.Drawing.Point(378, 18);
            this.bgiLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bgiLabel.Name = "bgiLabel";
            this.bgiLabel.Size = new System.Drawing.Size(144, 27);
            this.bgiLabel.TabIndex = 8;
            this.bgiLabel.Text = "背景图片更换";
            // 
            // openDir
            // 
            this.openDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openDir.Depth = 0;
            this.openDir.Hint = "路径(先点open)";
            this.openDir.Location = new System.Drawing.Point(383, 238);
            this.openDir.MaxLength = 32767;
            this.openDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.openDir.Name = "openDir";
            this.openDir.PasswordChar = '\0';
            this.openDir.SelectedText = "";
            this.openDir.SelectionLength = 0;
            this.openDir.SelectionStart = 0;
            this.openDir.Size = new System.Drawing.Size(312, 32);
            this.openDir.TabIndex = 7;
            this.openDir.TabStop = false;
            this.openDir.UseSystemPasswordChar = false;
            // 
            // openPic
            // 
            this.openPic.AutoSize = true;
            this.openPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openPic.Depth = 0;
            this.openPic.Location = new System.Drawing.Point(715, 241);
            this.openPic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openPic.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPic.Name = "openPic";
            this.openPic.Primary = false;
            this.openPic.Size = new System.Drawing.Size(68, 36);
            this.openPic.TabIndex = 6;
            this.openPic.Text = "open";
            this.openPic.UseVisualStyleBackColor = true;
            this.openPic.Click += new System.EventHandler(this.openPic_Click);
            // 
            // launchModeLabel
            // 
            this.launchModeLabel.AutoSize = true;
            this.launchModeLabel.Depth = 0;
            this.launchModeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.launchModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.launchModeLabel.Location = new System.Drawing.Point(21, 18);
            this.launchModeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchModeLabel.Name = "launchModeLabel";
            this.launchModeLabel.Size = new System.Drawing.Size(100, 27);
            this.launchModeLabel.TabIndex = 4;
            this.launchModeLabel.Text = "启动模式";
            // 
            // launchMode2
            // 
            this.launchMode2.AutoSize = true;
            this.launchMode2.Depth = 0;
            this.launchMode2.Font = new System.Drawing.Font("Roboto", 10F);
            this.launchMode2.Location = new System.Drawing.Point(26, 99);
            this.launchMode2.Margin = new System.Windows.Forms.Padding(0);
            this.launchMode2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.launchMode2.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchMode2.Name = "launchMode2";
            this.launchMode2.Ripple = true;
            this.launchMode2.Size = new System.Drawing.Size(144, 30);
            this.launchMode2.TabIndex = 3;
            this.launchMode2.Text = "BMCL Mode";
            this.launchMode2.UseVisualStyleBackColor = true;
            this.launchMode2.CheckedChanged += new System.EventHandler(this.launchMode2_CheckedChanged);
            // 
            // launchMode1
            // 
            this.launchMode1.AutoSize = true;
            this.launchMode1.Checked = true;
            this.launchMode1.Cursor = System.Windows.Forms.Cursors.Default;
            this.launchMode1.Depth = 0;
            this.launchMode1.Font = new System.Drawing.Font("Roboto", 10F);
            this.launchMode1.Location = new System.Drawing.Point(26, 57);
            this.launchMode1.Margin = new System.Windows.Forms.Padding(0);
            this.launchMode1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.launchMode1.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchMode1.Name = "launchMode1";
            this.launchMode1.Ripple = true;
            this.launchMode1.Size = new System.Drawing.Size(206, 30);
            this.launchMode1.TabIndex = 2;
            this.launchMode1.TabStop = true;
            this.launchMode1.Text = "MCLauncher Mode";
            this.launchMode1.UseVisualStyleBackColor = true;
            this.launchMode1.CheckedChanged += new System.EventHandler(this.launchMode1_CheckedChanged);
            // 
            // nightButton
            // 
            this.nightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nightButton.AutoSize = true;
            this.nightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nightButton.Depth = 0;
            this.nightButton.Location = new System.Drawing.Point(592, 315);
            this.nightButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nightButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nightButton.Name = "nightButton";
            this.nightButton.Primary = false;
            this.nightButton.Size = new System.Drawing.Size(76, 36);
            this.nightButton.TabIndex = 1;
            this.nightButton.Text = "Night";
            this.nightButton.UseVisualStyleBackColor = true;
            // 
            // changeColor
            // 
            this.changeColor.AllowDrop = true;
            this.changeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeColor.AutoSize = true;
            this.changeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeColor.Depth = 0;
            this.changeColor.Location = new System.Drawing.Point(703, 315);
            this.changeColor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeColor.Name = "changeColor";
            this.changeColor.Primary = true;
            this.changeColor.Size = new System.Drawing.Size(80, 36);
            this.changeColor.TabIndex = 0;
            this.changeColor.Text = "color";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(383, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialFlatButton1);
            this.tabPage4.Controls.Add(this.needTime);
            this.tabPage4.Controls.Add(this.downLabel2);
            this.tabPage4.Controls.Add(this.downLabel1);
            this.tabPage4.Controls.Add(this.downMod);
            this.tabPage4.Controls.Add(this.downAll);
            this.tabPage4.Controls.Add(this.materialProgressBar1);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 358);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mod客户端";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(674, 299);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(92, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "update";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // needTime
            // 
            this.needTime.AutoSize = true;
            this.needTime.Location = new System.Drawing.Point(530, 121);
            this.needTime.Name = "needTime";
            this.needTime.Size = new System.Drawing.Size(179, 18);
            this.needTime.TabIndex = 8;
            this.needTime.Text = "正在计算剩余时间...";
            this.needTime.Visible = false;
            // 
            // downLabel2
            // 
            this.downLabel2.AutoSize = true;
            this.downLabel2.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downLabel2.Location = new System.Drawing.Point(29, 115);
            this.downLabel2.Name = "downLabel2";
            this.downLabel2.Size = new System.Drawing.Size(82, 24);
            this.downLabel2.TabIndex = 7;
            this.downLabel2.Text = "下载:Null";
            // 
            // downLabel1
            // 
            this.downLabel1.AutoSize = true;
            this.downLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downLabel1.Location = new System.Drawing.Point(27, 44);
            this.downLabel1.Name = "downLabel1";
            this.downLabel1.Size = new System.Drawing.Size(127, 36);
            this.downLabel1.TabIndex = 6;
            this.downLabel1.Text = "未在下载";
            // 
            // downMod
            // 
            this.downMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downMod.AutoSize = true;
            this.downMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downMod.Depth = 0;
            this.downMod.Enabled = false;
            this.downMod.Location = new System.Drawing.Point(533, 299);
            this.downMod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.downMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.downMod.Name = "downMod";
            this.downMod.Primary = false;
            this.downMod.Size = new System.Drawing.Size(118, 36);
            this.downMod.TabIndex = 3;
            this.downMod.Text = "Mod Only";
            this.downMod.UseVisualStyleBackColor = true;
            this.downMod.Click += new System.EventHandler(this.downMod_Click);
            // 
            // downAll
            // 
            this.downAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downAll.AutoSize = true;
            this.downAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downAll.Depth = 0;
            this.downAll.Enabled = false;
            this.downAll.Location = new System.Drawing.Point(423, 299);
            this.downAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.downAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.downAll.Name = "downAll";
            this.downAll.Primary = false;
            this.downAll.Size = new System.Drawing.Size(82, 36);
            this.downAll.TabIndex = 2;
            this.downAll.Text = "全量包";
            this.downAll.UseVisualStyleBackColor = true;
            this.downAll.Click += new System.EventHandler(this.downAll_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(29, 94);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(737, 5);
            this.materialProgressBar1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel5);
            this.tabPage5.Controls.Add(this.materialLabel4);
            this.tabPage5.Controls.Add(this.REJoiner);
            this.tabPage5.Controls.Add(this.REMaker);
            this.tabPage5.Controls.Add(this.RElabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 358);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "关于";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(10, 191);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(383, 27);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "感谢KMCCC,Material Skin 项目的开源";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(10, 315);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(152, 27);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Ver:1.0 Build3";
            // 
            // REJoiner
            // 
            this.REJoiner.AutoSize = true;
            this.REJoiner.Depth = 0;
            this.REJoiner.Font = new System.Drawing.Font("Roboto", 11F);
            this.REJoiner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.REJoiner.Location = new System.Drawing.Point(10, 140);
            this.REJoiner.MouseState = MaterialSkin.MouseState.HOVER;
            this.REJoiner.Name = "REJoiner";
            this.REJoiner.Size = new System.Drawing.Size(233, 27);
            this.REJoiner.TabIndex = 2;
            this.REJoiner.Text = "\"Joiner\":Nuke,locceed";
            // 
            // REMaker
            // 
            this.REMaker.AutoSize = true;
            this.REMaker.Depth = 0;
            this.REMaker.Font = new System.Drawing.Font("Roboto", 11F);
            this.REMaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.REMaker.Location = new System.Drawing.Point(10, 92);
            this.REMaker.MouseState = MaterialSkin.MouseState.HOVER;
            this.REMaker.Name = "REMaker";
            this.REMaker.Size = new System.Drawing.Size(190, 27);
            this.REMaker.TabIndex = 1;
            this.REMaker.Text = "作者:huuhghhgyg";
            // 
            // RElabel
            // 
            this.RElabel.AutoSize = true;
            this.RElabel.Depth = 0;
            this.RElabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RElabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RElabel.Location = new System.Drawing.Point(8, 20);
            this.RElabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RElabel.Name = "RElabel";
            this.RElabel.Size = new System.Drawing.Size(139, 27);
            this.RElabel.TabIndex = 0;
            this.RElabel.Text = "RELauncher";
            // 
            // downCal
            // 
            this.downCal.Interval = 1000;
            this.downCal.Tick += new System.EventHandler(this.downCal_Tick);
            // 
            // LaunchForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialListView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LaunchForm";
            this.Text = "RELauncher";
            this.Load += new System.EventHandler(this.LaunchForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialSingleLineTextField memorySettings;
        private MaterialSkin.Controls.MaterialSingleLineTextField javaPathText;
        private MaterialSkin.Controls.MaterialSingleLineTextField usrName;
        private MaterialSkin.Controls.MaterialFlatButton saveSettingBtn;
        private MaterialSkin.Controls.MaterialFlatButton autoMemory;
        private MaterialSkin.Controls.MaterialFlatButton autoJava;
        private MaterialSkin.Controls.MaterialFlatButton changeColor;
        private MaterialSkin.Controls.MaterialFlatButton nightButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel settingsLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField gameWidth;
        private MaterialSkin.Controls.MaterialSingleLineTextField gameHeight;
        private MaterialSkin.Controls.MaterialRadioButton launchMode2;
        private MaterialSkin.Controls.MaterialRadioButton launchMode1;
        private MaterialSkin.Controls.MaterialLabel launchModeLabel;
        private MaterialSkin.Controls.MaterialFlatButton openPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField openDir;
        private MaterialSkin.Controls.MaterialFlatButton loadSetttings2;
        private MaterialSkin.Controls.MaterialLabel settingslLabel;
        private MaterialSkin.Controls.MaterialLabel bgiLabel;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel REJoiner;
        private MaterialSkin.Controls.MaterialLabel REMaker;
        private MaterialSkin.Controls.MaterialLabel RElabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton saveBtn2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialFlatButton downMod;
        private MaterialSkin.Controls.MaterialFlatButton downAll;
        private System.Windows.Forms.Timer downCal;
        private System.Windows.Forms.Label needTime;
        private System.Windows.Forms.Label downLabel1;
        private System.Windows.Forms.Label downLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

