
namespace B2BiCore.UI.Win
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxProjectSelector = new System.Windows.Forms.ComboBox();
            this.tabArtifacts = new System.Windows.Forms.TabControl();
            this.tabAllArtifacts = new System.Windows.Forms.TabPage();
            this.trvArtifacts = new System.Windows.Forms.TreeView();
            this.tabBP = new System.Windows.Forms.TabPage();
            this.lbxBPs = new System.Windows.Forms.ListBox();
            this.tabAdapters = new System.Windows.Forms.TabPage();
            this.tabCACerts = new System.Windows.Forms.TabPage();
            this.tabCDNetmaps = new System.Windows.Forms.TabPage();
            this.tabCodeLists = new System.Windows.Forms.TabPage();
            this.tabEnvelopes = new System.Windows.Forms.TabPage();
            this.tabMailboxes = new System.Windows.Forms.TabPage();
            this.tabMbxMessages = new System.Windows.Forms.TabPage();
            this.tabMbxRules = new System.Windows.Forms.TabPage();
            this.tabMaps = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.tabSchedules = new System.Windows.Forms.TabPage();
            this.tabUserActivities = new System.Windows.Forms.TabPage();
            this.tabWebServices = new System.Windows.Forms.TabPage();
            this.tabXMLSchemas = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtbTextDisplay = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabArtifacts.SuspendLayout();
            this.tabAllArtifacts.SuspendLayout();
            this.tabBP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem2.Text = "New Project";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1207, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Statue: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Status: Ready";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 52);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.tabArtifacts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.rtbTextDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 542);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxProjectSelector);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 33);
            this.panel2.TabIndex = 1;
            // 
            // cbxProjectSelector
            // 
            this.cbxProjectSelector.FormattingEnabled = true;
            this.cbxProjectSelector.Location = new System.Drawing.Point(13, 4);
            this.cbxProjectSelector.MaxDropDownItems = 5;
            this.cbxProjectSelector.Name = "cbxProjectSelector";
            this.cbxProjectSelector.Size = new System.Drawing.Size(361, 23);
            this.cbxProjectSelector.TabIndex = 0;
            this.cbxProjectSelector.Text = "Selected Project ...";
            // 
            // tabArtifacts
            // 
            this.tabArtifacts.Controls.Add(this.tabAllArtifacts);
            this.tabArtifacts.Controls.Add(this.tabBP);
            this.tabArtifacts.Controls.Add(this.tabAdapters);
            this.tabArtifacts.Controls.Add(this.tabCACerts);
            this.tabArtifacts.Controls.Add(this.tabCDNetmaps);
            this.tabArtifacts.Controls.Add(this.tabCodeLists);
            this.tabArtifacts.Controls.Add(this.tabEnvelopes);
            this.tabArtifacts.Controls.Add(this.tabMailboxes);
            this.tabArtifacts.Controls.Add(this.tabMbxMessages);
            this.tabArtifacts.Controls.Add(this.tabMbxRules);
            this.tabArtifacts.Controls.Add(this.tabMaps);
            this.tabArtifacts.Controls.Add(this.tabReports);
            this.tabArtifacts.Controls.Add(this.tabServices);
            this.tabArtifacts.Controls.Add(this.tabSchedules);
            this.tabArtifacts.Controls.Add(this.tabUserActivities);
            this.tabArtifacts.Controls.Add(this.tabWebServices);
            this.tabArtifacts.Controls.Add(this.tabXMLSchemas);
            this.tabArtifacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabArtifacts.Enabled = false;
            this.tabArtifacts.Location = new System.Drawing.Point(0, 39);
            this.tabArtifacts.Multiline = true;
            this.tabArtifacts.Name = "tabArtifacts";
            this.tabArtifacts.SelectedIndex = 0;
            this.tabArtifacts.Size = new System.Drawing.Size(402, 503);
            this.tabArtifacts.TabIndex = 0;
            // 
            // tabAllArtifacts
            // 
            this.tabAllArtifacts.BackColor = System.Drawing.Color.LightGray;
            this.tabAllArtifacts.Controls.Add(this.trvArtifacts);
            this.tabAllArtifacts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabAllArtifacts.Location = new System.Drawing.Point(4, 64);
            this.tabAllArtifacts.Name = "tabAllArtifacts";
            this.tabAllArtifacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllArtifacts.Size = new System.Drawing.Size(394, 435);
            this.tabAllArtifacts.TabIndex = 0;
            this.tabAllArtifacts.Text = "All Artifacts";
            // 
            // trvArtifacts
            // 
            this.trvArtifacts.BackColor = System.Drawing.Color.DarkGray;
            this.trvArtifacts.Location = new System.Drawing.Point(3, 6);
            this.trvArtifacts.Name = "trvArtifacts";
            this.trvArtifacts.Size = new System.Drawing.Size(383, 421);
            this.trvArtifacts.TabIndex = 0;
            // 
            // tabBP
            // 
            this.tabBP.Controls.Add(this.lbxBPs);
            this.tabBP.Location = new System.Drawing.Point(4, 64);
            this.tabBP.Name = "tabBP";
            this.tabBP.Padding = new System.Windows.Forms.Padding(3);
            this.tabBP.Size = new System.Drawing.Size(394, 435);
            this.tabBP.TabIndex = 1;
            this.tabBP.Text = "BPs";
            this.tabBP.UseVisualStyleBackColor = true;
            // 
            // lbxBPs
            // 
            this.lbxBPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxBPs.FormattingEnabled = true;
            this.lbxBPs.ItemHeight = 15;
            this.lbxBPs.Location = new System.Drawing.Point(3, 3);
            this.lbxBPs.Margin = new System.Windows.Forms.Padding(10);
            this.lbxBPs.Name = "lbxBPs";
            this.lbxBPs.Size = new System.Drawing.Size(388, 429);
            this.lbxBPs.TabIndex = 0;
            // 
            // tabAdapters
            // 
            this.tabAdapters.Location = new System.Drawing.Point(4, 24);
            this.tabAdapters.Name = "tabAdapters";
            this.tabAdapters.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdapters.Size = new System.Drawing.Size(394, 475);
            this.tabAdapters.TabIndex = 2;
            this.tabAdapters.Text = "Adapter";
            this.tabAdapters.UseVisualStyleBackColor = true;
            // 
            // tabCACerts
            // 
            this.tabCACerts.Location = new System.Drawing.Point(4, 24);
            this.tabCACerts.Name = "tabCACerts";
            this.tabCACerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabCACerts.Size = new System.Drawing.Size(394, 475);
            this.tabCACerts.TabIndex = 3;
            this.tabCACerts.Text = "CA-Certs";
            this.tabCACerts.UseVisualStyleBackColor = true;
            // 
            // tabCDNetmaps
            // 
            this.tabCDNetmaps.Location = new System.Drawing.Point(4, 24);
            this.tabCDNetmaps.Name = "tabCDNetmaps";
            this.tabCDNetmaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabCDNetmaps.Size = new System.Drawing.Size(394, 475);
            this.tabCDNetmaps.TabIndex = 4;
            this.tabCDNetmaps.Text = "CD Netmaps";
            this.tabCDNetmaps.UseVisualStyleBackColor = true;
            // 
            // tabCodeLists
            // 
            this.tabCodeLists.Location = new System.Drawing.Point(4, 24);
            this.tabCodeLists.Name = "tabCodeLists";
            this.tabCodeLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabCodeLists.Size = new System.Drawing.Size(394, 475);
            this.tabCodeLists.TabIndex = 5;
            this.tabCodeLists.Text = "CodeLists";
            this.tabCodeLists.UseVisualStyleBackColor = true;
            // 
            // tabEnvelopes
            // 
            this.tabEnvelopes.Location = new System.Drawing.Point(4, 44);
            this.tabEnvelopes.Name = "tabEnvelopes";
            this.tabEnvelopes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvelopes.Size = new System.Drawing.Size(394, 455);
            this.tabEnvelopes.TabIndex = 6;
            this.tabEnvelopes.Text = "Envelopes";
            this.tabEnvelopes.UseVisualStyleBackColor = true;
            // 
            // tabMailboxes
            // 
            this.tabMailboxes.Location = new System.Drawing.Point(4, 44);
            this.tabMailboxes.Name = "tabMailboxes";
            this.tabMailboxes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMailboxes.Size = new System.Drawing.Size(394, 455);
            this.tabMailboxes.TabIndex = 7;
            this.tabMailboxes.Text = "Mailboxes";
            this.tabMailboxes.UseVisualStyleBackColor = true;
            // 
            // tabMbxMessages
            // 
            this.tabMbxMessages.Location = new System.Drawing.Point(4, 44);
            this.tabMbxMessages.Name = "tabMbxMessages";
            this.tabMbxMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMbxMessages.Size = new System.Drawing.Size(394, 455);
            this.tabMbxMessages.TabIndex = 8;
            this.tabMbxMessages.Text = "Mbx Messages";
            this.tabMbxMessages.UseVisualStyleBackColor = true;
            // 
            // tabMbxRules
            // 
            this.tabMbxRules.Location = new System.Drawing.Point(4, 44);
            this.tabMbxRules.Name = "tabMbxRules";
            this.tabMbxRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabMbxRules.Size = new System.Drawing.Size(394, 455);
            this.tabMbxRules.TabIndex = 14;
            this.tabMbxRules.Text = "Mbx Rules";
            this.tabMbxRules.UseVisualStyleBackColor = true;
            // 
            // tabMaps
            // 
            this.tabMaps.Location = new System.Drawing.Point(4, 44);
            this.tabMaps.Name = "tabMaps";
            this.tabMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaps.Size = new System.Drawing.Size(394, 455);
            this.tabMaps.TabIndex = 9;
            this.tabMaps.Text = "Maps";
            this.tabMaps.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 44);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(394, 455);
            this.tabReports.TabIndex = 15;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Location = new System.Drawing.Point(4, 64);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(394, 435);
            this.tabServices.TabIndex = 10;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // tabSchedules
            // 
            this.tabSchedules.Location = new System.Drawing.Point(4, 64);
            this.tabSchedules.Name = "tabSchedules";
            this.tabSchedules.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedules.Size = new System.Drawing.Size(394, 435);
            this.tabSchedules.TabIndex = 11;
            this.tabSchedules.Text = "Schedules";
            this.tabSchedules.UseVisualStyleBackColor = true;
            // 
            // tabUserActivities
            // 
            this.tabUserActivities.Location = new System.Drawing.Point(4, 64);
            this.tabUserActivities.Name = "tabUserActivities";
            this.tabUserActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserActivities.Size = new System.Drawing.Size(394, 435);
            this.tabUserActivities.TabIndex = 12;
            this.tabUserActivities.Text = "User Activities";
            this.tabUserActivities.UseVisualStyleBackColor = true;
            // 
            // tabWebServices
            // 
            this.tabWebServices.Location = new System.Drawing.Point(4, 64);
            this.tabWebServices.Name = "tabWebServices";
            this.tabWebServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebServices.Size = new System.Drawing.Size(394, 435);
            this.tabWebServices.TabIndex = 13;
            this.tabWebServices.Text = "Web Services";
            this.tabWebServices.UseVisualStyleBackColor = true;
            // 
            // tabXMLSchemas
            // 
            this.tabXMLSchemas.Location = new System.Drawing.Point(4, 64);
            this.tabXMLSchemas.Name = "tabXMLSchemas";
            this.tabXMLSchemas.Size = new System.Drawing.Size(394, 435);
            this.tabXMLSchemas.TabIndex = 16;
            this.tabXMLSchemas.Text = "XML Schemas";
            this.tabXMLSchemas.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 542);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // rtbTextDisplay
            // 
            this.rtbTextDisplay.CausesValidation = false;
            this.rtbTextDisplay.DetectUrls = false;
            this.rtbTextDisplay.Location = new System.Drawing.Point(8, 21);
            this.rtbTextDisplay.Name = "rtbTextDisplay";
            this.rtbTextDisplay.ReadOnly = true;
            this.rtbTextDisplay.Size = new System.Drawing.Size(781, 509);
            this.rtbTextDisplay.TabIndex = 0;
            this.rtbTextDisplay.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1207, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B2Bi System Overview";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabArtifacts.ResumeLayout(false);
            this.tabAllArtifacts.ResumeLayout(false);
            this.tabBP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox rtbTextDisplay;
        private System.Windows.Forms.TabControl tabArtifacts;
        private System.Windows.Forms.TabPage tabAllArtifacts;
        private System.Windows.Forms.TreeView trvArtifacts;
        private System.Windows.Forms.TabPage tabBP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxProjectSelector;
        private System.Windows.Forms.TabPage tabAdapters;
        private System.Windows.Forms.TabPage tabCACerts;
        private System.Windows.Forms.TabPage tabCDNetmaps;
        private System.Windows.Forms.TabPage tabCodeLists;
        private System.Windows.Forms.TabPage tabEnvelopes;
        private System.Windows.Forms.TabPage tabMailboxes;
        private System.Windows.Forms.TabPage tabMbxMessages;
        private System.Windows.Forms.TabPage tabMaps;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabSchedules;
        private System.Windows.Forms.TabPage tabUserActivities;
        private System.Windows.Forms.TabPage tabWebServices;
        private System.Windows.Forms.TabPage tabMbxRules;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabXMLSchemas;
        private System.Windows.Forms.ListBox lbxBPs;
    }
}

