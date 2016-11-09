using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Management {
    public partial class FrmMain: DevExpress.XtraBars.Ribbon.RibbonForm {
        private int userType;
        private int currentBranch;
        public FrmMain(int type, int branch) {
            InitializeComponent();
            this.userType = type;
            this.currentBranch = branch;
            initDropDown();
            setBranch();
        }
        private void initDropDown() {
            branch.Properties.Items.Add("Branch 1");
            branch.Properties.Items.Add("Branch 2");
            branch.SelectedIndex = currentBranch;
        }
        private void setBranch() {
            switch(currentBranch) {
                case 0:
                    branch.Text = "Branch 1";
                    branch.Enabled = false;
                    break;
                case 1:
                    branch.Text = "Branch 2";
                    branch.Enabled = false;
                    break;
            }
            if(userType == 0) {
                branch.Enabled = true;
            }
        }

        private void dropDown_SelectedIndexChanged(object sender,EventArgs e) {
            currentBranch = branch.SelectedIndex;
            if(currentBranch == 1) {
                //page1.Visible = true;
            } else {
                //page1.Visible = false;
            }
        }

        private void btnLogin_ItemClick(object sender,ItemClickEventArgs e) {
            var form = new FrmImport();
            if(getForm(form) != null) {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }
        private DevExpress.XtraEditors.XtraForm getForm(DevExpress.XtraEditors.XtraForm form){
            foreach(var child in MdiChildren) {
                if(child.Name.Equals(form.Name)) {
                    child.Activate();
                    return (DevExpress.XtraEditors.XtraForm) child;
                }
            }
            return null;
        }

        private void btnExport_ItemClick(object sender,ItemClickEventArgs e) {
            var form = new FrmExport();
            if(getForm(form) != null) {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

    }
}