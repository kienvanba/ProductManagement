namespace Management {
    partial class FrmLogin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.warning = new DevExpress.XtraEditors.LabelControl();
            this.userName = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnForget = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.branch = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.userName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(257, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "LOG IN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "User Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // warning
            // 
            this.warning.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Appearance.ForeColor = System.Drawing.Color.Red;
            this.warning.Appearance.Options.UseFont = true;
            this.warning.Appearance.Options.UseForeColor = true;
            this.warning.Location = new System.Drawing.Point(115, 169);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(152, 16);
            this.warning.TabIndex = 3;
            this.warning.Text = "Invalid ID or Password!";
            this.warning.Visible = false;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(115, 100);
            this.userName.Name = "userName";
            this.userName.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userName.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Properties.Appearance.Options.UseBackColor = true;
            this.userName.Properties.Appearance.Options.UseFont = true;
            this.userName.Properties.MaxLength = 50;
            this.userName.Size = new System.Drawing.Size(246, 22);
            this.userName.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(115, 141);
            this.password.Name = "password";
            this.password.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Properties.Appearance.Options.UseBackColor = true;
            this.password.Properties.Appearance.Options.UseFont = true;
            this.password.Properties.MaxLength = 50;
            this.password.Properties.UseSystemPasswordChar = true;
            this.password.Size = new System.Drawing.Size(246, 22);
            this.password.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceDisabled.Options.UseBackColor = true;
            this.btnLogin.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLogin.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearancePressed.BackColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.AppearancePressed.Options.UseBackColor = true;
            this.btnLogin.AppearancePressed.Options.UseBorderColor = true;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLogin.Location = new System.Drawing.Point(115, 202);
            this.btnLogin.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnLogin.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "simpleButton1";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForget
            // 
            this.btnForget.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnForget.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnForget.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnForget.Appearance.Options.UseBackColor = true;
            this.btnForget.Appearance.Options.UseBorderColor = true;
            this.btnForget.Appearance.Options.UseFont = true;
            this.btnForget.Appearance.Options.UseForeColor = true;
            this.btnForget.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.AppearanceHovered.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.AppearanceHovered.Options.UseBackColor = true;
            this.btnForget.AppearanceHovered.Options.UseFont = true;
            this.btnForget.Location = new System.Drawing.Point(12, 297);
            this.btnForget.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnForget.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnForget.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnForget.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(178, 29);
            this.btnForget.TabIndex = 7;
            this.btnForget.Text = "Forget your password?";
            // 
            // progressBar
            // 
            this.progressBar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar.Appearance.Options.UseBackColor = true;
            this.progressBar.Appearance.Options.UseFont = true;
            this.progressBar.Appearance.Options.UseForeColor = true;
            this.progressBar.Caption = "";
            this.progressBar.Description = "";
            this.progressBar.Location = new System.Drawing.Point(115, 243);
            this.progressBar.LookAndFeel.SkinMaskColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.WhiteSmoke;
            this.progressBar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressBar.Name = "progressBar";
            this.progressBar.ShowCaption = false;
            this.progressBar.ShowDescription = false;
            this.progressBar.Size = new System.Drawing.Size(158, 48);
            this.progressBar.TabIndex = 8;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.Visible = false;
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // branch
            // 
            this.branch.EditValue = "Branch";
            this.branch.Location = new System.Drawing.Point(12, 21);
            this.branch.Name = "branch";
            this.branch.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Properties.Appearance.Options.UseFont = true;
            this.branch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.branch.Size = new System.Drawing.Size(155, 22);
            this.branch.TabIndex = 9;
            this.branch.SelectedIndexChanged += new System.EventHandler(this.branch_SelectedIndexChanged);
            // 
            // FrmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl warning;
        private DevExpress.XtraEditors.TextEdit userName;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnForget;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraEditors.ComboBoxEdit branch;

    }
}

