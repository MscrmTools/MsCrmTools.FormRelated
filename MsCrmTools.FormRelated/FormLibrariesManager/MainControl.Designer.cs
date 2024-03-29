﻿namespace MsCrmTools.FormLibrariesManager
{
    partial class MainControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLoadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLoadLibrariesAndScripts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddCheckedScripts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveCheckedScripts = new System.Windows.Forms.ToolStripButton();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.lvLogs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.crmScriptsTreeView1 = new MsCrmTools.FormLibrariesManager.UserControls.CrmScriptsTreeView();
            this.crmForms1 = new MsCrmTools.FormLibrariesManager.UserControls.CrmForms();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsddbLoad,
            this.tsbLoadLibrariesAndScripts,
            this.toolStripSeparator2,
            this.tsbAddCheckedScripts,
            this.toolStripSeparator3,
            this.tsbRemoveCheckedScripts});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1639, 46);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 41);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.TsbCloseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // tsddbLoad
            // 
            this.tsddbLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadAll,
            this.tsmiLoadFromSolution});
            this.tsddbLoad.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsddbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLoad.Name = "tsddbLoad";
            this.tsddbLoad.Size = new System.Drawing.Size(85, 41);
            this.tsddbLoad.Text = "Load";
            this.tsddbLoad.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbLoad_DropDownItemClicked);
            // 
            // tsmiLoadAll
            // 
            this.tsmiLoadAll.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadAll.Name = "tsmiLoadAll";
            this.tsmiLoadAll.Size = new System.Drawing.Size(397, 34);
            this.tsmiLoadAll.Text = "All libraries and forms";
            // 
            // tsmiLoadFromSolution
            // 
            this.tsmiLoadFromSolution.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadFromSolution.Name = "tsmiLoadFromSolution";
            this.tsmiLoadFromSolution.Size = new System.Drawing.Size(397, 34);
            this.tsmiLoadFromSolution.Text = "Libraries and forms from solution(s)";
            // 
            // tsbLoadLibrariesAndScripts
            // 
            this.tsbLoadLibrariesAndScripts.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadLibrariesAndScripts.Image")));
            this.tsbLoadLibrariesAndScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadLibrariesAndScripts.Name = "tsbLoadLibrariesAndScripts";
            this.tsbLoadLibrariesAndScripts.Size = new System.Drawing.Size(231, 41);
            this.tsbLoadLibrariesAndScripts.Text = "Load Libraries and Forms";
            this.tsbLoadLibrariesAndScripts.Click += new System.EventHandler(this.tsbLoadLibrariesAndScripts_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbAddCheckedScripts
            // 
            this.tsbAddCheckedScripts.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddCheckedScripts.Image")));
            this.tsbAddCheckedScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCheckedScripts.Name = "tsbAddCheckedScripts";
            this.tsbAddCheckedScripts.Size = new System.Drawing.Size(191, 41);
            this.tsbAddCheckedScripts.Text = "Add checked scripts";
            this.tsbAddCheckedScripts.Click += new System.EventHandler(this.tsbAddCheckedScripts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbRemoveCheckedScripts
            // 
            this.tsbRemoveCheckedScripts.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveCheckedScripts.Image")));
            this.tsbRemoveCheckedScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveCheckedScripts.Name = "tsbRemoveCheckedScripts";
            this.tsbRemoveCheckedScripts.Size = new System.Drawing.Size(221, 41);
            this.tsbRemoveCheckedScripts.Text = "Remove checked scripts";
            this.tsbRemoveCheckedScripts.Click += new System.EventHandler(this.tsbRemoveCheckedScripts_Click);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "nologo.png");
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(0, 0);
            this.lvLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(1364, 426);
            this.lvLogs.TabIndex = 5;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Entity";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Form";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Script";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Message";
            this.columnHeader4.Width = 300;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvLogs);
            this.splitContainer1.Size = new System.Drawing.Size(1366, 875);
            this.splitContainer1.SplitterDistance = 592;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.crmScriptsTreeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.crmForms1);
            this.splitContainer2.Size = new System.Drawing.Size(1366, 592);
            this.splitContainer2.SplitterDistance = 652;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // crmScriptsTreeView1
            // 
            this.crmScriptsTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmScriptsTreeView1.Location = new System.Drawing.Point(0, 0);
            this.crmScriptsTreeView1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.crmScriptsTreeView1.Name = "crmScriptsTreeView1";
            this.crmScriptsTreeView1.Service = null;
            this.crmScriptsTreeView1.Size = new System.Drawing.Size(652, 592);
            this.crmScriptsTreeView1.TabIndex = 3;
            // 
            // crmForms1
            // 
            this.crmForms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmForms1.Location = new System.Drawing.Point(0, 0);
            this.crmForms1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.crmForms1.Name = "crmForms1";
            this.crmForms1.Plugin = null;
            this.crmForms1.Service = null;
            this.crmForms1.Size = new System.Drawing.Size(708, 592);
            this.crmForms1.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1366, 923);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadLibrariesAndScripts;
        private UserControls.CrmScriptsTreeView crmScriptsTreeView1;
        private UserControls.CrmForms crmForms1;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAddCheckedScripts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRemoveCheckedScripts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromSolution;
    }
}
