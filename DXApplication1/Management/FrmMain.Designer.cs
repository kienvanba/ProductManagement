namespace Management {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.desktop = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.stage1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.branch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnImport,
            this.btnExport,
            this.btnEdit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsCustomizationForm.FormIcon = ((System.Drawing.Icon)(resources.GetObject("resource.FormIcon")));
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.desktop});
            this.ribbon.Size = new System.Drawing.Size(1264, 169);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below;
            // 
            // btnImport
            // 
            this.btnImport.Caption = "Import Product";
            this.btnImport.Id = 5;
            this.btnImport.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnImport.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnImport.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnImport.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnImport.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnImport.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnImport.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnImport.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnImport.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnImport.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnImport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnImport.LargeGlyph")));
            this.btnImport.Name = "btnImport";
            this.btnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnExport.Caption = "Export Product";
            this.btnExport.Id = 6;
            this.btnExport.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnExport.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnExport.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnExport.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExport.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnExport.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnExport.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnExport.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnExport.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExport.LargeGlyph")));
            this.btnExport.Name = "btnExport";
            this.btnExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit Product";
            this.btnEdit.Id = 7;
            this.btnEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnEdit.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnEdit.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnEdit.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            // 
            // desktop
            // 
            this.desktop.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.stage1});
            this.desktop.Name = "desktop";
            this.desktop.Text = "Desktop";
            // 
            // stage1
            // 
            this.stage1.ItemLinks.Add(this.btnImport);
            this.stage1.ItemLinks.Add(this.btnExport);
            this.stage1.ItemLinks.Add(this.btnEdit);
            this.stage1.Name = "stage1";
            this.stage1.Text = "Product";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 686);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1264, 33);
            // 
            // branch
            // 
            this.branch.EditValue = "";
            this.branch.Location = new System.Drawing.Point(0, 145);
            this.branch.MenuManager = this.ribbon;
            this.branch.Name = "branch";
            this.branch.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.branch.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Properties.Appearance.Options.UseBackColor = true;
            this.branch.Properties.Appearance.Options.UseFont = true;
            this.branch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branch.Properties.DropDownRows = 5;
            this.branch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.branch.Size = new System.Drawing.Size(126, 24);
            this.branch.TabIndex = 6;
            this.branch.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // xtraManager
            // 
            this.xtraManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraManager.MdiParent = this;
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1264, 719);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Work Space";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage desktop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup stage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.ComboBoxEdit branch;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraManager;
        private DevExpress.XtraBars.BarButtonItem btnImport;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
    }
}