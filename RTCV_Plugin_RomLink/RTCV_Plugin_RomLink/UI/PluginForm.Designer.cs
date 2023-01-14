namespace ROMLINK.UI
{

    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDragAndDrop = new System.Windows.Forms.Label();
            this.btnBrowseOriginalRom = new System.Windows.Forms.Button();
            this.btnBrowseCorruptedRom = new System.Windows.Forms.Button();
            this.btnBrowseBatchImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportCorruptedFile = new System.Windows.Forms.Button();
            this.btnExportStockpileToRoms = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBakeToCorrupted = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.cbAutoImport = new System.Windows.Forms.CheckBox();
            this.tbOriginalRomFile = new System.Windows.Forms.TextBox();
            this.tbCorruptedRomFile = new System.Windows.Forms.TextBox();
            this.btnLoadOriginalRom = new System.Windows.Forms.Button();
            this.LoadCorruptedRom = new System.Windows.Forms.Button();
            this.btnMakeFrame0 = new System.Windows.Forms.Button();
            this.btnBakeSelectedItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path of the Original ROM File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path of the Corrupted ROM File";
            // 
            // lbDragAndDrop
            // 
            this.lbDragAndDrop.AllowDrop = true;
            this.lbDragAndDrop.BackColor = System.Drawing.Color.Transparent;
            this.lbDragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDragAndDrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbDragAndDrop.ForeColor = System.Drawing.Color.White;
            this.lbDragAndDrop.Location = new System.Drawing.Point(303, 111);
            this.lbDragAndDrop.Name = "lbDragAndDrop";
            this.lbDragAndDrop.Size = new System.Drawing.Size(134, 34);
            this.lbDragAndDrop.TabIndex = 40;
            this.lbDragAndDrop.Tag = "color:light3";
            this.lbDragAndDrop.Text = "Drag and drop area";
            this.lbDragAndDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDragAndDrop_DragDrop);
            this.lbDragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDragAndDrop_DragEnter);
            // 
            // btnBrowseOriginalRom
            // 
            this.btnBrowseOriginalRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBrowseOriginalRom.FlatAppearance.BorderSize = 0;
            this.btnBrowseOriginalRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOriginalRom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseOriginalRom.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOriginalRom.Location = new System.Drawing.Point(4, 80);
            this.btnBrowseOriginalRom.Name = "btnBrowseOriginalRom";
            this.btnBrowseOriginalRom.Size = new System.Drawing.Size(81, 23);
            this.btnBrowseOriginalRom.TabIndex = 41;
            this.btnBrowseOriginalRom.Tag = "color:dark2";
            this.btnBrowseOriginalRom.Text = "Browse";
            this.btnBrowseOriginalRom.UseVisualStyleBackColor = false;
            this.btnBrowseOriginalRom.Click += new System.EventHandler(this.btnBrowseOriginalRom_Click);
            // 
            // btnBrowseCorruptedRom
            // 
            this.btnBrowseCorruptedRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBrowseCorruptedRom.FlatAppearance.BorderSize = 0;
            this.btnBrowseCorruptedRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCorruptedRom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseCorruptedRom.ForeColor = System.Drawing.Color.White;
            this.btnBrowseCorruptedRom.Location = new System.Drawing.Point(4, 146);
            this.btnBrowseCorruptedRom.Name = "btnBrowseCorruptedRom";
            this.btnBrowseCorruptedRom.Size = new System.Drawing.Size(81, 23);
            this.btnBrowseCorruptedRom.TabIndex = 42;
            this.btnBrowseCorruptedRom.Tag = "color:dark2";
            this.btnBrowseCorruptedRom.Text = "Browse";
            this.btnBrowseCorruptedRom.UseVisualStyleBackColor = false;
            this.btnBrowseCorruptedRom.Click += new System.EventHandler(this.btnBrowseCorruptedRom_Click);
            // 
            // btnBrowseBatchImport
            // 
            this.btnBrowseBatchImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBrowseBatchImport.FlatAppearance.BorderSize = 0;
            this.btnBrowseBatchImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBatchImport.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseBatchImport.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBatchImport.Location = new System.Drawing.Point(303, 85);
            this.btnBrowseBatchImport.Name = "btnBrowseBatchImport";
            this.btnBrowseBatchImport.Size = new System.Drawing.Size(134, 23);
            this.btnBrowseBatchImport.TabIndex = 43;
            this.btnBrowseBatchImport.Tag = "color:dark2";
            this.btnBrowseBatchImport.Text = "Browse";
            this.btnBrowseBatchImport.UseVisualStyleBackColor = false;
            this.btnBrowseBatchImport.Click += new System.EventHandler(this.btnBrowseBatchImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Batch Import to GH";
            // 
            // btnImportCorruptedFile
            // 
            this.btnImportCorruptedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnImportCorruptedFile.FlatAppearance.BorderSize = 0;
            this.btnImportCorruptedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportCorruptedFile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnImportCorruptedFile.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnImportCorruptedFile.Location = new System.Drawing.Point(3, 197);
            this.btnImportCorruptedFile.Name = "btnImportCorruptedFile";
            this.btnImportCorruptedFile.Size = new System.Drawing.Size(259, 23);
            this.btnImportCorruptedFile.TabIndex = 47;
            this.btnImportCorruptedFile.Tag = "color:dark2";
            this.btnImportCorruptedFile.Text = "Import Corrupted File to GH";
            this.btnImportCorruptedFile.UseVisualStyleBackColor = false;
            this.btnImportCorruptedFile.Click += new System.EventHandler(this.btnImportCorruptedFile_Click);
            // 
            // btnExportStockpileToRoms
            // 
            this.btnExportStockpileToRoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExportStockpileToRoms.FlatAppearance.BorderSize = 0;
            this.btnExportStockpileToRoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportStockpileToRoms.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnExportStockpileToRoms.ForeColor = System.Drawing.Color.White;
            this.btnExportStockpileToRoms.Location = new System.Drawing.Point(303, 173);
            this.btnExportStockpileToRoms.Name = "btnExportStockpileToRoms";
            this.btnExportStockpileToRoms.Size = new System.Drawing.Size(135, 35);
            this.btnExportStockpileToRoms.TabIndex = 48;
            this.btnExportStockpileToRoms.Tag = "color:dark2";
            this.btnExportStockpileToRoms.Text = "Export Stockpile to Baked Roms";
            this.btnExportStockpileToRoms.UseVisualStyleBackColor = false;
            this.btnExportStockpileToRoms.Click += new System.EventHandler(this.btnExportStockpileToRoms_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Batch Export";
            // 
            // btnBakeToCorrupted
            // 
            this.btnBakeToCorrupted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBakeToCorrupted.FlatAppearance.BorderSize = 0;
            this.btnBakeToCorrupted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakeToCorrupted.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBakeToCorrupted.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBakeToCorrupted.Location = new System.Drawing.Point(3, 223);
            this.btnBakeToCorrupted.Name = "btnBakeToCorrupted";
            this.btnBakeToCorrupted.Size = new System.Drawing.Size(259, 23);
            this.btnBakeToCorrupted.TabIndex = 51;
            this.btnBakeToCorrupted.Tag = "color:dark2";
            this.btnBakeToCorrupted.Text = "Bake selected GH item to Corrupted ROM";
            this.btnBakeToCorrupted.UseVisualStyleBackColor = false;
            this.btnBakeToCorrupted.Click += new System.EventHandler(this.btnBakeToCorrupted_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 52;
            this.label5.Text = "RomLink";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(97, 24);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(14, 13);
            this.version.TabIndex = 53;
            this.version.Text = "v";
            // 
            // cbAutoImport
            // 
            this.cbAutoImport.AutoSize = true;
            this.cbAutoImport.ForeColor = System.Drawing.Color.White;
            this.cbAutoImport.Location = new System.Drawing.Point(305, 44);
            this.cbAutoImport.Name = "cbAutoImport";
            this.cbAutoImport.Size = new System.Drawing.Size(136, 17);
            this.cbAutoImport.TabIndex = 54;
            this.cbAutoImport.Text = "Auto-Import Corruptions";
            this.cbAutoImport.UseVisualStyleBackColor = true;
            this.cbAutoImport.CheckedChanged += new System.EventHandler(this.cbAutoImport_CheckedChanged);
            // 
            // tbOriginalRomFile
            // 
            this.tbOriginalRomFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbOriginalRomFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOriginalRomFile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbOriginalRomFile.ForeColor = System.Drawing.Color.White;
            this.tbOriginalRomFile.Location = new System.Drawing.Point(91, 81);
            this.tbOriginalRomFile.Name = "tbOriginalRomFile";
            this.tbOriginalRomFile.Size = new System.Drawing.Size(173, 22);
            this.tbOriginalRomFile.TabIndex = 55;
            this.tbOriginalRomFile.Tag = "color:dark2";
            // 
            // tbCorruptedRomFile
            // 
            this.tbCorruptedRomFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbCorruptedRomFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorruptedRomFile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbCorruptedRomFile.ForeColor = System.Drawing.Color.White;
            this.tbCorruptedRomFile.Location = new System.Drawing.Point(91, 146);
            this.tbCorruptedRomFile.Name = "tbCorruptedRomFile";
            this.tbCorruptedRomFile.Size = new System.Drawing.Size(173, 22);
            this.tbCorruptedRomFile.TabIndex = 56;
            this.tbCorruptedRomFile.Tag = "color:dark2";
            // 
            // btnLoadOriginalRom
            // 
            this.btnLoadOriginalRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadOriginalRom.FlatAppearance.BorderSize = 0;
            this.btnLoadOriginalRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadOriginalRom.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnLoadOriginalRom.ForeColor = System.Drawing.Color.White;
            this.btnLoadOriginalRom.Location = new System.Drawing.Point(195, 60);
            this.btnLoadOriginalRom.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadOriginalRom.Name = "btnLoadOriginalRom";
            this.btnLoadOriginalRom.Size = new System.Drawing.Size(69, 21);
            this.btnLoadOriginalRom.TabIndex = 57;
            this.btnLoadOriginalRom.Tag = "color:dark2";
            this.btnLoadOriginalRom.Text = "Load ROM";
            this.btnLoadOriginalRom.UseVisualStyleBackColor = false;
            this.btnLoadOriginalRom.Click += new System.EventHandler(this.btnLoadOriginalRom_Click);
            // 
            // LoadCorruptedRom
            // 
            this.LoadCorruptedRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LoadCorruptedRom.FlatAppearance.BorderSize = 0;
            this.LoadCorruptedRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadCorruptedRom.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.LoadCorruptedRom.ForeColor = System.Drawing.Color.White;
            this.LoadCorruptedRom.Location = new System.Drawing.Point(195, 125);
            this.LoadCorruptedRom.Margin = new System.Windows.Forms.Padding(0);
            this.LoadCorruptedRom.Name = "LoadCorruptedRom";
            this.LoadCorruptedRom.Size = new System.Drawing.Size(69, 21);
            this.LoadCorruptedRom.TabIndex = 58;
            this.LoadCorruptedRom.Tag = "color:dark2";
            this.LoadCorruptedRom.Text = "Load ROM";
            this.LoadCorruptedRom.UseVisualStyleBackColor = false;
            this.LoadCorruptedRom.Click += new System.EventHandler(this.LoadCorruptedRom_Click);
            // 
            // btnMakeFrame0
            // 
            this.btnMakeFrame0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMakeFrame0.FlatAppearance.BorderSize = 0;
            this.btnMakeFrame0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeFrame0.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnMakeFrame0.ForeColor = System.Drawing.Color.White;
            this.btnMakeFrame0.Location = new System.Drawing.Point(305, 16);
            this.btnMakeFrame0.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeFrame0.Name = "btnMakeFrame0";
            this.btnMakeFrame0.Size = new System.Drawing.Size(132, 22);
            this.btnMakeFrame0.TabIndex = 59;
            this.btnMakeFrame0.Tag = "color:dark2";
            this.btnMakeFrame0.Text = "Make Frame0 State";
            this.btnMakeFrame0.UseVisualStyleBackColor = false;
            this.btnMakeFrame0.Click += new System.EventHandler(this.btnMakeFrame0_Click);
            // 
            // btnBakeSelectedItems
            // 
            this.btnBakeSelectedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBakeSelectedItems.FlatAppearance.BorderSize = 0;
            this.btnBakeSelectedItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakeSelectedItems.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBakeSelectedItems.ForeColor = System.Drawing.Color.White;
            this.btnBakeSelectedItems.Location = new System.Drawing.Point(303, 211);
            this.btnBakeSelectedItems.Name = "btnBakeSelectedItems";
            this.btnBakeSelectedItems.Size = new System.Drawing.Size(135, 35);
            this.btnBakeSelectedItems.TabIndex = 60;
            this.btnBakeSelectedItems.Tag = "color:dark2";
            this.btnBakeSelectedItems.Text = "Export Selected Items to Baked Roms";
            this.btnBakeSelectedItems.UseVisualStyleBackColor = false;
            this.btnBakeSelectedItems.Click += new System.EventHandler(this.btnBakeSelectedItems_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.btnBakeSelectedItems);
            this.Controls.Add(this.btnMakeFrame0);
            this.Controls.Add(this.LoadCorruptedRom);
            this.Controls.Add(this.btnLoadOriginalRom);
            this.Controls.Add(this.tbCorruptedRomFile);
            this.Controls.Add(this.tbOriginalRomFile);
            this.Controls.Add(this.cbAutoImport);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBakeToCorrupted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportStockpileToRoms);
            this.Controls.Add(this.btnImportCorruptedFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseBatchImport);
            this.Controls.Add(this.btnBrowseCorruptedRom);
            this.Controls.Add(this.btnBrowseOriginalRom);
            this.Controls.Add(this.lbDragAndDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbDragAndDrop;
        private System.Windows.Forms.Button btnBrowseOriginalRom;
        private System.Windows.Forms.Button btnBrowseCorruptedRom;
        private System.Windows.Forms.Button btnBrowseBatchImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImportCorruptedFile;
        private System.Windows.Forms.Button btnExportStockpileToRoms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBakeToCorrupted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.CheckBox cbAutoImport;
        private System.Windows.Forms.TextBox tbOriginalRomFile;
        private System.Windows.Forms.TextBox tbCorruptedRomFile;
        private System.Windows.Forms.Button btnLoadOriginalRom;
        private System.Windows.Forms.Button LoadCorruptedRom;
        private System.Windows.Forms.Button btnMakeFrame0;
        private System.Windows.Forms.Button btnBakeSelectedItems;
    }
}
