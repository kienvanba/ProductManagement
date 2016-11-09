using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Management {
    public partial class FrmImport: DevExpress.XtraEditors.XtraForm {
        public FrmImport() {
            InitializeComponent();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            pQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            pQuantity.Text = "0";
        }
        private void initAutoCompleteText() {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for(Int32 i = 0; i < dS.VATTU.Rows.Count; i++) {
                collection.Add(dS.VATTU.Rows[i][dS.VATTU.MAVTColumn].ToString());
            }
            collection.Add("coin card");
            collection.Add("Huy ce an cut");
            collection.Add("Long buoy an loin");
            collection.Add("Kien dep trai");
            pID.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            pID.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pID.MaskBox.AutoCompleteCustomSource = collection;
        }
        private void setBtnAddEnable() {
            if(string.IsNullOrWhiteSpace(pID.Text) || string.IsNullOrWhiteSpace(pName.Text)
                || string.IsNullOrWhiteSpace(pQuantity.Text) || string.IsNullOrWhiteSpace(pMeasure.Text)) {
                btnAdd.Enabled = false;
            } else {
                btnAdd.Enabled = true;
            }
        }
        private void setBtnAlterEnable() {

        }

        private void pID_EditValueChanged(object sender,EventArgs e) {
            setBtnAddEnable();
        }

        private void pName_EditValueChanged(object sender,EventArgs e) {
            setBtnAddEnable();
        }

        private void pQuantity_EditValueChanged(object sender,EventArgs e) {
            setBtnAddEnable();
        }

        private void pMeasure_EditValueChanged(object sender,EventArgs e) {
            setBtnAddEnable();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.dbsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmImport_Load(object sender,EventArgs e) {
            // TODO: This line of code loads data into the 'dS.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.dS.VATTU);
            initAutoCompleteText();
        }
    }
}