﻿namespace MsCrmTools.FormParameterManager
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCreateNewParameter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeleteParameters = new System.Windows.Forms.ToolStripButton();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.lvParameters = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbForms = new System.Windows.Forms.GroupBox();
            this.lvForms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsddbLoad,
            this.toolStripSeparator2,
            this.tsbCreateNewParameter,
            this.toolStripSeparator3,
            this.tsbDeleteParameters});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
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
            this.tsmiLoadAll.Size = new System.Drawing.Size(295, 34);
            this.tsmiLoadAll.Text = "All forms";
            // 
            // tsmiLoadFromSolution
            // 
            this.tsmiLoadFromSolution.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadFromSolution.Name = "tsmiLoadFromSolution";
            this.tsmiLoadFromSolution.Size = new System.Drawing.Size(295, 34);
            this.tsmiLoadFromSolution.Text = "Forms from solution(s)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbCreateNewParameter
            // 
            this.tsbCreateNewParameter.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateNewParameter.Image")));
            this.tsbCreateNewParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateNewParameter.Name = "tsbCreateNewParameter";
            this.tsbCreateNewParameter.Size = new System.Drawing.Size(205, 41);
            this.tsbCreateNewParameter.Text = "Create new parameter";
            this.tsbCreateNewParameter.Click += new System.EventHandler(this.tsbCreateNewParameter_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbDeleteParameters
            // 
            this.tsbDeleteParameters.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteParameters.Image")));
            this.tsbDeleteParameters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteParameters.Name = "tsbDeleteParameters";
            this.tsbDeleteParameters.Size = new System.Drawing.Size(186, 41);
            this.tsbDeleteParameters.Text = "Delete parameter(s)";
            this.tsbDeleteParameters.Click += new System.EventHandler(this.tsbDeleteParameters_Click);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "nologo.png");
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.lvParameters);
            this.gbParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParameters.Location = new System.Drawing.Point(0, 0);
            this.gbParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParameters.Size = new System.Drawing.Size(812, 1050);
            this.gbParameters.TabIndex = 3;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // lvParameters
            // 
            this.lvParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvParameters.FullRowSelect = true;
            this.lvParameters.HideSelection = false;
            this.lvParameters.Location = new System.Drawing.Point(5, 29);
            this.lvParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvParameters.Name = "lvParameters";
            this.lvParameters.Size = new System.Drawing.Size(965, 1225);
            this.lvParameters.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvParameters.TabIndex = 1;
            this.lvParameters.UseCompatibleStateImageBehavior = false;
            this.lvParameters.View = System.Windows.Forms.View.Details;
            this.lvParameters.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvParameters_ColumnClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 150;
            // 
            // gbForms
            // 
            this.gbForms.Controls.Add(this.lvForms);
            this.gbForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForms.Location = new System.Drawing.Point(0, 0);
            this.gbForms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbForms.Name = "gbForms";
            this.gbForms.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbForms.Size = new System.Drawing.Size(810, 1050);
            this.gbForms.TabIndex = 3;
            this.gbForms.TabStop = false;
            this.gbForms.Text = "Forms";
            // 
            // lvForms
            // 
            this.lvForms.CheckBoxes = true;
            this.lvForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lvForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvForms.FullRowSelect = true;
            this.lvForms.HideSelection = false;
            this.lvForms.Location = new System.Drawing.Point(5, 29);
            this.lvForms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvForms.Name = "lvForms";
            this.lvForms.Size = new System.Drawing.Size(962, 1225);
            this.lvForms.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvForms.TabIndex = 0;
            this.lvForms.UseCompatibleStateImageBehavior = false;
            this.lvForms.View = System.Windows.Forms.View.Details;
            this.lvForms.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvForms_ColumnClick);
            this.lvForms.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvForms_ItemChecked);
            this.lvForms.SelectedIndexChanged += new System.EventHandler(this.lvForms_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Entity";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Has custom param";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbForms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbParameters);
            this.splitContainer1.Size = new System.Drawing.Size(1358, 875);
            this.splitContainer1.SplitterDistance = 675;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
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
            this.gbParameters.ResumeLayout(false);
            this.gbForms.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.GroupBox gbForms;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvForms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvParameters;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCreateNewParameter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDeleteParameters;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromSolution;
    }
}
