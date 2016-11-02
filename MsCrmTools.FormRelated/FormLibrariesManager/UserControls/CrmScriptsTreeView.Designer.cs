namespace MsCrmTools.FormLibrariesManager.UserControls
{
    partial class CrmScriptsTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmScriptsTreeView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlActions = new System.Windows.Forms.Panel();
            this.ScriptsTreeView = new System.Windows.Forms.TreeView();
            this.llCollapse = new System.Windows.Forms.LinkLabel();
            this.llExpand = new System.Windows.Forms.LinkLabel();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "component.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "html.png");
            this.imageList1.Images.SetKeyName(3, "css.png");
            this.imageList1.Images.SetKeyName(4, "script.png");
            this.imageList1.Images.SetKeyName(5, "database.png");
            this.imageList1.Images.SetKeyName(6, "picture.png");
            this.imageList1.Images.SetKeyName(7, "picture.png");
            this.imageList1.Images.SetKeyName(8, "picture.png");
            this.imageList1.Images.SetKeyName(9, "silverlight.jpg");
            this.imageList1.Images.SetKeyName(10, "xsl.png");
            this.imageList1.Images.SetKeyName(11, "updateicons_16.png");
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.llExpand);
            this.pnlActions.Controls.Add(this.llCollapse);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(687, 30);
            this.pnlActions.TabIndex = 1;
            // 
            // ScriptsTreeView
            // 
            this.ScriptsTreeView.CheckBoxes = true;
            this.ScriptsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptsTreeView.ImageIndex = 0;
            this.ScriptsTreeView.ImageList = this.imageList1;
            this.ScriptsTreeView.Location = new System.Drawing.Point(0, 30);
            this.ScriptsTreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScriptsTreeView.Name = "ScriptsTreeView";
            this.ScriptsTreeView.SelectedImageIndex = 0;
            this.ScriptsTreeView.Size = new System.Drawing.Size(687, 927);
            this.ScriptsTreeView.TabIndex = 2;
            this.ScriptsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ScriptsTreeView_AfterCheck);
            // 
            // llCollapse
            // 
            this.llCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llCollapse.AutoSize = true;
            this.llCollapse.Location = new System.Drawing.Point(588, 5);
            this.llCollapse.Name = "llCollapse";
            this.llCollapse.Size = new System.Drawing.Size(89, 20);
            this.llCollapse.TabIndex = 0;
            this.llCollapse.TabStop = true;
            this.llCollapse.Text = "Collapse all";
            this.llCollapse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCollapse_LinkClicked);
            // 
            // llExpand
            // 
            this.llExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llExpand.AutoSize = true;
            this.llExpand.Location = new System.Drawing.Point(500, 5);
            this.llExpand.Name = "llExpand";
            this.llExpand.Size = new System.Drawing.Size(82, 20);
            this.llExpand.TabIndex = 1;
            this.llExpand.TabStop = true;
            this.llExpand.Text = "Expand all";
            this.llExpand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExpand_LinkClicked);
            // 
            // CrmScriptsTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScriptsTreeView);
            this.Controls.Add(this.pnlActions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrmScriptsTreeView";
            this.Size = new System.Drawing.Size(687, 957);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.TreeView ScriptsTreeView;
        private System.Windows.Forms.LinkLabel llExpand;
        private System.Windows.Forms.LinkLabel llCollapse;
    }
}
