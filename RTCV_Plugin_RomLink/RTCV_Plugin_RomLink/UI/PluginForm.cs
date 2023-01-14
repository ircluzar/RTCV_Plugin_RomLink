namespace ROMLINK.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;
    using RTCV.NetCore;
    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;
    using RTCV.UI.Modular;

    public partial class PluginForm : ComponentForm, IColorize
    {
        public ROMLINK plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        Timer time = null;

        public PluginForm(ROMLINK _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);


            this.Text = "RomLink"; 
            this.version.Text = $"{plugin.Version.ToString()}"; //automatic window title
        }



        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }    
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseOriginalRom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "*.*|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbOriginalRomFile.Text = ofd.FileName;
                }
            }
        }

        private void btnBrowseCorruptedRom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "*.*|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbCorruptedRomFile.Text = ofd.FileName;
                }
            }
        }

        private void cbAutoImport_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAutoImport.Checked)
            {
                StartTimer();
            }
            else
            {
                StopTimer();
            }
        }

        public void StartTimer()
        {
            StopTimer();

            time = new Timer();
            time.Interval = 1234;
            time.Tick += Time_Tick;
            lastModifiedDate = new FileInfo(tbCorruptedRomFile.Text).LastWriteTime;
            time.Start();
        }

        DateTime lastModifiedDate = DateTime.Now;
        private void Time_Tick(object sender, EventArgs e)
        {
            var fi = new FileInfo(tbCorruptedRomFile.Text);
            if (fi.Exists)
            {
                var modifiedDate = fi.LastWriteTime;
                if (modifiedDate != lastModifiedDate)
                {
                    lastModifiedDate = modifiedDate;
                    ImportToGH(tbCorruptedRomFile.Text);
                }
            }
        }

        public void StopTimer()
        {
            if(time != null)
            {
                time.Stop();
                time.Dispose();
                time = null;
            }
        }

        private void btnBrowseBatchImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOriginalRomFile.Text) || !File.Exists(tbOriginalRomFile.Text))
            {
                MessageBox.Show("Original Rom file empty");
                return;
            }

            if (BaseStashkey == null)
            {
                MessageBox.Show("Could not send to Stockpile manager. \nIf you have not yet, you need to create a Frame0 Savestate using the 'Make Frame0 State' button at the top of the plugin beforehand.");
                return;
            }


            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "*.*|*.*", Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (var file in files)
                        ImportToGH(file);
                }
            }
        }
        private void lbDragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbDragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                    ImportToGH(file);
            }

        }

        public void ImportToGH(string filename)
        {

            if (!File.Exists(filename))
            {
                MessageBox.Show($"File not found at location '{filename}'");
                return;
            }

            var sk = (StashKey)BaseStashkey?.Clone();
            if (sk == null)
            {
                MessageBox.Show("Could not send to Stockpile manager. \nIf you have not yet, you need to create a Frame0 Savestate using the 'Make Frame0 State' button at the top of the plugin beforehand.");
                return;
            }

            var fi = new FileInfo(filename);
            var bl = LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Remote.BLGetDiffBlastLayer, filename);

            if (bl == null)
                return;

            sk.BlastLayer = bl;

            var shortname = fi.Name.Replace(fi.Extension, "");
            sk.Alias = shortname;

            //push to stash
            StockpileManagerUISide.StashHistory.Add(sk);
            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
            S.GET<StashHistoryForm>().RefreshStashHistorySelectLast();
            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
            S.GET<StockpileManagerForm>().dgvStockpile.ClearSelection();
            S.GET<StashHistoryForm>().DontLoadSelectedStash = false;


            //push to stockpile
            S.GET<StashHistoryForm>().AddStashToStockpile(false);
        }

        private void btnImportCorruptedFile_Click(object sender, EventArgs e)
        {
            var filepath = tbCorruptedRomFile.Text;
            ImportToGH(filepath);
        }

        StashKey BaseStashkey = null;
        private void btnMakeFrame0_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbOriginalRomFile.Text) || !File.Exists(tbOriginalRomFile.Text))
            {
                MessageBox.Show("Cannot prepare Glitch Harvester, invalid/empty rom path ?");
                return;
            }

            //Load rom and make GH savestate
            LocalNetCoreRouter.Route(Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.LoadROM, tbOriginalRomFile.Text, true);
            S.GET<SavestateManagerForm>().savestateList.NewSavestateNow();

            BaseStashkey = S.GET<GlitchHarvesterBlastForm>().SendRawToStash(true);

            MessageBox.Show("Savestate created successfully");
        }

        private void btnLoadOriginalRom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOriginalRomFile.Text) || !File.Exists(tbOriginalRomFile.Text))

            {
                MessageBox.Show("Original Rom file empty or file missing");
                return;
            }

            LocalNetCoreRouter.Route(Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.LoadROM, tbOriginalRomFile.Text, true);
        }

        private void LoadCorruptedRom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOriginalRomFile.Text) ||  !File.Exists(tbCorruptedRomFile.Text))
            {
                MessageBox.Show("Corrupted Rom file empty or file missing");
                return;
            }

            LocalNetCoreRouter.Route(Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.LoadROM, tbCorruptedRomFile.Text, true);
        }

        public StashKey[] GetSelectedKeys()
        {
            IEnumerable<DataGridViewRow> alldgvRows = S.GET<StockpileManagerForm>().dgvStockpile.SelectedRows.Cast<DataGridViewRow>();
            return alldgvRows.Select(it => (it.Cells["Item"].Value as StashKey)).ToArray();
        }

        private void btnBakeToCorrupted_Click(object sender, EventArgs e)
        {
            var targetFile = tbCorruptedRomFile.Text;
            var keys = GetSelectedKeys();

            if(keys.Length == 0)
            {
                MessageBox.Show($"No stockpile item selected.");
                return;
            }
            else if (keys.Length > 1)
            {
                MessageBox.Show($"This button only supports exporting one rom at a time. Use Batch Export for exporting your stockpile.");
                return;
            }
            else
            {
                BakeToRom(keys.First(),targetFile);
                MessageBox.Show($"Baked corruption to '{targetFile}'");
            }

            
        }

        public void BakeToRom(StashKey sk, string filename)
        {
            BlastEditorForm.OpenBlastEditor(sk, true);
            var currentBlastEditor = S.GET<BlastEditorForm>();
            currentBlastEditor.BakeROMBlastunitsToFile(filename);
            currentBlastEditor.Close();
        }

        private void btnExportStockpileToRoms_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbOriginalRomFile.Text) || !File.Exists(tbOriginalRomFile.Text))
            {
                MessageBox.Show("Original Rom file empty");
                return;
            }

            string folder;
            string ext = Path.GetExtension(tbOriginalRomFile.Text);

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folder = fbd.SelectedPath;
                }
                else
                    return;
            }

            var stockpileManager = S.GET<StockpileManagerForm>();
            Stockpile sks = new Stockpile(stockpileManager.dgvStockpile);

            foreach (var sk in sks.StashKeys)
            {
                string filename = Path.Combine(folder, sk.Alias + ext);
                BakeToRom(sk, filename);
            }

            MessageBox.Show($"Baked corruptions to '{folder}'");
        }

        private void btnBakeSelectedItems_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOriginalRomFile.Text) || !File.Exists(tbOriginalRomFile.Text))
            {
                MessageBox.Show("Original Rom file empty");
                return;
            }

            var keys = GetSelectedKeys();

            if (keys.Length == 0)
            {
                MessageBox.Show($"No stockpile items selected.");
                return;
            }
            else
            {

                string folder;
                string ext = Path.GetExtension(tbOriginalRomFile.Text);

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        folder = fbd.SelectedPath;
                    }
                    else
                        return;
                }

                foreach (var sk in keys)
                {
                    string filename = Path.Combine(folder, sk.Alias + ext);
                    BakeToRom(sk, filename);
                }

                MessageBox.Show($"Baked corruptions to '{folder}'");
            }
        }

    }
}
