using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;
using System.Resources;
using System.Globalization;

namespace DesktopManager
{
    public partial class Form1 : Form
    {
        #region Constants
        //Import System ParametersInfo from user32.dll to set Wallpater ;)
        [DllImport("c:\\Windows\\system32\\user32.dll")]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);     
        //private string OFDFilter = "Bitmap Files(*.BMP)|*.BMP|All files (*.*)|*.*";
        private string OFDFilter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        //"Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        // Localisation thing
        private ResourceManager m_ResourceManager = new ResourceManager("DesktopManager.lang", System.Reflection.Assembly.GetExecutingAssembly());
        private CultureInfo m_EngCulture = new CultureInfo("en-US");
        private CultureInfo m_RusCulture = new CultureInfo("ru-RU");

        private string sBackground;
        //private string sProgDir = "c:\\Documents and Settings\\mhorbanov.GC2083\\My Documents\\Visual Studio 2008\\Projects\\DesktopManager\\DesktopManager\\bin\\Debug\\";
        //private string sProgDir = "c:\\Users\\maxim\\Desktop\\src\\DesktopManager\\DesktopManager\\bin\\Debug\\";
        //private string sProgDir = Directory.GetCurrentDirectory();
        private string sProgDir = Path.GetDirectoryName(Application.ExecutablePath)+"\\";
        private string sWallpaper = "wallpaper.bmp";
        private string sLastScannedDir;
        private string sSearchPatern = "*.jpg";
        
        #endregion
        public Form1()
        {
            InitializeComponent();            
        }        
        
        #region Language
        private void updateUI()
        {
            bSetWallpaper.Text = m_ResourceManager.GetString("bSetWallpaper");
            bAdd.Text = m_ResourceManager.GetString("bAdd");
            bRemove.Text = m_ResourceManager.GetString("bRemove");
            bListAddDir.Text = m_ResourceManager.GetString("bListAddDir");
            bClearList.Text = m_ResourceManager.GetString("bClearList");
            bListSave.Text = m_ResourceManager.GetString("bListSave");
            bListLoad.Text = m_ResourceManager.GetString("bListLoad");
            tabPage1.Text = m_ResourceManager.GetString("tabPage1");
            tabPage3.Text = m_ResourceManager.GetString("tabPage3");
            tabPage4.Text = m_ResourceManager.GetString("tabPage4");
            groupWall.Text = m_ResourceManager.GetString("groupWall");
            groupStyle.Text = m_ResourceManager.GetString("groupStyle");
            groupTimer.Text = m_ResourceManager.GetString("groupTimer");
            radioCenter.Text = m_ResourceManager.GetString("radioCenter");
            radioTile.Text = m_ResourceManager.GetString("radioTile");
            cbStretch.Text = m_ResourceManager.GetString("cbStretch");
            groupTimer.Text = m_ResourceManager.GetString("groupTimer");
            cbUseTimer.Text = m_ResourceManager.GetString("cbUseTimer");
            groupLanguage.Text = m_ResourceManager.GetString("groupLanguage");
            groupList.Text = m_ResourceManager.GetString("groupList");
        }
        private void changeLang()
        {
            switch (cbLanguage.SelectedItem.ToString())
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = m_EngCulture;
                    updateUI();
                    break;
                case "Russian":
                    Thread.CurrentThread.CurrentUICulture = m_RusCulture;
                    updateUI();
                    break;
            }

        }
        
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeLang();
        }

        private void cbLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            changeLang();
        }
        #endregion
        //Recursively search for needed files
        private void DirSearch(string sDir)
        {
            foreach (string f in Directory.GetFiles(sDir, sSearchPatern))
            {
                listCurrent.Items.Add(f);
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {                
                DirSearch(d);
            }
        }
        #region Regestry
        private void GetRegData()
        {
            RegistryKey BmpPath = Registry.CurrentUser;
            BmpPath = BmpPath.OpenSubKey("Control Panel\\Desktop\\");
            sBackground = BmpPath.GetValue("Wallpaper").ToString();
            BmpPath.Close();
        }
        private void SetRegData(string sWallName)
        {
            RegistryKey BmpPath = Registry.CurrentUser;
            BmpPath = BmpPath.OpenSubKey("Control Panel\\Desktop\\", true);
            object bmpName, optionTile, optionStretch;
            bmpName = sWallName;
            optionTile = "0";
            optionStretch = "0";

            //GetOptions
            if (radioTile.Checked == true)
                optionTile = "1";
            if (radioCenter.Checked == true)
                optionTile = "0";
            if (cbStretch.Checked == true)
                optionStretch = "2";
            //if (radioTile.Checked == true)
            //    Tile = "1";
            //if (radioCenter.Checked == true)
            //    Tile = "0";
            //if (checkStretch.Checked == true)
            //    Stretch = "2";

            BmpPath.SetValue("WallpaperStyle", optionStretch);
            BmpPath.SetValue("Wallpaper", bmpName);
            BmpPath.SetValue("TileWallpaper", optionTile);
            BmpPath.Close();
        }
        #endregion
        #region Wallpaper
        private void bSetWallpaper_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Start();
                timerTick();
            }
            else
                SetWallpaper();
        }
        private void SetWallpaper()
        {
            ConvertImageToBMP(listCurrent.SelectedItem.ToString());
            SetWallpaperBMP(sProgDir + sWallpaper);
        }
        private void SetWallpaperBMP(string sWallpaper)
        {
            //string CurrentItem = listCurrent.SelectedItem.ToString();
            SetRegData(sWallpaper);
            SystemParametersInfo(0x0014, 0, sWallpaper, 0);
            //statusBar1.Text = CurrentItem;
            //InitTimer((double)timeToChange.Value);
        }
        private void ConvertImageToBMP(string sImage)
        {
            //string curDir = Directory.GetCurrentDirectory();
            if (Directory.Exists(sProgDir))
            {
                Image iCurrent = Image.FromFile(sImage);
                //string sNewName = System.IO.Path.GetFileNameWithoutExtension(sImage);
                //sNewName = sProgDir + sNewName + ".bmp";
                //iCurrent.Save(sNewName, ImageFormat.Bmp);                
                iCurrent.Save(sProgDir + sWallpaper, ImageFormat.Bmp);
            }
        }
        #endregion
        #region Notify Icon & Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hideAndShow()
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();                
                WindowState = FormWindowState.Minimized;
            }
            else
                if (WindowState == FormWindowState.Minimized)
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                } 
        }
        private void notifyIconStatus_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                hideAndShow();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            hideAndShow();
        }
        
        #endregion        
        #region Settings (Load&Save)
        //Load last added directory
        private void loadLastDir(string lastDir)
        {
            if (lastDir != null)
            {
                DirectoryInfo di = new DirectoryInfo(lastDir);
                if (di.Exists)
                {
                    DirSearch(lastDir);
                    listCurrent.SelectedIndex = 0;
                    setUpTimer();
                }
            }
        }
        private void readSettings()
        {
            //Load Style settings
            cbStretch.Checked = DesktopManager.Properties.Settings.Default.style_Stretch;
            radioCenter.Checked = DesktopManager.Properties.Settings.Default.style_Center;
            radioTile.Checked = DesktopManager.Properties.Settings.Default.style_Tyle;            
            // Load Timer settings
            cbUseTimer.Checked = DesktopManager.Properties.Settings.Default.timer_Use;
            numericTimer.Value = DesktopManager.Properties.Settings.Default.timer_Time;
            cbLanguage.SelectedItem = DesktopManager.Properties.Settings.Default.language;
            loadLastDir(DesktopManager.Properties.Settings.Default.last_ScanDir);
        }
        private void saveSettings()
        {
            //Save Style settings
            DesktopManager.Properties.Settings.Default.style_Stretch = cbStretch.Checked;
            DesktopManager.Properties.Settings.Default.style_Center = radioCenter.Checked;
            DesktopManager.Properties.Settings.Default.style_Tyle = radioTile.Checked;
            // Save Timer settings
            DesktopManager.Properties.Settings.Default.timer_Use = cbUseTimer.Checked;
            DesktopManager.Properties.Settings.Default.timer_Time = numericTimer.Value;
            DesktopManager.Properties.Settings.Default.language = cbLanguage.SelectedItem.ToString();
            
            //Save Last dialog
            if (sLastScannedDir != null)
                DesktopManager.Properties.Settings.Default.last_ScanDir = sLastScannedDir;

            DesktopManager.Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }
        #endregion
        #region Lists
        private void listCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCurrent.SelectedIndex != -1)
                pictureBoxPreview.Load(listCurrent.SelectedItem.ToString());
            else
                pictureBoxPreview.Refresh();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = OFDFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string currentFile = openFileDialog1.FileName.ToString();
                FileInfo fi = new FileInfo(currentFile);
                listCurrent.Items.Add(fi.FullName);
            }
        }
        private void bRemove_Click(object sender, EventArgs e)
        {
            int curindex = listCurrent.SelectedIndex;
            if (listCurrent.SelectedIndex != -1)
                listCurrent.Items.RemoveAt(listCurrent.SelectedIndex);
            if (curindex != listCurrent.Items.Count)
                listCurrent.SelectedIndex = curindex;
            else
                listCurrent.SelectedIndex = curindex - 1;
            listCurrent.Invalidate();
        }
        private void bListAddDir_Click_1(object sender, EventArgs e)
        {
            //openFileDialog1.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirSearch(folderBrowserDialog1.SelectedPath);
                sLastScannedDir = folderBrowserDialog1.SelectedPath;
            }
        }
        private void bListSave_Click_1(object sender, EventArgs e)
        {
            if (listCurrent.Items.Count != 0)
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    saveList(saveFileDialog1.FileName.ToString());
        }
      
        private void saveList(string sCurListName)
        {
            StreamWriter sw = new StreamWriter(sCurListName);
            foreach (string curItem in listCurrent.Items)
            {
                sw.WriteLine(curItem);
            }
            sw.Close();
        }
        private void bListLoad_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                loadList(openFileDialog1.FileName.ToString());
        }
        private void loadList(string sCurListName)
        {
            StreamReader sr = new StreamReader(sCurListName);
            while(!sr.EndOfStream)
                listCurrent.Items.Add(sr.ReadLine().ToString());
            sr.Close();
        }

        //Clear current list
        private void bClearList_Click(object sender, EventArgs e)
        {
            listCurrent.Items.Clear();
        }
        #endregion
        #region Timer
        private void cbUseTimer_CheckedChanged(object sender, EventArgs e)
        {
            setUpTimer();
        }
        private void numericTimer_ValueChanged(object sender, EventArgs e)
        {
            setUpTimer();
        }
        private void setUpTimer()
        {
            if (listCurrent.Items.Count != 0)
            {
                timer1.Interval = (int)numericTimer.Value*1200;
                if (cbUseTimer.Checked == true)
                    timer1.Start();

                else if (cbUseTimer.Checked == false)
                    timer1.Stop();
            }
        }
        private void timerTick()
        {
            SetWallpaper();
            if (listCurrent.SelectedIndex == listCurrent.Items.Count - 1)
                listCurrent.SelectedIndex = 0;
            else
                listCurrent.SelectedIndex = listCurrent.SelectedIndex + 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick();
        }
        #endregion


        















    }
}
