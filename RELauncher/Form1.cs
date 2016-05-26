using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Configuration;
using System.Linq;
using KMCCC.Launcher;
using KMCCC.Authentication;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading;

namespace RELauncher
{
    public partial class LaunchForm : MaterialForm
    {
        //定义的全局变量
        public int colorSchemeIndex = 0;
        private string NightMode;
        public int launchModeInt;//判断启动模式值
        double nowVer = 0.12;

        private readonly MaterialSkinManager materialSkinManager;
        public LaunchForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void loadSettings()             //启动时读取的信息
        {
            if (!File.Exists("./RELauncher.exe.config"))
            {
                string[] lines = { "<?xml version=\"1.0\" encoding=\"utf-8\"?>",
                    "<configuration>",
                    "  <appSettings>",
                    "    <add key=\"usrname\" value=\"\"/>",
                    "    <add key=\"passwd\" value=\"\"/>",
                    "    <add key=\"JavaPath\" value=\"\"/>",
                    "    <add key=\"memory\" value=\"\"/>",
                    "    <add key=\"color\" value=\"\"/>",
                    "    <add key=\"Nightmode\" value=\"\"/>",
                    "    <add key=\"GameHeight\" value=\"\"/>",
                    "    <add key=\"GameWidth\" value=\"\"/>",
                    "    <add key=\"LaunchMode\" value=\"\"/>",
                    "    <add key=\"ClientSettingsProvider.ServiceUri\" value=\"\"/>",
                    "  </appSettings>",
                    "",
                    "<startup><supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.5\"/></startup></configuration>",
};
                System.IO.File.WriteAllLines(@"./RELauncher.exe.config", lines, Encoding.UTF8);
            }

            this.usrName.Text = ConfigurationManager.AppSettings["usrname"];
            this.javaPathText.Text = ConfigurationManager.AppSettings["JavaPath"];
            this.memorySettings.Text = ConfigurationManager.AppSettings["memory"];
            string colorSchemeIndexread;
            colorSchemeIndexread = ConfigurationManager.AppSettings["color"];
            NightMode = ConfigurationManager.AppSettings["Nightmode"];
            if (File.Exists("./bgi.jpg"))
            {
                FileStream inputStream = new FileStream("./bgi.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                pictureBox1.Image = new Bitmap(inputStream);
                tabPage1.BackgroundImage = new Bitmap(inputStream);
                inputStream.Dispose();
            }
            else
            {
                tabPage1.BackgroundImage = Properties.Resources.Material;
            }
            if ((ConfigurationManager.AppSettings["LaunchMode"] != "2"))
            {
                launchModeInt = 1;
                launchMode1.Checked = true;
            }
            else
            {
                launchModeInt = 2;
                launchMode2.Checked = true;
            }
            Cleanner();
            loadVersion();
            Thread chkUpdate = new Thread(new ThreadStart(checkUpdate));
            chkUpdate.IsBackground = true;
            chkUpdate.Start();
        }

        private void checkUpdate()
        {
            try
            {
                string newVerStr;
                double newVer;
                try
                {
                    DownloadFile("http://huuhghhgyg.github.io/REVercheck.txt", "ver.txt", materialProgressBar1, downLabel2);
                    newVerStr = System.IO.File.ReadAllText(@"./ver.txt");
                    newVer = Convert.ToDouble(newVerStr);
                    if (nowVer < newVer)
                    {
                        MessageBox.Show("启动器有更新，可到下载中心点击Update下载");
                    }
                    materialProgressBar1.Value = 0;
                    downLabel2.Text = "下载:Null";
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void loadVersion()              //读取游戏列表
        {
            var versions = Program.Core.GetVersions().ToArray();
            comboBox1.DataSource = versions;//绑定数据源
            comboBox1.DisplayMember = "Id";//设置comboBox显示的为版本Id
        }

        private void LaunchIt()
        {
            try
            {
                var ver = (KMCCC.Launcher.Version)comboBox1.SelectedItem;
                if (launchModeInt == 1)
                {
                    if (gameHeight.Text == "" && gameWidth.Text == "" || gameHeight.Text == null && gameWidth.Text == null)
                    {
                        gameHeight.Text = "720";
                        gameWidth.Text = "1280";
                    }
                    var result = Program.Core.Launch(new LaunchOptions
                    {
                        Version = ver, //Ver为Versions里你要启动的版本名字
                        MaxMemory = int.Parse(memorySettings.Text), //最大内存，int类型
                        Authenticator = new OfflineAuthenticator(usrName.Text), //离线启动，ZhaiSoul那儿为你要设置的游戏名

                        //Authenticator = new YggdrasilLogin("邮箱", "密码", true), // 正版启动，最后一个为是否twitch登录

                        Mode = LaunchMode.MCLauncher, //启动模式，这个我会在后面解释有哪几种
                        Size = new WindowSize { Height = Convert.ToUInt16(gameHeight.Text), Width = Convert.ToUInt16(gameWidth.Text) } //设置窗口大小，可以不要}
                    });
                    if (!result.Success)
                    {
                        //MessageBox.Show(result.ErrorMessage, result.ErrorType.ToString());
                        switch (result.ErrorType)
                        {
                            case ErrorType.NoJAVA:
                                MessageBox.Show("你系统的Java有异常，可能你非正常途径删除过Java，请尝试重新安装Java\n详细信息：" + result.ErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case ErrorType.AuthenticationFailed:
                                MessageBox.Show(this, "正版验证失败！请检查你的账号密码", "账号错误\n详细信息：" + result.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case ErrorType.UncompressingFailed:
                                MessageBox.Show(this, "可能的多开或文件损坏，请确认文件完整且不要多开\n如果你不是多开游戏的话，请检查libraries文件夹是否完整\n详细信息：" + result.ErrorMessage, "可能的多开或文件损坏", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show(this,
                                    result.ErrorMessage + "\n" +
                                    (result.Exception == null ? string.Empty : result.Exception.StackTrace),
                                    "启动错误，请将此窗口截图向开发者寻求帮助");
                                break;
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    var result = Program.Core.Launch(new LaunchOptions
                    {
                        Version = ver, //Ver为Versions里你要启动的版本名字
                        MaxMemory = int.Parse(memorySettings.Text), //最大内存，int类型
                        Authenticator = new OfflineAuthenticator(usrName.Text), //离线启动，ZhaiSoul那儿为你要设置的游戏名

                        //Authenticator = new YggdrasilLogin("邮箱", "密码", true), // 正版启动，最后一个为是否twitch登录

                        Mode = LaunchMode.BmclMode, //启动模式，这个我会在后面解释有哪几种

                        Size = new WindowSize { Height = Convert.ToUInt16(gameHeight.Text), Width = Convert.ToUInt16(gameWidth.Text) } //设置窗口大小，可以不要
                    });
                    if (!result.Success)
                    {
                        //MessageBox.Show(result.ErrorMessage, result.ErrorType.ToString());
                        switch (result.ErrorType)
                        {
                            case ErrorType.NoJAVA:
                                MessageBox.Show("你系统的Java有异常，可能你非正常途径删除过Java，请尝试重新安装Java\n详细信息：" + result.ErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case ErrorType.AuthenticationFailed:
                                MessageBox.Show(this, "正版验证失败！请检查你的账号密码", "账号错误\n详细信息：" + result.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case ErrorType.UncompressingFailed:
                                MessageBox.Show(this, "可能的多开或文件损坏，请确认文件完整且不要多开\n如果你不是多开游戏的话，请检查libraries文件夹是否完整\n详细信息：" + result.ErrorMessage, "可能的多开或文件损坏", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show(this,
                                    result.ErrorMessage + "\n" +
                                    (result.Exception == null ? string.Empty : result.Exception.StackTrace),
                                    "启动错误，请将此窗口截图向开发者寻求帮助");
                                break;
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch
            {
            }
            }
       
        public void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog, System.Windows.Forms.Label downLabel1)
        {
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    string percent2 = Convert.ToDouble(percent).ToString("0.0");
                    downLabel2.Text = "已下载" + percent2.ToString() + "%";
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Cleanner()//下载文件清理专家
        {
            if (File.Exists("./.minecraft.zip"))
            {
                File.Delete("./.minecraft.zip");
            }
            if (File.Exists("./.minecraft/versions/1.7.10-Forge10.13.4.1490-1.7.10/mods.zip"))
            {
                File.Delete("./.minecraft/versions/1.7.10-Forge10.13.4.1490-1.7.10/mods.zip");
            }
            if (File.Exists("./ver.txt"))
            {
                File.Delete("./ver.txt");
            }
        }


        private void changeColor_Click(object sender, EventArgs e)            //换个颜色
        {
            //判断是否为夜晚模式
            if (NightMode == "true")
            {
                materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
                NightMode = "false";
            }
            colorSchemeIndex++;
            if (colorSchemeIndex > 10) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    nightButton.Visible = true;
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange600, Primary.Orange700, Primary.Orange200, Accent.Amber100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Teal200, Accent.Teal100, TextShade.WHITE);
                    nightButton.Visible = true;
                    break;
                case 5:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple700, Primary.Purple200, Accent.Purple100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 6:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink200, Accent.Red100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 7:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal200, Accent.Teal100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 8:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan600, Primary.Cyan700, Primary.Cyan200, Accent.Teal100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 9:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.LightGreen100, TextShade.WHITE);
                    nightButton.Visible = false;
                    break;
                case 10:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.Teal700, TextShade.WHITE);
                    break;
            }
        }
        private void SaveSettings()
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["usrname"].Value = usrName.Text;
            cfa.AppSettings.Settings["JavaPath"].Value = javaPathText.Text;
            cfa.AppSettings.Settings["memory"].Value = memorySettings.Text;
            cfa.AppSettings.Settings["color"].Value = colorSchemeIndex.ToString();
            cfa.AppSettings.Settings["Nightmode"].Value = NightMode;
            cfa.AppSettings.Settings["GameHeight"].Value = gameHeight.Text;
            cfa.AppSettings.Settings["GameWidth"].Value = gameWidth.Text;
            cfa.AppSettings.Settings["LaunchMode"].Value = launchModeInt.ToString();

            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void LaunchForm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void saveSettingBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (usrName.Text != "" && javaPathText.Text != "" && memorySettings.Text != "")
            {

                LaunchIt();
            }
            else
            {
                MessageBox.Show("骚年你好像漏了什么没填哦~", "设置不完善(RELauncher)");
            }
        }

        private void launchMode1_CheckedChanged(object sender, EventArgs e)
        {
            if (launchMode1.Checked == true)
            {
                launchModeInt = 1;//判断是否为mclauncher模式启动
            }
        }

        private void launchMode2_CheckedChanged(object sender, EventArgs e)
        {
            if (launchMode2.Checked == true)
            {
                launchModeInt = 2;//判断是否为mclauncher模式启动
            }
        }

        private void autoJava_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("请确定您安装了Java", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                javaPathText.Text = KMCCC.Tools.SystemTools.FindJava().Last();//textbox1显示我们找到的最后一个Java（也是最近安装的一个）
            }
        }

        private void openPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\Patch";
            openFileDialog1.Filter = "Image files (*.*)|*.*|jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openDir.Text = openFileDialog1.FileName;
            }
            tabPage1.BackgroundImage = Properties.Resources.Material;
            FileStream inputStream = new FileStream(openDir.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            pictureBox1.Image = new Bitmap(inputStream);
            tabPage1.BackgroundImage = new Bitmap(inputStream);
            inputStream.Dispose();
            File.Copy(openDir.Text, "./bgi.jpg", true);
        }

        private void autoMemory_Click(object sender, EventArgs e)
        {
            memorySettings.Text = "1024";
        }

        private void loadSetttings2_Click(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void downAll_Click(object sender, EventArgs e)
        {
            if (downLabel1.Text == "正在下载" || downLabel1.Text == "正在安装")
            {
                MessageBox.Show("正在下载包，请稍候", "警告");
            }
            else
            {
                downLabel1.Text = "正在下载";
                downLabel2.Text = "已下载:0%";

                a = 0; b = 0; c = 0; percent = 0; totalDownloadedByte = 0;
                downCal.Enabled = true;
                needTime.Visible = true;
                needTime.Text = "正在计算剩余时间...";
                DownloadFile("http://download.zcraft.cn/.minecraft.zip", @"./.minecraft.zip", materialProgressBar1, downLabel2);
                downCal.Enabled = false;

                downLabel1.Text = "正在安装:全量包";
                if (File.Exists("./.minecraft"))//删除原有文件夹:  .minecraft
                {
                    File.Delete("./.minecraft");
                }

                System.IO.Compression.ZipFile.ExtractToDirectory("./.minecraft.zip", "./");//解压
                MessageBox.Show("全量包安装完成", "安装服务");
                downLabel1.Text = "未在下载";
                downLabel2.Text = "下载:Null";
                needTime.Visible = false;
                loadVersion();
            }
        }

        int a;
        double b;
        int c;
        float percent = 0;
        long totalDownloadedByte = 0;

        private void downCal_Tick(object sender, EventArgs e)
        {
            a = a + 1;
            if (a > 5)
            {
                if (a == 0 || materialProgressBar1.Value == 0)
                {
                    b = 0;
                }
                else
                {
                    b = (100 - (int)percent) / ((double)percent / a);
                    c = (int)b;
                    needTime.Text = "剩余时间:" + c.ToString() + "秒";
                }
            }
        }

        private void downMod_Click(object sender, EventArgs e)
        {
            if (downLabel1.Text == "正在下载" || downLabel1.Text == "正在安装")
            {
                MessageBox.Show("正在下载包，请稍候", "警告");
            }
            else
            {
                downLabel1.Text = "正在下载";
                downLabel2.Text = "已下载:0%";

                a = 0; b = 0; c = 0; percent = 0; totalDownloadedByte = 0;
                downCal.Enabled = true;
                needTime.Visible = true;
                needTime.Text = "正在计算剩余时间...";
                DownloadFile("http://download.zcraft.cn/mods.zip", @"./mods.zip", materialProgressBar1, downLabel2);
                downCal.Enabled = false;

                /*开始安装*/
                downLabel1.Text = "正在安装:Mod包";//删除原有文件夹:  .minecraft
                if (File.Exists("./.minecraft/versions/1.7.10-Forge10.13.4.1490-1.7.10/mods"))
                {
                    File.Delete("./.minecraft/versions/1.7.10-Forge10.13.4.1490-1.7.10/mods");
                    System.IO.Compression.ZipFile.ExtractToDirectory(
                        "./mods.zip",
                        "./.minecraft/versions/1.7.10-Forge10.13.4.1490-1.7.10"
                        );

                    Cleanner();
                }
                else
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(
                    ".mods.zip",
                    "./.minecraft"
                    );
                    Cleanner();
                }
                MessageBox.Show("安装mod文件完成", "安装服务");
                    downLabel1.Text = "未在下载";
                    downLabel2.Text = "下载:Null";
                    materialProgressBar1.Value = 0;

                    needTime.Visible = false;//隐藏下载时间
            }
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            /*检查更新*/
            string newVerStr;
            double newVer;
                newVerStr = System.IO.File.ReadAllText(@"./ver.txt");
                newVer = Convert.ToDouble(newVerStr);
                materialProgressBar1.Value = 0;
                downLabel2.Text = "下载:Null";
                if (nowVer < newVer)
                {
                    try
                    {
                    downLabel1.Text = "正在更新启动器";
                    DownloadFile("http://huuhghhgyg.github.io/RELauncher.exe", "RELauncherUpdated.exe", materialProgressBar1, downLabel2);
                    downLabel1.Text = "未在下载";
                    downLabel2.Text = "下载:Null";
                    materialProgressBar1.Value = 0;
                    MessageBox.Show("新版启动器下载完成，已命名为RELauncherUpdated。\n请及时删除本版启动器并更改新启动器名为RELauncher以便下次能够正常更新");
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
