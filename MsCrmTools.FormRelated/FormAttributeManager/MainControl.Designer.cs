namespace MsCrmTools.FormAttributeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLoadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSaveForms = new System.Windows.Forms.ToolStripButton();
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.tsbPublish = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.attributeSelector1 = new MsCrmTools.FormAttributeManager.UserControls.AttributeSelector();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.removeFromFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbLabel = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiEnableFieldDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisableFieldDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbLock = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiLockField = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnlockField = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbReadOnly = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiMarkAsReadOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarkAsEditable = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbVisibility = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiMarkAsVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarkAsNotVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.toolStripSeparator2,
            this.tsbSaveForms,
            this.tslInfo,
            this.tsbPublish,
            this.toolStripSeparator3,
            this.tsbClearLog});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1317, 34);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 29);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsddbLoad
            // 
            this.tsddbLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadAll,
            this.tsmiLoadFromSolution});
            this.tsddbLoad.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsddbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLoad.Name = "tsddbLoad";
            this.tsddbLoad.Size = new System.Drawing.Size(85, 29);
            this.tsddbLoad.Text = "Load";
            this.tsddbLoad.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbLoad_DropDownItemClicked);
            // 
            // tsmiLoadAll
            // 
            this.tsmiLoadAll.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadAll.Name = "tsmiLoadAll";
            this.tsmiLoadAll.Size = new System.Drawing.Size(301, 34);
            this.tsmiLoadAll.Text = "All entities";
            // 
            // tsmiLoadFromSolution
            // 
            this.tsmiLoadFromSolution.Image = global::MsCrmTools.FormRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadFromSolution.Name = "tsmiLoadFromSolution";
            this.tsmiLoadFromSolution.Size = new System.Drawing.Size(301, 34);
            this.tsmiLoadFromSolution.Text = "Entities from solution(s)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbSaveForms
            // 
            this.tsbSaveForms.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveForms.Image")));
            this.tsbSaveForms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveForms.Name = "tsbSaveForms";
            this.tsbSaveForms.Size = new System.Drawing.Size(121, 29);
            this.tsbSaveForms.Text = "Save forms";
            this.tsbSaveForms.Click += new System.EventHandler(this.tsbSaveForms_Click);
            // 
            // tslInfo
            // 
            this.tslInfo.ForeColor = System.Drawing.Color.Red;
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(333, 29);
            this.tslInfo.Text = "(Your changes are not saved to CRM yet)";
            this.tslInfo.ToolTipText = "Click on Save forms to save your changes to CRM";
            this.tslInfo.Visible = false;
            // 
            // tsbPublish
            // 
            this.tsbPublish.Image = ((System.Drawing.Image)(resources.GetObject("tsbPublish.Image")));
            this.tsbPublish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPublish.Name = "tsbPublish";
            this.tsbPublish.Size = new System.Drawing.Size(138, 29);
            this.tsbPublish.Text = "Publish entity";
            this.tsbPublish.Click += new System.EventHandler(this.tsbPublish_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbClearLog
            // 
            this.tsbClearLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearLog.Image")));
            this.tsbClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearLog.Name = "tsbClearLog";
            this.tsbClearLog.Size = new System.Drawing.Size(102, 29);
            this.tsbClearLog.Text = "Clear log";
            this.tsbClearLog.Click += new System.EventHandler(this.tsbClearLog_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.attributeSelector1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1317, 574);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 7;
            // 
            // attributeSelector1
            // 
            this.attributeSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeSelector1.Location = new System.Drawing.Point(0, 0);
            this.attributeSelector1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.attributeSelector1.Name = "attributeSelector1";
            this.attributeSelector1.Size = new System.Drawing.Size(659, 574);
            this.attributeSelector1.TabIndex = 4;
            this.attributeSelector1.OnAttributeSelected += new System.EventHandler<MsCrmTools.FormAttributeManager.AppCode.AttributeSelectedEventArgs>(this.attributeSelector1_OnAttributeSelected);
            this.attributeSelector1.OnEntitySelected += new System.EventHandler<MsCrmTools.FormAttributeManager.AppCode.EntitySelectedEventArgs>(this.attributeSelector1_OnEntitySelected);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(654, 540);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Form";
            this.columnHeader1.Width = 304;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is on form";
            this.columnHeader5.Width = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tssbLabel,
            this.tssbLock,
            this.tssbReadOnly,
            this.tssbVisibility});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(654, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromFormToolStripMenuItem,
            this.addToFormsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(124, 29);
            this.toolStripDropDownButton1.Text = "Attribute";
            // 
            // removeFromFormToolStripMenuItem
            // 
            this.removeFromFormToolStripMenuItem.Name = "removeFromFormToolStripMenuItem";
            this.removeFromFormToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.removeFromFormToolStripMenuItem.Text = "Remove from Form(s)";
            this.removeFromFormToolStripMenuItem.Click += new System.EventHandler(this.removeFromFormToolStripMenuItem_Click);
            // 
            // addToFormsToolStripMenuItem
            // 
            this.addToFormsToolStripMenuItem.Name = "addToFormsToolStripMenuItem";
            this.addToFormsToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.addToFormsToolStripMenuItem.Text = "Add to Form(s)";
            this.addToFormsToolStripMenuItem.Click += new System.EventHandler(this.addToFormsToolStripMenuItem_Click);
            // 
            // tssbLabel
            // 
            this.tssbLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEnableFieldDisplay,
            this.tsmiDisableFieldDisplay,
            this.updateLabelToolStripMenuItem});
            this.tssbLabel.Image = ((System.Drawing.Image)(resources.GetObject("tssbLabel.Image")));
            this.tssbLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbLabel.Name = "tssbLabel";
            this.tssbLabel.Size = new System.Drawing.Size(98, 29);
            this.tssbLabel.Text = "Label";
            // 
            // tsmiEnableFieldDisplay
            // 
            this.tsmiEnableFieldDisplay.Name = "tsmiEnableFieldDisplay";
            this.tsmiEnableFieldDisplay.Size = new System.Drawing.Size(284, 34);
            this.tsmiEnableFieldDisplay.Text = "Display label on form";
            this.tsmiEnableFieldDisplay.Click += new System.EventHandler(this.tsmiEnableFieldDisplay_Click);
            // 
            // tsmiDisableFieldDisplay
            // 
            this.tsmiDisableFieldDisplay.Name = "tsmiDisableFieldDisplay";
            this.tsmiDisableFieldDisplay.Size = new System.Drawing.Size(284, 34);
            this.tsmiDisableFieldDisplay.Text = "Hide label on form";
            this.tsmiDisableFieldDisplay.Click += new System.EventHandler(this.tsmiDisableFieldDisplay_Click);
            // 
            // updateLabelToolStripMenuItem
            // 
            this.updateLabelToolStripMenuItem.Name = "updateLabelToolStripMenuItem";
            this.updateLabelToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.updateLabelToolStripMenuItem.Text = "Update label";
            this.updateLabelToolStripMenuItem.Click += new System.EventHandler(this.updateLabelToolStripMenuItem_Click);
            // 
            // tssbLock
            // 
            this.tssbLock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLockField,
            this.tsmiUnlockField});
            this.tssbLock.Image = ((System.Drawing.Image)(resources.GetObject("tssbLock.Image")));
            this.tssbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbLock.Name = "tssbLock";
            this.tssbLock.Size = new System.Drawing.Size(93, 29);
            this.tssbLock.Text = "Lock";
            // 
            // tsmiLockField
            // 
            this.tsmiLockField.Name = "tsmiLockField";
            this.tsmiLockField.Size = new System.Drawing.Size(277, 34);
            this.tsmiLockField.Text = "Lock field on form";
            this.tsmiLockField.Click += new System.EventHandler(this.tsmiLockField_Click);
            // 
            // tsmiUnlockField
            // 
            this.tsmiUnlockField.Name = "tsmiUnlockField";
            this.tsmiUnlockField.Size = new System.Drawing.Size(277, 34);
            this.tsmiUnlockField.Text = "Unlock field on form";
            this.tsmiUnlockField.Click += new System.EventHandler(this.tsmiUnlockField_Click);
            // 
            // tssbReadOnly
            // 
            this.tssbReadOnly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMarkAsReadOnly,
            this.tsmiMarkAsEditable});
            this.tssbReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("tssbReadOnly.Image")));
            this.tssbReadOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbReadOnly.Name = "tssbReadOnly";
            this.tssbReadOnly.Size = new System.Drawing.Size(135, 29);
            this.tssbReadOnly.Text = "Read Only";
            // 
            // tsmiMarkAsReadOnly
            // 
            this.tsmiMarkAsReadOnly.Name = "tsmiMarkAsReadOnly";
            this.tsmiMarkAsReadOnly.Size = new System.Drawing.Size(294, 34);
            this.tsmiMarkAsReadOnly.Text = "Mark field as read only";
            this.tsmiMarkAsReadOnly.Click += new System.EventHandler(this.tsmiMarkAsReadOnly_Click);
            // 
            // tsmiMarkAsEditable
            // 
            this.tsmiMarkAsEditable.Name = "tsmiMarkAsEditable";
            this.tsmiMarkAsEditable.Size = new System.Drawing.Size(294, 34);
            this.tsmiMarkAsEditable.Text = "Mark field as editable";
            this.tsmiMarkAsEditable.Click += new System.EventHandler(this.tsmiMarkAsEditable_Click);
            // 
            // tssbVisibility
            // 
            this.tssbVisibility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMarkAsVisible,
            this.tsmiMarkAsNotVisible});
            this.tssbVisibility.Image = ((System.Drawing.Image)(resources.GetObject("tssbVisibility.Image")));
            this.tssbVisibility.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbVisibility.Name = "tssbVisibility";
            this.tssbVisibility.Size = new System.Drawing.Size(119, 29);
            this.tssbVisibility.Text = "Visibility";
            // 
            // tsmiMarkAsVisible
            // 
            this.tsmiMarkAsVisible.Name = "tsmiMarkAsVisible";
            this.tsmiMarkAsVisible.Size = new System.Drawing.Size(382, 34);
            this.tsmiMarkAsVisible.Text = "Make the field visible on form";
            this.tsmiMarkAsVisible.Click += new System.EventHandler(this.tsmiMarkAsVisible_Click);
            // 
            // tsmiMarkAsNotVisible
            // 
            this.tsmiMarkAsNotVisible.Name = "tsmiMarkAsNotVisible";
            this.tsmiMarkAsNotVisible.Size = new System.Drawing.Size(382, 34);
            this.tsmiMarkAsNotVisible.Text = "Make the field not visible on form";
            this.tsmiMarkAsNotVisible.Click += new System.EventHandler(this.tsmiMarkAsNotVisible_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 34);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvLogs);
            this.splitContainer2.Size = new System.Drawing.Size(1317, 778);
            this.splitContainer2.SplitterDistance = 574;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 8;
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogs.FullRowSelect = true;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(0, 0);
            this.lvLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(1317, 199);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Entity";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Form";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Message";
            this.columnHeader4.Width = 300;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1317, 812);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private UserControls.AttributeSelector attributeSelector1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnableFieldDisplay;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisableFieldDisplay;
        private System.Windows.Forms.ToolStripSplitButton tssbLock;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockField;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnlockField;
        private System.Windows.Forms.ToolStripDropDownButton tssbReadOnly;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarkAsReadOnly;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarkAsEditable;
        private System.Windows.Forms.ToolStripDropDownButton tssbVisibility;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarkAsVisible;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarkAsNotVisible;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem removeFromFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbSaveForms;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbClearLog;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripLabel tslInfo;
        private System.Windows.Forms.ToolStripButton tsbPublish;
        private System.Windows.Forms.ToolStripMenuItem updateLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromSolution;
    }
}
